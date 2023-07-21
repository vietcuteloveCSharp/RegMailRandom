namespace RegMailRandom
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
            this.Tittle = new System.Windows.Forms.Label();
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tittle.ForeColor = System.Drawing.Color.IndianRed;
            this.Tittle.Location = new System.Drawing.Point(213, 20);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(384, 45);
            this.Tittle.TabIndex = 0;
            this.Tittle.Text = "Tools Reg Mail Random";
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Location = new System.Drawing.Point(45, 127);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(94, 29);
            this.Btn_Reg.TabIndex = 1;
            this.Btn_Reg.Text = "Reg  Mail";
            this.Btn_Reg.UseVisualStyleBackColor = true;
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(45, 210);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(94, 29);
            this.Btn_Stop.TabIndex = 2;
            this.Btn_Stop.Text = " Dừng";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Reg);
            this.Controls.Add(this.Tittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Tittle;
        private Button Btn_Reg;
        private Button Btn_Stop;
    }
}