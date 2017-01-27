using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointVectorMgr {
    public class Point {
        public int X { get; set; }
        public int Y { get; set; }
        public static implicit operator string(Point from) {
            return string.Format("({0},{1})", from.X, from.Y);
        }
        public static implicit operator bool(Point from) {
            return ((from.X == 0) && (from.Y == 0));
        }

        public Point(int X, int Y) {
            this.X = X;
            this.Y = Y;
        }
        public Point() {
            X = 0;
            Y = 0;
        }
    }

    public class Vector {
        protected Point pointFrom;
        protected Point pointTo;

        public static implicit operator string(Vector from) {
            return string.Format("{0}-{1}", (string)from.pointFrom, (string)from.pointTo);
        }
        public static implicit operator bool(Vector from) {
            return (from.pointFrom && from.pointTo);
        }

        public static Vector operator +(Vector leftOp, Vector rightOp) {
            return new Vector(leftOp.pointFrom.X + rightOp.pointFrom.X, leftOp.pointFrom.Y + rightOp.pointFrom.Y,
                leftOp.pointTo.X + rightOp.pointTo.X, leftOp.pointTo.Y + rightOp.pointTo.Y);
        }

        public static Vector operator -(Vector leftOp, Vector rightOp) {
            return new Vector(leftOp.pointFrom.X - rightOp.pointFrom.X, leftOp.pointFrom.Y - rightOp.pointFrom.Y,
                leftOp.pointTo.X - rightOp.pointTo.X, leftOp.pointTo.Y - rightOp.pointTo.Y);
        }

        public Vector() {
            pointFrom = new Point();
            pointTo = new Point();
        }

        public Vector(Point pointFrom, Point pointTo) {
            this.pointFrom = pointFrom;
            this.pointTo = pointTo;
        }

        public Vector(int fromX, int fromY, int toX, int toY) {
            pointFrom = new Point(fromX, fromY);
            pointTo = new Point(toX, toY);
        }

    }

    public class Manager {
        private int vElemCount=0;
        public int ElemCount{get{return vElemCount;}}
        private const int vMaxCapacity=20;
        private Vector[] vectorArray = new Vector[vMaxCapacity];

        public Vector this[int index] {
            get { return vectorArray[index]; }
            set { vectorArray[index] = value; }
        }

        public Point GetRandomPoint(int min, int max) {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return new Point(rnd.Next(min, max), rnd.Next(min, max));
        }

        public Manager() {
            int minCoord = -100;
            int maxCoord = 100;
            for (int i = 0; i < 10; i++) {
                vectorArray[i] = new Vector(GetRandomPoint(minCoord, maxCoord), GetRandomPoint(minCoord, maxCoord));
                vElemCount++;
            }
        }

        public bool AddVector(int fromX, int fromY, int toX, int toY){
            bool ok=false;
            if (vElemCount + 1 > vMaxCapacity)
                return false;
            vectorArray[vElemCount++]=new Vector(fromX,fromY,toX,toY);
            return ok;
        }
    }
}
