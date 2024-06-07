namespace DemoSquare
{

    /*Create a class named Square that contains data fields for height, width, and
        surfaceArea, and a method named computeSurfaceArea(). cWrite an application
        that instantiates a Square object and a Cube object and displays the surface areas of the
        objects. Save the files as Cube.java, Square.java, and DemoSquare.java*/

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Square sq = new Square(5, 5);
            sq.computeSurfaceArea();
            //Console.WriteLine(sq.GetSurfaceArea());*/

            Cube cb = new Cube(5, 5, 5);
            cb.computeSurfaceArea();
            Console.WriteLine(cb.GetSurfaceArea());
        }
    }
    class Square
    {
        protected double height;
        protected double width;
        protected double surfaceArea;
        public Square(double height, double width)
        {
            this.height = height;
            this.width = width;
            
        }
        public double GetHeight()
        {
            return height;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetSurfaceArea()
        {
            return surfaceArea;
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public virtual void computeSurfaceArea()
        {
            surfaceArea = height * width;
            
        }
    }

    /*Create a child class
        named Cube. Cube contains an additional data field named depth, and a
        computeSurfaceArea() method that overrides the parent method.*/
    class Cube : Square
    {
        private double depth;

        public Cube(double depth, double height, double width) : base(height, width)
        {
            this.depth = depth;
        }
        public double GetDepth()
        {
            return depth;
        }
        public void setDepth(double Depth)
        {
            depth = Depth;
        }
        public override void computeSurfaceArea()
        {
            base.computeSurfaceArea();
            //surfaceArea = 2 * (height * width * depth) + 2 * (height * width * depth);
            //base.computeSurfaceArea();
            surfaceArea = surfaceArea * depth;


        }
    }
}