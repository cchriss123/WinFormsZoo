using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoo
{
    abstract class Animal
    {
        protected int Age { get; set; }
        public string Name { get; protected set; }

        protected bool IsHungry { get; set; }
        public string FavoriteFood { get; protected set; }

        public Animal(int _Age, string _Name)
        {
            Age = _Age;
            Name = _Name;
            IsHungry = true;
        }


        public virtual string Eat(string food)
        {
            if (IsHungry)
            {
                IsHungry = false;
                return $"The {GetType().Name} {Name} is eating the {food}";
            }
            else
                return $"The {GetType().Name} {Name} is not hungry";           
        }

        public virtual string Interact()
        {
            if (IsHungry)
                return$"The {GetType().Name} {Name} is hungry and sad";
            else
            {
                IsHungry = true;
                return $"The {GetType().Name} {Name} and roars!";
                
            }
        }



        public override string ToString()
        {
            return $"{GetType().Name}, Name: {Name}, Age: {Age}, IsHungry: {IsHungry}, FavoriteFood: {FavoriteFood}";
        }
    }
}
