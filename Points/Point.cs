using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        internal Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static PointSet operator +(PointSet set, Point point)
        {
            if (set == null || point == null)
                throw new ArgumentNullException("set or point cannot be null");

            var result = new PointSet(set.set);

            result.set.Add(point);

            return result;
        }

        public static PointSet operator +(Point left, Point right)
        {
            if (right == null || left == null)
                throw new ArgumentNullException("set or point cannot be null");

            var set = new HashSet<Point>();

            set.Add(left);
            set.Add(right);

            return new PointSet(set);
        }

        public override string ToString()
        {
            return $"({X}; {Y})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Point))
                return false;

            return this.X == ((Point)obj).X && this.Y == ((Point)obj).Y;
        }

        public override int GetHashCode()
        {
            return this.X.GetHashCode() + this.Y.GetHashCode();
        }
    }

    class PointSet
    {
        public HashSet<Point> set { get; private set; }

        internal PointSet()
        {
            set = new HashSet<Point>();
        }

        internal PointSet(HashSet<Point> set)
        {
            this.set = new HashSet<Point>(set);
        }

        public static PointSet operator +(PointSet left, PointSet right)
        {
            if (right == null || left == null)
                throw new ArgumentNullException("set or point cannot be null");

            var result = left.set.Union(right.set);

            return new PointSet((HashSet<Point>)result);
        }

        public override string ToString()
        {
            var str = "{ ";

            set.ToList().ForEach(e => str += e.ToString() + " ");

            return str + "}";
        }
    }
}
