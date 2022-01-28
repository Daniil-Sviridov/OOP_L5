using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L5
{
    internal class Ratio
    {
        private int _m;
        private int _n;

        public int M
        {
            get
            {
                return _m;
            }
        }
        public int N
        {
            get
            {
                return _n;
            }
        }


        public Ratio(int m, int n)
        {
            _m = m;

            if (n < 1)
                throw new ArgumentOutOfRangeException("n");

            _n = n;
        }

        public override string ToString()
        {
            return $"{_m}/{_n}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Ratio objectType)
            {
                int LM = this._m * objectType._n;
                int RM = objectType.M * this._n;

                return LM == RM;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Ratio obj1, Ratio obj2)
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Ratio obj1, Ratio obj2)
        {
            return !obj1.Equals(obj2);
        }

        public static bool operator <(Ratio obj1, Ratio obj2)
        {

            if (obj1 == null|| obj2 == null) return false; // Возможно лучше генерировать исключение но делать я этого конечно не буду

            int LM = obj1.M * obj2.N;
            int RM = obj2.M * obj1.N;

            return LM < RM;
        }

        public static bool operator >(Ratio obj1, Ratio obj2)
        {
            if (obj1 == null || obj2 == null) return false; // Возможно лучше генерировать исключение но делать я этого конечно не буду

            int LM = obj1.M * obj2.N;
            int RM = obj2.M * obj1.N;

            return LM > RM;
        }

        public static bool operator <=(Ratio obj1, Ratio obj2)
        {
            if (obj1 == null || obj2 == null) return false; // Возможно лучше генерировать исключение но делать я этого конечно не буду

            int LM = obj1.M * obj2.N;
            int RM = obj2.M * obj1.N;

            return LM <= RM;
        }

        public static bool operator >=(Ratio obj1, Ratio obj2)
        {
            if (obj1 == null || obj2 == null) return false; // Возможно лучше генерировать исключение но делать я этого конечно не буду

            int LM = obj1.M * obj2.N;
            int RM = obj2.M * obj1.N;

            return LM >= RM;
        }

        public static Ratio operator +(Ratio obj1, Ratio obj2)
        {
            int LM = obj1.M * obj2.N;
            int RM = obj2.M * obj1.N;

            int NN = obj1.N * obj2.N;

            return new Ratio(LM + RM, NN);
        }

        public static Ratio operator -(Ratio obj1, Ratio obj2)
        {
            int LM = obj1.M * obj2.N;
            int RM = obj2.M * obj1.N;

            int NN = obj1.N * obj2.N;

            return new Ratio(LM - RM, NN);
        }

        public static Ratio operator ++(Ratio obj)
        {
            return obj;
        }

        public static Ratio operator --(Ratio obj)
        {
            return obj;
        }
    }
}
