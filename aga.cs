using System;
namespace test
{
    public class Main : IFartable  {
        public static int fartable;
        public void OnFart() {
            fartable = 1;
        }
    }
}


