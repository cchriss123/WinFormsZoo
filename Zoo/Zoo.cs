using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Zoo.animals;

namespace Zoo
{
    class Zoo
    {
        public string OpeningHours { get; set; }
        public double EntranceFee { get; set; }
        private List<Animal> animals = new List<Animal>();
        private List<Visitor> visitors = new List<Visitor>();
        public ZooKeeper zooKeeper = new ZooKeeper();
        private HashSet<String> animalTypes = new HashSet<string>() { "Lion", "LionCub", "Wolf"};

        public Zoo(string _openingHours, double _entranceFee)
        {
            OpeningHours = _openingHours;
            EntranceFee = _entranceFee;
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void AddVisitor(Visitor visitor)
        {
            visitors.Add(visitor);
        }

        public List<Visitor> GetVisitors()
        {
            return visitors;
        }

        public HashSet<String> GetAnimalTypes()
        {
            return animalTypes;
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }


        public void AddDefaultVisitors()
        {
            visitors.Add(new Visitor("Anders Åke"));
            visitors.Add(new Visitor("Dalle"));
            visitors.Add(new Visitor("Stefan"));
            visitors.Add(new Visitor("Ulrika"));
            visitors.Add(new Visitor("CyberSlayer99"));
            visitors.Add(new Visitor("Anna"));
            visitors.Add(new Visitor("Karin"));
        }

        public void AddDefaultAnimals()
        {
            animals.Add(new Lion(10, "Mufasa"));
            animals.Add(new Lion(8, "Scar"));
            animals.Add(new LionCub(2, "Simba"));
            animals.Add(new Lion(9, "Kiara"));
            animals.Add(new Wolf(4, "Eva"));
            animals.Add(new Wolf(2, "Glenn"));
        }
    }
}
