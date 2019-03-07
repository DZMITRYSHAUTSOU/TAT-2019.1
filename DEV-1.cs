using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1 
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)//Реализована работа сразу с несколькими словами из командной строки
            {
                string slovo = args[i];
                if (slovo.Length < 2)//Проверка ввода 
                {
                    Console.WriteLine("NOT CORRECT!");
                }

                Console.WriteLine($"\n{slovo}\n");

                Sequence obj = new Sequence(slovo);//Запуск алгоритма
            }
            Console.ReadKey();
        }
    }
    class Sequence
    {
        public Sequence(string slovo)//Сам алгоритм
        {
            bool flag = false;//Используется как индикатор повторного символа
            string buff;//Содержит в себе часть слова до первого повторяющегося символа (или слово целиком)
            string buff2 = string.Empty;//Через эту переменную осуществлен вывод всех комбинаций букв
            buff = string.Concat(slovo[0]);
            for (int i = 1; i < slovo.Length; i++)
            {
                if (slovo[i] != slovo[i - 1])//Поиск подстрок без повторных элементов
                {
                    buff += slovo[i];
                }
                else
                {
                    flag = true;
                }

                if (flag || i == slovo.Length - 1)//Алгоритм вывода
                    while (buff.Length >= 2)
                    {
                        for (int k = 0; k < buff.Length; k++)
                        {
                            buff2 += buff[k];
                            if (buff2.Length >= 2)
                            {
                                Console.WriteLine(buff2);
                            }
                        }
                        buff = buff.TrimStart(buff[0]);
                        buff2 = string.Empty;
                    }
                flag = false;
            }
        }
    }
}


