using System;
using System.Collections.Generic;

namespace AitportStuff
{
    public class Priority : IComparable<Priority>, IComparable
    {
        private readonly int m_priorityValue;

        public Priority(int _priorityValue)
        {
            m_priorityValue = _priorityValue;
        }

        /// <inheritdoc />
        public int CompareTo(object _obj)
        {
            if (ReferenceEquals(null, _obj))
            {
                return 1;
            }

            if (ReferenceEquals(this, _obj))
            {
                return 0;
            }

            return _obj is Priority other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Priority)}");
        }

        /// <inheritdoc />
        public int CompareTo(Priority _other)
        {
            if (ReferenceEquals(this, _other))
            {
                return 0;
            }

            if (ReferenceEquals(null, _other))
            {
                return 1;
            }

            return _other.m_priorityValue.CompareTo(m_priorityValue);
        }

        public static bool operator <(Priority _left, Priority _right)
        {
            return Comparer<Priority>.Default.Compare(_left, _right) < 0;
        }

        public static bool operator >(Priority _left, Priority _right)
        {
            return Comparer<Priority>.Default.Compare(_left, _right) > 0;
        }

        public static bool operator <=(Priority _left, Priority _right)
        {
            return Comparer<Priority>.Default.Compare(_left, _right) <= 0;
        }

        public static bool operator >=(Priority _left, Priority _right)
        {
            return Comparer<Priority>.Default.Compare(_left, _right) >= 0;
        }
    }
}
