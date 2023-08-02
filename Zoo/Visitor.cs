using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Visitor
    {
        public string Name { get; set; }

        public Visitor(string _Name)
        {
            Name = _Name;
        }

        public string feedAnimal(ZooKeeper zooKeeper, Animal animal)
        {
            return zooKeeper.FeedAnimal(animal);
        }


    }
}
