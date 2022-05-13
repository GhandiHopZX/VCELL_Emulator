using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCELL_Emulator
{
    public class MemoryBank
    {
        public Action actm;
        public Think thinke;
        StreamWriter writer = new StreamWriter(@"C:*\\VCELL_Emulator\VCELL_Emulator\MemSav0.bin");
        StreamReader reader = new StreamReader(@"C:*\\VCELL_Emulator\VCELL_Emulator\MemSav0.bin");

        public MemoryBank this[int e]
        {
            get { return this[e]; }
            set { this[e] = value; }
        }

        public static void Load()
        {
            StreamReader reader = new StreamReader(@"C:\\VCELL_Emulator\VCELL_Emulator\MemSav0.bin");
            
            // this is the Reading function
            reader.ReadToEnd();

            // a re-noding function would go here.

            reader.Close();
        }

        public void Save()
        {
            StreamWriter writer = new StreamWriter(@"C:\\VCELL_Emulator\VCELL_Emulator\MemSav0.bin");

            // this is the Writing function
            writer.Write(this.ToString());
            writer.Close();
        }
    }
}
