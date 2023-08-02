using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.animals
{
    class LionCub : Lion
    {
        int Months { get; set; }
        public LionCub(int _Months, string _Name) : base(0, _Name)
        {
            FavoriteFood = "milk";
            Months = _Months;
        }


        public override string Eat(string food)
        {
            if (IsHungry)
            {
                IsHungry = false;
                return $"The {GetType().Name} {Name} is drinking the {food}";
            }
            else
                return $"The {GetType().Name} {Name} is not hungry";           
        }




        public override string ToString()
        {
            return $"{GetType().Name}, Name: {Name}, Months: {Months}, IsHungry: {IsHungry}, FavoriteFood: {FavoriteFood}";
        }


    }
}
