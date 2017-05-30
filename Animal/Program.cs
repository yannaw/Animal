using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv {
    class Program {
        static void Main(string[] args) {
            var animalList = new List<Animal>();
            animalList.Add(new Horse('F'));
            animalList.Add(new Worm());

            Console.WriteLine("Djur:");

            int c = 0;
            foreach(var e in animalList) {
                Console.WriteLine("{1}", c, e);
                c++;
            }

            var doglList = new List<Dog>();
            doglList.Add(new Dog());
            //            doglList.Add(new Horse()); //Kan ej kasta häst till dog

            var birdList = new List<Bird>();
            birdList.Add(new Pelican());
            birdList.Add(new Flamingo());
            birdList.Add(new Swan());

            c = 0;
            foreach(var e in birdList) {
                Console.WriteLine("{1}", c, e);
                c++;
            }
        }
    }
}
