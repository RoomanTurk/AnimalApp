using Animal_App;
using System.Data.Common;

Animal animal = new Animal();
Animal.Cat cat = new Animal.Cat();
Animal.Cow cow = new Animal.Cow();
Animal.Duck duck = new Animal.Duck();
Animal.Wolf wolf = new Animal.Wolf();
Animal.Parrot parrot = new Animal.Parrot();
Console.WriteLine("Welcome");
Console.WriteLine("*****************************************************************");
Console.WriteLine("App Information: Animal Calss And Object");
Console.WriteLine("*****************************************************************");
animal.Animal_Name();
int Animal = int.Parse(Console.ReadLine());
Console.WriteLine("*****************************************************************");
if (Animal == 1)
{
    cat.Animal_Walk();
    cat.Animal_Sound();
    cat.Animal_Food();
    cat.Animal_Features();
    cat.Animal_Location();
}
else if (Animal == 2)
{
    cow.Animal_Walk();
    cow.Animal_Sound();
    cow.Animal_Food();
    cow.Animal_Features();
    cow .Animal_Location();
}
else if (Animal == 3)
{
    parrot.Animal_Walk();
    parrot.Animal_Sound();
    parrot.Animal_Food();
    parrot.Animal_Features();
    parrot.Animal_Location();
}
else if (Animal == 4)
{
    duck.Animal_Walk();
    duck.Animal_Sound();
    duck.Animal_Food();
    duck.Animal_Features();
    duck.Animal_Location();
}
else if (Animal == 5)
{
    wolf.Animal_Walk();
    wolf.Animal_Sound();
    wolf.Animal_Food();
    wolf.Animal_Features();
    wolf.Animal_Location();
}
else
{
    Console.WriteLine("Error");
    return;
}
Console.WriteLine("*****************************************************************");
Console.ReadKey();

