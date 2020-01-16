using System;
using System.Collections.Generic;

namespace Discovery.Extensions.Linq
{
    public class GeneralPropertyComparer<T, TKey> : IEqualityComparer<T>
    {
        private Func<T, TKey> expr { get;set; }
        
        public GeneralPropertyComparer(Func<T, TKey> _expr){
            this.expr = _expr;
        }

        public bool Equals(T left, T right)
        {
            var leftProp = expr.Invoke(left);
            var rightProp = expr.Invoke(right);

            if(leftProp == null && rightProp == null)
                return true;

            if(leftProp == null ^ rightProp == null)
                return false;
            
            return leftProp.Equals(rightProp);
        }

        public int GetHashCode(T obj)
        {
            var prop = expr.Invoke(obj);
            return (prop == null) ? 0 : prop.GetHashCode();
        }
    }

}