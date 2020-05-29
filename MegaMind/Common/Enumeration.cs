using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace MegaMind.Common
{
    public abstract class Enumeration : IComparable
    {
        public string Name { get; }

        public int Id { get; }

        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public static T Find<T>(Expression<Func<T, bool>> expression) where T : Enumeration
        {
            return GetAll<T>().FirstOrDefault(expression.Compile());
        }

        public static T Find<T>(int id) where T : Enumeration
        {
            return GetAll<T>().FirstOrDefault(t => t.Id == id);
        }

        public override bool Equals(object obj)
        {
            var otherValue = (Enumeration)obj;

            if (otherValue == null)
                return false;

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        protected bool Equals(Enumeration other)
        {
            return Name == other.Name && Id == other.Id;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ Id;
            }
        }

        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);
    }
}
