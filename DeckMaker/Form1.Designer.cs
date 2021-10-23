
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
            this.compFixedUnit1 = new DeckMaker.CompFixedUnit();
            this.compFixedUnit2 = new DeckMaker.CompFixedUnit();
            this.compFixedUnit3 = new DeckMaker.CompFixedUnit();
            this.lbEntry = new System.Windows.Forms.Label();
            this.tbEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Beige;
            this.richTextBox1.Location = new System.Drawing.Point(12, 312);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(994, 149);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // compFixedUnit1
            // 
            this.compFixedUnit1.Location = new System.Drawing.Point(13, 63);
            this.compFixedUnit1.Name = "compFixedUnit1";
            this.compFixedUnit1.Size = new System.Drawing.Size(150, 75);
            this.compFixedUnit1.TabIndex = 3;
            // 
            // compFixedUnit2
            // 
            this.compFixedUnit2.Location = new System.Drawing.Point(178, 63);
            this.compFixedUnit2.Name = "compFixedUnit2";
            this.compFixedUnit2.Size = new System.Drawing.Size(150, 75);
            this.compFixedUnit2.TabIndex = 4;
            // 
            // compFixedUnit3
            // 
            this.compFixedUnit3.Location = new System.Drawing.Point(334, 63);
            this.compFixedUnit3.Name = "compFixedUnit3";
            this.compFixedUnit3.Size = new System.Drawing.Size(150, 75);
            this.compFixedUnit3.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(216, 500);
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
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(530, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "진영";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "NOD";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "GDI";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "모두 가능";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEntry);
            this.Controls.Add(this.lbEntry);
            this.Controls.Add(this.compFixedUnit3);
            this.Controls.Add(this.compFixedUnit2);
            this.Controls.Add(this.compFixedUnit1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CompFixedUnit compFixedUnit1;
        private CompFixedUnit compFixedUnit2;
        private CompFixedUnit compFixedUnit3;
        private System.Windows.Forms.Label lbEntry;
        private System.Windows.Forms.TextBox tbEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

