using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_SpyProgram.Elements;

namespace Nikita_SpyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var spyFile = new SpyFile();

            Dictionary<DateTime, ConsoleKey> keys = new Dictionary<DateTime, ConsoleKey>();

            spyFile.KeyLogger += (date, key) => keys[date] = key;

            spyFile.Start();

            foreach (KeyValuePair<DateTime, ConsoleKey> item in keys)
                Console.WriteLine($" Время: {item.Key} | Клавиша : {item.Value}");

            Console.ReadKey();
        }
    }
}
