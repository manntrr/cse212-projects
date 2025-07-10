/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService
{
    public static void Run()
    {
        /*
        requirements

            1) The user shall specify the maximum size of the Customer Service Queue when it is created.
                If the size is invalid (less than or equal to 0) then the size shall default to 10.
            2) The AddNewCustomer method shall enqueue a new customer into the queue.
            3) If the queue is full when trying to add a customer, then an error message will be displayed.
            4) The ServeCustomer function shall dequeue the next customer from the queue and display the details.
            5) If the queue is empty when trying to serve a customer, then an error message will be displayed.
        */

        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");

        // Defect(s) Found: 

        CustomerService queue_neg1 = new CustomerService(-1);
        CustomerService queue_0 = new CustomerService(0);
        CustomerService queue_1 = new CustomerService(1);
        CustomerService queue_11 = new CustomerService(11);

        Console.WriteLine("queue_neg1:  expected = 10; maxsize = " + queue_neg1._maxSize.ToString());
        Console.WriteLine("queue_0:  expected = 10; maxsize = " + queue_0._maxSize.ToString());
        Console.WriteLine("queue_1:  expected = 1; maxsize = " + queue_1._maxSize.ToString());
        Console.WriteLine("queue_11:  expected = 11; maxsize = " + queue_11._maxSize.ToString());

        Console.WriteLine("=================");


        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 
        //  #1)  the add customer function is not testing for maximum queue size.

        queue_1.AddNewCustomer();
        Console.WriteLine("queue_1:  expected = 1; size = " + queue_1._queue.Count);
        try
        {
            queue_1.AddNewCustomer();
            Console.WriteLine("queue_1:  expected = error; no error thrown!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("queue_1:  expected = error; error thrown!");
        }
        queue_1.ServeCustomer();
        Console.WriteLine("queue_1:  expected = size = 0 and customer info displayed above; size = " + queue_1._queue.Count);
        try
        {
            queue_1.ServeCustomer();
            Console.WriteLine("queue_1:  expected = error; no error thrown!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("queue_1:  expected = error; error thrown!");
        }

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize)
    {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer
    {
        public Customer(string name, string accountId, string problem)
        {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString()
        {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer()
    {
        // Verify there is room in the service queue
        // need to valid for the maxsize not only over max size.
        //if (_queue.Count > _maxSize)
        if (_queue.Count >= _maxSize)
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer()
    {
        _queue.RemoveAt(0);
        var customer = _queue[0];
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString()
    {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}
