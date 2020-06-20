using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int word = 0;
            string[] text = File.ReadAllLines("file.txt");
            for (int i = 0; i < text.Length; i++)
            {
                string[] mass;
                mass = text[i].Split(' ');
                for (int c = 0; c < mass.Length; c++)
                {
                    if (mass[c] == "STUDENT")
                    {
                        word++;
                    }
                }
            }
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
