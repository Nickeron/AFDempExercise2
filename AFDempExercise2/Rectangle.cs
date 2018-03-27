using System;

namespace AFDempExercise2
{
    class Rectangle : Shape, IComparable, IEquatable<Rectangle>
    {
        private static string Name { get; }
        private int Width { get; }
        private int Height { get; }
        protected int Area { get; set; }

        static Rectangle()
        {
            Name = "Rectangle";
        }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
            ShapeColor = (Color)aRandomColor.Next(Enum.GetNames(typeof(Color)).Length);
            GetArea();
        }

        public Rectangle(int width, int height, Color rColor)
        {
            Width = width;
            Height = height;
            ShapeColor = rColor;
            GetArea();
        }

        public override string GetInfo()
        {
            return $"{Name} of color {ShapeColor}, width {Width} and height {Height}.";
        }

        public virtual void GetArea()
        {
            Area = Width * Height;
        }

        public int CompareTo(object otherObject)
        {
            Rectangle otherRectangle = otherObject as Rectangle;

            if (Area > otherRectangle.Area)
            {
                return 1;
            }
            else if (Area == otherRectangle.Area)
            {
                return 0;
            }
            return -1;
        }

        public bool Equals(Rectangle otherRectangle)
        {
            return (Area == otherRectangle.Area);
        }

        public override int GetHashCode()
        {
            return Area.GetHashCode();
        }
    }
}
