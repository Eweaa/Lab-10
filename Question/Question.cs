namespace QuestionCL
{
    public class BaseQuestion
    {
        public BaseQuestion(string _Header, string _Body, int _Mark)
        {
            Header = _Header;
            Body = _Body;
            Mark = _Mark;
        }
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public AnswerList Answers { get; set; }

        //public override string ToString()
        //{
        //    return $"{Body}";
        //}
        public override bool Equals(object? obj)
        {
            BaseQuestion BQ = obj as BaseQuestion;
            if (BQ is BaseQuestion && BQ.Body == Body)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            string test = ToString();
            return test.GetHashCode();
        }
    }

    public class TrueOrFalseQuestion : BaseQuestion
    {
        public TrueOrFalseQuestion(string _Header, string _Body, int _Mark) : base(_Header, _Body, _Mark)
        {
        }
    }

    public class ChooseOneQuestion : BaseQuestion
    {
        public ChooseOneQuestion(string _Header, string _Body, int _Mark) : base(_Header, _Body, _Mark)
        {
        }
    }

    public class ChooseMultiple : BaseQuestion
    {
        public ChooseMultiple(string _Header, string _Body, int _Marks) : base(_Header, _Body, _Marks)
        {
        }
    }

    public class QuestionList : List<BaseQuestion>
    {
        public QuestionList(string _ListTitle)
        {
            ListTitle = _ListTitle;
        }
        public string ListTitle { get; set; }
        public new void Add(BaseQuestion question)
        {
            base.Add(question);

            string path = "C:\\Users\\youse\\desktop";

            using (StreamWriter MyFile = new StreamWriter(Path.Combine(path, $"{ListTitle}.txt"), true))
            {
                MyFile.WriteLine(question.Header);
            }
        }
    }

    public class Answer
    {
        public Answer(string _Body)
        {
            Body = _Body;
        }
        public string Body { get; set; }
    }

    public class AnswerList : List<Answer>
    {
        public new void Add(Answer answer)
        {
            base.Add(answer);
        }
    }

    public class BaseExam
    {
        public TimeSpan Time { get; set; }
        public Dictionary<BaseQuestion, Answer> QuestionWithAnswers { get; set; }
    }

    public class PracticeExam : BaseExam
    {
    }

    public class FinalExam : BaseExam 
    {
    }

    public class Subject
    {
    }
}
