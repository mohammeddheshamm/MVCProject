using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.BLL.Specification;
using Demo.DAL.Entities;
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
	public class DepartmentController : Controller
    {
        //Inhertance : FullTimeEmployee is a Employee.
        //Composition: Room             has a Chair.

        // Dh ha7tagoo lama a3ooz a48al al index w ana m4 ha4a8al al index 8iir lama a3ml object 
        // w awl 7aga bt4t8aal laama ba3ml object hya al constructor fa ana dlwa2ty ha3ml constructor a3ml fyh object mn DepartmentRepository
        // 3l4aaan aly ta7t dy bs reference m4 object.
  
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        // in this relation department Controller is a controller
        // but DepartmentController has a DepartmentRepository.
        public DepartmentController(IUnitOfWork unitOfWork ,IMapper mapper)
        {
            // Foo2 ana batloob mn L CLR ano y create object mn al DepartmentRepository
            
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string SearchValue)
        {
            // Binding is sending data from the Controller to the view
            // 1.ViewData : Dictionary object
            //ViewData["Message"] = "Hello World";
            //2.ViewBag : Carries Dynamic Variable which know it's value in run time.
            var departments = Enumerable.Empty<Department>();
            if (string.IsNullOrEmpty(SearchValue))
                departments = await _unitOfWork.Repository<Department>().GetAll();
            else
            {
                var spec = new DepartmentWithEmployeeSpecifications(SearchValue);
                departments = await _unitOfWork.Repository<Department>().SearchByNameWithSpec(spec);
            }
            
            var mappedDepts = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View(mappedDepts);
        }
        // Dh al action aly hywadinii 3la view al create
        // get is the default
        public IActionResult Create()
        {
            return View();
        }
        // w Dh al action aly lama agy a3ml submit hy create al Department
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentViewModel departmentVM)
        {
            if (ModelState.IsValid) // Server side Validation
            {
                var mappedDept = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                await _unitOfWork.Repository<Department>().Add(mappedDept);
                // TempData Transfer data from action to view of another action.
                // And it is Key value dictionary like ViewData
                TempData["Message"] = "Department Created Succefully"; 
                return RedirectToAction(nameof(Index));
            }
            return View(departmentVM);
        }
        //Department/Details/
        public async Task<IActionResult> Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return BadRequest();
            var department = await _unitOfWork.Repository<Department>().Get(id.Value);
            if (department == null)
                return BadRequest();
            var mappedDept = _mapper.Map<Department, DepartmentViewModel>(department);
            return View(ViewName , mappedDept);  
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id, "Edit");
            //if (id == null)
            //    return BadRequest();
            //var department = _departmentRepository.Get(id.Value);
            //if (department == null)
            //    return BadRequest();
            //return View(department);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute]int id ,DepartmentViewModel departmentVM)
        {
            if (id != departmentVM.Id)
                return BadRequest();
            
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedDept = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                    await _unitOfWork.Repository<Department>().Update(mappedDept);
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    //1.Log Exception
                    //2. Friendly Message
                    ModelState.AddModelError(string.Empty, ex.Message); //Not Friendly Message

                } 
            }
            return View(departmentVM);
        }
        // I make id nullable in case id is not sent in the link
        //[HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
            //if (id == null)
            //    return BadRequest();
            //var department = _departmentRepository.Get(id.Value);
            //if(department == null)
            //    return BadRequest();
            //return View(department);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id ,DepartmentViewModel departmentVM)
        {
            if (id != departmentVM.Id)
                return BadRequest();
            try
            {
                var mappedDept = _mapper.Map<DepartmentViewModel,Department>(departmentVM);
                await _unitOfWork.Repository<Department>().Delete(mappedDept);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                //1.Log Exception
                //2. Friendly Message
                ModelState.AddModelError(string.Empty, ex.Message); //Not Friendly Message
                return View(departmentVM);
            }
        }
    }
}
