namespace COMP003A.LectureActivity5_3
{
    /// <summary>
    /// Represents a generic shape with an abstract method
    /// </summary>
    abstract class Shape
    {
        // Auto-implemented property
        public string Name { get; set; }

        /// <summary>
        /// Abstract method to calculate area.
        /// </summary>
        public abstract double CalculateArea();

        /// <summary>
        /// Displays the shape's name
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }

        /// <summary>
        /// Repersents a circle derived from Shape
        /// </summary>
        class Circle : Shape
        {
            public double Radius { get; set; }

            /// <summary>
            /// Constructor for Circle
            /// </summary>
            /// <param name="radius"></param>
            public Circle(double radius)
            {
                Name = "Circle";
                Radius = radius;
            }

            /// <summary>
            /// Calculates the area of the circle
            /// </summary>
            public override double CalculateArea()
            {
                //returns the area of the circle
                return Math.PI * Radius * Radius;
            }

            /// <summary>
            /// Implements Draw() mehtod for a circle.
            /// </summary>
            public void Draw() 
            {
            Console.WriteLine("Drawing a circle.");
            }
        }
    /// <summary>
    /// Repersents a rectangle derived from Shape
    /// </summary>
    class Rectangle : Shape
    {
        // Auto-implemented properties
        public double Width { get; set; }
        public double Height { get; set; }

        /// <summary>
        /// Constructor for Rectangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(double width, double height)
        {
            Name = "Rectangle";
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        public override double CalculateArea()
        {
            //returns the area of the circle
            return Width * Height;
        }
        /// <summary>
        /// Implements Draw() mehtod for a rectangle.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
            }
    }

    /// <summary>
    ///  Defines a contract for drawable objects.
    /// </summary>
    interface IDrawable 
    {
        /// <summary>
        /// Draws the object.
        /// </summary>
        void Draw();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(5);
            Shape myRectangle = new Rectangle(4, 6);

            myCircle.DisplayInfo();
            Console.WriteLine($"Area: {myCircle.CalculateArea()}");
            ((IDrawable)myCircle).Draw();

            myRectangle.DisplayInfo();
            Console.WriteLine($"Area: {myRectangle.CalculateArea()}");
            ((IDrawable)myRectangle).Draw();

        }
    }
}
