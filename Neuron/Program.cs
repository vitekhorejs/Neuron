using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] input_strenght = new int[] {1,1,1,1};
            int[] input_value = new int[] {0,0,0,0};
            bool repeat = true;
            string input;
            int neuron_limit = 5;

            while (repeat)
            {
                Console.WriteLine("Vstup 1:");
                input = Console.ReadLine();
                Int32.TryParse(input, out input_value[0]);
                Console.Clear();

                Console.WriteLine("Vstup 2:");
                input = Console.ReadLine();
                Int32.TryParse(input, out input_value[1]);
                Console.Clear();

                Console.WriteLine("Vstup 3:");
                input = Console.ReadLine();
                Int32.TryParse(input, out input_value[2]);
                Console.Clear();

                Console.WriteLine("Vstup 4:");
                input = Console.ReadLine();
                Int32.TryParse(input, out input_value[3]);
                Console.Clear();

                if (input_value[0] * input_strenght[0] + input_value[1] * input_strenght[1] + input_value[2] * input_strenght[2] + input_value[3] * input_strenght[3] >= neuron_limit)
                {
                    Console.WriteLine("Neuron vystřelil");
                }
                else
                {
                    Console.WriteLine("Neuron nevystřelil");
                }

                for (int a = 0; a < 3; a++)
                {
                    if (input_value[a] >= 1)
                    {
                        input_strenght[a]++;
                    } 
                }
            }
        }
    }
}
