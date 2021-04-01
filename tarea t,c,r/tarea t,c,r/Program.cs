using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_t_c_r
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, a, area, num;
            string si;
            do
            {
                Console.WriteLine("elija un figura geometrica");
                Console.WriteLine("1.cuadrado");
                Console.WriteLine("2rectangulo");
                Console.WriteLine("3triangulo");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ponga la base o el lado");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ponga la altura o el lado");
                a = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        area = b * a;
                        Console.WriteLine("el area del cuadrado es :" + area);
                        break;

                    case 2:
                        area = b * a;
                        Console.WriteLine("el area del rectangulo es:" + area);
                        break;
                    case 3:
                        area = b * a / 2;
                        Console.WriteLine("el area del triangulo es:" + area);
                        break;
                }
                Console.WriteLine("desea volver a intentarlo");
                si = Console.ReadLine();
            }
            while (si == "SI" || si == "si");
        }
    }
}