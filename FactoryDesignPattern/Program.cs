using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape = shapeFactory.GetShape("RECTANGLE");
            shape.Draw();
            IShape shape2 = shapeFactory.GetShape("SQUARE");
            shape2.Draw();
            IShape shape3 = shapeFactory.GetShape("CIRCLE");
            shape3.Draw();
            Console.ReadLine();
        }
    }
}
