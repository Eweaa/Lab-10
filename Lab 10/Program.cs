using BookCL;
using QuestionCL;

namespace Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] authors = ["Khaled Fahmy", "Hossam Fakhr"];
            string[] author2 = ["George Orwell"];
            Book b1 = new("123", "In Quest of Justice", authors, DateTime.Now, 350);
            Book b2 = new("456", "1984", author2, DateTime.Now, 200);

            List<Book> books = new() { b1, b2 };

            //books.Add(b1);
            //books.Add(b2);

            Console.WriteLine(b1);

            Console.WriteLine(BookFunctions.GetTitle(b1));
            Console.WriteLine(BookFunctions.GetPrice(b1));
            Console.WriteLine(BookFunctions.GetAuthors(b1));

            BookFunctionDelegate d1 = delegate (Book b)
            {
                return b1.ISBN;
            };

            BookFunctionDelegate d2 = BookFunctions.GetTitle;

            BookFunctionDelegate getISBN = delegate (Book b) { return b.ISBN; };


            LibraryEngine.ProcessBooks(books, (Book b) => b.ISBN);
            LibraryEngine.ProcessBooks(books, (Book b) => b.PublicationDate.ToString());



            BaseQuestion q1 = new("123", "123", 1);
            BaseQuestion q2 = new("123", "123", 1);
            //BaseQuestion q2 = new("123", "123", 1);
            //BaseQuestion q3 = new("123", "123", 1);
            //BaseQuestion q4 = new("10, 11, 12", "123", 1);

            Answer a11 = new("Answer 1.1");
            Answer a12 = new("Answer 1.2");
            Answer a13 = new("Answer 1.3");
            Answer a14 = new("Answer 1.4");

            AnswerList AL = new();

            AL.Add(a11);
            AL.Add(a12);
            AL.Add(a13);
            AL.Add(a14);

            QuestionList QL = new QuestionList("List1");
            QL.Add(q1); 
            q1.Answers = AL;
            foreach (var item in q1.Answers)
            {
                Console.WriteLine($"A- {item.Body}");
            }
            //QL.Add(q2); 
            //QL.Add(q3);
            //QL.Add(q4);

            PracticeExam PE = new PracticeExam();

            Dictionary<BaseQuestion, Answer> test = new Dictionary<BaseQuestion, Answer>();
            test.Add(q1, a11);

            var hope = test.Keys.FirstOrDefault();
            Console.WriteLine(hope.Mark);
            Console.WriteLine(hope.Equals(q2));
            Console.WriteLine($"===========> {hope}");

            Dictionary<string, string> CorrectAnswers = new Dictionary<string, string>();
            CorrectAnswers.Add(q1.Body, a11.Body);



            Console.Write("Enter An Answer: ");
            int x = int.Parse(Console.ReadLine());

            string answered = q1.Answers[x -1].Body;
            Console.WriteLine(answered);

            string correctAnswer = (CorrectAnswers[q1.Body]);

            if (answered == correctAnswer)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
        public delegate string BookFunctionDelegate(Book B);
    }
}
