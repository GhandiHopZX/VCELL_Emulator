using System;
using System.Collections.Generic;

/// <summary>
/// Todos
/// remember to use Euler's formula
/// to create an ideal way of
/// prismatic formations
/// </summary>
namespace VCELL_Emulator
{
    public class VCELL
    {
        #region stats
        private string name1;
        private float agility;
        private float speed2;
        private float jump_strength2; // not a base stat
        private int intel;

        public int GetIntel()
        {
            return intel;
        }

        public void SetIntel(int value)
        {
            intel = value;
        }

        private int dex;

        public int GetDex()
        {
            return dex;
        }

        public void SetDex(int value)
        {
            dex = value;
        }

        private int sp;

        public int GetSp()
        {
            return sp;
        }

        public void SetSp(int value)
        {
            sp = value;
        }

        private int fp;

        // aural branch
        public int GetFp()
        {
            return fp;
        }

        // aural branch
        public void SetFp(int value)
        {
            fp = value;
        }

        private int spr;

        public int GetSpr()
        {
            return spr;
        }

        public void SetSpr(int value)
        {
            spr = value;
        }

        private int con;

        public int GetCon()
        {
            return con;
        }

        public void SetCon(int value)
        {
            con = value;
        }

        private int hp;

        // Vigor branch
        public int GetHp()
        {
            return hp;
        }

        // Vigor branch
        public void SetHp(int value)
        {
            hp = value;
        }

        private int end;

        public int GetEnd()
        {
            return end;
        }

        public void SetEnd(int value)
        {
            end = value;
        }

        private int str;

        public int GetStr()
        {
            return str;
        }

        public void SetStr(int value)
        {
            str = value;
        }

        private int atk;

        // Prowess branch
        public int GetAtk()
        {
            return atk;
        }

        // Prowess branch
        public void SetAtk(int value)
        {
            atk = value;
        }

        private int def;

        public int GetDef()
        {
            return def;
        }

        public void SetDef(int value)
        {
            def = value;
        }

        private int ap;

        public int GetAp()
        {
            return ap;
        }

        public void SetAp(int value)
        {
            ap = value;
        }

        private int dp;

        public int GetDp()
        {
            return dp;
        }

        public void SetDp(int value)
        {
            dp = value;
        }

        public float GetAgility()
        {
            return agility;
        }

        public void SetAgility(float value)
        {
            agility = value;
        }

        private int pNum; // this is just a node count
        //default is 4 a Tetrahedron class add one then its a pentahedron
        public VNode one, two, three, four;
        public VNode []vry;
        public CustLinkedList prism = new CustLinkedList(); // for save data


        public VNode[] Vry { get => vry; set => vry = value; }

        public VTree Me {get; set;}

        public float GetJump_strength2()
        {
            return jump_strength2;
        }

        public void SetJump_strength2(float value)
        {
            jump_strength2 = value;
        }

        public float GetSpeed()
        {
            return speed2;
        }

        public void SetSpeed(float value)
        {
            speed2 = value;
        }

        public int GetPNum()
        {
            return pNum;
        }

        public void SetPNum(int value)
        {
            pNum = value;
        }

        public string GetName1()
        {
            return name1;
        }

        public void SetName1(string value)
        {
            name1 = value;
        }
        #endregion
        public VCELL()
        {
            name1 = "def";
            intel= 0;
            agility= 0;
            dex= 0;
            sp= 0;
            fp= 0;
            spr= 0;
            con= 0;
            end= 0;
            str= 0;
            atk= 0;
            SetSpeed(0);
            SetDef(0);
            SetAgility(0);
            SetAp(0);
            SetDp(0);

            //one.data = GetName1();
            //two.data = GetHp();
            //three.data = GetSp();
            //four.data = GetAp();
        }

        public VCELL(VNode[] vry)
        {
            this.vry = vry;
        }
        public VCELL(int pNum, VNode[] vry)
        {
            this.SetPNum(pNum);
            this.vry = vry;
            this.SetJump_strength2(GetSpeed() * GetAgility());
        }
        public VCELL(string name, int pNum2, int pNums, VNode[] vry)
        {
            // stats
            //speed = GetSpeed();
            //agility = GetAgility();

            SetName1(name);
            pNum = pNum2;
            this.SetPNum(pNum);
            this.pNum = pNums;
            this.vry = vry;
            //SetAgility(agility);
            //speed = GetSpeed();
            this.SetJump_strength2(GetSpeed() * GetAgility());
        }
        #region aparatus calls
        #endregion
        public void Init_PrismataSystem()
        {
            VNode[] restOfNodes = null;

            restOfNodes[0].data = intel;
            restOfNodes[1].data = agility;
            restOfNodes[2].data = dex;
            restOfNodes[3].data = sp;
            restOfNodes[4].data = fp;
            restOfNodes[5].data = spr;
            restOfNodes[6].data = con;
            restOfNodes[7].data = end;
            restOfNodes[8].data = str;
            restOfNodes[9].data = atk;
            restOfNodes[10].data = GetSpeed();
            restOfNodes[11].data = GetDef();
            restOfNodes[12].data = GetAgility();
            restOfNodes[13].data = GetAp();
            restOfNodes[14].data = GetDp();
            Me.Insert(one, 0); // store stats n shit here
            Me.Insert(two, 1);// store stats n shit here
            Me.Insert(three, 2);// store stats n shit here
            Me.Insert(four, 3);// store stats n shit here

            for (var i = 0; i < restOfNodes.Length; i++) // store the rest here
            {
                Vry[i].data = restOfNodes[i];
            }

            for (var i = 0; i < Vry.Length; i++)
            {
                Me.Insert(Vry[i], i);
            }

            const string outputo = "this workd";
            Console.WriteLine(outputo);
            // print something here
        }
    }
}
