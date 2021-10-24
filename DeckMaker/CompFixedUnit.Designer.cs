
namespace DeckMaker
{
    partial class CompFixedUnit
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUnitType = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUnitType
            // 
            this.lbUnitType.AutoSize = true;
            this.lbUnitType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUnitType.Location = new System.Drawing.Point(0, 0);
            this.lbUnitType.Name = "lbUnitType";
            this.lbUnitType.Size = new System.Drawing.Size(103, 15);
            this.lbUnitType.TabIndex = 0;
            this.lbUnitType.Text = "label1sdfdsfsdfdsf";
            this.lbUnitType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(56, 38);
            this.tbValue.MaxLength = 1;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(91, 23);
            this.tbValue.TabIndex = 1;
            this.tbValue.Text = "1";
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "고정 수";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompFixedUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lbUnitType);
            this.Name = "CompFixedUnit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUnitType;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label1;
    }
}
