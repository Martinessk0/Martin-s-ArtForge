namespace FinalProject
{
    partial class CalculationForm
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
            lblName = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe Script", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ImeMode = ImeMode.NoControl;
            lblName.Location = new Point(179, 45);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(974, 111);
            lblName.TabIndex = 4;
            lblName.Text = "Calculation of all figures";
            // 
            // CalculationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1355, 1217);
            Controls.Add(lblName);
            Name = "CalculationForm";
            Text = "Calculation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
    }
}