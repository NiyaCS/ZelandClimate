using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelandClimate
{
    public class MålingRegister
    {
        public List<Måling> Målinger { get; set; }

        public MålingRegister()
        {

            Målinger = new List<Måling>(); 

        }


    }

}
