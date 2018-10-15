using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coloque aqui o seu codigo
            double x, y;
            Console.WriteLine("insira as codernadas de x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insira as codernadas de y");
            y = Convert.ToDouble(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("x-{0} e y-{1} Pertencem ao 1º quadrante", x, y);
            }
            else if(x>0 && y<0) 
            {
                Console.WriteLine("x-{0} e y-{1} Pertencem ao 4º quadrante", x, y);
            }
             else if(x<0 && y>0)
            {
                Console.WriteLine("x-{0} e y-{1} Pertencem ao 2º quadrante", x, y);
            }
            else if(x<0 && y<0)
            {
                Console.WriteLine("x-{0} e y-{1} Pertencem ao 3º quadrante", x, y);
            }
             else if(x<0 && y<0)
            {
                Console.WriteLine("x-{0} e y-{1} Pertencem a origem do referencial ", x, y);
            }
        
        }
    }
}
