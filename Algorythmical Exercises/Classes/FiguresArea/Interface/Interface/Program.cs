using System;
using FigureLibrary;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some code, which will be validate data to constructors:
            try
            {
                Console.WriteLine("Ведите радиус окружности: ");
                double radius = Double.Parse(Console.ReadLine());
                IFigure circle = new Circle { Radius = radius };
                var results = new List<ValidationResult>();
                var context = new ValidationContext(circle);
                if (!Validator.TryValidateObject(circle, context, results, true))
                {
                    foreach (var error in results)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                else
                {
                    Console.WriteLine(circle.GetArea());
                }
                // The Same code for triangles and some other figures
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }    
    }
}
