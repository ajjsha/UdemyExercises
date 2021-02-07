using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyExercises
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position position {get; set;}
        public Type type { get; set; }

        //virtual method can be overridden in deriving classes
        public virtual void Draw() 
        {
            Console.WriteLine("Drawing shape");
        }

    }





}
