namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Question 1 
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.
            Book book = new Book
            {
                title = "C#",
                pages = 200,
            };
            object obj = book;
            Console.WriteLine(obj);

            #endregion
        }

    }
}