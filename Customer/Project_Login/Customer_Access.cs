using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlDbType;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Login
{
    class Customer_Access
    {
       
         Customer_Log _customer = new Customer_Log();
         
        SqlConnection _sqlConnection = new SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True ");
        SqlCommand com = new SqlCommand();
        
        
        
            
    }
}
