using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_test
{
    public class Coordinates
    {
        private double x;
        private double y;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public void Init(double a, double b)
        {
            x = a;
            y = b;
        }
        public void Display()
        {
            string s, s1;
            s1 = Convert.ToString(x);
            s = "x:" + s1 + " ";
            s1 = Convert.ToString(y);
            s = s + "y:" + s1;
            Console.WriteLine(s);
        }
        public void Read()
        {
            string s = "";
            s = Console.ReadLine();
            string[] s1;
            s1 = s.Split(new char[] { ' ', '\t' },
            StringSplitOptions.RemoveEmptyEntries);
            x = Convert.ToInt32(s1[0]);
            y = Convert.ToInt32(s1[1]);
        }
        public double Vectorlen()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public Coordinates Add(Coordinates a, Coordinates b)
        {
            Coordinates c = new Coordinates();
            c.x = a.x + b.x;
            c.y = a.y + b.y;
            return c;
        }
        public override bool Equals(Object obj)
        {
            if (obj is Coordinates)
            {
                var that = obj as Coordinates;
                return this.x == that.x && this.y == that.y;
            }

            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates a = new Coordinates();
            a.X = 10;
            double k;
            k = (int)a.X;
            Console.WriteLine(k);
            Coordinates b = new Coordinates();
            b.Init(0, 10);
            b.Display();
            Coordinates c = new Coordinates();
            c.Read();
            c.Display();
            k = b.Vectorlen();
            Console.WriteLine(k);
            Coordinates d = new Coordinates();
            d = a.Add(b, c);
            d.Display();
        }
    }
}



