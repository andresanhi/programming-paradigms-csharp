using System;

namespace ProceduralProgramming
{
    static class Program
    {
        static void Main(string[] args)
        {
            var opc = GetData();
            switch (opc)
            {
                case '1':
                    TriangleArea();
                    break;
                case '2':
                    TriangleRectangle();
                    break;
            }
        }

        public static char GetData()
        {
            Console.WriteLine("1 Area del triángulo");
            Console.WriteLine("2 Perímetro del triángulo");
            Console.WriteLine("Introduce tu opción: ");
            return Convert.ToChar(Console.ReadLine());
        }

        public static void TriangleArea()
        {
            double b, h, area;
            Console.WriteLine("Ingresa base: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa altura: ");
            h = Convert.ToDouble(Console.ReadLine());
            area = b * h / 2;
            Console.WriteLine("El área es {0}", area);
        }

        public static void TriangleRectangle()
        {
            double b, a, c, peri;
            Console.WriteLine("Ingresa lado A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa lado B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa lado C");
            c = Convert.ToDouble(Console.ReadLine());
            peri = a + b + c;
            Console.WriteLine("El perímetro es {0}", peri);
        }
    }
}
