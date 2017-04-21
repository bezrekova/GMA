using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Animal:IComparable<Animal>
    {
        public string Name { get; set; }
        private string breed;
        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }

        public Animal(string name,string breed)
        {
            Name = name;
            Breed = breed;
        }

        public Animal()
        {

        }
        public virtual string IntroduceMyself()
        {
            return null;
        }

        public int CompareTo(Animal other)
        {
            //return this.Name.CompareTo(other.Name);
            return String.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
}
