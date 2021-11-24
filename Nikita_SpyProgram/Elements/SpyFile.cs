using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_SpyProgram.Elements
{
    class SpyFile
    {
        public event Action<DateTime, ConsoleKeyInfo> KeyLogger;

        public void Start()
        {
            bool isEnter = false;
            ConsoleKeyInfo key;

            Console.WriteLine("Включено логирование клавиш");

            while (!isEnter)
            {
                key = Console.ReadKey();

                isEnter = key.Key.Equals(ConsoleKey.Enter);

                KeyLogger(DateTime.Now, key);
            }
        }
    }
}
