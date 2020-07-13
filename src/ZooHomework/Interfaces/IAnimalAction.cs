using System;
using ZooHomework.Enums;
using ZooHomework.Models;

namespace ZooHomework.Interfaces
{
    interface IAnimalAction 
    {

        void Rename(Animal animal, string name);
        void GetInfo(Animal animal);
        void SetPassport(Animal animal, string passport);
    }
}
