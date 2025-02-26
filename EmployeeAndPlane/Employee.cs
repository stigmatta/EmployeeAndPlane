﻿using System;
using System.Text.RegularExpressions;

namespace EmployeeClass
{
    internal class Employee
    {
        static string emailPattern = @"^\S+@\S+\.\S+$";
        private DateTime birthday;
        private string? phoneNumber;
        private string? email;

        public string Name { get; set; }

        public string? Position { get; set; }


        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                if (value.Year > 2006)
                    birthday = value.Date;
            }
        }

        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value != null && value.Length == 10)
                    phoneNumber = value;
            }
        }


        public string? Email
        {
            get { return email; }
            set
            {
                if (Regex.IsMatch(value ?? string.Empty, emailPattern))
                    email = value;
            }
        }


        public Employee()
        {
            Name = "No name";
            Birthday = DateTime.Now.Date;
            PhoneNumber = string.Empty;
            Email = string.Empty;
            Position = string.Empty;
        }

        public Employee(string name, DateTime birthday,  string? phoneNumber,  string? email,  string? position)
        {
            Name = name;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            Email = email;
            Position = position;
        }

        public void InputData()
        {
            Console.WriteLine("Имя:");
            Name = Console.ReadLine();

            Console.WriteLine("Дата рождения(ХХХХ-УУ-ZZ):");
            Birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Номер телефона:");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("Email:");
            Email = Console.ReadLine();

            Console.WriteLine("Должность:");
            Position = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine("Имя:{0}\nДата рождения:{1}\nНомер телефона:{2}\nЭлектронная почта:{3}\nДолжность:{4}\n", Name, Birthday.ToString("d"), PhoneNumber, Email, Position);
        }

    }
}
