using System;
using System.Collections.Generic;

namespace PetShop
{
    class PetShop 
    {
        private List<Animal> animalList;

        public PetShop()
        {
            animalList = new List<Animal>();
        }
        public object Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddPet(Animal animal)
        {
            animalList.Add(animal);
        }

        

        //animalList.Sort(delegate(Animal a, Animal b)){
        //     return a.GetType().Name.CompareTo(b.GetType().Name);
        // });


        //method to print every animal's properties of the list
        public void IntroduceAll()
        {
            //TODO: implement animals sort depends on Dog or Cat+names
            animalList.Sort();
            foreach (var pet in animalList)
            {
                string classType = pet.GetType().Name;
                Console.WriteLine(classType + " " + pet.Name + " of  breed: " + pet.Breed + " says: " + pet.IntroduceMyself());
            }

        }




    }
}
