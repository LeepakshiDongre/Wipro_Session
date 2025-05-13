public class Employee
{
    public int EmployeeID {  get; set; }
    public string EmployeeName { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Employee[] EmployeeArray = {
            new Employee() { EmployeeID = 1, EmployeeName = "John", Age = 18 },
            new Employee() { EmployeeID = 2, EmployeeName = "Steve", Age = 21 },
            new Employee() { EmployeeID = 3, EmployeeName = "Bill", Age = 25 },
            new Employee() { EmployeeID = 4, EmployeeName = "Ram", Age = 20 },
            new Employee() { EmployeeID = 5, EmployeeName = "Ron", Age = 31 },
            new Employee() { EmployeeID = 6, EmployeeName = "Chris", Age = 17 },
            new Employee() { EmployeeID = 7, EmployeeName = "Rob", Age = 19 },

        };

        Employee[] Employees = new Employee[10];
        int i = 0;
        foreach (Employee employee in EmployeeArray)
        {
            if (employee.Age > 12 && employee.Age < 20)
            {
                Employees[i] = employee;
                System.Console.WriteLine(employee.EmployeeName);
            }
        }
    }

}



//2 Method
public class Employee
{
    public int EmployeeID {  get; set; }
    public string EmployeeName { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Employee[] EmployeeArray = {
            new Employee() { EmployeeID = 1, EmployeeName = "John", Age = 18 },
            new Employee() { EmployeeID = 2, EmployeeName = "Steve", Age = 21 },
            new Employee() { EmployeeID = 3, EmployeeName = "Bill", Age = 25 },
            new Employee() { EmployeeID = 4, EmployeeName = "Ram", Age = 20 },
            new Employee() { EmployeeID = 5, EmployeeName = "Ron", Age = 31 },
            new Employee() { EmployeeID = 6, EmployeeName = "Chris", Age = 17 },
            new Employee() { EmployeeID = 7, EmployeeName = "Rob", Age = 19 },

        };

        //Use LINQ to find teenager Employees
        Employee[] teenAgerEmployees = EmployeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

        //Use LINQ to find first Employee whose name is Bill
        Employee bill = EmployeeArray.Where(s => s.EmployeeName == "Bill").FirstOrDefault();

        //Use LINQ to find Employee whose EmployeeID is 5
        Employee Employee5 = EmployeeArray.Where(s => s.EmployeeID == 5).FirstOrDefault();

    }
}

// 3rd 
//Define a custom delegate that has a string parameter and returns void.
delegate void CustomDel(string s);
class TestClass
{
    //Define two methods that have the same signature as CustomDel.
    static void Hello(string s)
    {
        Console.WriteLine($" Hello, {s}!");
    }

    static void Main()
    {
        //Declare instances of the  custom delegate.
        CustomDel hiDel;

        hiDel = Hello;

        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");
    }
}



//MULTICASTINGDELEGATE
//Define a custom delegate that has a string parameter and returns void.
delegate void CustomDel(string s);
class TestClass
{
    //Define two methods that have the same signature as CustomDel.
    static void Hello(string s)
    {
        Console.WriteLine($" Hello, {s}!");
    }
    static void Goodbye(string s)
    {
        Console.WriteLine($" Goodbye, {s}!");
    }

    static void Main()
    {
        //Declare instances of the  custom delegate.
        CustomDel hiDel, byeDel, multiDel;

        hiDel = Hello;

        // Create the delegate oblect byeDel that references the 
        //method Goodbye
        byeDel = Goodbye;

        //The two delegates, hiDel and byeDel, are combined to 
        //from multiDel.
        //MULTICAST DELEGATE - SIMPLE INVOCATION
        multiDel = hiDel + byeDel;

        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");
        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("B");
        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("C");


    }
}




//Anothe
//Define a custom delegate that has a string parameter and returns void.
delegate void CustomDel(string s);
class TestClass
{
    //Define two methods that have the same signature as CustomDel.
    static void Hello(string s)
    {
        Console.WriteLine($" Hello, {s}!");
    }
    static void Goodbye(string s)
    {
        Console.WriteLine($" Goodbye, {s}!");
    }

    static void Main()
    {
        //Declare instances of the  custom delegate.
        CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;

        hiDel = Hello;

        // Create the delegate oblect byeDel that references the 
        //method Goodbye
        byeDel = Goodbye;

        //The two delegates, hiDel and byeDel, are combined to 
        //from multiDel.
        //MULTICAST DELEGATE - SIMPLE INVOCATION
        multiDel = hiDel + byeDel;

        //Remove hiDel from the multicast delegate, leaving byeDel, which calls only the method Goodbye.
        multiMinusHiDel = multiDel - hiDel;



        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");
        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("B");
        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("C");
        Console.WriteLine("Invoking delegate multiMinusHiDel:");
        multiMinusHiDel("D");

    }
}




//Simple Operation Using Delegate method
class SimpleDelegate
{
    public delegate int SomeOperation(int i, int j);

    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            SomeOperation add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);
        }
    }
}


//Without Using Delegate Using Func for return 
class   Function
{
    static int Sum(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Func<int, int, int> add = Sum;

        int result = add(10, 10);

        Console.WriteLine(result);
    }
}


//When not return use Action 

