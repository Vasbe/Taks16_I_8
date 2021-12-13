
using System;
using System.IO;
using System.Linq;

namespace Taks_16_I_8
{
    class main
    {
        public static void Main()
        {
            StreamReader filein = new StreamReader("testInput.txt");
            Console.WriteLine("Введите заданное число: ");
            double c = double.Parse(Console.ReadLine());
            string[] text = filein.ReadLine().Split(" ");
            double[] array = new double[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = double.Parse(text[i]);
            }
            var sortedNums = array.Where(x => x > c);
            foreach (var x in sortedNums)
            {
                Console.WriteLine(x / 2);
            }
        }
    }
}