namespace SeaLibrary
{
    partial class SeaBattleField
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SeaBattleField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DoubleBuffered = true;
            this.Name = "SeaBattleField";
            this.Size = new System.Drawing.Size(307, 299);            
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SeaBattleField_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SeaBattleField_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
