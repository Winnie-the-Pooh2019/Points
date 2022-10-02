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
            if (set is null || point is null)
                throw new ArgumentNullException("set or point cannot be null");

            var result = new PointSet(set.set);

            result.set.Add(point);

            return result;
        }

        public static PointSet operator +(Point point, PointSet set) => set + point;

        public static PointSet operator +(Point left, Point right)
        {
            if (right is null || left is null)
                throw new ArgumentNullException("set or point cannot be null");

            var set = new HashSet<Point>();

            set.Add(left);
            set.Add(right);

            return new PointSet(set);
        }

        public static PointSet operator -(PointSet set, Point point)
        {
            if (set is null || point is null)
                throw new ArgumentNullException("Point or set cannot be null");

            var newSet = new HashSet<Point>(set.set);
            newSet.Remove(point);

            return new PointSet(newSet);
        }

        public static bool operator ==(Point left, Point right)
        {
            if (right is null || left is null)
                throw new ArgumentNullException("set or point cannot be null");

            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right) => !(left == right);

        public override string ToString()
        {
            return $"({X}; {Y})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != typeof(Point))
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
            if (right is null || left is null)
                throw new ArgumentNullException("set or point cannot be null");

            var result = new HashSet<Point>(left.set);
            result.UnionWith(right.set);

            return new PointSet((HashSet<Point>)result);
        }

        public static PointSet operator -(PointSet left, PointSet right)
        {
            if (right is null || right is null)
                throw new ArgumentNullException("set or point cannot be null");

            var result = new HashSet<Point>(left.set);
            result.ExceptWith(right.set);

            return new PointSet((HashSet<Point>)result);
        }

        public static bool operator ==(PointSet left, PointSet right)
        {
            if (right is null || right is null)
                throw new ArgumentNullException("set or point cannot be null");

            return left.Equals(right);
        }

        public static bool operator !=(PointSet left, PointSet right) => !(left == right);

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != typeof(PointSet))
                return false;

            return this.set.ToList().All(e => ((PointSet)obj).set.Contains(e));
        }

        public override string ToString()
        {
            var str = "{ ";

            set.ToList().ForEach(e => str += e.ToString() + " ");

            return str + "}";
        }

        public override int GetHashCode() => this.set.GetHashCode();
    }
}
