using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeckMaker
{
    public partial class Form1 : Form
    {
        

        private List<EntryData> _entryList = new List<EntryData>();
        private Dictionary<FactionType, Dictionary<UnitType, List<UnitData>>> _unitDic = new Dictionary<FactionType, Dictionary<UnitType, List<UnitData>>>();

        

        public Form1()
        {
            InitializeComponent();
            compFixedAirUnit.Init(UnitType.Air);
            compFixedTankUnit.Init(UnitType.Factory);
            compFixedInfanUnit.Init(UnitType.Barrack);

            InitUnit();
        }

        private void InitUnit()
        {
        
            foreach (var obj in (FactionType[])Enum.GetValues(typeof(FactionType)))
            {
                Dictionary<UnitType, List<UnitData>> dataDic = new Dictionary<UnitType, List<UnitData>>();
                _unitDic.Add(obj, dataDic);
                
                foreach(var unit in (UnitType[])Enum.GetValues(typeof(UnitType)))
                {
                    dataDic.Add(unit, new List<UnitData>());
                }
            }
        


            var workbook = GetWorkbook("list.xlsx", ".xlsx");
            ISheet sheet = workbook.GetSheetAt(0);
            try
            {
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    IRow curRow = sheet.GetRow(i);
                    List<ICell> cellList = curRow.Cells;

                    GetString(out var original, curRow, 0);
                    GetString(out var kr, curRow, 1);
                    GetString(out var faction, curRow, 2);
                    GetString(out var unitType, curRow, 3);

                    GetString(out var antiTank, curRow, 4);
                    GetString(out var antiInfan, curRow, 5);
                    GetString(out var antiAir, curRow, 6);
                    GetString(out var cost, curRow, 7);

                    UnitData data = new UnitData();
                    data.EnName = original;
                    data.KrName = kr;
                    data.UnitType = Enum.Parse<UnitType>(unitType);
                    data.FactionType = Enum.Parse<FactionType>(faction);

                    data.AntiAir = Convert.ToInt32(antiAir);
                    data.AntiTank = Convert.ToInt32(antiTank);
                    data.AntiInfan = Convert.ToInt32(antiInfan);
                    data.Cost = Convert.ToInt32(cost);

                    _unitDic[data.FactionType][data.UnitType].Add(data);


                }
                //MessageBox.Show("성공! File 폴더에서 확인하세요");
            }
            catch (Exception e)
            {
                MessageBox.Show("에러발생 ! " + e.ToString());
            }
        }

        private void ParseEntry()
        {
            _entryList.Clear();
            if (!string.IsNullOrEmpty(tbEntry.Text))
            {
                string result = tbEntry.Text.Replace(System.Environment.NewLine, "").Replace(" ", "");
                string[] entrys = result.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach(var obj in entrys)
                {
                    _entryList.Add(new EntryData{ Name = obj}) ;
                }
            }
        }

        private void MakeDeck()
        {
            richTextBox1.Clear();
            ParseEntry();
            foreach (var obj in _entryList)
            {
                MakeUserDeck(obj);
            }
        }

        private void MakeUserDeck(EntryData entry)
        {
            Random random = new Random();
            //종족 등록
            FactionType faction = FactionType.GDI;
            if (rbAll.Checked)
            {
                Array values = Enum.GetValues(typeof(FactionType));           
                faction = (FactionType)values.GetValue(random.Next(values.Length));
            }
            else if(rbGDI.Checked)
            {
                faction = FactionType.GDI;
            }
            else if(rbNod.Checked)
            {
                faction = FactionType.NOD;
            }
          
           

            //사령관
            int count = _unitDic[faction][UnitType.Commander].Count;
            UnitData commander = _unitDic[faction][UnitType.Commander][random.Next(count)];

            //유닛
            //일단 다 합친다
            List<UnitData> list = _unitDic[faction][UnitType.Air].Concat(_unitDic[faction][UnitType.Tech].Concat(_unitDic[faction][UnitType.Barrack].
                Concat(_unitDic[faction][UnitType.Factory]))).ToList();

            //고정 유닛 안티 에어
            List<UnitData> fixedAntiList =
                list.Where(data => data.Cost <= 60 && (data.AntiAir >= 2   || data.AntiInfan >= 2 || data.AntiTank >= 2) ).ToList();

            List<UnitData> selectList = new List<UnitData>();

            int airCount = compFixedAirUnit.Count;
            int tankCount = compFixedTankUnit.Count;
            int infanCount = compFixedInfanUnit.Count;

            int max = 6;


            //에어
            List<UnitData> antiAirList = fixedAntiList.Where(data => data.AntiAir >= 2).ToList();
            for (int i = 0; i < airCount && selectList.Count < max ; i++)
            {
                int pickIndex = random.Next(antiAirList.Count);
                UnitData unit = antiAirList[pickIndex];
                selectList.Add(unit);

                if(unit.AntiInfan >=2)
                {
                    infanCount--;
                }

                if (unit.AntiTank >= 2)
                {
                    tankCount--;
                }

                list.Remove(unit);
                fixedAntiList.Remove(unit);
                antiAirList.RemoveAt(pickIndex);

                if(antiAirList.Count == 0)
                {
                    break;
                }    
            }

            //탱크
            List<UnitData> antiTankList = fixedAntiList.Where(data => data.AntiTank >= 2).ToList();
            for (int i = 0; i < tankCount && selectList.Count < max; i++)
            {
                int pickIndex = random.Next(antiTankList.Count);
                UnitData unit = antiTankList[pickIndex];
                selectList.Add(unit);

                if (unit.AntiInfan >= 2)
                {
                    infanCount--;
                }

                if (unit.AntiAir >= 2)
                {
                    airCount--;
                }

                list.Remove(unit);
                fixedAntiList.Remove(unit);
                antiTankList.RemoveAt(pickIndex);

                if (antiTankList.Count == 0)
                {
                    break;
                }
            }

            //보병
            List<UnitData> antiInfanList = fixedAntiList.Where(data => data.AntiInfan >= 2).ToList();
            for (int i = 0; i < infanCount && selectList.Count < max ; i++)
            {
                int pickIndex = random.Next(antiInfanList.Count);
                UnitData unit = antiInfanList[pickIndex];
                selectList.Add(unit);

                if (unit.AntiTank >= 2)
                {
                    tankCount--;
                }

                if (unit.AntiAir >= 2)
                {
                    airCount--;
                }

                list.Remove(unit);
                fixedAntiList.Remove(unit);
                antiInfanList.RemoveAt(pickIndex);


                if (antiInfanList.Count == 0)
                {
                    break;
                }
            }

            int remain = 6- selectList.Count;
            int techCount = 0;

            for (int i = 0; i < remain; i++)
            {
                int pickIndex = random.Next(list.Count);
                UnitData unit = list[pickIndex];

                if(unit.UnitType == UnitType.Tech)
                {
                    techCount++;

                    if(techCount >= 3)
                    {
                        //3개가 넘으면 테크 유닛을 모두 없앤다.
                        list.RemoveAll(data => data.UnitType == UnitType.Tech);
                    }
                }

                entry.UnitList.Add(unit);
                list.Remove(unit);
            }

            entry.UnitList = entry.UnitList.Concat(selectList).ToList();

            entry.AppendText(richTextBox1);
        }     


        private void GetString(out string value, IRow row, int index)
        {
            value = "";
            var cell = row.GetCell(index);

            if (cell != null && cell.CellType == CellType.String)
            {
                value = cell.StringCellValue;
            }
            else if (cell != null && cell.CellType == CellType.Numeric)
            {
                value = cell.NumericCellValue.ToString();
            }
        }


        public IWorkbook GetWorkbook(string filename, string version)
        {
            using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                //표준 xls 버젼
                if (".xls".Equals(version))
                {
                    return new HSSFWorkbook(stream);
                }
                //확장 xlsx 버젼
                else if (".xlsx".Equals(version))
                {
                    return new XSSFWorkbook(stream);
                }
                throw new NotSupportedException();
            }
        }







        private void tbEntry_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeDeck();
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.SelectedText = text;
            //box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        public static void AppendText(this EntryData entry, RichTextBox box)
        {
            entry.UnitList.Sort(new SortByTpye());
            box.AppendText(entry.Name + " : ", Color.Black );
            
            foreach(var obj in entry.UnitList)
            {
                box.AppendText($" {obj.KrName} /", obj.GetTextClor());
            }
            box.AppendText(System.Environment.NewLine);
            //box.Text += System.Environment.NewLine;
        }
    }
}
