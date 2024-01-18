using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    // Derived class for a double-glazed window
    public class DoubleGlazedWindow : Window
    {
        public int Chamberness { get; set; }
        public double TotalThickness { get; set; }
        public double GlassThickness { get; set; }

        public DoubleGlazedWindow(string article, int chamberness, double totalThickness, double glassThickness)
            : base(article)
        {
            Chamberness = chamberness;
            TotalThickness = totalThickness;
            GlassThickness = glassThickness;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Double-Glazed Window - Article: {ArticleWindow}");
            Console.WriteLine($"Chamberness: {Chamberness}");
            Console.WriteLine($"Total Thickness: {TotalThickness} mm");
            Console.WriteLine($"Glass Thickness: {GlassThickness} mm");
        }
    }
}
