namespace BookCL
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string temp = "";
            for (int i = 0; i < B.Authors.Length; i++)
            {
                if (i != B.Authors.Length - 1)
                    temp += B.Authors[i] + ", ";
                else
                {
                    temp += B.Authors[i];
                }
            }
            return temp;
        }
        public static string GetPrice(Book B)
        {
            return $"{B.Price}";
        }

        public static string GetISBN(Book B) => B.ISBN;
        public static string GetPublicationDate(Book B) => B.PublicationDate.ToString();

    }
}
