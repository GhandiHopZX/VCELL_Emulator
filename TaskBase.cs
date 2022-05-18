using System;
using System.Collections; // do this in order to use ArrayList and other cool things 
using System.Collections.Generic;
using System.Linq;

namespace VCELL_Emulator
{
    public partial class TaskBase
    {
        public MemoryBank Memories = new MemoryBank();
        delegate void presetTaskLookup (Action task);
        delegate void presetThinkLookup (Think task);
        public Action eAction { get; set; }
        public Predicate<Action> ishappen;
        public Think Think { get; set; }
        public Action Action { get; private set; }

        System.Action sysAction1;
        System.Action<int> action; // arraylistdemo
        enum thang
        {
            ACT,
            ATTACK,
            TALK,
            THINK,
            FEEL, 
            HEAR,
            RECOG
        };

        public TaskBase this[int index]
        {
            get 
            { 
                return this[index]; 
            }
            set 
            {
                this[index] = value;
            }
        }

       // public Action action2(int e) // action delegate
       // {
            // same type and parameters
         //   List<Action> actions2
           // {
            ///    new Action()
            ////]]/    {
             //       grabPresetTaskList(e),
            //        "boppin",
                   //10,
            //        thang.ACT
              ///  },
            //    new Action()
            //    {
            //        ishappen,
             //       "w",
             //       1,
            //        thang.HEAR
            //    }
            //}
           // return actions2[3].;
      //  }


        
        public Action FetchAction(int e)
        {
        # region bloat

            int[] nums = { 1, 3, 5, 6, -2, 4};

            //method syntax
            var nummeth = nums.Where(x => (x % 2 == e)).OrderBy(x => x);
        
            var positiveNums = from n in nums
                               where n > 0
                               select n; // using linq u can select and order data from 
        // different data types and use them accordingly
            var acsPosNums = from n in nums // data 
                             orderby n ascending // sort/arg
                             select n; // selection
            string[] bmw = {"whef.", "omg", "Gud Car", "meh"};

            var cars = from v 
                   in bmw
                   group v 
                   by v.Substring(v.LastIndexOf('.'));

            foreach (var ec in cars)
            {
               Console.WriteLine("Group Name = " + ec.Key);
               //foreach (string ec in cars)
               //{
                //  Console.WriteLine("\t" + ec);
               //}
            }

            foreach (var vefer in acsPosNums)
            {
                Console.WriteLine(vefer);
            }

            var domeOfSins = from s in bmw
                             select new {
                                            r = s[0],
                                            rName = s.ToString()
                                        };
        #endregion

            return this[e].Action;
        }

        public Think FetchThought(int e)
        {
            return this[e].Think;
        }

        public Action grabPresetTaskList(int e)
        {
            List<Action> redundants = new List<Action>();
            int redundaC = 0;

            Action[] tasks =
            {
                new Action() 
                { 
                idea = memoryThinkTank
                (e, ea: Memories), what = "Walk_Around", times = 1,
                //thang.ACT
                }
            };

            Action[] actions = tasks.Where(s => s.times > 13).ToArray();

            //string[] stall = tasks.Where(s =>
            //{
               // bool v = s.what == "still";//|| "stall" || "wait" || " " || "" || "waiting";
               
            //}).FirstOrDefault();

            //String doing = tasks.Where(s => s.times == 20).FirstOrDefault();

            foreach(Action action in tasks)
            {
                redundants.Add(action);
                ++redundaC;
            }

            redundants.Clear();
            Console.WriteLine(redundaC +" : " + "redundancies cleared");
           return tasks[e]; // predicate delagate checks for
            // relevant data or criterion
        }

        public static Think memoryThinkTank(int e, MemoryBank ea)
        {
            return ea.MemTup[e].thinke;
        }

        #region basic funcions
        public static void arrayListDemo()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("me");

            arrayList.Insert(1, "efm");

            arrayList.Reverse();
            foreach(var j in arrayList)
            {
                Console.WriteLine(j);
            }
        }
        #endregion
    }
}
