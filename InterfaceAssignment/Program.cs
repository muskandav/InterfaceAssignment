// See https://aka.ms/new-console-template for more information

using System;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var tcsEmp1 = new TCSEmployee("Muskan", "Program Associate","UXV123", "Auto", 4000.00);
            var wfEmp1 = new WellsFargoEmployee("Vijaya", "Software Engineer","UXY124", "CCIBT", 10000);

            tcsEmp1.ViewDetails(10);

            wfEmp1.ViewDetails(20);


        }
    }
}