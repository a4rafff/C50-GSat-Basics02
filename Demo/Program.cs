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
        }

    }
}