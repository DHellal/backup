using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    class Program
    {


        public static event GoDelegue Declencheur;

        public static event Action goaction;



        static void Main(string[] args)
        {


            //Actions act1 = new Actions();
            //Actions act2 = new Actions();
            //Actions act3 = new Actions();


            int i =0;
            string chaine = "test";


           ActionsD1 act1D = new ActionsD1(Actions.Action1);

            ActionD2 act2D = new ActionD2(Actions.Action2);

            ActionD3 act3D = new ActionD3(Actions.Action3);



            act1D.BeginInvoke(null, null);
            act2D.BeginInvoke(i, null, null);
            act3D.Invoke(chaine);




              Actions lesActions = new Actions();

            var d1 = new ActionDelegue1(lesActions.Action1);
            var d2 = new ActionDelegue2(lesActions.Action2);
            var d3 = new ActionDelegue3(lesActions.Action3);

            d1.Invoke();



            Actions gogo = new Actions();



            Declencheur += gogo.Action1;
            Declencheur += gogo.Action2;
            Declencheur += gogo.Action3;






        Console.Read();










    }
        
    }



             


    }


















