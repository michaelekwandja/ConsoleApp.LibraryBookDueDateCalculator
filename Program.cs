using Microsoft.VisualBasic;
using System.Xml.Linq;
//methods
void Title()
{
    Console.WriteLine("********** - Due Date Calculator - **********");
    Console.WriteLine("********** - KuilsRiver Library - **********");

}

Title();
Console.WriteLine();

string userName;
string userSurname;
DateTime userDOB;
string userIDLast7Digits;
var userIDFirst6Digits = string.Empty;
string userID;
string nameOfBook;
bool validDateOfBirth;
string userinput;
DateTime today = DateTime.Now;
string displayDueDate;

try
{
    Console.Write("Enter your Name: ");
    userName = Console.ReadLine();
    Console.Clear();

    Title();
    Console.WriteLine();
    Console.Write("Surname: ");
    userSurname = Console.ReadLine();
    Console.Clear();

    Title();
    Console.WriteLine();
    do
    {
        Console.Write("Enter you date of birth(Jan 21, 2006): ");
        userinput = Console.ReadLine();
        validDateOfBirth = DateTime.TryParse(userinput, out userDOB);
        if (validDateOfBirth is false)
        {
            Console.WriteLine("Invalid format.");
            Console.WriteLine();
        }
    } while (validDateOfBirth is false);
    Console.Clear();

    Title();
    Console.WriteLine();
    do
    {
        userIDFirst6Digits = userDOB.ToString("yyMMdd");
        userIDFirst6Digits.Substring(0, 5);
        Console.Write($"ID (enter last 7 digits): {userIDFirst6Digits}");
        userIDLast7Digits = Console.ReadLine();
        userID = userIDFirst6Digits + userIDLast7Digits;

        if (userIDLast7Digits.Length is not 7)
        {
            Console.WriteLine("Please enter the last 7 digits of your ID number.");
            Console.WriteLine();
        }

    } while (userIDLast7Digits.Length is not 7);
    Console.Clear();

    Title();
    Console.WriteLine();
    Console.Write("Book Name: ");
    nameOfBook = Console.ReadLine();
    Console.Clear();

    DateTime dueDate = today.AddDays(-35);
    displayDueDate = dueDate.ToString("dd mm yyyy");

    Receipt();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Receipt()
{
    Title();
    Console.WriteLine();
    Console.WriteLine("Receipt");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"Issed on: {today}");
    Console.WriteLine($"To: {userName} {userSurname}");
    Console.WriteLine($"ID: {userID}");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"Book Name: {nameOfBook}");
    Console.WriteLine($"Due Date: {displayDueDate}");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("Books are to be returned 35 days after being borrowed.");
    Console.WriteLine("Thank you.");
    Console.ReadLine();

}