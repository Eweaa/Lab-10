namespace BookCL
{
    public class LibraryEngine
    {
        public delegate string BookFunctionDelegate(Book B);

        public delegate Func<Book, string> BookTest(Book B);

        //public Func<Book, string> BookFunctionDelegate;
        public static void ProcessBooks(List<Book> bList, BookFunctionDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
