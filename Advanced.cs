using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Reflection;

// 8. Dependency Inversion
public interface IService
{
    void Serve();
}

public class Service : IService
{
    public void Serve() => System.Console.WriteLine("Service Called");
}

public class Client
{
    private readonly IService _service;
    public Client(IService service) => _service = service;
    public void Start() => _service.Serve();
}
// 7. Attribute
/* [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class MyAttribute : Attribute
{
    public string Description { get; }
    public MyAttribute(string description) => Description = description;
}

[MyAttribute("This is a sample class.")]
class SampleClass
{
    [MyAttribute("This is a sample method.")]
    public void SampleMethod() { }
} */

// 6. Extension Method
/* public static class StringExtensions
{
    public static string Reverse(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
} */
// 3b. Generic Class
/* public class GenericList<T>
{
    private T[] _items = new T[10];
    private int _count;

    public void Add(T item)
    {
        if (_count < _items.Length)
        {
            _items[_count++] = item;
        }
    }

    public T this[int index]
    {
        get { return _items[index]; }
    }
} */

//4a delegates
/* delegate int Operation(int a, int b); */
class Program
{
    // 1. LINQ(Language Integrated Query)
    //static void Main()
    //{
    // 1a. LINQ to Objects
    /* List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
    var evenNumbers = from n in numbers
                      where n % 2 == 0
                      select n;
    System.Console.WriteLine("Even numbers:");
    foreach (var number in evenNumbers)
    {
        System.Console.WriteLine(number);
    } */

    // 1b.LINQ to XML
    /* string xml = @"
    <Books>
        <Book>
            <Title> Book1</Title>
            <Author> Author1</Author>
        </Book>
        <Book>
            <Title> Book2</Title>
            <Author> Author2</Author>
        </Book>
    </Books>";
    XDocument doc = XDocument.Parse(xml);

    var titles = from book in doc.Descendants("Book")
                 select book.Element("Title").Value;
    System.Console.WriteLine("Book Titles:");
    foreach (var title in titles)
    {
        System.Console.WriteLine(title);
    } */
    //}

    // 2. Asynchronous Programming (Async/Await)
    /*  static async Task Main()
     {
         string url = "https://api.github.com/repos/dotnet/runtime";
         string content = await FetchUrlAsync(url);
         System.Console.WriteLine(content);
     }

     static async Task<string> FetchUrlAsync(string url)
     {
         using (HttpClient client = new HttpClient())
         {
             client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
             string result = await client.GetStringAsync(url);
             return result;
         }
     } */

    // 3. Generics (allowing to define type-safe data structures without committing to actual data types)
    // 3a. Generic Method
    /* static void Main()
    {
        System.Console.WriteLine(Add(5, 10));
        System.Console.WriteLine(Add(5.5, 10.5));
    }
    static T Add<T>(T a, T b)
    {
        dynamic da = a;
        dynamic db = b;
        return da + db;
    } */

    // 3b. Generic Class
    /*  static void Main()
     {
         GenericList<int> intList = new GenericList<int>();
         intList.Add(1);
         intList.Add(2);
         System.Console.WriteLine(intList[0]);
         System.Console.WriteLine(intList[1]);
     } */

    // 4. Delegates and Events
    // 4a. Delegates: type-safe poitners to methods
    /* static void Main()
    {
        Operation add = Add;
        Operation multiply = Multiply;
        System.Console.WriteLine("Add: " + add(3, 4));
        System.Console.WriteLine("Multiply: " + multiply(3, 4));
    }
    static int Add(int a, int b) => a + b;
    static int Multiply(int a, int b) => a * b; */

    // 4b. Events: a way for a class to provide notifications
    /* public delegate void Notify();
    public event Notify OnNotify;
    static void Main()
    {
        Program p = new Program();
        p.OnNotify += () => System.Console.WriteLine("Notifaction received!");
        p.NotifyEvent();
    }
    public void NotifyEvent()
    {
        OnNotify?.Invoke();
    } */

    // 5. Reflection: inspect and interact with types at runtime
    /*  static void Main()
     {
         Type type = typeof(Sample);
         Console.WriteLine("Methods:");
         foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
         {
             Console.WriteLine(method.Name);
         }
     } */

    // 6. Extension Methods: Allow you to add methods to exisiting types without modifying them
    /* static void Main()
    {
        string example = "Hello, World!";
        System.Console.WriteLine(example.Reverse());
    } */

    // 7. Attributes: provide a way to add metadata to your code
    /*  static void Main()
     {
         Type type = typeof(SampleClass);
         var classAttribute = (MyAttribute)Attribute.GetCustomAttribute(type, typeof(MyAttribute));
         System.Console.WriteLine("Class attribute: " + classAttribute.Description);

         var method = type.GetMethod("SampleMethod");
         var methodAttribute = (MyAttribute)Attribute.GetCustomAttribute(method, typeof(MyAttribute));
         System.Console.WriteLine("Method attribute: " + methodAttribute.Description);
     } */

    // 8. Dependency Inverison 
    /*     static void Main()
        {
            IService service = new Service();
            Client client = new Client(service);
            client.Start();
        } */
}
// 5.Refleciton
/* class Sample
{
    public void Method1() { }
    public void Method2() { }
} */