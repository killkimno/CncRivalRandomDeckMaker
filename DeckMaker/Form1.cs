using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckMaker
{
    public partial class Form1 : Form
    {
        public class EntryData
        {
            public string Name;
           
        }

        private List<EntryData> _entryList = new List<EntryData>();

        public Form1()
        {
            InitializeComponent();
            compFixedUnit1.Init(GlobalDefine.UnitType.Air);
            compFixedUnit2.Init(GlobalDefine.UnitType.Tank);
            compFixedUnit3.Init(GlobalDefine.UnitType.infantry);
        }

        private void ParseEntry()
        {
            if (!string.IsNullOrEmpty(tbEntry.Text))
            {
                string result = tbEntry.Text.Replace(System.Environment.NewLine, "");
                string[] entrys = result.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach(var obj in entrys)
                {
                    _entryList.Add(new EntryData{ Name = obj});
                }
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
    }
}
