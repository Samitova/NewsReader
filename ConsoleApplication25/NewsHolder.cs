using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class NewsHolder
    {             
        private List<News> _news = new List<News>();

        public void AddNews(News myNews)
        {
            _news.Add(myNews);           
        }

        public News GetNewsByIndex(string index)
        {
            return _news.Find(item => item.Index == index);
        }

        public void DisplayNews(string index)
        {
            News found = GetNewsByIndex(index);
            if (found != null)
            {
                Console.WriteLine(GetNewsByIndex(index).ToString());
            }
            else
            {
                Console.WriteLine("No such article");
            }           
        }

        public void DisplayShortContent()
        {
          _news.ForEach(item => Console.WriteLine(item.ShortDiscript()));
        }

        public void AddComment(string index, string comment)
        {
            News found = GetNewsByIndex(index);
            if (found != null)
            {
                found.AddComent(comment);
            }
            else
            {
                Console.WriteLine("No such article");
            }
        }
    }
}
