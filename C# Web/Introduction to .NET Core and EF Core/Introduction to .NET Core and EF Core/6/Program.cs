namespace ShopHierarchyExtended
{
    using System;
    using System.Linq;
    using System.Text;
    using Data;
    using Models;

    public class Startup
    {
        private const string TerminatingCommand = "END";
        private const string RegisterCommand = "register";
        private const string OrderCommand = "order";
        private const string ReviewCommand = "review";

        public static void Main()
        {
            using (var context = new ShopDbContext())
            {
                InitializeDatabase(context);
                AddSalesmen(context);
                ProcessCommands(context);
                PrintCustomersOrdersAndReviewsCount(context);
            }
        }

        private static void PrintCustomersOrdersAndReviewsCount(ShopDbContext context)
        {
            var customersData = context
                .Customers
                .Select(c => new
                {
                    Name = c.Name,
                    OrdersCount = c.Orders.Count,
                    ReviewsCount = c.Reviews.Count
                })
                .OrderByDescending(c => c.OrdersCount)
                .ThenByDescending(c => c.ReviewsCount)
                .ToList();

            var builder = new StringBuilder();
            foreach (var customer in customersData)
            {
                builder
                    .AppendLine(customer.Name)
                    .AppendLine($"Orders: {customer.OrdersCount}")
                    .AppendLine($"Reviews: {customer.ReviewsCount}");
            }

            Console.WriteLine(builder.ToString().Trim());
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

                var commandTokens = SplitInput(input, '-');
                var command = commandTokens[0];
                var commandArgs = commandTokens[1];

                switch (command)
                {
                    case RegisterCommand:
                        RegisterCustomer(context, commandArgs);
                        break;
                    case OrderCommand:
                        AddOrder(context, commandArgs);
                        break;
                    case ReviewCommand:
                        AddReview(context, commandArgs);
                        break;
                    default:
                        break;
                }
            }
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

        private static void AddOrder(ShopDbContext context, string commandArgs)
        {
            var customerId = int.Parse(commandArgs);

            if (context.Customers.FirstOrDefault(c => c.Id == customerId) != null)
            {
                context.Orders.Add(new Order { CustomerId = customerId });

                context.SaveChanges();
            }
        }

        private static void AddReview(ShopDbContext context, string commandArgs)
        {
            var customerId = int.Parse(commandArgs);

            if (context.Customers.FirstOrDefault(c => c.Id == customerId) != null)
            {
                context.Reviews.Add(new Review { CustomerId = customerId });

                context.SaveChanges();
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