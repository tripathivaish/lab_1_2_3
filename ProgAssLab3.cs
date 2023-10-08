using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp5
{
    public class Assembly1
    {

        protected internal string Account_holder_name;

        public Assembly1()
        {
            Console.Write("Enter Account Holder Name: ");
            Account_holder_name = Console.ReadLine();
        }

    }

}