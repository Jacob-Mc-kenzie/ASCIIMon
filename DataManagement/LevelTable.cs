using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement
{
    public struct LevelEffects
    {
        public int level;
        public int EvolvesTo; //the Id of the pokemon to evolve to at this level, null if none;
        public PMoveStore LearnableMove;
    }
    public class levelTable
    {
        internal LevelEffects[] Levels;
        int tracker;
        public levelTable()
        {
            Levels = new LevelEffects[100];
            tracker = 0;
        }
        public bool Add(int level)
        {
            if(tracker < 100)
            {
                Levels[tracker] = new LevelEffects { level = level };
                tracker++;
            }
            return false;
        }
        public bool Add(int level, int EvolutionID)
        {
            if (tracker < 100)
            {
                Levels[tracker] = new LevelEffects { level = level, EvolvesTo=EvolutionID };
                tracker++;
            }
            return false;
        }
        public bool Add(int level, int EvolutionID, PMoveStore LearnableMove)
        {
            if (tracker < 100)
            {
                Levels[tracker] = new LevelEffects { level = level, EvolvesTo = EvolutionID, LearnableMove=LearnableMove };
                tracker++;
            }
            return false;
        }
    }
    public static class LevelTable
    {
    }
}
