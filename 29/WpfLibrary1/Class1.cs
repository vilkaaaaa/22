using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfLibrary1
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);
    public class AccountEventArgs
    {
        public string Message { get; set; }
        public decimal Sum
        {
            get { return Sum; }

            private set { Sum = value; }
        }
        public AccountEventArgs(string message, decimal Sum)
        {
            this.Message = message;
            this.Sum = Sum;
        }
    }
    public interface IAccount
    {
      void Put(decimal sum)
        {
    
        }
      decimal Withdraw(decimal sum)
        {
            return 0;
        }
    }

}
