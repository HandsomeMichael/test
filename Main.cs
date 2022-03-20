using System;
using System.Collections.Generic;

namespace test
{
    public class Main : IFartable  {

        private static List<IFartable> farties;
        private static int fartable;

        internal static List<IFartable> Farties { get => farties; set => farties = value; }
        public static int Fartable { get => fartable; set => fartable = value; }

        // @HandsomeMichael do stuff
        public Main()
        {
        }

        void IFartable.OnFart() => Fartable = 1;
    }
}


