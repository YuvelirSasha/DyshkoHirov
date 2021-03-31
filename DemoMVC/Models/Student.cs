using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(150)]
        public string FirstName { get; set; }
                
        [StringLength(150)]
        public string LastName { get; set; }

        public int Age { get; set; }

        [Display(Name="Enroll Date")]
        public DateTime EnrollDate { get; set; }
    }
}
