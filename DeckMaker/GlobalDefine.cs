using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckMaker
{
    public enum UnitType
    {
        Air, Factory, Barrack, Commander, Tech
    }

    public enum FactionType
    {
        GDI, NOD
    }

    public class EntryData
    {
        public string Name;
        public List<UnitData> UnitList = new List<UnitData>();

        public override string ToString()
        {
            string result = $"{Name} ; ";

            foreach (var obj in UnitList)
            {
                result += $" {obj.EnName} / ";
            }

            return result;

        }


    }

    public class UnitData
    {
        public string EnName;
        public string KrName;
        public int Tier;
        public UnitType UnitType;
        public FactionType FactionType;
        public bool IsAllowAir;
        public bool IsAllowTank;
        public bool IsAllowInfantry;

        public Color GetTextClor()
        {
            Color color = Color.Black;

            switch (UnitType)
            {
                case UnitType.Air:
                    color = Color.Blue;
                    break;

                case UnitType.Barrack:
                    color = Color.Green;
                    break;

                case UnitType.Tech:
                    color = Color.Red;
                    break;
                case UnitType.Factory:
                    color = Color.Purple;
                    break;
            }

            return color;
        }
    }
}
