﻿namespace DefiningClasses
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
}