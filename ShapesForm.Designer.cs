namespace FinalProject
{
    partial class ShapesForm
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
            btnRectangular = new Button();
            btnCircle = new Button();
            btnLine = new Button();
            btnSquare = new Button();
            btnClose = new Button();
            label2 = new Label();
            lblColor = new Label();
            pickColor = new Button();
            SuspendLayout();
            // 
            // btnRectangular
            // 
            btnRectangular.BackColor = Color.Transparent;
            btnRectangular.BackgroundImage = Properties.Resources.rectangle;
            btnRectangular.BackgroundImageLayout = ImageLayout.Stretch;
            btnRectangular.FlatAppearance.BorderColor = Color.Green;
            btnRectangular.FlatAppearance.BorderSize = 0;
            btnRectangular.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnRectangular.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnRectangular.FlatStyle = FlatStyle.Flat;
            btnRectangular.ImeMode = ImeMode.NoControl;
            btnRectangular.Location = new Point(45, 199);
            btnRectangular.Margin = new Padding(6);
            btnRectangular.Name = "btnRectangular";
            btnRectangular.Size = new Size(240, 130);
            btnRectangular.TabIndex = 7;
            btnRectangular.UseVisualStyleBackColor = false;
            btnRectangular.Click += btnRectangular_Click;
            // 
            // btnCircle
            // 
            btnCircle.BackColor = Color.Transparent;
            btnCircle.BackgroundImage = Properties.Resources.circle;
            btnCircle.BackgroundImageLayout = ImageLayout.Zoom;
            btnCircle.FlatAppearance.BorderColor = Color.Green;
            btnCircle.FlatAppearance.BorderSize = 0;
            btnCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnCircle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnCircle.FlatStyle = FlatStyle.Flat;
            btnCircle.ImeMode = ImeMode.NoControl;
            btnCircle.Location = new Point(357, 412);
            btnCircle.Margin = new Padding(6);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(240, 130);
            btnCircle.TabIndex = 10;
            btnCircle.UseVisualStyleBackColor = false;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnLine
            // 
            btnLine.BackColor = Color.Transparent;
            btnLine.BackgroundImage = Properties.Resources.line;
            btnLine.BackgroundImageLayout = ImageLayout.Zoom;
            btnLine.FlatAppearance.BorderColor = Color.Green;
            btnLine.FlatAppearance.BorderSize = 0;
            btnLine.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnLine.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnLine.FlatStyle = FlatStyle.Flat;
            btnLine.ImeMode = ImeMode.NoControl;
            btnLine.Location = new Point(45, 412);
            btnLine.Margin = new Padding(6);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(240, 130);
            btnLine.TabIndex = 9;
            btnLine.UseVisualStyleBackColor = false;
            btnLine.Click += btnLine_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.Transparent;
            btnSquare.BackgroundImage = Properties.Resources.Square;
            btnSquare.BackgroundImageLayout = ImageLayout.Zoom;
            btnSquare.FlatAppearance.BorderColor = Color.Green;
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnSquare.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.ImeMode = ImeMode.NoControl;
            btnSquare.Location = new Point(357, 199);
            btnSquare.Margin = new Padding(6);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(240, 130);
            btnSquare.TabIndex = 8;
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(391, 652);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(244, 126);
            btnClose.TabIndex = 11;
            btnClose.Text = "OK";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(251, 48);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(256, 60);
            label2.TabIndex = 12;
            label2.Text = "Pick figure:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe Script", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblColor.ImeMode = ImeMode.NoControl;
            lblColor.Location = new Point(817, 48);
            lblColor.Margin = new Padding(6, 0, 6, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(243, 60);
            lblColor.TabIndex = 13;
            lblColor.Text = "Pick color:";
            // 
            // pickColor
            // 
            pickColor.AutoSize = true;
            pickColor.BackColor = Color.Transparent;
            pickColor.BackgroundImage = Properties.Resources.pickColorLogo;
            pickColor.BackgroundImageLayout = ImageLayout.Zoom;
            pickColor.FlatAppearance.BorderSize = 0;
            pickColor.FlatStyle = FlatStyle.Flat;
            pickColor.ForeColor = Color.Transparent;
            pickColor.ImeMode = ImeMode.NoControl;
            pickColor.Location = new Point(856, 267);
            pickColor.Margin = new Padding(6);
            pickColor.Name = "pickColor";
            pickColor.Size = new Size(176, 186);
            pickColor.TabIndex = 14;
            pickColor.UseVisualStyleBackColor = false;
            pickColor.Click += pickColor_Click;
            // 
            // ShapesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1133, 807);
            Controls.Add(pickColor);
            Controls.Add(lblColor);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnRectangular);
            Controls.Add(btnCircle);
            Controls.Add(btnLine);
            Controls.Add(btnSquare);
            Name = "ShapesForm";
            Text = "ShapesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRectangular;
        private Button btnCircle;
        private Button btnLine;
        private Button btnSquare;
        private Button btnClose;
        private Label label2;
        private Label lblColor;
        private Button pickColor;
    }
}