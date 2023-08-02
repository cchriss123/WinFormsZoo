using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.animals
{
    class Lion : Animal
    {
        public Lion(int _Age, string _Name) : base(_Age, _Name)
        {
            FavoriteFood = "meat";
        }
    }
}
