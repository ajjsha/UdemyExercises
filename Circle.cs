using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyExercises
{
    //sealed is the opposite to abstract, it means nothing can dervie from that class/class member
    //sealed has sense to be applied only on methods that are overriding virtual methods from base class
    //kind of antipattern since can impact design by messing up inheritance hierarchy
    sealed class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
            base.Draw();
        }

    }
}
