using session__2_EntityFrameworkCore.Context;
using session__2_EntityFrameworkCore.Entities;

namespace session__2_EntityFrameworkCore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using AppDbContext Context = new AppDbContext();
            #region create
            //var employee = new Employee()
            //{
            //    Name = "bassim",
            //    Salary = 2000,
            //    Age = 25,
            //    Address = "Giza",
            //};
            //Console.WriteLine(Context.Entry(employee).State);
            //employee.Name = "ahmed";
            //Context.Add(employee);
            //Console.WriteLine(Context.Entry(employee).State);
            //Context.SaveChanges();
            //Console.WriteLine(Context.Entry(employee).State);
            //employee.Name = "bassim";
            //Console.WriteLine(Context.Entry(employee).State);
            //Context.SaveChanges();
            #endregion
            #region Read
            ////var result = Context.employees.FirstOrDefault(e => e.Id == 4);
            ////Console.WriteLine(result.Salary);
            ////var result=Context.Employees;
            ////var result=Context.Employees.ToList();
            // var result = Context.Employees.Select(x => x.Name).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Update
            //    var result = Context.Employees.FirstOrDefault(e => e.Id == 4);
            //    Console.WriteLine(Context.Entry(result).State);
            //    result.Name = "ali";

            //    Console.WriteLine(Context.Entry(result).State);
            //    Context.Update(result);
            //    Console.WriteLine(Context.Entry(result).State);
            //    Context.SaveChanges();
            //}
            #endregion
            #region Delete
            //var result = Context.Employees.FirstOrDefault(e => e.Id == 4);
            //Console.WriteLine(Context.Entry(result).State);
            //Context.Remove(result);
            //Console.WriteLine(Context.Entry(result).State);
            //Context.SaveChanges();


            #endregion

        }
    }
}
