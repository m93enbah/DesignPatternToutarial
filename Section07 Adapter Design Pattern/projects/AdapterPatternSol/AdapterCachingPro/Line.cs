﻿namespace AdapterCachingPro
{
    public class Line
    {
        public Point Start;
        public Point End;

        public Line(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
        }

        protected bool Equals(Line other)
        {
            return Equals(Start, other.Start) && Equals(End, other.End);
        }

        //it will resolve the issue of the replicate temp data
        //make check equal by reference if it equals return true
        //and then check for the two Point Start , End
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Line)obj);
        }
        //we override GetHashCode() on the Point , Line 
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Start != null ? Start.GetHashCode() : 0) * 397) ^ (End != null ? End.GetHashCode() : 0);
            }
        }
    }
}
