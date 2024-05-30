using System;
using System.Security.AccessControl;
using System.Threading;

class MultiThreading
{
    /* // 1. Basic Threads
    static void Main()
    {
        
        // Create a new thread rthat runs the PrintNumbers method
        Thread thread = new Thread(PrintNumbers);
        thread.Start();

        // Continue executing the main thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.Sleep(1000);
        }
    }
    static void PrintNumbers()
    {
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Worker Thread: " + i);
            Thread.Sleep(1000); // Sleep for 1 second
        }
    } */

    // 2. ThreadPool
    /* static void Main()
    {
        // Queue the PrintNumbers method to run on a ThreadPool thread
        ThreadPool.QueueUserWorkItem(PrintNumbers);

        // Continue executing the main thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.Sleep(1000);
        }

    }
    static void PrintNumbers(object state)
    {
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Worker Thread: " + i);
            Thread.Sleep(1000); // Sleep for 1 second
        }
    } */

    // 3."Task, "async/await'
    /* static async Task Main()
    {
        // Start the PrintNumbersAsync method asynchronously
        Task task = PrintNumbersAsync();

        // Continue executing the main thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            await Task.Delay(1000);  // Asynchronously wait for 1 second
        }

        // Wait for the asycnchronous method to complete
        await task;

    }
    static async Task PrintNumbersAsync()
    {
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Worker Thread:" + i);
            await Task.Delay(1000); // Asynchronouly wait for 1 second
        }
    } */

    // 4. Parallel Programming
    /* static void Main()
    {
        // Execute a parallel for loop
        Parallel.For(0, 5, i =>
        {
            System.Console.WriteLine("Parallel Loop:" + i);
            Task.Delay(1000).Wait(); //Simulate work nby waiting for 1 second.
        });

        // Continue executing the main thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Task.Delay(1000).Wait(); //Simulate work nby waiting for 1 second.
        }
    } */

    // 5. using lock statement
    static object _lockObject = new object();
    static int _counter = 0;

    static void Main()
    {
        Thread thread1 = new Thread(IncrementCounter);
        Thread thread2 = new Thread(IncrementCounter);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
        System.Console.WriteLine("Final Counter:" + _counter);
    }
    static void IncrementCounter()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (_lockObject)
            {
                _counter++;
            }
        }
    }
}

int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    System.Console.WriteLine("Number: " + number);
}

List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
fruits.Add("Date");
fruits.Remove("Banada");
foreach (string fruit in fruits)
{
    System.Console.WriteLine("Fruits: " + fruit);
}