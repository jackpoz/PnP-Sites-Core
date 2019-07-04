using OfficeDevPnP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace CoreResourcesTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-se");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-se");
            string resourceValue = GetCoreResources.FileFolderExtensions_CreateFolder0Under12;
            Console.WriteLine("Resource value: " + resourceValue);
            Console.ReadKey();
        }
    }
}
