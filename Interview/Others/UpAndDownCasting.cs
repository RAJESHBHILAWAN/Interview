using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal class UpAndDownCasting
    {
      public  UpAndDownCasting() {


            //      Shape
            //       ||
            // ---------------
            // ||           ||
            //Circle    Triangle
            //Upcasting
            Shape shape;
            shape = new Circle(33, 55);
            shape.Draw();
            shape = new Triangle(4, 5);
            shape.Draw();
            Circle c = new Circle(2,4);
            Shape ss = (Shape)c;
            ss.Draw();
            c.Draw();
            //Upcasting

            //Downcasting
            Shape s = new Circle(2,4);
            Circle c1 = (Circle)s;
            c1.Draw();
            //Circle circle = new Circle(2,4);
            //Shape circleAsShape = (Shape)circle;

            //Circle circle1 = new Circle(2,3);
            //Shape shape1 = (Shape)circle1; //Casting the object to the base type




        }
    }

    public class Shape
    {
        private int xc, yc;
        public Shape(int xx, int yy) {
            xc = xx; 
            yc = yy;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Shape has x coordinate {xc} and y coordinate : {yc}");
        }
    }

    public class Circle : Shape
    {
        private int xc, yc;

        public Circle(int xx, int yy) : base(xx, yy)
        {
            xc = xx;
            yc = yy;
        }

        public override void Draw() {

            Console.WriteLine($"Circle has x coordinate {xc} and y coordinate : {yc}");

        }
    }

    public class Triangle : Shape
    {
        private int xc, yc;

        public Triangle(int xx, int yy) : base(xx, yy)
        {
            xc = xx;
            yc = yy;
        }

        public override void Draw()
        {

            Console.WriteLine($"Triangle has x coordinate {xc} and y coordinate : {yc}");

        }
    }

}
