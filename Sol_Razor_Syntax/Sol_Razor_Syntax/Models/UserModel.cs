using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Razor_Syntax.Models
{
    public class UserModel
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }
    }

    public class TestClass : IDisposable
    {
        public String GetName()
        {
            return "Hello Using Directive";
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}