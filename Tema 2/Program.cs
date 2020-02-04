using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public class Asignare_1
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = (a = 2) * a;
            int c = b * (b = 5);
            Console.WriteLine("a =" + a + ", b =" + b + ", c =" + c);
            Console.ReadLine();
            //Raspuns: A afisat mai multe string-uri concatenate: a =2, b =5, c =20 
            //a=2 si b=5 deoarece s-a luat in considerare ultima valoare declarata. 
            //c=20 deoarece 4*5=20

        }
    }
    public class Asignare_2
    {
        static void Main(string[] args)
        {
            double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i);
            Console.ReadLine();
            //Se compileaza, afiseaza 4. 
            //Este o instructiune if-else care are urmatoarea logica: daca 3.95 > 4 atunci d=3.95, altfel i=4

        }
    }
    public class Asignare_3
    {
        static void Main(string[] args)
        {
            int a = 3;
            if (++a < 4)

                if (a++ < 4)
                    Console.WriteLine(a);

                else
                    Console.WriteLine(a);
            Console.ReadLine();
            //Nu se afiseaza pentru ca numarul "a" nu este mai mic ca 4. 

        }
    }
    public class Asignare_4
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i < 10; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma este: " + suma);
            Console.ReadLine();
            // Raspuns: 45
        }
    }

    public class Asignare_5
    {
        static void Main(string[] args)
        {
            int produs = 1;
            for (int n = 1; n < 13; n++)
            {
                produs = produs * n;
            }
            Console.WriteLine("Produsul este: " + produs);
            Console.ReadLine();
        }
    }
    public class Asignare_6
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 10;

            if (a < b)
            {
                if (a < c)
                    Console.WriteLine("Minimum este: " + a);
                else
                    Console.WriteLine("Minimum este: " + c);
                Console.ReadLine();
            }
            else
            {
                if (b < c)
                    Console.WriteLine("Minimum este: " + b);
                else
                    Console.WriteLine("Minimum este: " + c);
                Console.ReadLine();

            }
        }
    }



    public class Asignare_7
    {
        static void Main(string[] args)
        {
            int x = 8;
            if (x % 2 == 0)
            {
                Console.WriteLine("Numarul este par");
            }
            else
            {
                Console.WriteLine("Numarul este impar");

            }
            Console.ReadLine();
        }
    }
    public class Asignare_8
    {
        static void Main(string[] args)
        {
            int numarzi;

            //Citeste ziua din saptamana de la user
            Console.WriteLine("Introduce numarul zilei (1-7): ");
            numarzi = Convert.ToInt32(Console.ReadLine());

            switch (numarzi)
            {
                case 1:
                    Console.WriteLine("Luni");
                    break;
                case 2:
                    Console.WriteLine("Marti");
                    break;
                case 3:
                    Console.WriteLine("Miercuri");
                    break;
                case 4:
                    Console.WriteLine("Joi");
                    break;
                case 5:
                    Console.WriteLine("Vineri");
                    break;
                case 6:
                    Console.WriteLine("Sambata");
                    break;
                case 7:
                    Console.WriteLine("Duminica");
                    break;
                default:
                    Console.WriteLine("Valoare invalida! Te rog sa introduci un numar de la 1-7.");
                    break;

            }
            Console.ReadLine();
        }
    }
}






