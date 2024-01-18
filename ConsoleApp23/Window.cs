using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public abstract class Window
    {
        internal string ArticleWindow { get; set; }

        public Window(string article)
        {
            ArticleWindow = article;
        }

        public abstract void DisplayInfo();
    }
}
