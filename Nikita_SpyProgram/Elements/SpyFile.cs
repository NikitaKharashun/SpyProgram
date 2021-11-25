using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_SpyProgram.Elements
{
    class SpyFile
    {
        public event Action<DateTime, ConsoleKey> KeyLogger;

        public void Start()
        {
            bool isEnter = false;
            ConsoleKey key;

            Console.WriteLine("Включено логирование клавиш. Нажмите Enter, чтобы выйти");

            while (!isEnter)
            {
                key = Console.ReadKey().Key;

                isEnter = key.Equals(ConsoleKey.Enter);

                KeyLogger(DateTime.Now, key);
            }
        }
    }
}
