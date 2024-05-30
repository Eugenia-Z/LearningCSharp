using System;

namespace TryCSharp
{
    // 7. Polymorphism
    /* abstract class Shape
    {
        public abstract void Draw();
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a Circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a Rectangle");
        }
    } */
    // 6. Inheritance
    /* class Animal
    {
        public string Name { get; set; }
        public void Speak()
        {
            System.Console.WriteLine(Name + " makes a sound.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            System.Console.WriteLine(Name + " barks.");
        }
    } */

    // 5. OOD
    /* class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            System.Console.WriteLine("hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    } */
    class Program
    {
        // static void Main()
        // {
        // Console.WriteLine("Hello, World!");

        // 1. Variable declaration needs to be initialized 
        /* int number = 15;
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is even.");
        }
        else
        {
            Console.WriteLine(number + " is odd.");
        } */

        // 2. For and While loop
        /* for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Iteration: " + i);
        }

        int j = 0;
        while (j < 5)
        {
            System.Console.WriteLine("Iteration: " + j);
            j++;
        } */

        // 3. Arrays and Lists
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

        // 4. Functions and Methods
        /* int result = Add(5, 3);
        System.Console.WriteLine("Sum: " + result); */

        // 5. OOD
        /* Person person = new Person();
        person.Name = "Alice";
        person.Age = 30;
        person.Introduce(); */

        // 6. Inheritance
        /* Dog dog = new Dog();
        dog.Name = "Andy";
        dog.Speak();
        dog.Bark(); */

        // 7. Polymorphism
        /* Shape shape1 = new Circle();
        Shape shape2 = new Rectangle();
        shape1.Draw();
        shape2.Draw(); */

        // 8. Exception Handling
        /* try
        {
            int dividend = 10;
            int divisor = 0;
            int result = dividend / divisor;
        }
        catch (DivideByZeroException ex)
        {
            System.Console.WriteLine("Error:" + ex.Message);
        } */

        // 9. File I/O
        /*  string path = "example.txt";

         // Write to a file
         File.WriteAllText(path, "Hello, file!");

         // Read from a file
         string content = File.ReadAllText(path);
     System.Console.WriteLine("File Content: " + content);
     */
    }

    /* static int Add(int a, int b)
    {
        return a + b;
    } */
}

