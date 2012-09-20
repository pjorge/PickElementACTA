using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PickElementACTA
{
    public class Program
    {
        static void Main(string[] args)
        {

            string f = "nomes.txt";
            List<String> lines = new List<String>();

            using (StreamReader r = new StreamReader(f,Encoding.Default))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            List<String> names = new List<String>();

            int count = lines.Count;
            for (int i = 1; i < 5; i++)
            {
                System.Threading.Thread.Sleep(650);
                Random rnd = new Random();
                int number = rnd.Next(count);
                string selName = lines[number];
                if (!names.Contains(selName))
                {
                    names.Add(selName);
                }
            }

            Console.WriteLine(names[0]);
            Console.Read();
        }
    }
}
