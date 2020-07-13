using System;

namespace ToDo
{
    public class ToDo
    {
        //поле
        private DateTime _creation;

        public ToDo() { }

        public ToDo(DateTime creation)
        {
            _creation = creation;
        }

        //свойство
        public string Name { get; set; }
        public int MyProperty { get; set; }

        public void Show() 
        {
            Console.WriteLine($"{Name}, {_creation}");
        }
    }
}
