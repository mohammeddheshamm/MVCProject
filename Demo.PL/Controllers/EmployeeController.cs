using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Entities;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            //Fy al parameter ana b Ask al CLR 3l4an y inject object mn al Context  
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string SearchValue)
        {
            var employees = Enumerable.Empty<Employee>();
            if (string.IsNullOrEmpty(SearchValue))
                 employees = await _unitOfWork.EmployeeRepository.GetAll();
             
            else
                 employees = _unitOfWork.EmployeeRepository.SearchEmployeesByName(SearchValue);
            
            var mappedEmps = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
            return View(mappedEmps);

        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await _unitOfWork.EmployeeRepository.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                employeeVM.ImageName = DocumentSetting.UploadFile(employeeVM.Image, "images");
                ///Manual Mapping
                ///var mappedEmp = new Employee()
                ///{
                ///    Name = employeeVM.Name,
                ///    Age = employeeVM.Age,
                ///    Address = employeeVM.Address,
                ///    Email = employeeVM.Email,
                ///    PhoneNumber = employeeVM.PhoneNumber,
                ///    Salary = employeeVM.Salary,
                ///    IsActive = employeeVM.IsActive,
                ///    HireDate = employeeVM.HireDate,
                ///    DepartmentId = employeeVM.DepartmentId,
                ///};
                var mappedEmp = _mapper.Map<EmployeeViewModel , Employee>(employeeVM);
                await _unitOfWork.EmployeeRepository.Add(mappedEmp);
                return RedirectToAction(nameof(Index));
            }
            return View(employeeVM);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id ,string ViewName ="Details") 
        {
            if (id == null)
                return BadRequest();
            var employee = await _unitOfWork.EmployeeRepository.Get(id.Value);
            if(employee == null)
                return BadRequest();
            var mappedEmp = _mapper.Map<Employee, EmployeeViewModel>(employee);
            return View(ViewName , mappedEmp);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute]int id,EmployeeViewModel employeeVM)
        {
            if (employeeVM.Id != id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    if (employeeVM.ImageName != null)
                    {
                        DocumentSetting.DeleteFile(employeeVM.ImageName, "images");
                        employeeVM.ImageName = DocumentSetting.UploadFile(employeeVM.Image,"images");
                    }
                    else
                        employeeVM.ImageName = DocumentSetting.UploadFile(employeeVM.Image, "images");

                    var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    await _unitOfWork.EmployeeRepository.Update(mappedEmp);
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex) 
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
               
            }
            return View(employeeVM);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return await Details(id,"Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id,EmployeeViewModel employeeVM)
        {
            if(employeeVM.Id != id)
                return BadRequest();
            try
            {
                var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                int count = await _unitOfWork.EmployeeRepository.Delete(mappedEmp);
                if(count > 0)
                    DocumentSetting.DeleteFile(employeeVM.ImageName, "images");
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(employeeVM);
        }
    }
}
