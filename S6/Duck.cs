using System;
using System.Collections.Generic;
using System.Text;

namespace S6
{
    public class Duck
    {
        public virtual void Quack() 
        { 

        }
    }

    public class Duckling : Duck
    {
        public override void Quack()
        {
            base.Quack();


        }
    }
}
