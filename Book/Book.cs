namespace BookCL
{
    public class Book
    {
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < Authors.Length; i++)
            {
                if (i != Authors.Length - 1)
                    temp += Authors[i] + " and ";
                else
                {
                    temp += Authors[i];
                }
            }

            return $"{Title} is written by {temp}, it was published on {PublicationDate} and it goes for {Price}";
        }

    }
    //public class BookFunctions
    //{
    //    public static string GetTitle(Book B)
    //    {
    //        return B.Title;
    //    }
    //    public static string GetAuthors(Book B)
    //    {
    //        string temp = "";
    //        for (int i = 0; i < B.Authors.Length; i++)
    //        {
    //            if (i != B.Authors.Length - 1)
    //                temp += B.Authors[i] + ", ";
    //            else
    //            {
    //                temp += B.Authors[i];
    //            }
    //        }
    //        return temp;
    //    }
    //    public static string GetPrice(Book B)
    //    {
    //        return $"{B.Price}";
    //    }

    //    public static string GetISBN(Book B) => B.ISBN;
    //    public static string GetPublicationDate(Book B) => B.PublicationDate.ToString();


    //}
    //public class LibraryEngine
    //{
    //    public delegate string BookFunctionDelegate(Book B);
    //    public static void ProcessBooks(List<Book> bList, BookFunctionDelegate fPtr)
    //    {
    //        foreach (Book B in bList)
    //        {
    //            Console.WriteLine(fPtr(B));
    //        }
    //    }
    //}
}
