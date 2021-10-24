﻿using System;
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
        public UnitType UnitType;
        public int Count { get { return _count; } }
        private int _count;
        public CompFixedUnit()
        {
            InitializeComponent();
        }

        public void Init(UnitType unitType)
        {
            UnitType = unitType;

            switch(unitType)
            {
                case UnitType.Air:
                    lbUnitType.Text = "고정 공중 유닛";
                    break;

                case UnitType.Factory:
                    lbUnitType.Text = "고정 차량 유닛";
                    break;

                case UnitType.Barrack:
                    lbUnitType.Text = "고정 보병 유닛";
                    break;
            }
        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(tbValue.Text);
              

                if(result < 0)
                {
                    result = 0;
                  
                }
                _count = result;

            }
            catch
            {
                _count = 1;
            }
        }
    }
}
