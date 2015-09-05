using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Game_Engine
{
    public class Vector
    {
        public float X{ get; set; }
        public float Y{ get; set; }

        static public Vector operator +(Vector A, Vector B)
        {
            return new Vector(A.X+B.X,A.Y+B.Y);
        }
        static public Vector operator -(Vector A, Vector B)
        {
            return new Vector(A.X - B.X, A.Y - B.Y);
        }
        static public Vector operator *(float X, Vector A)
        {
            return new Vector(X*A.X,X*A.Y);
        }
        static public Vector operator *(Vector A, float X)
        {
            return new Vector(A.X*X,A.Y*X);
        }
        static public Vector operator /(float X, Vector A)
        {
            return new Vector(X / A.X, X / A.Y);
        }
        static public Vector operator /(Vector A, float X)
        {
            return new Vector(A.X / X, A.Y / X);
        }
        static public bool operator ==(Vector A, Vector B)
        {
            return (A.X == B.X && A.Y == B.Y);
        }
        static public bool operator !=(Vector A, Vector B)
        {
            return (A.X != B.X || A.Y != B.Y);
        }

        static public Vector Up
        {
            get
            {
                return new Vector(0,1);
            }
        }
        static public Vector Down
        {
            get
            {
                return new Vector(0, -1);
            }
        }
        static public Vector Right
        {
            get
            {
                return new Vector(1, 0);
            }
        }
        static public Vector Left
        {
            get
            {
                return new Vector(-1, 0);
            }
        }

        public override bool Equals(object other)
        {
            return this == (Vector)other;
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(X*X + Y*Y);
        }
        public Vector GetNormal()
        {
            return new Vector(-Y,X);
        }
        public Vector Normalize()
        {
            float length = Magnitude();
            return new Vector(X/length,Y/length);
        }
        public override string ToString()
        {
            return X+" , "+Y;
        }

        public Vector()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Vector(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Vector(double X, double Y)
        {
            this.X = (float)X;
            this.Y = (float)Y;
        }
        public Vector(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Vector(long X, long Y)
        {
            this.X = X;
            this.Y = Y;
        }


    }
}
