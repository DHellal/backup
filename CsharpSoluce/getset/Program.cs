using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Program
    {
        static void Main(string[] args)
        {


            // version 1
            #region

            //A a = new A();

            //int x = a.Get();

            //a.Set(88);
            #endregion



            //vesion 2

            #region
            A a = new getset.A();
            a.i = 10;

            int x = a.i;
            #endregion



        }
    }
}
