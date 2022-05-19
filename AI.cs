﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCELL_Emulator
{
    partial class AI : VCELL
    {
        #region properties
        string name;
        bool alive;
        int priorityLvl;
        VCELL AVCELL = new VCELL();
        Type typeChek = typeof(DoThought);
        private VNode[] AddedNodes = Array.Empty<VNode>(); // put stuff in here or in the constructor
        Stack<Action> tasks;
        private List<Action> savedActions;
        private List<Action> tempActions;
        Stack<Think> thoughts;
        MemoryBank MemoryBank;
        //public MemoryBank Memories = new MemoryBank(); this will exist inside TaskBase

        delegate void VNodeDelegate(VNode vNodeD);
        public string Name { get => name; set => name = value; }
        public bool Alive { get => alive; set => alive = value; }
        public int PriorityLvl { get => priorityLvl; set => priorityLvl = value; }
        public VNode[] AddedNodes1 { get => AddedNodes; set => AddedNodes = value; }
        public Type Typey { get; set; }

        public Type GetTypeChek()
        {
            //Typey = Type.GetType("ass");
            return typeChek;
        }

        public void SetTypeChek(Type value)
        {
            typeChek = value;
        }

        public delegate void DoTask();
        public delegate void DoThought();
        //crafted delagate
        public delegate void InAction(Think Thought, Action action);
        #endregion

        public AI(string Inin, int NodesAdd, bool Active)
        {
            DoThought doThought = new(ActivateLoop);
            Name = Inin;
            // VCELL Time
            Alive = Active;
            if(Alive == false)
            {
                Console.WriteLine("I'm StillBorn...");
            }
            doThought(); //put this in different places
        }

        public void VInitializer()
        {
            AVCELL.SetName1("");
            AVCELL.SetSpeed(9);
            bool isV = (AVCELL is VCELL);
            Console.WriteLine("THis is a VCELL");
            Console.WriteLine("vabidabi punjabi?: {0}",
                ChackValidabaidi(AVCELL));
        }

        public static string ChackValidabaidi(dynamic obj)
        {
            VCELL fe = obj as VCELL;
            if (fe != null)
            {
                return "Checkenn :" + fe.GetName1(); 
            }
            return "Not a Punjabi";
        }

        public DoTask FocusAction(DoTask doTask)
        {
            if(doTask.GetInvocationList().Any())
            {
                // then continue
                {
                    object em = doTask.Method;
                    // parse em and see what's inside
                    // then create a method of service
                    // invoke at the 
                    // runtime
                }
            }
            return doTask;
        }

        private DoTask ExecuteAction(Action ina)
        {
            if (!ina.Equals(savedActions.BinarySearch(ina)))
            {
                tempActions.Add(savedActions.First());
                savedActions.Remove(savedActions.First());
            }
            return new DoTask(ExecuteAction(ina));
        }

        public void CallRoutine() // calls a set of actions
        {
            
        }

        public virtual void Thinking()
        {
            AsyncCallback callback; // whenever a routine is complete call this.
            AsyncCallback watch; // lookat a specific att

            switch(PriorityLvl)
            {
                case 0:
                    // Nothing to do. seek.. find...
                    break;
                case 1:
                    // tasks of what. Misc Stuff. Side qs.. Create tasks?
                    break;
                case 2:
                    // BORED AF time to do shit.
                    break;
                case 3:
                    // Stressed little
                    break;
                case 4:
                    // Very Stressed ATTACK TIME
                    break;
                case 5:
                    // COMBAT MODE
                    break;
                default:
                    // DO SHIT
                    break;
            }
        }

        public void ActivateLoop()
        {
            switch (this.Alive)
            {
                case true:
                    Thinking();
                    Action action = tasks.Peek();

                    //annonymous function. Monitor?

                    VNodeDelegate vNodeDelegate = 
                        delegate (VNode vNode) 
                        { 
                            Console.WriteLine
                            ("bloop", action.ToString(), vNode.name); 
                        };

                    bool canRun = tasks.TryPop(out action);
                    if (canRun != true)
                    {
                        ExecuteAction(action);
                    }// pop from the top
                    else
                    {
                        tasks.Pop();
                        ActivateLoop();
                    }
                break;
                case false:
                    Console.WriteLine("Im Dead.");
                break;
            }
        }
    }

    class Id // just imperatives
    {

    }
    class Ego // a molded form of conscienceness
    {

    }
    class SuperEgo : Ego // Better Ego
    {

    }
    class Identity // THE WHOLE
    {

    }
    delegate bool FindVNode(VNode vNode);
    class AI_EXTENSION
    {
        public static VNode[] Wereu(VNode[] vNodes, FindVNode del)
        {
            int i = 0;
            List<VNode> results = new List<VNode>();
            foreach (VNode vNode1 in vNodes)
            {
                if(del(vNode1))
                {
                    results[i] = vNode1;
                    i++;
                    Console.WriteLine(vNode1.name);
                }
            }
            return results.ToArray();
        }
    }

}
