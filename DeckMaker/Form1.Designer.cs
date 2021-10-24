
namespace DeckMaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.compFixedAirUnit = new DeckMaker.CompFixedUnit();
            this.compFixedTankUnit = new DeckMaker.CompFixedUnit();
            this.compFixedInfanUnit = new DeckMaker.CompFixedUnit();
            this.lbEntry = new System.Windows.Forms.Label();
            this.tbEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNod = new System.Windows.Forms.RadioButton();
            this.rbGDI = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Beige;
            this.richTextBox1.Location = new System.Drawing.Point(13, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(1022, 273);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // compFixedAirUnit
            // 
            this.compFixedAirUnit.Location = new System.Drawing.Point(13, 63);
            this.compFixedAirUnit.Name = "compFixedAirUnit";
            this.compFixedAirUnit.Size = new System.Drawing.Size(150, 75);
            this.compFixedAirUnit.TabIndex = 3;
            // 
            // compFixedTankUnit
            // 
            this.compFixedTankUnit.Location = new System.Drawing.Point(178, 63);
            this.compFixedTankUnit.Name = "compFixedTankUnit";
            this.compFixedTankUnit.Size = new System.Drawing.Size(150, 75);
            this.compFixedTankUnit.TabIndex = 4;
            // 
            // compFixedInfanUnit
            // 
            this.compFixedInfanUnit.Location = new System.Drawing.Point(334, 63);
            this.compFixedInfanUnit.Name = "compFixedInfanUnit";
            this.compFixedInfanUnit.Size = new System.Drawing.Size(150, 75);
            this.compFixedInfanUnit.TabIndex = 5;
            // 
            // lbEntry
            // 
            this.lbEntry.AutoSize = true;
            this.lbEntry.Location = new System.Drawing.Point(13, 157);
            this.lbEntry.Name = "lbEntry";
            this.lbEntry.Size = new System.Drawing.Size(110, 15);
            this.lbEntry.TabIndex = 6;
            this.lbEntry.Text = "참가자  , 키로 구분";
            // 
            // tbEntry
            // 
            this.tbEntry.Location = new System.Drawing.Point(13, 187);
            this.tbEntry.Multiline = true;
            this.tbEntry.Name = "tbEntry";
            this.tbEntry.Size = new System.Drawing.Size(993, 69);
            this.tbEntry.TabIndex = 7;
            this.tbEntry.TextChanged += new System.EventHandler(this.tbEntry_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "덱 결과";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "덱 생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(246, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(319, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/killkimno/CncRivalRandomDeckMaker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNod);
            this.groupBox1.Controls.Add(this.rbGDI);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(530, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "진영";
            // 
            // rbNod
            // 
            this.rbNod.AutoSize = true;
            this.rbNod.Location = new System.Drawing.Point(6, 72);
            this.rbNod.Name = "rbNod";
            this.rbNod.Size = new System.Drawing.Size(52, 19);
            this.rbNod.TabIndex = 2;
            this.rbNod.Text = "NOD";
            this.rbNod.UseVisualStyleBackColor = true;
            // 
            // rbGDI
            // 
            this.rbGDI.AutoSize = true;
            this.rbGDI.Location = new System.Drawing.Point(6, 47);
            this.rbGDI.Name = "rbGDI";
            this.rbGDI.Size = new System.Drawing.Size(45, 19);
            this.rbGDI.TabIndex = 1;
            this.rbGDI.Text = "GDI";
            this.rbGDI.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 22);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(77, 19);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "모두 가능";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Build : 2021/10/24 , 몽키해드";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEntry);
            this.Controls.Add(this.lbEntry);
            this.Controls.Add(this.compFixedInfanUnit);
            this.Controls.Add(this.compFixedTankUnit);
            this.Controls.Add(this.compFixedAirUnit);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "춫 라이벌 랜덤 덱 생성기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CompFixedUnit compFixedAirUnit;
        private CompFixedUnit compFixedTankUnit;
        private CompFixedUnit compFixedInfanUnit;
        private System.Windows.Forms.Label lbEntry;
        private System.Windows.Forms.TextBox tbEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNod;
        private System.Windows.Forms.RadioButton rbGDI;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label2;
    }
}

