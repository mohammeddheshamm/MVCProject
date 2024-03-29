using Demo.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace Demo.PL.ViewModels
{
    public class EmployeeViewModel
    {
        // AL View Model hwa al model aly hayzhaar ll User fy al view lakn al model Ely hwa Employee dy by Represent al Tables fy al database.
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max Length is 50 Chars")]
        [MinLength(5, ErrorMessage = "Min Length is 5 Chars")]
        public string Name { get; set; }
        [Range(22, 30, ErrorMessage = "Age must be between 22 and 30")]
        public int? Age { get; set; }
        //[RegularExpression(@"^[0,9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$",
        //    ErrorMessage ="Address must be like 123-Street-City-Country")]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        [Range(4000, 8000)]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
        [ForeignKey("Department")]
        [Display(Name = "Department")]
        public int? DepartmentId { get; set; } // it should be nullable as in case it is not null and there is some rows with no department 
                                               // So this will make a mess
                                               // Navigational property
        public Department Department { get; set; }
        public IFormFile Image { get; set; }
        public string ImageName { get; set; }
    }
}
