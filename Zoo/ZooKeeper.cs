using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class ZooKeeper
    {
        string Name;

        public ZooKeeper()
        {
            Name = "Glenn";
        }


        public string FeedAnimal(Animal animal)
        {
            return animal.Eat(animal.FavoriteFood);
        }

        public string InteractWithAnimal(Animal animal)
        {
            return animal.Interact();
        }

 

        public string GetGreeting(Visitor visitor, Animal animal)
        {
            return $"Hello {visitor.Name}, my name is {Name} and I am the zookeeper.\r\n" +
                   $"I see you're interested in the {animal.GetType().Name} {animal.Name}.\r\n" +
                   $"Would you like to feed or interact with them?";

        }

        public string AnnounceFeeding(Animal animal)
        {
            return $"Im going to feed this {animal.GetType().Name} some {animal.FavoriteFood}!";
        }
    }




}
