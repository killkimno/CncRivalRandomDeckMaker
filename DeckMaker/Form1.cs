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

        private List<UnitData> _nodUnitDataList = new List<UnitData>();
        private List<UnitData> _gdiUnitDataList = new List<UnitData>();

        private List<UnitData> _nodCommanderList = new List<UnitData>();
        private List<UnitData> _gdiCommanderList = new List<UnitData>();

        public Form1()
        {
            InitializeComponent();
            compFixedUnit1.Init(UnitType.Air);
            compFixedUnit2.Init(UnitType.Factory);
            compFixedUnit3.Init(UnitType.Barrack);

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
                    GetString(out var faction, curRow, 1);
                    GetString(out var unitType, curRow, 2);

                    UnitData data = new UnitData();
                    data.EnName = original;
                    data.UnitType = Enum.Parse<UnitType>(unitType);
                    data.FactionType = Enum.Parse<FactionType>(faction);


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
                string result = tbEntry.Text.Replace(System.Environment.NewLine, "");
                string[] entrys = result.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach(var obj in entrys)
                {
                    _entryList.Add(new EntryData{ Name = obj}) ;
                }
            }
        }

        private void MakeDeck()
        {
            ParseEntry();
            foreach (var obj in _entryList)
            {
                MakeUserDeck(obj);
            }
        }

        private void MakeUserDeck(EntryData entry)
        {
            //종족 등록

            Array values = Enum.GetValues(typeof(FactionType));
            Random random = new Random();
            FactionType faction = (FactionType)values.GetValue(random.Next(values.Length));

            //사령관
            int count = _unitDic[faction][UnitType.Commander].Count;
            UnitData commander = _unitDic[faction][UnitType.Commander][random.Next(count)];

            //유닛

            //일단 다 합친다
            List<UnitData> list = _unitDic[faction][UnitType.Air].Concat(_unitDic[faction][UnitType.Tech].Concat(_unitDic[faction][UnitType.Barrack].
                Concat(_unitDic[faction][UnitType.Factory]))).ToList();


            for(int i = 0; i < 6; i++)
            {
                int pickIndex = random.Next(list.Count);
                UnitData unit = list[pickIndex];
                entry.UnitList.Add(unit);
                list.RemoveAt(pickIndex);
            }

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
            box.AppendText(entry.Name + " : ", Color.Black );
            
            foreach(var obj in entry.UnitList)
            {
                box.AppendText($" {obj.EnName} /", obj.GetTextClor());
            }
            box.AppendText(System.Environment.NewLine);
            //box.Text += System.Environment.NewLine;
        }
    }
}
