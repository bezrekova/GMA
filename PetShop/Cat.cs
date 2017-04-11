using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Cat:Animal
    {
        public Cat(string name,string breed):base(name,breed)
        {

        }

        public override string IntroduceMyself()
        {
            return "Meow-meow";
        }

    }
}
