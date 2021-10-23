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
    public partial class CompFixedUnit : UserControl
    {
        public GlobalDefine.UnitType UnitType;
        public int Count { get; private set; }
        public CompFixedUnit()
        {
            InitializeComponent();
        }

        public void Init(GlobalDefine.UnitType unitType)
        {
            UnitType = unitType;

            switch(unitType)
            {
                case GlobalDefine.UnitType.Air:
                    lbUnitType.Text = "고정 공중 유닛";
                    break;

                case GlobalDefine.UnitType.Tank:
                    lbUnitType.Text = "고정 차량 유닛";
                    break;

                case GlobalDefine.UnitType.infantry:
                    lbUnitType.Text = "고정 보병 유닛";
                    break;
            }
        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(tbValue.Text);
                result = Count;

                if(result < 0)
                {
                    result = 0;
                  
                }

            }
            catch
            {
            }
        }
    }
}
