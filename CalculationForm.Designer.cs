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
            lblSameFillColor = new Label();
            lblCountSameFillColor = new Label();
            lblCountSameOutlineColor = new Label();
            lblSameOutlineColor = new Label();
            lblCountAllFigures = new Label();
            lblAllFigures = new Label();
            btnChooseColor = new Button();
            lblColor = new Label();
            btnCalculate = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe Script", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ImeMode = ImeMode.NoControl;
            lblName.Location = new Point(71, 44);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(974, 111);
            lblName.TabIndex = 4;
            lblName.Text = "Calculation of all figures";
            // 
            // lblSameFillColor
            // 
            lblSameFillColor.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblSameFillColor.Location = new Point(40, 219);
            lblSameFillColor.Margin = new Padding(4, 0, 4, 0);
            lblSameFillColor.Name = "lblSameFillColor";
            lblSameFillColor.Size = new Size(400, 97);
            lblSameFillColor.TabIndex = 5;
            lblSameFillColor.Text = "Count of figures with same fill color:";
            // 
            // lblCountSameFillColor
            // 
            lblCountSameFillColor.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountSameFillColor.Location = new Point(565, 219);
            lblCountSameFillColor.Margin = new Padding(4, 0, 4, 0);
            lblCountSameFillColor.Name = "lblCountSameFillColor";
            lblCountSameFillColor.Size = new Size(161, 97);
            lblCountSameFillColor.TabIndex = 6;
            // 
            // lblCountSameOutlineColor
            // 
            lblCountSameOutlineColor.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountSameOutlineColor.Location = new Point(565, 383);
            lblCountSameOutlineColor.Margin = new Padding(4, 0, 4, 0);
            lblCountSameOutlineColor.Name = "lblCountSameOutlineColor";
            lblCountSameOutlineColor.Size = new Size(161, 97);
            lblCountSameOutlineColor.TabIndex = 8;
            // 
            // lblSameOutlineColor
            // 
            lblSameOutlineColor.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblSameOutlineColor.Location = new Point(40, 383);
            lblSameOutlineColor.Margin = new Padding(4, 0, 4, 0);
            lblSameOutlineColor.Name = "lblSameOutlineColor";
            lblSameOutlineColor.Size = new Size(425, 97);
            lblSameOutlineColor.TabIndex = 7;
            lblSameOutlineColor.Text = "Count of figures with same outline color:";
            // 
            // lblCountAllFigures
            // 
            lblCountAllFigures.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountAllFigures.Location = new Point(565, 537);
            lblCountAllFigures.Margin = new Padding(4, 0, 4, 0);
            lblCountAllFigures.Name = "lblCountAllFigures";
            lblCountAllFigures.Size = new Size(161, 97);
            lblCountAllFigures.TabIndex = 10;
            // 
            // lblAllFigures
            // 
            lblAllFigures.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblAllFigures.Location = new Point(40, 537);
            lblAllFigures.Margin = new Padding(4, 0, 4, 0);
            lblAllFigures.Name = "lblAllFigures";
            lblAllFigures.Size = new Size(400, 97);
            lblAllFigures.TabIndex = 9;
            lblAllFigures.Text = "Count of all figures:";
            // 
            // btnChooseColor
            // 
            btnChooseColor.BackgroundImage = Properties.Resources.pickColorLogo;
            btnChooseColor.BackgroundImageLayout = ImageLayout.Stretch;
            btnChooseColor.Location = new Point(1338, 44);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(120, 110);
            btnChooseColor.TabIndex = 11;
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // lblColor
            // 
            lblColor.Location = new Point(1477, 44);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(120, 110);
            lblColor.TabIndex = 12;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(565, 1083);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(236, 105);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(851, 1083);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(236, 105);
            btnOK.TabIndex = 14;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // CalculationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1609, 1217);
            Controls.Add(btnOK);
            Controls.Add(btnCalculate);
            Controls.Add(lblColor);
            Controls.Add(btnChooseColor);
            Controls.Add(lblCountAllFigures);
            Controls.Add(lblAllFigures);
            Controls.Add(lblCountSameOutlineColor);
            Controls.Add(lblSameOutlineColor);
            Controls.Add(lblCountSameFillColor);
            Controls.Add(lblSameFillColor);
            Controls.Add(lblName);
            Name = "CalculationForm";
            Text = "Calculation";
            Load += CalculationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSameFillColor;
        private Label lblCountSameFillColor;
        private Label lblCountSameOutlineColor;
        private Label lblSameOutlineColor;
        private Label lblCountAllFigures;
        private Label lblAllFigures;
        private Button btnChooseColor;
        private Label lblColor;
        private Button btnCalculate;
        private Button btnOK;
    }
}