using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A3_LukeNoble_5030271
{
    public class AccountAddInterestFailedException : Exception
    {
        public AccountAddInterestFailedException(string message) : base(message)
        {

        }
    }
}
