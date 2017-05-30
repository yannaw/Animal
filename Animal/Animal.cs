using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv {
    /// <summary>
    /// 3.2 Arv
    /// 
    /// 12 Vilken typ måste listan lagra?
    /// 13 Vilken typ måste listan vara: Animal
    /// 14 Nytt attribut läggs till i närmsta basklass, vilket blir Bird för subklasserna Pelican, Flamingo, Swan 
    /// 15 Globalt attribult läggs till i basklassen dvs i Animal
    /// 
    /// </summary>
    class Animal {
        private string family;
        private char sex;

        public string AnimalFamily { get { return family; } set { } }
        public char AnimalSex { get { return sex; } set { } }

        public Animal() {
        }
        public Animal(string Family, char Sex) {
            family = Family;
            sex = Sex;
        }
        public Animal(string Family) : this(Family, 'u') {
        }
        public override string ToString() {
            return (family + " " + AnimalSex);
        }
    }
    class Horse : Animal {
        private int height;
        public int Height { get { return height; } set { } }
        public Horse() : base("Mammal") { }
        public Horse(char Sex) : base("Mammal", Sex) { }
    }
    class Dog : Animal {
        private string color;
        public Dog() : base("Reptile") { }
    }
    class Hedgehog : Animal {
        private int quill;
        public Hedgehog() : base("Fish") { }
    }
    class Worm : Animal {
        private string habitat;
        public Worm() : base("Insect") { }

    }
    class Bird : Animal {
        private double weight;
        public Bird(int Weight) : base("Egglaying") {
            weight = Weight;
        }
    }
    class Pelican : Bird {
        private string name;
        public Pelican() : base(1) {

        }
  /*      Append?
  public override string ToString() {
            return (name + " "  );
        }
        */
    }
    class Flamingo : Bird {
        private int partners;
        public Flamingo() : base(2) {

        }
    }
    class Swan : Bird {
        private int kids; public Swan() : base(3) {

        }
    }
}
