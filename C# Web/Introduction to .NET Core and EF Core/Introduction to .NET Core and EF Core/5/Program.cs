namespace ShopHierarchy
{
    using System;
    using System.Linq;
    using Data;
    using Models;

    public class Startup
{
    private const string TerminatingCommand = "END";
    private const string RegisterCommand = "register";

    public static void Main()
    {
        using (var context = new ShopDbContext())
        {
            InitializeDatabase(context);
            AddSalesmen(context);
            ProcessCommands(context);
            PrintSalesmenWithCustomersCount(context);
        }
    }

    private static void PrintSalesmenWithCustomersCount(ShopDbContext context)
    {
        context
            .Salesmen
            .Select(s => new
            {
                Name = s.Name,
                CustomersCount = s.Customers.Count
            })
            .OrderByDescending(s => s.CustomersCount)
            .ThenBy(s => s.Name)
            .ToList()
            .ForEach(s => Console.WriteLine($"{s.Name} - {s.CustomersCount} customers"));
    }

    private static void RegisterCustomer(ShopDbContext context, string commandArgs)
    {
        var tokens = SplitInput(commandArgs, ';');
        var customerName = tokens[0];
        var salesmanId = int.Parse(tokens[1]);

        if (context.Salesmen.FirstOrDefault(s => s.Id == salesmanId) != null)
        {
            context.Customers.Add(new Customer { Name = customerName, SalesmanId = salesmanId });

            context.SaveChanges();
        }
    }

    private static void ProcessCommands(ShopDbContext context)
    {
        while (true)
        {
            var input = ReadInput();
            if (input == TerminatingCommand)
            {
                break;
            }

            var tokens = SplitInput(input, '-');
            var command = tokens[0];
            var commandArgs = tokens[1];

            switch (command)
            {
                case RegisterCommand:
                    RegisterCustomer(context, commandArgs);
                    break;
                default:
                    break;
            }
        }
    }

    private static void AddSalesmen(ShopDbContext context)
    {
        var input = ReadInput();
        var salesmenNames = SplitInput(input, ';');

        foreach (var name in salesmenNames)
        {
            context.Salesmen.Add(new Salesman { Name = name });
        }

        context.SaveChanges();
    }

    private static string[] SplitInput(string input, params char[] delimiters)
    {
        return input
              .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => x.Trim())
              .ToArray();
    }

    private static string ReadInput()
    {
        return Console.ReadLine().Trim();
    }

    private static void InitializeDatabase(ShopDbContext context)
    {
        Console.WriteLine("Initializing database...");

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        Console.WriteLine("Read data:");
    }
}
}