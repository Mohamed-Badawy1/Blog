using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Blog.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Department name is required")]
       
        public string? DepName { get; set; }

        [Required(ErrorMessage = "CreateDate is required")]
        
        public string? CreateDate { get; set; }

        public ICollection<Author>? Authors { get; set; }
    }
}

