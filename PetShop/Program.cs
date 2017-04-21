using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            PetShop shop = new PetShop();
            shop.AddPet(new Cat("Alice", "main coon"));
            shop.AddPet(new Dog("Terminator", "bulldog"));
           // shop.IntroduceAll();
            shop.AddPet(new Cat("Belka", "american curl"));
            shop.AddPet(new Dog("Samuel", "foxhound"));
            shop.AddPet(new Dog("Alfred", "spaniel"));
            shop.AddPet(new Cat("Rex", "cornix rex"));
            shop.IntroduceAll();
            //Console.WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Name);
            // Console.WriteLine(shop.GetType().Name);
            

            Console.ReadKey();


        }
    }
}
