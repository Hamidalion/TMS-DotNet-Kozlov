using System;

namespace ConsoleApp1
{
    public class Person
    {
        private string _name;


        public string SecondName { get; set; }

        public string Name { get; set; }
        public string FullName 
        { 
            get
            {
                return SecondName + " " +Name;
            }
        }
        public string ShotName 
        {
            get
            {
                return $"{SecondName} {Name.Substring(0,1)}.";
            }
        }

        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException("Имя не может быть пустым");
        //        }
        //        _name = value;
        //    }
        //}

        //public string GetName ()
        //{
        //    return _name;
        //}

        //public void SetName (string name)
        //{
        //    if (string.IsNullOrWhiteSpace (name))
        //    {
        //        throw new ArgumentNullException ("Имя не может быть пустым");
        //    }
        //    _name = name;
        //}

    }
}
