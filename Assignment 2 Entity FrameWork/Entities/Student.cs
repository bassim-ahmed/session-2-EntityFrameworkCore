using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace assignment_1_entity_frame_work.Entities
{
    internal class Student
    {
        [Key]
        public int ID { get; set; }
        [Column("FName")]
        [Required]
        public string FirstName { get; set; }
        [Column("LName")]
        public string LastName { get; set; }
        [Column("Address")]
        public string StudentAddress { get; set; }
        [Column("Age")]
        [Required]
        [Range(20,60)]
        public int StudentAge { get; set; }
        [Column("Dep_Id")]
        public int DepartmentId { get; set; }
    }
}
