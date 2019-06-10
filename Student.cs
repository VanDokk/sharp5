using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student:IPeople
    {
        private string name;
        private string lastName;
        private string middleName;
        private decimal course;
        private int age;
        private string university;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public decimal Course { get => course; set => course = value; }
        public int Age { get => age; set => age = value == 0 ? 18 : value; }
        public string University { get => university; set => university = value; }

        public Student()
        {
            Name = "Vasya";
            LastName = "Petrov";
            MiddleName = "Vasilyevich";
            course = 0;
            Age = 0;
            University = "ONPU";
        }

        public Student(string Name, string LastName, string MiddleName, decimal course, int age, string university)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.Course = course;
            this.Age = age;
            this.University = university;
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
        
        void Search(Student[] st, string LastName)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i].Name == Name)
                {
                    Console.WriteLine(st[i].Name + " " + st[i].LastName + " " + st[i].MiddleName);
                    Console.WriteLine("Курс: " + Course + " Возраст: " + Age + " Универ: " + University);
                }
                else
                {
                    Console.WriteLine("Такого студента нет");
                }
            }
        }

        void Search(Student[] st, decimal course)
        {
            for (int i = 0; i < st.Length; i++)
            { 
                if (st[i].Course == course )
                {
                    Console.WriteLine(st[i].Name + " " + st[i].LastName + " " + st[i].MiddleName);
                    Console.WriteLine("Курс: " + Course + " Возраст: " + Age + " Универ: " + University);
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
        }

        void Search(Student[] st, int Age)
        {
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i].Age == Age)
                {
                    Console.WriteLine(st[i].Name + " " + st[i].LastName + " " + st[i].MiddleName);
                    Console.WriteLine("Курс: " + Course + " Возраст: " + Age + " Универ: " + University);
                }
                else
                {
                    Console.WriteLine("Такого студента нет");
                }
            }
        }

        void EditName(Student[] st, int index, string Name)
        {
            st[index].Name = Name;
        }

        void EditLastName(Student[] st, int index, string LastName)
        {
            st[index].LastName = LastName;
        }

        void EditMiddleName(Student[] st, int index, string MiddleName)
        {
            st[index].MiddleName = MiddleName;
        }

        void EditAge(Student[] st, int index, int age)
        {
            st[index].Age = age;
        }

        void EditCourse(Student[] st, int index, decimal course)
        {
            st[index].Course = course;
        }

        void EditUniversity(Student[] st, int index, string university)
        {
            st[index].University = university;
        }
    }
}
