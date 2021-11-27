using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public static void FileInfo(DateTime time, ConsoleKey key)
        {
            string path = @"C:\Users\khara\Desktop\Info.txt";

            var file = new FileInfo(path);

            using (StreamWriter sw = file.CreateText())           
                sw.Write($" Время: {time} | Клавиша : {key}");


            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
        }
    }
}
