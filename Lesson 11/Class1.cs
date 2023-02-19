using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    struct Linear
    {
        double k;
        double b;
        
        public Linear(double k, double b)
        {

            this.k = k;
            this.b = b;
           
        }

        public string Root()
        {
            double x = -b / k;
       
        return $"solution - {x}";
        }
 
    }
}
