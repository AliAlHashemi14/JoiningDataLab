using JoiningDataLab;

List<Order> orders = new List<Order>()
{
    new Order("Acme Hardware","Mouse",25m,3),
    new Order("Acme Hardware","Keyboard",45m,2),
    new Order("Falls Realty","MacBook",800m,2),
    new Order("Julie's Morning Diner","iPad",525m,1),
    new Order("Julie's Morning Diner","Credit Card Reader",45m,1)
};

//JUSTIN CODE

//Make a distinct list of orders using customer names
List<Order> distinctCustomerOrders = orders.DistinctBy(o => o.CustomerName).ToList();

foreach (Order distinctCustomer in distinctCustomerOrders)
{
    decimal total = 0;
    //Display customer name on first line
    Console.WriteLine(distinctCustomer.CustomerName);

    //Grab all orders that belong to that customer
    List<Order> CustomerOrders = orders.Where(o => o.CustomerName == distinctCustomer.CustomerName).ToList();

    //Display header
    Console.WriteLine(String.Format("{0,-20} {0,-15} {0,-15} {0,-15}", "Item", "Price", "Quantity", "Total"));

    //Loop through all orders that belong to current customer
    foreach (Order o in CustomerOrders)
    {
        
        Console.WriteLine(String.Format("{0,-20} {1,-15} {2,-15} {3,-15}", o.Item,o.Price,o.Quantity,o.Quantity*o.Price));
        total += o.Quantity * o.Price;
        
    }
    Console.WriteLine($"Total \t\t\t\t\t\t     {total}");
}



//if (distinctCustomer.Item == null && CustomerOrders.Count == 1)

