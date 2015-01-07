using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRageMath
{
    [Serializable]
    public struct Vector3I : IEquatable<Vector3I>, IComparable<Vector3I>
    {
        public static readonly Vector3I.EqualityComparer Comparer = new Vector3I.EqualityComparer();
        public static Vector3I UnitX = new Vector3I(1, 0, 0);
        public static Vector3I UnitY = new Vector3I(0, 1, 0);
        public static Vector3I UnitZ = new Vector3I(0, 0, 1);
        public static Vector3I Zero = new Vector3I(0, 0, 0);
        public static Vector3I MaxValue = new Vector3I(int.MaxValue, int.MaxValue, int.MaxValue);
        public static Vector3I MinValue = new Vector3I(int.MinValue, int.MinValue, int.MinValue);
        public static Vector3I Up = new Vector3I(0, 1, 0);
        public static Vector3I Down = new Vector3I(0, -1, 0);
        public static Vector3I Right = new Vector3I(1, 0, 0);
        public static Vector3I Left = new Vector3I(-1, 0, 0);
        public static Vector3I Forward = new Vector3I(0, 0, -1);
        public static Vector3I Backward = new Vector3I(0, 0, 1);
        public static Vector3I One = new Vector3I(1, 1, 1);
        public int X;
        public int Y;
        public int Z;

        public Vector3I(int xyz)
        {
            this.X = xyz;
            this.Y = xyz;
            this.Z = xyz;
        }

        public Vector3I(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Vector3I operator *(Vector3I a, Vector3I b)
        {
            return new Vector3I(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }

        public static bool operator ==(Vector3I a, Vector3I b)
        {
            if (a.X == b.X && a.Y == b.Y)
                return a.Z == b.Z;
            return false;
        }

        public static bool operator !=(Vector3I a, Vector3I b)
        {
            return !(a == b);
        }

        public static Vector3I operator /(Vector3I a, int num)
        {
            return new Vector3I(a.X / num, a.Y / num, a.Z / num);
        }

        public static Vector3I operator /(Vector3I a, Vector3I b)
        {
            return new Vector3I(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }

        public static Vector3I operator %(Vector3I a, int num)
        {
            return new Vector3I(a.X % num, a.Y % num, a.Z % num);
        }

        public static Vector3I operator >>(Vector3I v, int shift)
        {
            return new Vector3I(v.X >> shift, v.Y >> shift, v.Z >> shift);
        }

        public static Vector3I operator <<(Vector3I v, int shift)
        {
            return new Vector3I(v.X << shift, v.Y << shift, v.Z << shift);
        }

        public static Vector3I operator *(int num, Vector3I b)
        {
            return new Vector3I(num * b.X, num * b.Y, num * b.Z);
        }

        public static Vector3I operator *(Vector3I a, int num)
        {
            return new Vector3I(num * a.X, num * a.Y, num * a.Z);
        }

        public static Vector3I operator +(Vector3I a, Vector3I b)
        {
            return new Vector3I(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3I operator +(Vector3I a, int b)
        {
            return new Vector3I(a.X + b, a.Y + b, a.Z + b);
        }

        public static Vector3I operator -(Vector3I a, Vector3I b)
        {
            return new Vector3I(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Vector3I operator -(Vector3I a, int b)
        {
            return new Vector3I(a.X - b, a.Y - b, a.Z - b);
        }

        public static Vector3I operator -(Vector3I a)
        {
            return new Vector3I(-a.X, -a.Y, -a.Z);
        }

        public override string ToString()
        {
            return string.Format("[X:{0}, Y:{1}, Z:{2}]", (object)this.X, (object)this.Y, (object)this.Z);
        }

        public bool Equals(Vector3I other)
        {
            if (other.X == this.X && other.Y == this.Y)
                return other.Z == this.Z;
            return false;
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals((object)null, obj) || obj.GetType() != typeof(Vector3I))
                return false;
            return this.Equals((Vector3I)obj);
        }

        public override int GetHashCode()
        {
            return (this.X * 397 ^ this.Y) * 397 ^ this.Z;
        }

        public bool IsInsideInclusive(ref Vector3I min, ref Vector3I max)
        {
            if (min.X <= this.X && this.X <= max.X && (min.Y <= this.Y && this.Y <= max.Y) && min.Z <= this.Z)
                return this.Z <= max.Z;
            return false;
        }

        public bool IsInsideInclusive(Vector3I min, Vector3I max)
        {
            return this.IsInsideInclusive(ref min, ref max);
        }

        public int RectangularDistance(Vector3I otherVector)
        {
            return Math.Abs(this.X - otherVector.X) + Math.Abs(this.Y - otherVector.Y) + Math.Abs(this.Z - otherVector.Z);
        }

        public int RectangularLength()
        {
            return Math.Abs(this.X) + Math.Abs(this.Y) + Math.Abs(this.Z);
        }

        public static bool BoxIntersects(Vector3I minA, Vector3I maxA, Vector3I minB, Vector3I maxB)
        {
            return Vector3I.BoxIntersects(ref minA, ref maxA, ref minB, ref maxB);
        }

        public static bool BoxIntersects(ref Vector3I minA, ref Vector3I maxA, ref Vector3I minB, ref Vector3I maxB)
        {
            if (maxA.X >= minB.X && minA.X <= maxB.X && (maxA.Y >= minB.Y && minA.Y <= maxB.Y) && maxA.Z >= minB.Z)
                return minA.Z <= maxB.Z;
            return false;
        }

        public static bool BoxContains(Vector3I boxMin, Vector3I boxMax, Vector3I pt)
        {
            if (boxMax.X >= pt.X && boxMin.X <= pt.X && (boxMax.Y >= pt.Y && boxMin.Y <= pt.Y) && boxMax.Z >= pt.Z)
                return boxMin.Z <= pt.Z;
            return false;
        }

        public static bool BoxContains(ref Vector3I boxMin, ref Vector3I boxMax, ref Vector3I pt)
        {
            if (boxMax.X >= pt.X && boxMin.X <= pt.X && (boxMax.Y >= pt.Y && boxMin.Y <= pt.Y) && boxMax.Z >= pt.Z)
                return boxMin.Z <= pt.Z;
            return false;
        }

        public static Vector3I Min(Vector3I value1, Vector3I value2)
        {
            Vector3I vector3I;
            vector3I.X = value1.X < value2.X ? value1.X : value2.X;
            vector3I.Y = value1.Y < value2.Y ? value1.Y : value2.Y;
            vector3I.Z = value1.Z < value2.Z ? value1.Z : value2.Z;
            return vector3I;
        }

        public static void Min(ref Vector3I value1, ref Vector3I value2, out Vector3I result)
        {
            result.X = value1.X < value2.X ? value1.X : value2.X;
            result.Y = value1.Y < value2.Y ? value1.Y : value2.Y;
            result.Z = value1.Z < value2.Z ? value1.Z : value2.Z;
        }

        public int AbsMin()
        {
            if (Math.Abs(this.X) < Math.Abs(this.Y))
            {
                if (Math.Abs(this.X) < Math.Abs(this.Z))
                    return Math.Abs(this.X);
                return Math.Abs(this.Z);
            }
            if (Math.Abs(this.Y) < Math.Abs(this.Z))
                return Math.Abs(this.Y);
            return Math.Abs(this.Z);
        }

        public static Vector3I Max(Vector3I value1, Vector3I value2)
        {
            Vector3I vector3I;
            vector3I.X = value1.X > value2.X ? value1.X : value2.X;
            vector3I.Y = value1.Y > value2.Y ? value1.Y : value2.Y;
            vector3I.Z = value1.Z > value2.Z ? value1.Z : value2.Z;
            return vector3I;
        }

        public static void Max(ref Vector3I value1, ref Vector3I value2, out Vector3I result)
        {
            result.X = value1.X > value2.X ? value1.X : value2.X;
            result.Y = value1.Y > value2.Y ? value1.Y : value2.Y;
            result.Z = value1.Z > value2.Z ? value1.Z : value2.Z;
        }

        public int AbsMax()
        {
            if (Math.Abs(this.X) > Math.Abs(this.Y))
            {
                if (Math.Abs(this.X) > Math.Abs(this.Z))
                    return Math.Abs(this.X);
                return Math.Abs(this.Z);
            }
            if (Math.Abs(this.Y) > Math.Abs(this.Z))
                return Math.Abs(this.Y);
            return Math.Abs(this.Z);
        }

        public static Vector3I DominantAxisProjection(Vector3I value1)
        {
            if (Math.Abs(value1.X) > Math.Abs(value1.Y))
            {
                value1.Y = 0;
                if (Math.Abs(value1.X) > Math.Abs(value1.Z))
                    value1.Z = 0;
                else
                    value1.X = 0;
            }
            else
            {
                value1.X = 0;
                if (Math.Abs(value1.Y) > Math.Abs(value1.Z))
                    value1.Z = 0;
                else
                    value1.Y = 0;
            }
            return value1;
        }

        public static void DominantAxisProjection(ref Vector3I value1, out Vector3I result)
        {
            if (Math.Abs(value1.X) > Math.Abs(value1.Y))
            {
                if (Math.Abs(value1.X) > Math.Abs(value1.Z))
                    result = new Vector3I(value1.X, 0, 0);
                else
                    result = new Vector3I(0, 0, value1.Z);
            }
            else if (Math.Abs(value1.Y) > Math.Abs(value1.Z))
                result = new Vector3I(0, value1.Y, 0);
            else
                result = new Vector3I(0, 0, value1.Z);
        }

        public static void Cross(ref Vector3I vector1, ref Vector3I vector2, out Vector3I result)
        {
            int num1 = vector1.Y * vector2.Z - vector1.Z * vector2.Y;
            int num2 = vector1.Z * vector2.X - vector1.X * vector2.Z;
            int num3 = vector1.X * vector2.Y - vector1.Y * vector2.X;
            result.X = num1;
            result.Y = num2;
            result.Z = num3;
        }

        public int Size()
        {
            return Math.Abs(this.X * this.Y * this.Z);
        }

        public int CompareTo(Vector3I other)
        {
            int num1 = this.X - other.X;
            int num2 = this.Y - other.Y;
            int num3 = this.Z - other.Z;
            if (num1 != 0)
                return num1;
            if (num2 == 0)
                return num3;
            return num2;
        }

        public static Vector3I Abs(Vector3I value)
        {
            return new Vector3I(Math.Abs(value.X), Math.Abs(value.Y), Math.Abs(value.Z));
        }

        public static void Abs(ref Vector3I value, out Vector3I result)
        {
            result.X = Math.Abs(value.X);
            result.Y = Math.Abs(value.Y);
            result.Z = Math.Abs(value.Z);
        }

        public static Vector3I Clamp(Vector3I value1, Vector3I min, Vector3I max)
        {
            Vector3I result;
            Vector3I.Clamp(ref value1, ref min, ref max, out result);
            return result;
        }

        public static void Clamp(ref Vector3I value1, ref Vector3I min, ref Vector3I max, out Vector3I result)
        {
            int num1 = value1.X;
            int num2 = num1 > max.X ? max.X : num1;
            result.X = num2 < min.X ? min.X : num2;
            int num3 = value1.Y;
            int num4 = num3 > max.Y ? max.Y : num3;
            result.Y = num4 < min.Y ? min.Y : num4;
            int num5 = value1.Z;
            int num6 = num5 > max.Z ? max.Z : num5;
            result.Z = num6 < min.Z ? min.Z : num6;
        }

        public static int DistanceManhattan(Vector3I first, Vector3I second)
        {
            Vector3I vector3I = Vector3I.Abs(first - second);
            return vector3I.X + vector3I.Y + vector3I.Z;
        }

        public int Dot(ref Vector3I v)
        {
            return this.X * v.X + this.Y * v.Y + this.Z * v.Z;
        }

        public static int Dot(ref Vector3I vector1, ref Vector3I vector2)
        {
            return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z;
        }

        public struct RangeIterator
        {
            private Vector3I m_start;
            private Vector3I m_end;
            private Vector3I m_current;

            public Vector3I Current
            {
                get
                {
                    return this.m_current;
                }
            }

            public RangeIterator(ref Vector3I start, ref Vector3I end)
            {
                this.m_start = start;
                this.m_end = end;
                this.m_current = this.m_start;
            }

            public bool IsValid()
            {
                if (this.m_current.Z <= this.m_end.Z && this.m_current.X <= this.m_end.X)
                    return this.m_current.Y <= this.m_end.Y;
                return false;
            }

            public void GetNext(out Vector3I next)
            {
                this.MoveNext();
                next = this.m_current;
            }

            public void MoveNext()
            {
                ++this.m_current.X;
                if (this.m_current.X <= this.m_end.X)
                    return;
                this.m_current.X = this.m_start.X;
                ++this.m_current.Y;
                if (this.m_current.Y <= this.m_end.Y)
                    return;
                this.m_current.Y = this.m_start.Y;
                ++this.m_current.Z;
            }
        }

        public class EqualityComparer : IEqualityComparer<Vector3I>, IComparer<Vector3I>
        {
            public bool Equals(Vector3I x, Vector3I y)
            {
                return x.X == y.X & x.Y == y.Y & x.Z == y.Z;
            }

            public int GetHashCode(Vector3I obj)
            {
                return (obj.X * 397 ^ obj.Y) * 397 ^ obj.Z;
            }

            public int Compare(Vector3I x, Vector3I y)
            {
                return x.CompareTo(y);
            }
        }
    }
}
