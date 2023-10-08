using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_App
{
    internal class Animal
    {
        public void Animal_Name()
        {
            Console.WriteLine("Animal List:");
            Console.WriteLine("1- Cat");
            Console.WriteLine("2- Cow");
            Console.WriteLine("3- Parrot");
            Console.WriteLine("4- Duck");
            Console.WriteLine("5- Wolf");
            Console.WriteLine("Please Select Animals Number:");
        }
        interface IAnimal
        {
            void Animal_Sound();
            void Animal_Walk();
            void Animal_Food();
            void Animal_Features();
            void Animal_Location();
        }

        public class Cat : IAnimal
        {
            public void Animal_Walk()
            {
                Console.WriteLine("Walk: on hands and feet");
            }
            public void Animal_Sound()
            {
                Console.WriteLine("Sound: Miuuuu Miuuuu");
            } 
            public void Animal_Food()
            {
                Console.WriteLine("Food: Meat - Milk");
            }
            public void Animal_Features()
            {
                Console.WriteLine("Features: Mouse Hunter - Pet - Mammal");
            }
            public void Animal_Location()
            {
                Console.WriteLine("Location: Home - Street");
            }
        }
        public class Cow : IAnimal
        {
            public void Animal_Walk()
            {
                Console.WriteLine("Walk: on hands and feet");
            }
            public void Animal_Sound()
            {
                Console.WriteLine("Sound: Mooo Moooo");
            }
            public void Animal_Food()
            {
                Console.WriteLine("Food: Plant");
            }
            public void Animal_Features()
            {
                Console.WriteLine("Features: giving milk - Pet - Mammal");
            }
            public void Animal_Location()
            {
                Console.WriteLine("Location: Farm");
            }
        }
        public class Parrot : IAnimal
        {
            public void Animal_Walk()
            {
                Console.WriteLine("Walk: on feet");
            }
            public void Animal_Sound()
            {
                Console.WriteLine("Sound: Imitation of human voice");
            }
            public void Animal_Food()
            {
                Console.WriteLine("Food: seed");
            }
            public void Animal_Features()
            {
                Console.WriteLine("Features: Imitation of human voice - Pet - laying eggs - Flight");
            }
            public void Animal_Location()
            {
                Console.WriteLine("Location: Home And Jungle");
            }
        }
        public class Duck : IAnimal
        {
            public void Animal_Walk()
            {
                Console.WriteLine("Walk: on feet");
            }
            public void Animal_Sound()
            {
                Console.WriteLine("Sound: ghoooak");
            }
            public void Animal_Food()
            {
                Console.WriteLine("Food: seed - Plant");
            }
            public void Animal_Features()
            {
                Console.WriteLine("Features: the swimmer - Pet - laying eggs");
            }
            public void Animal_Location()
            {
                Console.WriteLine("Location: Farme - Lake ");
            }
        }
        public class Wolf : IAnimal
        {
            public void Animal_Walk()
            {
                Console.WriteLine("Walk: on hands and feet");
            }
            public void Animal_Sound()
            {
                Console.WriteLine("Sound: aaaaoooooo aaaoooooooo");
            }
            public void Animal_Food()
            {
                Console.WriteLine("Food: Meat");
            }
            public void Animal_Features()
            {
                Console.WriteLine("Features: Hunter - wild animal - Mammal");
            }
            public void Animal_Location()
            {
                Console.WriteLine("Location: Forest - Mountain - Jungle");
            }
        }
    }
}
