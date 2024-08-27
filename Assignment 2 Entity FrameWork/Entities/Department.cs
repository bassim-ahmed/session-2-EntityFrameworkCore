using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1_entity_frame_work.Entities
{
    internal class Department
    {
        [Key]
        public int ID { get; set; }
        [Column("Name")]
        public string DepartmentName { get; set; }
        [Column("Ins_ID")]
        public int InstructorId { get; set; }
        [Column("HiringDate")]
        public DateTime InstructorHiringDate { get; set; }
    }
}
