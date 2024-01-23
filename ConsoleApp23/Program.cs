using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store window objects
            List<Window> windowsList = new List<Window>();

            // Add sample windows to the list
            windowsList.Add(new DoubleGlazedWindow("W123", 2, 15.0, 8.0));
            windowsList.Add(new SingleGlazedWindow("W456", 10.0));
            windowsList.Add(new DoubleGlazedWindow("W789", 3, 20.0, 12.0));

            // Display information about each window
            foreach (var window in windowsList)
            {
                window.DisplayInfo();
                Console.WriteLine(); // Add a newline for better readability
            }

            Console.WriteLine("Введите первые несколько букв артикула, чтобы выполнить поиск похожих артикулов:");
            string searchLetters = Console.ReadLine();

            // Search for similar articles and display them
            SearchSimilarArticles(windowsList, searchLetters);

            Console.ReadLine();
        }

        static void SearchSimilarArticles(List<Window> windowsList, string searchLetters)
        {
            Console.WriteLine($"Результаты поиска артикулов, начинающихся с '{searchLetters}':");

            foreach (var window in windowsList)
            {
                if (window.ArticleWindow.StartsWith(searchLetters, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(window.ArticleWindow);

                    Console.WriteLine("Выберите артикул и введите его код:");
                    string selectedArticle = Console.ReadLine();

                    if (string.Equals(selectedArticle, window.ArticleWindow, StringComparison.OrdinalIgnoreCase))
                    {
                        switch (selectedArticle)
                        {
                            case "W123":
                                // Display information about the glass unit for W123
                                Console.WriteLine($"Информация о стеклопакете  {window.ArticleWindow}:");
                                if (window is DoubleGlazedWindow doubleGlazedWindow)
                                {
                                    Console.WriteLine($"Layers: {doubleGlazedWindow.Chamberness}");
                                    Console.WriteLine($"Thickness: {doubleGlazedWindow.TotalThickness}");
                                    Console.WriteLine($"GlassThickness: {doubleGlazedWindow.GlassThickness}");
                                }
                                break;

                            case "W456":
                                // Display information about the glass unit for W456
                                Console.WriteLine($"Информация о стеклопакете  {window.ArticleWindow}:");
                                if (window is SingleGlazedWindow singleGlazedWindow)
                                {
                                    Console.WriteLine($"Thickness: {singleGlazedWindow.Thickness}");
                                    
                                }
                                break;

                            case "W789":
                                // Display information about the glass unit for W456
                                Console.WriteLine($"Информация о стеклопакете  {window.ArticleWindow}:");
                                if (window is DoubleGlazedWindow doubleGlazedWindow1)
                                {
                                    Console.WriteLine($"Layers: {doubleGlazedWindow1.Chamberness}");
                                    Console.WriteLine($"Thickness: {doubleGlazedWindow1.TotalThickness}");
                                    Console.WriteLine($"GlassThickness: {doubleGlazedWindow1.GlassThickness}");
                                }
                                break;

                            // Add cases for other articles if needed

                            default:
                                Console.WriteLine("Неизвестный артикул.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод. Пожалуйста, выберите подходящий артикул.");
                    }

                    Console.WriteLine(); // Add a newline for better readability
                }
            }
        }

    }





}
