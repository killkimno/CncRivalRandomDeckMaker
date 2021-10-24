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
        Barrack = 0, Factory, Air,  Tech, Commander
    }

    public enum FactionType
    {
        GDI, NOD
    }

    public class EntryData
    {
        public string Name;
        public UnitData Commander;
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

    public class SortByTpye : IComparer<UnitData>
    {
        public int Compare(UnitData first, UnitData second)
        {
            int value1 =(int) first.UnitType;
            int value2 = (int)second.UnitType;
            return value1.CompareTo(value2);
        }
    }
    public class UnitData
    {
        public string EnName;
        public string KrName;
        public int Cost;
        public UnitType UnitType;
        public FactionType FactionType;
        public int AntiAir;
        public int AntiTank;
        public int AntiInfan;

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
