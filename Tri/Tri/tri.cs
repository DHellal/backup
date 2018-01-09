using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri
{
    class tri
    {

        public static int[] triage(int[] tableau)
        {

            int[] tableprive = tableau;
            int index = 0;
            int intermediaire = 0;


            while (index < tableprive.Length-1)
            {

                if (tableprive[index] > tableprive[index + 1])
                {

                    intermediaire = tableprive[index];
                    tableprive[index] = tableprive[index + 1];
                    tableprive[index + 1] = intermediaire;
                    index = 0;
                }
                else
                {


                    index++;


                }
            }



            return tableprive;


        }
        



    }
}
