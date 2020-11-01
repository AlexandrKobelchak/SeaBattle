namespace SeaBattle
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.seaBattleField2 = new SeaLibrary.SeaBattleField();
            this.seaBattleField1 = new SeaLibrary.SeaBattleField();
            this.SuspendLayout();
            // 
            // seaBattleField2
            // 
            this.seaBattleField2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.seaBattleField2.Cursor = System.Windows.Forms.Cursors.No;
            this.seaBattleField2.Location = new System.Drawing.Point(378, 12);
            this.seaBattleField2.Name = "seaBattleField2";
            this.seaBattleField2.Size = new System.Drawing.Size(350, 350);
            this.seaBattleField2.TabIndex = 1;
            // 
            // seaBattleField1
            // 
            this.seaBattleField1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.seaBattleField1.IsMyShips = false;
            this.seaBattleField1.Location = new System.Drawing.Point(12, 12);
            this.seaBattleField1.Name = "seaBattleField1";
            this.seaBattleField1.Size = new System.Drawing.Size(350, 350);
            this.seaBattleField1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 384);
            this.Controls.Add(this.seaBattleField2);
            this.Controls.Add(this.seaBattleField1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SeaLibrary.SeaBattleField seaBattleField1;
        private SeaLibrary.SeaBattleField seaBattleField2;
    }
}

