using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    /// <summary>
    /// Flatwhite klassen arver fra Kaffe og implementere interfacet Imælk
    /// </summary>
    public class Flatwhite : Kaffe, Imælk
      
  
    {
        public int MlMælk()
        {
            return 160;
        }
        /// <summary>
        /// Fortæller noget om hvor meget mælk der skal i en cortado
        /// </summary>
        /// <returns></returns>

        public override int Pris()
        {
            return 45;
        }

        /// <summary>
        /// Angiver prisen for en cortado
        /// </summary>
        /// <returns></returns>
        

        public override string Styrke()
        {
            return "mild";
        } 
        

    }
   
}
