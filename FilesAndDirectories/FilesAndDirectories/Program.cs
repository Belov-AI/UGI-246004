using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAndDirectories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test.txt";
            Console.WriteLine(File.Exists(fileName));

            string[] verse = {
                "Тихо, тихо ползи",
                "Улитка по склону Фудзи",
                "Вверх до самых высот."
            };

            if(!File.Exists(fileName))
                File.Create(fileName).Close();

            Console.WriteLine(File.Exists(fileName));

            File.WriteAllText(fileName, "Хокку\n\n");
            File.AppendAllLines(fileName, verse);

            

            Console.WriteLine("\nВведите имя файла");

            fileName = Console.ReadLine();

            //var text = File.ReadAllLines(fileName, Encoding.GetEncoding(1251));

            //PrintText(text);

            if (File.Exists(fileName))
                using (var stream = new StreamReader(fileName, Encoding.GetEncoding(1251)))
                {

                    while (!stream.EndOfStream)
                        Console.WriteLine(stream.ReadLine());
                }
            
            //File.Delete(fileName);
            //Console.WriteLine(File.Exists(fileName));
        }

        static void PrintText(string[] text)
        {
            foreach(var line in text)
                Console.WriteLine(line);
        }
    }
}
