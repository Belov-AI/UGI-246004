using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace FrequencyAmalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла");
            var fileName = Console.ReadLine();

            if(!File.Exists(fileName))
            {
                Console.WriteLine("Файл не существует");
                return;
            }

            var text = File.ReadAllLines(fileName);

            string[] words;
            var frequencyDictionary = new SortedDictionary<string, int>();

            foreach (var line in text) 
            { 
                words = line.Split(new[] {' ', '.', ',', ';', ':', '?', '!',
                    '\t', '(', ')', '<', '>', '=', '-', '–', '—', '«', '»'});

                foreach(var word in words)
                {
                    var key = word.ToLower();

                    if (key != string.Empty)
                        if (frequencyDictionary.ContainsKey(key))
                            frequencyDictionary[key]++;
                        else
                            frequencyDictionary[key] = 1;
                }
                      
            }

            foreach(var  elem in frequencyDictionary)
                Console.WriteLine($"{elem.Key}: {elem.Value}");

            var valuesDict = new SortedDictionary<int, List<string>>();

            foreach(var elem in frequencyDictionary)
            {
                if (valuesDict.ContainsKey(elem.Value))
                    valuesDict[elem.Value].Add(elem.Key);
                else
                    valuesDict.Add(elem.Value, new List<string> { elem.Key });
            }

            foreach (var elem in valuesDict)
            {
                Console.Write(elem.Key + ": ");
                
                foreach(var w in elem.Value)
                    Console.Write($"{w} ");

                Console.WriteLine();
            }

        }
    }
}
