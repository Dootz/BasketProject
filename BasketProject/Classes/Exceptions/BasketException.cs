using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketProject.Classes
{
    class BasketException : Exception
    {
        public BasketException()
        {
        }

        public BasketException(String message):base(message)
        {
        }

        public BasketException(String message, Exception inner) : base(message, inner)
        {
        }
    }
}
