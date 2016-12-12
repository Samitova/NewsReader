using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    internal class Coment
    {
        public DateTime CreationDate { get; set; }

        public string Content { get; set; }

        public Coment(string msg)
        {
            Content = msg;
            CreationDate = DateTime.Now;
        }

        public override string ToString()
        {
            return String.Format($"{Content} {CreationDate.ToShortDateString()}");
        }
    }
}
