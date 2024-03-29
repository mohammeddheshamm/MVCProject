using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public int? Age { get; set; }
        //[RegularExpression(@"^[0,9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$",
        //    ErrorMessage ="Address must be like 123-Street-City-Country")]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public DateTime HireDate { get; set; }
        public DateTime DateOfCreation { get; set;} = DateTime.Now;
        [ForeignKey("Department")]
        
        public int? DepartmentId { get; set; } // it should be nullable as in case it is not null and there is some rows with no department 
                                               // So this will make a mess
        // Navigational property
        public virtual Department Department { get; set; }

        public string ImageName { get; set; }
    }
}
