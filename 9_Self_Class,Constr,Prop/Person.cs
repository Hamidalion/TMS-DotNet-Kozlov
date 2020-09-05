using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Self_Class_Constr_Prop
{
    public class Person
    {
        // пубдичная переменная 
        //private string _name;

        public string Name { get; set; }

        public string SecondName { get; set; }

        public string FullName 
        { 
            get 
            {
                return SecondName + " " + Name;
            } 
        
        }

        public string Short
        {
            get
            {
                return $"{ SecondName} {Name.Substring(0, 1)}.";
            }
        }

        /// <summary>
        /// КОНСТРУКТОР
        /// </summary>
        /// <param name="secondName"></param>
        /// <param name="name"></param>
        public Person (string secondName, string name, int age)
        {
            if (age > 0 )
            {

            }
            else
            {

            }
            
            SecondName = secondName;
            Name = name;
        }

        // СТАРЫЕ СВОЙСТВА
        //public string Name 
        //{
        //    get 
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }
        //}
    }
}
