using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class A
    {

        // version 1
        #region
        //private int i = 77;
        //public int Get() { return i; }      // lit i

        //public void Set(int value) { i = value; }       //ecrit en prennant parametre
        #endregion      // version 1


        // version 1bis
        #region
        //private int i = 77;
        //public int Get() { return i; }      // lit i

        //public void Set(int value) { if(value<1000) i = value; }       //ecrit en prennant parametre avec conditions
        #endregion      // version 1




        // version 2
        #region
        //private int _i = 77;

        //public int i        // un i image
        //{
        //    get { return _i; }
        //    set { _i = i; }

        //}

        #endregion



        #region

        public int i { get; set; }      // fait lui meme une variable privée et l'encaspsule dedans

        #endregion






    }
}
