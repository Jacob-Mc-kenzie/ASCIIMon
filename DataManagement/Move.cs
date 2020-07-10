using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement
{
    public enum DamageCatagory {  
        Physical, 
        Special, 
        Status
    }
    public struct PMoveStore
    {
        public int ID;
        public Ptype Type;
        public DamageCatagory Catagory;
        public string Name;
        public string Description;
        public int Power;
        public double Accuracy;
        public int Priority;
        public int BasePP;
        public int MaxPP;
        public bool MakesContact;
    }
    public struct PMoveInstance
    {
        public int ID;
        public int totalPP;
        public int currentPP;
        public int StoreID;
    }
    public class Move
    {

    }
}
