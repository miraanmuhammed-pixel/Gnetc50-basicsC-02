using System.Globalization;
using System.Text;

namespace assignment02.routeProject;

class Program
{
    static void Main(string[] args)
    {
        #region q1
        // Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
        //     both title and upperTitle to show that title did not change.
        // string title = "clean code";
        // string upperTitle = title.ToUpper();
        // Console.WriteLine($"title={title}");
        // Console.WriteLine($"Uppertitle={upperTitle}");
        #endregion

        #region q2
        // Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
        // to check if they point to the same object in memory.
        // string title1 = "Clean Code";
        // string title2= "Clean Code";
        // Console.WriteLine(object.ReferenceEquals(title1,title2));
        #endregion

        #region q3

        //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
        //object. Print the final result.
        // StringBuilder text = new StringBuilder();
        // text.Append("Book List");
        // text.Append(" - Updated");
        // Console.WriteLine(text);

        #endregion

        #region q4
       // Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
           // Print the result.
           // text.Replace("Book List","Library");
           // Console.WriteLine(text);
           #endregion

           #region q5
           // Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
           // Pages: 464" using the + operator.
           string title = "Clean Code";
           int pages = 464;
           // Console.WriteLine("book:"+title+",pages:"+pages);
           #endregion

           #region q6
           // Build the same sentence as above, but using string interpolation ($"...").
          // Console.WriteLine($"book:{title},pages:{pages}");

           #endregion

           #region q7
           //Build the same sentence again, but using string.Format().
           // string text=string.Format("book:{0},pages:{1}", title, pages);
           // Console.WriteLine(text);
           #endregion

           #region q8


           // Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
           // 300, otherwise prints "Short Book".
           // int pages = 464;
           // if(pages>300) Console.WriteLine("Long Book");
           // else Console.WriteLine("Short Book");
           //


           #endregion

           #region q9

           // Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
           //     greater than 300 and isAvailable is true. Use the && operator.
           // int pages = 464;
           // bool isAvailable = true;
           // if(pages>300 && isAvailable==true) Console.WriteLine("You can borrow this book");
           // else Console.WriteLine("You cannot borrow this book");

           #endregion

           #region q10

           // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
           //     "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
           // string title = "Refactoring";
           // switch (title)
           // {
           //     case "Clean Code": Console.WriteLine("Great choice!");break;
           //         case "Refactoring": Console.WriteLine("Nice pick!");break;
           //         default: Console.WriteLine("Never heard of it"); break;
           // }



           #endregion

           #region q11

           // Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
           // variable sizeLabel (same rule as question 8: long if pages > 300).
           // int pages = 464;
           //
           // string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
           // Console.WriteLine(sizeLabel);

           #endregion

           #region q12

           // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
           //     to print each book with its position number, like 1. Clean Code.
           //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
           // for (int i = 0; i < books.Length; i++)
           // {
           //     Console.WriteLine($"{i+1}.{books[i]}");
           // }

           #endregion

           #region q13

           // Using the same books array, use a while loop to print every book title.
           // string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
           //
           // int i = 0;
           // while (i < books.Length)
           // {
           //     Console.WriteLine($"{i+1}.{books[i]}");
           //     i++;
           // }

           #endregion

           #region q14

           //Write a do-while loop that prints "Checking book..." exactly 3 times.
           // string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
           // int i = 0;
           // do
           //  {
           //      Console.WriteLine($"{i + 1}.{books[i]}");
           //      i++;
           //  } while (i < books.Length);

           #endregion

           #region q15

           // Using the same books array, use a foreach loop to print every book title.
           // foreach (string title in books)
           // {
           //     Console.WriteLine(title);
           // }

           #endregion

           #region q16

           // Using the same books array, loop through it and print each title, but stop completely (break) once
           //     you reach "Refactoring".
           // for(int i = 0; i < books.Length; i++)
           // {
           //     if (books[i] == "refactoring")
           //     {
           //         Console.WriteLine(books[i]);
           //         break;
           //     }
           //     Console.WriteLine(books[i]);
           // }

           #endregion

           #region q17

           // Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
           // continue, don't stop the loop).
           // for (int i = 0; i < books.Length; i++)
           // {
           //     if (books[i]=="The Pragmatic Programmer")continue;
           //     Console.WriteLine(books[i]);
           // }

           #endregion

           #region q18

           // Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
           // use return to exit the method early instead of printing anything.

           //  static void PrintFirstBook(string[]books)
           // {
           //     
           //     for (int i = 0; i < books.Length; i++)
           //     {
           //        if(books==null || books.Length==0)
           //        {
           //            return;
           //        }
           //        
           //            Console.WriteLine(books[0]);
           //        
           //     }
           // }

           #endregion


    }
}