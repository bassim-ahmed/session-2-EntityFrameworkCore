using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session__2_EntityFrameworkCore.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        //public int EmployeeId {  get; set; }//FK

        //[ForeignKey("Managre")]
        [ForeignKey(nameof(Department.Manager))]

        public int EmptId { get; set; } //fORIEGN KEY
        public Employee Manager { get; set; }//navigational property



        public List<Employee> Employees { get; set; }

    }
}
