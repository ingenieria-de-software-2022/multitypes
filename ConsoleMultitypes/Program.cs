using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultitypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 2.5;
            Console.WriteLine(x);
            x = 2;
            Console.WriteLine(x);
            x = 3.6F;
            Console.WriteLine(x);

            var y = 45;
            Console.WriteLine(y);
            // y = 3.5;
            // y = 7.9F;
            y = 'A';
            Console.WriteLine(y);

            var q = "ICE";
            Console.WriteLine(q);
            q = "ESIME";
            Console.WriteLine(q);
            // q = 4.6;
            // q = 3;

            // ! Los tipos estan limitados a la primera definición utilizada en la declaración de la variable,
            // ! esto no ocurre con los que son creados con la palabra object

            object a;
            a = 3;
            Console.WriteLine(a);
            a = 4.6F;
            Console.WriteLine(a);
            a = 2.6;
            Console.WriteLine(a);
            a = 'A';
            Console.WriteLine(a);
            a = "ESIME";
            Console.WriteLine(a);

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }
    }
}
