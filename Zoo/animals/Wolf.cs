using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zoo.animals
{
    class Wolf : Animal
    {
        public Wolf(int _Age, string _Name) : base(_Age, _Name)
        {
            FavoriteFood = "meat";
        }

        public override string Interact()
        {
            if (IsHungry)
                return $"The wolf {Name} is hungry and sad";
            else
            {
                IsHungry = true;
                return $"The wolf " + Name + " howls!";               
            }
        }
    }
}
