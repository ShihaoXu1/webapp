using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naming.Practice
{
    public class Practic
    {
        
    }
}
// Always use native datatype instead of .NET CTS type. For example, use int instead of In32 or Int64
// Good
// Private Member Variable
// Always try to use camelCase terminology prefix with underscore(_ ).
private int _salary = 100;

// Class
// Always use PascalCase for class names, Try to use noun or noun phrase for class name.
public partial class About: Page
{
    //...
}

// Methods
// Always use PascalCase for method names. Use maximum 7 parameter for a method.

public string GetPosts(string postId)
{
    // Argument and Local Variable
    // Always use camelCase with method arguments and local variables. Don't use Hungarian notation for variables
    int numberOfPost = 0;
    // Dnot use abbreviations for any words and dont use underscore in between any name.

}
// Property
// Use PascalCase for property. Never use Get and Set as prefix with property name.


private int _salary = 100;
public int Salary
{
    get { return _salary; }
    set { _salary = value; }
}

// Interface
// Always use letter "I" as prefix with name of interface. After letter I, use PascalCase.
public interface IUser
{
    /// <summary>  
    /// Check user is exists or not  
    /// </summary>  
    /// <returns>return bool value</returns>  
    bool ValidateUser();
}

// Member variable
// Declare member variable at the top of the class, If class has static member then it will come at the top most and after that other member variable.
public class Account
{
    public static string BankName;
    public static decimal Reserves;
    public string Number
    {
        get;
        set;
    }
    public DateTime DateOpened
    {
        get;
        set;
    }
    public DateTime DateClosed
    {
        get;
        set;
    }
    public decimal Balance
    {
        get;
        set;
    }
    // Constructor  
    public Account()
    {
        // ...  
    }
}