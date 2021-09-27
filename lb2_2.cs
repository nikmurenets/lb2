using System;

namespace Laboratorka2
{
    class Rectangle

    {

        public double side1; // сторона 1

        public double side2; // сторона 2

        public Rectangle(double s1, double s2) { side1 = s1; side2 = s2; }

        public void AreaCalculator()
        {
            double area = side1 * side2;
            Console.WriteLine($"Площадь = {area}");
        }

        public void PeriemetrCalculator()

        {
            double periemeter = (side1 + side2) * 2;
            Console.WriteLine($"Периметр = {periemeter}");
        }


        class Program

        {
            static double s1;

            static double s2;



            static void Main(string[] args)

            {
                Console.WriteLine("Введите первую сторону фигуры");
                s1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону фигуры");
                s2 = Convert.ToDouble(Console.ReadLine());

                Type t1 = s1.GetType();
                Type t2 = s2.GetType();

                if (t1.Equals(typeof(double)) & t2.Equals(typeof(double)))
                {
                    Rectangle sqare = new Rectangle(s1, s2);

                    sqare.AreaCalculator();

                    sqare.PeriemetrCalculator();
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("не тот тип");

                }

            }
        }
    }
}

