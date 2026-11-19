using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Question 1 
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.
            //Book book = new Book
            //{
            //    title = "C#",
            //    pages = 200,
            //};
            //object obj = book;
            //Console.WriteLine(obj);

            #endregion

            #region Question 2
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            //Book book = new Book();
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion

            #region Question 3

            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.int pages = "464";

            /* int pages = "464";
               this a compile-time error 
             two sol 
               1- change data type to string 
               2- remove "" 

               int pages = 464;
            */

            #endregion

            #region Question 4
            // Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int x = 10; int y = 0;
            //    Console.WriteLine(x / y);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Done");

            #endregion

            #region Question 5
            // Declare an int pages = 300; then store it in a double variable without using a cast

            //int pages = 300;

            //double total = pages;

            //Console.WriteLine(total);


            #endregion

            #region Question 6
            // Declare a double price = 49.99; then convert it into an int using a cast.



            //double price = 49.99;

            //int intPrice = (int)price;

            //Console.WriteLine(intPrice);


            #endregion
            #region Question 7
            // Given string pagesText = "464";, convert it into an int using the Convert class.



            //string pagesText = "464";

            //int pagesInt = Convert.ToInt32(pagesText);

            //Console.WriteLine(pagesInt);


            #endregion

            #region Question 8
            // Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,use int.TryParse() to safely try converting it, and print "Invalid number" if it fails



            //string yearText = "2023";

            //int yearInt = int.Parse(yearText);

            //Console.WriteLine(yearInt);

            //string badText = "abc";

            //if (int.TryParse(badText, out int badInt))
            //{
            //    Console.WriteLine(badInt);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}


            #endregion

            #region Question 9
            // Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string

            //int pagesQ9 = 464;

            //string pageQ9Text = pagesQ9.ToString();

            //Console.WriteLine(pageQ9Text.GetType());


            //}


            #endregion

            #region Question 10
            // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.


            int copies = 100;

            object objBox = copies;

            int objInt = (int)objBox;


            //}


            #endregion
        }

    }
}
