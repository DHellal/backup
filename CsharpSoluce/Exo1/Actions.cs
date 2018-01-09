using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exo1
{
    class Actions
    {


        





        public void Action1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Action 1");


        }


        public  void Action2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Action 2");


        }       // met le int i



        public  void Action3()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Action 3");


        }       // mets le string s





    }




    delegate void ActionsD1();

    delegate void ActionD2(int i);

    delegate void ActionD3(string s);


    public delegate void GoDelegue();            // c'est un delegué contenant une liste de delegués
}
