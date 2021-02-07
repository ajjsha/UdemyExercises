using System;
using System.Collections.Generic;

namespace UdemyExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            var circle = new Circle();
            var triangle = new Triangle();
            shapes.Add(circle);
            shapes.Add(triangle);

            var canvas = new Canvas();
            canvas.DrawShape(shapes);

            var activity = new Cooking();
            activity.Perform();

            //incorrect, since abstract classes cannot be instantiated
            //var abstractActivity = new Activity();
        }
    }
}
