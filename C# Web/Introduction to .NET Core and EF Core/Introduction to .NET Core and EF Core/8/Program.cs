namespace ShopHierarchyComplexQuery
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
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
                AddItems(context);
                ProcessCommands(context);

                PrintCustomerOrdersAndReviews(context);         // Problem 7
                //PrintCustomerSummary(context);                  // Problem 8
                //PrintCustomerOrdersHavingSeveralItems(context); // Problem 9
            }
        }

        private static void PrintCustomerOrdersHavingSeveralItems(ShopDbContext context)
        {
            var customerId = int.Parse(ReadInput());

            var ordersWithSeveralItems = context
                .Orders
                .Where(o => o.CustomerId == customerId &&
                            o.Items.Count > 1)
                .Count();

            Console.WriteLine($"Orders: {ordersWithSeveralItems}");
        }

        private static void PrintCustomerSummary(ShopDbContext context)
        {
            var customerId = int.Parse(ReadInput());

            var customerData = context
                .Customers
                .Where(c => c.Id == customerId)
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count,
                    Salesman = c.Salesman.Name
                })
                .FirstOrDefault();

            var builder = new StringBuilder();
            builder
                .AppendLine($"Customer: {customerData.Name}")
                .AppendLine($"Orders count: {customerData.Orders}")
                .AppendLine($"Reviews count: {customerData.Reviews}")
                .AppendLine($"Salesman: {customerData.Salesman}");

            Console.WriteLine(builder.ToString().Trim());
        }

        private static void PrintCustomerOrdersAndReviews(ShopDbContext context)
        {
            var customerId = int.Parse(ReadInput());

            var customerData = context
                .Customers
                .Where(c => c.Id == customerId)
                .Select(c => new
                {
                    Orders = c.Orders
                            .Select(o => new
                            {
                                o.Id,
                                Items = o.Items.Count
                            })
                            .OrderBy(o => o.Id),
                    Reviews = c.Reviews.Count
                })
                .FirstOrDefault();

            var builder = new StringBuilder();
            foreach (var order in customerData.Orders)
            {
                builder.AppendLine($"order {order.Id}: {order.Items} items");
            }

            builder.AppendLine($"reviews: {customerData.Reviews}");

            Console.WriteLine(builder.ToString().Trim());
        }

        private static void AlternativeQueries(ShopDbContext context)
        {
            var customerId = int.Parse(ReadInput());
            var customer = context.Customers.FirstOrDefault(c => c.Id == customerId);

            // PrintCustomerOrdersHavingSeveralItems
            var ordersCount = context
                .Entry(customer)
                .Collection(c => c.Orders)
                .Query()
                .Count(o => o.Items.Count > 1);

            // PrintCustomerSummary
            context
                .Entry(customer)
                .Collection(c => c.Orders)
                .Load();

            int count = customer.Orders.Count;

            context
                .Entry(customer)
                .Reference(c => c.Salesman)
                .Load();

            var salesman = customer.Salesman.Name;

            // PrintCustomerOrdersAndReviews
            var customerData = context
                .Customers
                .Include(c => c.Orders)
                    .ThenInclude(o => o.Items)
                .Include(c => c.Reviews)
                .FirstOrDefault(c => c.Id == customerId);
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
                    case OrderCommand:
                        AddOrder(context, commandArgs);
                        break;
                    case ReviewCommand:
                        AddReview(context, commandArgs);
                        break;
                    default: break;
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
            var tokens = SplitInput(commandArgs, ';');
            var ids = tokens.Select(int.Parse).ToList();
            var customerId = ids[0];
            var itemIds = new HashSet<int>(ids.Skip(1));

            if (context.Customers.FirstOrDefault(c => c.Id == customerId) != null)
            {
                var order = new Order { CustomerId = customerId };

                foreach (var itemId in itemIds)
                {
                    if (context.Items.FirstOrDefault(i => i.Id == itemId) != null)
                    {
                        order.Items.Add(new ItemOrder { ItemId = itemId });
                    }
                }

                context.Orders.Add(order);

                context.SaveChanges();
            }
        }

        private static void AddReview(ShopDbContext context, string commandArgs)
        {
            var tokens = SplitInput(commandArgs, ';');
            var customerId = int.Parse(tokens[0]);
            var itemId = int.Parse(tokens[1]);

            if (context.Customers.FirstOrDefault(c => c.Id == customerId) != null &&
                context.Items.FirstOrDefault(i => i.Id == itemId) != null)
            {
                context.Reviews.Add(new Review { CustomerId = customerId, ItemId = itemId });

                context.SaveChanges();
            }
        }

        private static void AddItems(ShopDbContext context)
        {
            while (true)
            {
                var input = ReadInput();
                if (input == TerminatingCommand)
                {
                    break;
                }

                var tokens = SplitInput(input, ';');
                var itemName = tokens[0];
                var itemPrice = decimal.Parse(tokens[1]);

                context.Items.Add(new Item { Name = itemName, Price = itemPrice });

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