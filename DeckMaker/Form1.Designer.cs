
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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // compFixedUnit1
            // 
            this.compFixedUnit1.Location = new System.Drawing.Point(13, 31);
            this.compFixedUnit1.Name = "compFixedUnit1";
            this.compFixedUnit1.Size = new System.Drawing.Size(150, 75);
            this.compFixedUnit1.TabIndex = 3;
            // 
            // compFixedUnit2
            // 
            this.compFixedUnit2.Location = new System.Drawing.Point(178, 31);
            this.compFixedUnit2.Name = "compFixedUnit2";
            this.compFixedUnit2.Size = new System.Drawing.Size(150, 75);
            this.compFixedUnit2.TabIndex = 4;
            // 
            // compFixedUnit3
            // 
            this.compFixedUnit3.Location = new System.Drawing.Point(334, 31);
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
            this.tbEntry.Size = new System.Drawing.Size(775, 69);
            this.tbEntry.TabIndex = 7;
            this.tbEntry.TextChanged += new System.EventHandler(this.tbEntry_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEntry);
            this.Controls.Add(this.lbEntry);
            this.Controls.Add(this.compFixedUnit3);
            this.Controls.Add(this.compFixedUnit2);
            this.Controls.Add(this.compFixedUnit1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

