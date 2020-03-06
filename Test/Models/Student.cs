using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models {
    public class Student {
        public int Id { get; set; }
        public int? MajorId { get; set; }
        [StringLength(30)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(30)]
        [Required]
        public string LastName { get; set; }
        public int? SAT { get; set; }
        public double? GPA { get; set; }
        public virtual Major Major { get; set; }

        public Student() { }    
    }
}
