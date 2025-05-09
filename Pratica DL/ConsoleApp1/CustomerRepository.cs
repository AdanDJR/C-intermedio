using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DL
{
    public class CustomerRepository
    {
        public string GetCustomer(int customerId)
        {
            return $"Cliente con ID {customerId}";
        }
    }

}
