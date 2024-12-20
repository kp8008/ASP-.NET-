using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("This is main hospital");

        }
    }
    public class Apollo : Hospital 
    {
        public override void HospitalDetails() 
        {
            Console.WriteLine("This is Appolo hospital");
        }
       
    
    }
    public class Wockhardt : Hospital {
        public override void HospitalDetails()
        {
            Console.WriteLine("This is Wockhardt hospital");
        }
    }
    public class Gokul_Superspeciality : Hospital {
        public override void HospitalDetails()
        {
            Console.WriteLine("This is Gokul_Superspeciality hospital");
        }
    }


}
