using System;
using System.IO;
using System.Threading.Tasks;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string fin = @"input.xml";
            string fout = @"output.txt";
            //var xmlOne = new XmlFile(path);
            var newAdapter = new Adapter();
            var text = new Text();
            text = newAdapter.ConvertXMLToStr(fin);

            using (StreamWriter sw = new StreamWriter(fout, false))
            {
                for (int i = 0; i < text.text.Count; i++)
                {
                    sw.WriteLine(text.text[i]);
                }
            }
            Console.WriteLine("Programm finished.");
            Console.ReadKey();
        }
    }
}
