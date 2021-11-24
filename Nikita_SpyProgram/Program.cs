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

            Dictionary<DateTime, ConsoleKeyInfo> keys = new Dictionary<DateTime, ConsoleKeyInfo>();

            spyFile.KeyLogger += (date, info) => keys[date] = info;

            spyFile.Start();

            foreach (KeyValuePair<DateTime, ConsoleKeyInfo> item in keys)
                Console.WriteLine($" Время: {item.Key} | Клавиша : {item.Value.KeyChar}");

            Console.ReadLine();
        }
    }
}
