using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class HelloService : IHelloService
    {
        public string Hello() 
        {
            return "hello";
        }

    }
}
