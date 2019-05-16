using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Razor_Syntax.Models
{
    public abstract class InheritanceTestClass : RazorPage<UserModel>
    {
        public String GetName() => "Kishor Naik";
    }
}