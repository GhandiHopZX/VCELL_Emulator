using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCELL_Emulator
{
    public class MemoryBank: VNode
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

        public async void MethodRem(VNode[] m, Stack<Task> ts, int w)
        {
            await Recall(m, ts, w);
            Console.WriteLine("Recalling..." + PlaceF().ToString());
        }

        private object PlaceF()
        {
            throw new NotImplementedException();
        }

        public Task PlaceF(int e) // change to VNode
        { 
            return Task.Run(() => { Thread.Sleep(5000); return this[e]; });
        }

        private Task Recall(VNode[] m, Stack<Task> ts, int w)
        {
            /// 
            // pull the nodes
            //
            /// find the Node(s) needed.
            /// put that b on the stack of cmds
            return PlaceF(w);
        }
    }
}
