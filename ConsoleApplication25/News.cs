using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    internal class News
    {
        public string Index { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Coment> Coment { get; set; }

        public News(string index, string title, string content)
        {
            Coment = new List<Coment>();
            Index = index;
            Title = title;
            Content = content;
        }

        public void AddComent(string msg)
        {
            Coment.Add(new Coment(msg));
        }

        public override string ToString()
        {
            if (Coment == null)
            {
                return String.Format($"{Content}");
            }
            else
            {
                string msg = string.Empty;
                for (int i = 0; i < Coment.Count; i++)
                {
                    msg += Coment[i].ToString()+"\n";
                }               
                return String.Format($"{Content} \n {msg}");
            }
           
        }

        public string ShortDiscript()
        {
            if (Content.Length > 50)
            {
                return String.Format($"{Index,-5} {Title,-20} {Content.Substring(0, 50)}");
            }
            else
            {
                return String.Format($"{Index,-5} {Title,-20} {Content}");
            }            
        }

    }
}
