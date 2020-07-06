using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
    class Notebook
    {
        static Dictionary<string, string> al = new Dictionary<string, string>(); 
        public static Note n = new Note();
        static void Main(string[] args)
        {
            n.Output();
        }
        public void CreateNewNote() // создание новой записи
        {
            Console.Clear();
            Console.WriteLine("Введите ваши данные");
            Note input = new Note();
            List<string> y = input.inp;
            for (int i = 0; i < y.Count; i++)
            {
                if(i == 3)
                {
                    Console.Write(y[i] + "(только цифры): ");
                }else
                if (i>4)
                {
                    Console.Write(y[i] + "(поле не является обязательным): ");
                }else
                    Console.Write(y[i]);
                al.Add(y[i], Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Все данные сохранены");
            Console.WriteLine("Хотите проддолжить работу? \nВведите yes или no");
            n.swihc();


        }

        public void EditNote() //Редактирование ранее созданной записи
        {
            Console.Clear();
            int i = 1;
            foreach (var item in al)
            {
                Console.WriteLine(i + "." + item.Key + " " + item.Value);
                i++;
            }
            Console.WriteLine("Введите номер поля которое хотите редактировать: ");
            int t = int.Parse(Console.ReadLine());
            string a = n.inp[t-1];
            Console.WriteLine("Введите данные:");
            al[a] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Редактирование завершено");
            Console.WriteLine("Хотите проддолжить работу? \nВведите yes или no");
            n.swihc();
            
        }

        public void DeleteNote() //Удаление ранее созданной записи
        {
            Console.Clear();
            Console.WriteLine("Вы действительно хотите очистить записную книжку \nВведите yes или no");
            string v = Console.ReadLine();
            switch (v)
            {
                case "yes":
                    al.Clear();
                    Console.Clear();
                    break;
                case "no":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Команда не распознана");
                    break;
            }
            Console.WriteLine("Хотите проддолжить работу? \nВведите yes или no");
            n.swihc();
        }

        public void ReadNote() //Просмотр созданной записи
        {
            Console.Clear();
            foreach (var item in al)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Хотите проддолжить работу? \nВведите yes или no");
            n.swihc();
        }

        public void ShowAllNotes() //Просмотр всех созданных записей в общем списке
        {
            Console.WriteLine("Фамилия: " + al["Фамилия: "]);
            Console.WriteLine("Имя: " + al["Имя: "]);
            Console.WriteLine("Номер телефона " + al["Номер телефона "]);
            Console.WriteLine("Хотите проддолжить работу? \nВведите yes или no");
            n.swihc();
        }

    }
    class Note
    { 
        public List<string> inp = new List<string>() { "Фамилия: ", "Имя: ", "Отчество: ", "Номер телефона ", "Страна: ", "Дата рождения ", "Организация ", "Должность ", "Прочие заметки " };
            
        public void Output() 
        {
            Console.WriteLine("1.создание новой записи");
            Console.WriteLine("2.Редактирование ранее созданной записи");
            Console.WriteLine("3.Удаление ранее созданной записи");
            Console.WriteLine("4.Просмотр созданной записи");
            Console.WriteLine("5.Просмотр всех созданных записей в общем списке");
            Console.Write("Введите номер команды:");
            int x = int.Parse(Console.ReadLine());
            Notebook b = new Notebook();
            switch (x)
            {
                case 1:
                    b.CreateNewNote();
                    break;
                case 2:
                    b.EditNote();
                    break;
                case 3:
                    b.DeleteNote();
                    break;
                case 4:
                    b.ReadNote();
                    break;
                case 5:
                    b.ShowAllNotes();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Команда не распознана");
                    break;
            }
        }
        public void swihc()
        {
            switch (Console.ReadLine())
            {
                case "yes":
                    Console.Clear();
                    Output();
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Команда не распознана");
                    break;
            }
        }

           

    }
    
}
