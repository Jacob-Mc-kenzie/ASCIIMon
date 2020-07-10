using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement
{

    public class StatInstance
    {
        Stats Base;
        Stats Current;
        Stats EVs;
        int Level;
        public Stats GetCurrent { get { return Current; } }
        public StatInstance(Stats BaseStats, int level)
        {
            Base = BaseStats;
            EVs = new Stats { Attack = 0, HP = 0, Defense = 0, SpAtk = 0, SpDef = 0, Speed = 0 };
            Level = level;
            Current = CalculateStats();

        }
        private Stats CalculateStats()
        {
            int HpCalc()
            {
                return (int)(Math.Abs((((Base.HP*2)+Math.Abs(Math.Sqrt(EVs.HP)/4))*Level)/100)+Level+10);
            }
            int OtherCalc(int S, int E)
            {
                return (int)(Math.Abs((((S * 2) + Math.Abs(Math.Sqrt(E) / 4)) * Level) / 100) + 5);
            }
            return new Stats
            {
                HP = HpCalc(),
                Attack = OtherCalc(Base.Attack, EVs.Attack),
                Defense = OtherCalc(Base.Defense, EVs.Defense),
                SpAtk = OtherCalc(Base.SpAtk, EVs.SpAtk),
                SpDef = OtherCalc(Base.SpDef, EVs.SpDef),
                Speed = OtherCalc(Base.Speed, EVs.Speed)
            };
        }
        public void UpdateEVs(Stats toAdd)
        {
            EVs = new Stats
            {
                Attack = (EVs.Attack + toAdd.Attack <= 255? EVs.Attack + toAdd.Attack: 255),
                HP = (EVs.HP + toAdd.HP <= 255? EVs.HP + toAdd.HP: 255),
                Defense = (EVs.Defense+ toAdd.Defense <= 255? EVs.Defense+toAdd.Defense: 255),
                SpAtk= (EVs.SpAtk + toAdd.SpAtk <= 255? EVs.SpAtk + toAdd.SpAtk: 255),
                SpDef=(EVs.SpDef+toAdd.SpDef <= 255? EVs.SpDef + toAdd.SpDef : 255),
                Speed=(EVs.Speed+toAdd.Speed <= 255? EVs.Speed+toAdd.Speed : 255)
            };
        }

        public void UpdateLevel(int newLevel)
        {
            Level = newLevel;
        }
    }
}
