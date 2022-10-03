using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It_Mia.Data
{
    public class PersonSequencer
    {
        private static int personId;
    public static int NextPersonId()
    {
        return personId++;
    }
    
    public static int Reset()
        {
            personId = 0;
            return personId;
        }
    }
}
