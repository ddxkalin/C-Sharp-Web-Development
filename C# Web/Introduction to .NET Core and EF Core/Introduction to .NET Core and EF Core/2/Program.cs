namespace OneToManyRelation
{
    using System;
    using Data;
    using Models;

    public class Startup
{
    public static void Main()
    {
        using (var context = new EmployeesDbContext())
        {
            InitializeDatabase(context);
            Seed(context);
        }
    }

    private static void Seed(EmployeesDbContext context)
    {
        var employee1 = new Employee { Name = "Pesho" };
        var employee2 = new Employee { Name = "Ivan" };
        var employee3 = new Employee { Name = "Maria" };

        var itDepartment = new Department { Name = "IT" };
        var financeDepartment = new Department { Name = "Finance" };

        itDepartment.Employees.Add(employee1);
        itDepartment.Employees.Add(employee2);
        financeDepartment.Employees.Add(employee3);

        context.Departments.Add(itDepartment);
        context.Departments.Add(financeDepartment);

        context.SaveChanges();

        Console.WriteLine("Database EmployeesDb created.");
    }

    private static void InitializeDatabase(EmployeesDbContext context)
    {
        Console.WriteLine("Initializing database...");

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }
}
}