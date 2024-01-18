using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class SingleGlazedWindow : Window
    {
        public double Thickness { get; set; }

        public SingleGlazedWindow(string article, double thickness)
            : base(article)
        {
            Thickness = thickness;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Single-Glazed Window - Article: {ArticleWindow}");
            Console.WriteLine($"Thickness: {Thickness} mm");
        }
    }
}
