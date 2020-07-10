using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement
{
    public enum GrowthGroup { Erratic, Fast, MedFast, MedSlow, Slow, Fluctuating }
    public class LevelInstance
    {
        int level;
        int Exp;
        int ExpToNext;
        GrowthGroup group;
        public LevelInstance(int level, GrowthGroup growthGroup)
        {
            this.level = level;
            this.group = growthGroup;
            Exp = 0;
            this.ExpToNext = ExpToNextLevel();
        }

        private int ExpToNextLevel()
        {
            switch (group){
                case GrowthGroup.Erratic:
                    if(level <= 50)
                    {
                        return (int)((Math.Pow(level,3.0) * (100-level))/50);
                    }
                    else if (level >= 50 && level <= 68)
                    {
                        return (int)((Math.Pow(level, 3.0) * (150 - level)) / 100);
                    }
                    else if(68 <= level && level <= 98)
                    {
                        return (int)((Math.Pow(level, 3.0) * Math.Abs((1911-(10*level))/3)) / 500);
                    }
                    else
                    {
                        return (int)((Math.Pow(level, 3.0) * (160 - level)) / 100);
                    }
                case GrowthGroup.Fast:
                    return (int)((4*Math.Pow(level,3))/5);
                case GrowthGroup.MedFast:
                    return (int)Math.Pow(level, 3);
                case GrowthGroup.MedSlow:
                    return (int)(((6.0/5.0)*Math.Pow(level,3))-(15*Math.Pow(level,2))+(100*level)-140);
                case GrowthGroup.Slow:
                    return (int)((5*Math.Pow(level,3))/4);
                case GrowthGroup.Fluctuating:
                    if(level <= 15)
                    {
                        return (int)(Math.Pow(level,3)*((Math.Abs((level + 1)/3)+24)/50));
                    }
                    if (level <= 36)
                    {
                        return (int)(Math.Pow(level,3)*((level+14)/50));
                    }
                    else
                    {
                        return (int)((Math.Abs(level/2.0)+32)/50);
                    }
                default:
                    return -1;
            }
        }

        public int GiveExp(int ammount)
        {
            if(ExpToNext <= Exp + ammount)
            {
                level++;
                ExpToNext = ExpToNextLevel();
                return GiveExp(ammount);
            }
            Exp += ammount;
            return level;
        }

    }
}
