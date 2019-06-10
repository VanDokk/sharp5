using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pulpit:IPeople,IWorker
    {
        private string name;
        private string lastName;
        private string middleName;
        private int age;
        private string university;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public int Age { get => age; set => age = value == 0 ? 18 : value; }
        public string University { get => university; set => university = value; }

        public Pulpit()
        {
            Name = "Vasya";
            LastName = "Petrov";
            MiddleName = "Vasilyevich";
            Age = 0;
            University = "ONPU";
        }

        public Pulpit(string name, string name2, string name3, int age, string univer)
        {
            this.Name = name;
            this.LastName = name2;
            this.MiddleName = name3;
            this.Age = age;
            this.University = univer;
        }

        void IPeople.FIO()
        {
            Console.WriteLine(Name + " " + LastName + " " + MiddleName);
        }

        void IPeople.Age()
        {
            Console.WriteLine("Возраст: " + Age);
        }

        void IPeople.University()
        {
            Console.WriteLine("Универ: " + University);
        }

        void IWorker.Position()
        {
            Console.WriteLine("Pulpit");
        }

        void EditName(Pulpit[] st, int index, string Name)
        {
            st[index].Name = Name;
        }

        void Search(Pulpit[] st, string LastName)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i].Name == Name)
                {
                    Console.WriteLine(st[i].Name + " " + st[i].LastName + " " + st[i].MiddleName);
                    Console.WriteLine(" Возраст: " + Age + " Универ: " + University);
                }
                else
                {
                    Console.WriteLine("Такого преподавателя нет");
                }
            }
        }

        void Search(Pulpit[] st, int Age)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i].Age == Age)
                {
                    Console.WriteLine(st[i].Name + " " + st[i].LastName + " " + st[i].MiddleName);
                    Console.WriteLine(" Возраст: " + Age + " Универ: " + University);
                }
                else
                {
                    Console.WriteLine("Такого преподавателя нет");
                }
            }
        }

        void EditLastName(Pulpit[] st, int index, string LastName)
        {
            st[index].LastName = LastName;
        }

        void EditMiddleName(Pulpit[] st, int index, string MiddleName)
        {
            st[index].MiddleName = MiddleName;
        }

        void EditAge(Pulpit[] st, int index, int age)
        {
            st[index].Age = age;
        }

        void EditUniversity(Pulpit[] st, int index, string university)
        {
            st[index].University = university;
        }

    }
}
