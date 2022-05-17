using System;

namespace VCELL_Emulator
{
    class Program
    {
        static void Main()
        {
            #region Am's brain
            dynamic dynamicvar = 233;
            Console.WriteLine("Val :", dynamicvar);
            var myAnnon = new
            {
                name = "thing",
                age = 2,
                currentVer = 6.0
            };
            AI Am = new AI("Am", 8, false);
            
            for (int i = 0; i < 5; i++)
            {

            }
            #endregion
            
            Console.WriteLine("Hello World!");
        }
    }
}
