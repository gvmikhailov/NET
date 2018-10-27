using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

// Алгебра комплексных чисел

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> signs = new List<string>() { "+", "-", "/", "*", "_", };
            Random rnd = new Random();
            double realPartN1 = rnd.Next(1, 100);
            double realPartN2 = rnd.Next(1, 100);
            double imaginaryPartN1 = rnd.Next(1, 100);
            double imaginaryPartN2 = rnd.Next(1, 100);
            Complex cmplx1 = new Complex(realPartN1, imaginaryPartN1);
            Complex cmplx2 = new Complex(realPartN2, imaginaryPartN2);
            string sign = signs[rnd.Next(0, signs.Count)];
            Operation(sign, cmplx1, cmplx2);
        }

        static void Operation(string sign, Complex cmplx1, Complex cmplx2)
        {
            switch (sign)
            {
                case "+":
                    {
                        Complex summ = Complex.Add(cmplx1, cmplx2);
                        Console.WriteLine("Сумма двух комплексных чисел " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx1) + " и " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx2) + " Равна " + String.Format(new ComplexFormatter(), "{0:I0}", summ));
                        break;
                    }
                case "-":
                    {
                        Complex substract = Complex.Subtract(cmplx1, cmplx2);
                        Console.WriteLine("Разность двух комплексных чисел " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx1) + " и " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx2) + " Равна " + String.Format(new ComplexFormatter(), "{0:I0}", substract));
                        break;
                    }
                case "/":
                    {
                        Complex devide = Complex.Divide(cmplx1, cmplx2);
                        Console.WriteLine("Деление комплексного числа " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx1) + " на " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx2) + " Равна " + String.Format(new ComplexFormatter(), "{0:I0}", devide));
                        break;
                    }
                case "*":
                    {
                        Complex multiply = Complex.Multiply(cmplx1, cmplx2);
                        Console.WriteLine("Умножение комплексного числа " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx1) + " на " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx2) + " Равна " + String.Format(new ComplexFormatter(), "{0:I0}", multiply));
                        break;
                    }
                case "_":
                    {
                        Complex conjugate1 = Complex.Conjugate(cmplx1);
                        Complex conjugate2 = Complex.Conjugate(cmplx2);
                        Console.WriteLine("Сопряжение комплексного числа " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx1) + " Равно " + String.Format(new ComplexFormatter(), "{0:I0}", conjugate1));
                        Console.WriteLine("Сопряжение комплексного числа " + String.Format(new ComplexFormatter(), "{0:I0}", cmplx2) + " Равно " + String.Format(new ComplexFormatter(), "{0:I0}", conjugate2));
                        break;
                    }
            }

        }
    }
}


