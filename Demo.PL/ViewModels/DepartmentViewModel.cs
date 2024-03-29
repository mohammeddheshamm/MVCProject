using Demo.DAL.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Demo.PL.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is Required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50, ErrorMessage = "The Max Length is 50 Chars")]
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        //Navigational Property
        public ICollection<Employee> Employees { get; set; }
    }
}
