using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {

        static void Main(string[] args)
        {

            NewsHolder holder = new NewsHolder();
            holder.AddNews(new News("1", "Big Ban", "jsdfhskdtshgkdsriutirehgidfyigtduyidfkjgkdlf"));
            holder.AddNews(new News("2", "Dog", "sertreyyrtuyrtuyuuyiujhgjghiuoiupio[po[ioopuihghghjhg"));
            holder.AddNews(new News("3", "Good Boy", "sdgjdfyudfkljgkljgldfkjgklfdjkgdfjglkdfjg;l"));

            MainMenu(holder);
        }

        public static void MainMenu(NewsHolder holder) {
            holder.DisplayShortContent();
            Console.WriteLine("Chose article");
            string index = Console.ReadLine();
            holder.DisplayNews(index);

            Console.WriteLine("Would you like to add comment. Y/N");

            switch (Console.ReadLine().ToUpper())
            {
                case "Y":
                    Console.WriteLine("Enter comment");
                    holder.AddComment(index, Console.ReadLine());
                    holder.DisplayNews(index);
                    MainMenu(holder);
                    break;
                case "N":
                    MainMenu(holder);
                    break;
                default:
                    Console.WriteLine("Dont Understand. Go to main menu.");
                    MainMenu(holder);
                    break;
            }
        }     
    }
}
