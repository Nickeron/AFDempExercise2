using System;

namespace AFDempExercise2
{
    sealed class Square : Rectangle, IEquatable<Square>
    {
        private static string Name { get; }
        private int Side { get; }

        static Square()
        {
            Name = "Square";
        }

        public Square(int side)
        {
            Side = side;
            ShapeColor = (Color)aRandomColor.Next(Enum.GetNames(typeof(Color)).Length);
            GetArea();
        }

        public Square(int side, Color sColor)
        {
            Side = side;
            ShapeColor = sColor;
            GetArea();
        }

        public override void GetArea()
        {
            Area = (int)Math.Pow(Side, 2);
        }

        public override string GetInfo()
        {
            return $"{Name} of color {ShapeColor} and side length {Side}.";
        }

        public new int CompareTo(object obj)
        {
            Square otherSquare = obj as Square;
            if (Side > otherSquare.Side)
            {
                return 1;
            }
            else if (Side == otherSquare.Side)
            {
                return 0;
            }
            return -1;
        }

        public bool Equals(Square other)
        {
            return (Side == other.Side);
        }

        public override int GetHashCode()
        {
            return Side.GetHashCode();
        }
    }
}
