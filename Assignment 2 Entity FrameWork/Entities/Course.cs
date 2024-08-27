using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1_entity_frame_work.Entities
{
    internal class Course
    {
        [Key]
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }
        public List<Stud_Course> Students { get; set; }
    }

}
