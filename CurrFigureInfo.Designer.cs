namespace FinalProject
{
    partial class CurrFigureInfo
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
            lblWidth = new Label();
            lblName = new Label();
            lblHeight = new Label();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            lblArea = new Label();
            txtArea = new TextBox();
            btnOK = new Button();
            btnChange = new Button();
            lblOutline = new Label();
            lblFill = new Label();
            colorDialog1 = new ColorDialog();
            btnColorOutline = new Button();
            btnColorFill = new Button();
            lblOutlineColor = new Label();
            lblFillColor = new Label();
            SuspendLayout();
            // 
            // lblWidth
            // 
            lblWidth.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblWidth.Location = new Point(25, 103);
            lblWidth.Margin = new Padding(2, 0, 2, 0);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(106, 27);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Width:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe Script", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ImeMode = ImeMode.NoControl;
            lblName.Location = new Point(261, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 55);
            lblName.TabIndex = 3;
            // 
            // lblHeight
            // 
            lblHeight.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeight.Location = new Point(25, 163);
            lblHeight.Margin = new Padding(2, 0, 2, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(106, 27);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Height:";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(126, 92);
            txtWidth.Multiline = true;
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(183, 38);
            txtWidth.TabIndex = 5;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(126, 152);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(183, 38);
            txtHeight.TabIndex = 6;
            // 
            // lblArea
            // 
            lblArea.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblArea.Location = new Point(25, 226);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(106, 27);
            lblArea.TabIndex = 7;
            lblArea.Text = "Area:";
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(126, 215);
            txtArea.Multiline = true;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(183, 38);
            txtArea.TabIndex = 8;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(261, 512);
            btnOK.Margin = new Padding(2, 1, 2, 1);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(129, 44);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(499, 226);
            btnChange.Margin = new Padding(2, 1, 2, 1);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(129, 38);
            btnChange.TabIndex = 10;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnResize_Click;
            // 
            // lblOutline
            // 
            lblOutline.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutline.Location = new Point(25, 287);
            lblOutline.Margin = new Padding(2, 0, 2, 0);
            lblOutline.Name = "lblOutline";
            lblOutline.Size = new Size(88, 27);
            lblOutline.TabIndex = 11;
            lblOutline.Text = "Outline:";
            // 
            // lblFill
            // 
            lblFill.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblFill.Location = new Point(25, 351);
            lblFill.Margin = new Padding(2, 0, 2, 0);
            lblFill.Name = "lblFill";
            lblFill.Size = new Size(106, 27);
            lblFill.TabIndex = 12;
            lblFill.Text = "Fill:";
            // 
            // btnColorOutline
            // 
            btnColorOutline.Location = new Point(126, 282);
            btnColorOutline.Name = "btnColorOutline";
            btnColorOutline.Size = new Size(135, 43);
            btnColorOutline.TabIndex = 13;
            btnColorOutline.Text = "Change Color";
            btnColorOutline.UseVisualStyleBackColor = true;
            btnColorOutline.Click += btnColorOutline_Click;
            // 
            // btnColorFill
            // 
            btnColorFill.Location = new Point(126, 343);
            btnColorFill.Name = "btnColorFill";
            btnColorFill.Size = new Size(135, 43);
            btnColorFill.TabIndex = 14;
            btnColorFill.Text = "Change Color";
            btnColorFill.UseVisualStyleBackColor = true;
            btnColorFill.Click += btnColorFill_Click;
            // 
            // lblOutlineColor
            // 
            lblOutlineColor.Location = new Point(261, 282);
            lblOutlineColor.Name = "lblOutlineColor";
            lblOutlineColor.Size = new Size(48, 43);
            lblOutlineColor.TabIndex = 15;
            // 
            // lblFillColor
            // 
            lblFillColor.Location = new Point(261, 343);
            lblFillColor.Name = "lblFillColor";
            lblFillColor.Size = new Size(48, 43);
            lblFillColor.TabIndex = 16;
            // 
            // CurrFigureInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(653, 566);
            Controls.Add(lblFillColor);
            Controls.Add(lblOutlineColor);
            Controls.Add(btnColorFill);
            Controls.Add(btnColorOutline);
            Controls.Add(lblFill);
            Controls.Add(lblOutline);
            Controls.Add(btnChange);
            Controls.Add(btnOK);
            Controls.Add(txtArea);
            Controls.Add(lblArea);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(lblHeight);
            Controls.Add(lblName);
            Controls.Add(lblWidth);
            Name = "CurrFigureInfo";
            Text = "Current Figure Information";
            Load += CurrFigureInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWidth;
        private Label lblName;
        private Label lblHeight;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Label lblArea;
        private TextBox txtArea;
        private Button btnOK;
        private Button btnChange;
        private Label lblOutline;
        private Label lblFill;
        private ColorDialog colorDialog1;
        private Button btnColorOutline;
        private Button btnColorFill;
        private Label lblOutlineColor;
        private Label lblFillColor;
    }
}