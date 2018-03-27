using System;

namespace AFDempExercise2
{
    abstract class Shape
    {
        protected static Random aRandomColor;
        protected Color ShapeColor { get; set; }

        static Shape()
        {
            aRandomColor = new Random();
        }

        public abstract string GetInfo();

        public override string ToString()
        {
            return GetInfo();
        }
    }
}