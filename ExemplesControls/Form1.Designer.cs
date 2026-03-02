namespace ExemplesControls
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
            trackBar1 = new TrackBar();
            colorDialog1 = new ColorDialog();
            btnCanviarColorFons = new Button();
            lblNivellVolum = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 20;
            trackBar1.Location = new Point(50, 50);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(200, 45);
            trackBar1.SmallChange = 5;
            trackBar1.TabIndex = 0;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // colorDialog1
            // 
            colorDialog1.ShowHelp = true;
            // 
            // btnCanviarColorFons
            // 
            btnCanviarColorFons.Location = new Point(50, 110);
            btnCanviarColorFons.Name = "btnCanviarColorFons";
            btnCanviarColorFons.Size = new Size(200, 40);
            btnCanviarColorFons.TabIndex = 1;
            btnCanviarColorFons.Text = "Canviar Fons (ColorDialog)";
            btnCanviarColorFons.UseVisualStyleBackColor = true;
            btnCanviarColorFons.Click += btnCanviarColorFons_Click;
            // 
            // lblNivellVolum
            // 
            lblNivellVolum.AutoSize = true;
            lblNivellVolum.Location = new Point(260, 55);
            lblNivellVolum.Name = "lblNivellVolum";
            lblNivellVolum.Size = new Size(69, 15);
            lblNivellVolum.TabIndex = 2;
            lblNivellVolum.Text = "Volum: 50%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 180);
            Controls.Add(lblNivellVolum);
            Controls.Add(btnCanviarColorFons);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Exemples Controls - Joan del Tio";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCanviarColorFons;
        private System.Windows.Forms.Label lblNivellVolum;
    }
}
