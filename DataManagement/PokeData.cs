using System;

namespace DataManagement
{
    public enum Ptype 
    { 
        Normal, 
        Fire, 
        Fighting,
        Water, 
        Flying, 
        Grass, 
        Poison, 
        Electric, 
        Ground, 
        Psychic, 
        Rock, 
        Ice, 
        Bug, 
        Dragon, 
        Ghost,
        Dark, 
        Steel, 
        Fairy, 
        Unknown
    }
    public struct Stats
    {
        public int HP, Attack, Defense, SpAtk, SpDef, Speed;
    }
    public struct PokeStore
    {
        public int ID;
        public Ptype[] Type;
        public string Name;
        public int GenderRatio;
        public GrowthGroup growthGroup;
        public int BaseExp;
        public Stats BaseStats;
        public levelTable levelTable;
        public int CatchRate;
    }
    public struct PokeInstance
    {
        public int ID;
        public int StoreID;
        public bool isMale;
        public LevelInstance Level;
        public StatInstance stats;
    }
    public class PokeData
    {
    }
}
