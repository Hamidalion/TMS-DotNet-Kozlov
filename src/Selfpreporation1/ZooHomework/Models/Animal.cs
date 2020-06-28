using System;
using ZooHomework.Enums;

namespace ZooHomework.Models
{

    class Animal
    {

        public string Name { get; set; }
        public void Rename(string name)
        {
            Name = name;
        }

        public Animal()
        {
            Name = "Noname";
            Kind = KindType.None;
            _passport = Guid.NewGuid().ToString();
        }
        public Animal(string name)
        {
            Name = name;
            Kind = KindType.None;
            _passport = Guid.NewGuid().ToString();
        }
        public Animal(string name, KindType kind)
        {
            Name = name;
            Kind = kind;
        }
        public Animal(string name, KindType kind, string passport)
        {
            Name = name;
            Kind = kind;
            _passport = passport;
        }

        private readonly Guid _id = Guid.NewGuid();
        public Guid GetId()
        {
            return _id;
        }

        private string _passport;
        public string GetPassport()
        {
            return _passport;
        }

        public void SetPassport(string passport)
        {
            _passport = passport;
        }
        
        public KindType Kind { get; set; }
        
    }
}
