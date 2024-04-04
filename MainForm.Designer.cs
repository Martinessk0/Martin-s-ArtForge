﻿namespace FinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainLayout = new Panel();
            colorDialog1 = new ColorDialog();
            upperPanelLayout = new Panel();
            lblCurrColor = new Label();
            btnFill = new Button();
            label1 = new Label();
            logo = new Button();
            pickColor = new Button();
            leftPanelLayout = new Panel();
            btnRectangular = new Button();
            btnCircle = new Button();
            btnMove = new Button();
            btnEraser = new Button();
            btnLine = new Button();
            btnSquare = new Button();
            label2 = new Label();
            upperPanelLayout.SuspendLayout();
            leftPanelLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.White;
            resources.ApplyResources(mainLayout, "mainLayout");
            mainLayout.Name = "mainLayout";
            mainLayout.Paint += mainLayout_Paint;
            mainLayout.MouseDown += mainPanel_MouseDown;
            mainLayout.MouseMove += mainLayout_MouseMove;
            mainLayout.MouseUp += mainPanel_MouseUp;
            // 
            // colorDialog1
            // 
            colorDialog1.ShowHelp = true;
            // 
            // upperPanelLayout
            // 
            upperPanelLayout.BackColor = Color.LightSeaGreen;
            upperPanelLayout.Controls.Add(lblCurrColor);
            upperPanelLayout.Controls.Add(btnFill);
            upperPanelLayout.Controls.Add(label1);
            upperPanelLayout.Controls.Add(logo);
            upperPanelLayout.Controls.Add(pickColor);
            resources.ApplyResources(upperPanelLayout, "upperPanelLayout");
            upperPanelLayout.Name = "upperPanelLayout";
            // 
            // lblCurrColor
            // 
            lblCurrColor.BackColor = Color.Transparent;
            resources.ApplyResources(lblCurrColor, "lblCurrColor");
            lblCurrColor.Name = "lblCurrColor";
            // 
            // btnFill
            // 
            resources.ApplyResources(btnFill, "btnFill");
            btnFill.BackColor = Color.Transparent;
            btnFill.BackgroundImage = Properties.Resources.fillBucket;
            btnFill.FlatAppearance.BorderColor = Color.Cyan;
            btnFill.FlatAppearance.BorderSize = 0;
            btnFill.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnFill.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnFill.ForeColor = Color.Transparent;
            btnFill.Name = "btnFill";
            btnFill.UseVisualStyleBackColor = false;
            btnFill.Click += btnFill_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.mainLogo;
            resources.ApplyResources(logo, "logo");
            logo.FlatAppearance.BorderSize = 0;
            logo.Name = "logo";
            logo.UseVisualStyleBackColor = false;
            // 
            // pickColor
            // 
            resources.ApplyResources(pickColor, "pickColor");
            pickColor.BackColor = Color.Transparent;
            pickColor.BackgroundImage = Properties.Resources.pickColorLogo;
            pickColor.FlatAppearance.BorderSize = 0;
            pickColor.ForeColor = Color.Transparent;
            pickColor.Name = "pickColor";
            pickColor.UseVisualStyleBackColor = false;
            pickColor.Click += pickColor_Click;
            // 
            // leftPanelLayout
            // 
            leftPanelLayout.BackColor = Color.SpringGreen;
            leftPanelLayout.Controls.Add(btnRectangular);
            leftPanelLayout.Controls.Add(btnCircle);
            leftPanelLayout.Controls.Add(btnMove);
            leftPanelLayout.Controls.Add(btnEraser);
            leftPanelLayout.Controls.Add(btnLine);
            leftPanelLayout.Controls.Add(btnSquare);
            leftPanelLayout.Controls.Add(label2);
            resources.ApplyResources(leftPanelLayout, "leftPanelLayout");
            leftPanelLayout.Name = "leftPanelLayout";
            // 
            // btnRectangular
            // 
            btnRectangular.BackColor = Color.Transparent;
            btnRectangular.BackgroundImage = Properties.Resources.rectangle;
            resources.ApplyResources(btnRectangular, "btnRectangular");
            btnRectangular.FlatAppearance.BorderColor = Color.Green;
            btnRectangular.FlatAppearance.BorderSize = 0;
            btnRectangular.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnRectangular.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnRectangular.Name = "btnRectangular";
            btnRectangular.UseVisualStyleBackColor = false;
            btnRectangular.Click += btnRectangular_Click;
            // 
            // btnCircle
            // 
            btnCircle.BackColor = Color.Transparent;
            btnCircle.BackgroundImage = Properties.Resources.circle;
            resources.ApplyResources(btnCircle, "btnCircle");
            btnCircle.FlatAppearance.BorderColor = Color.Green;
            btnCircle.FlatAppearance.BorderSize = 0;
            btnCircle.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnCircle.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnCircle.Name = "btnCircle";
            btnCircle.UseVisualStyleBackColor = false;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnMove
            // 
            btnMove.BackColor = Color.Transparent;
            btnMove.BackgroundImage = Properties.Resources.move;
            resources.ApplyResources(btnMove, "btnMove");
            btnMove.FlatAppearance.BorderColor = Color.Green;
            btnMove.FlatAppearance.BorderSize = 0;
            btnMove.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnMove.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMove.Name = "btnMove";
            btnMove.UseVisualStyleBackColor = false;
            btnMove.Click += btnMove_Click;
            // 
            // btnEraser
            // 
            btnEraser.BackColor = Color.Transparent;
            btnEraser.BackgroundImage = Properties.Resources.eraser;
            resources.ApplyResources(btnEraser, "btnEraser");
            btnEraser.FlatAppearance.BorderColor = Color.Green;
            btnEraser.FlatAppearance.BorderSize = 0;
            btnEraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnEraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnEraser.Name = "btnEraser";
            btnEraser.UseVisualStyleBackColor = false;
            btnEraser.Click += btnEraser_Click;
            // 
            // btnLine
            // 
            btnLine.BackColor = Color.Transparent;
            btnLine.BackgroundImage = Properties.Resources.line;
            resources.ApplyResources(btnLine, "btnLine");
            btnLine.FlatAppearance.BorderColor = Color.Green;
            btnLine.FlatAppearance.BorderSize = 0;
            btnLine.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnLine.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnLine.Name = "btnLine";
            btnLine.UseVisualStyleBackColor = false;
            btnLine.Click += btnLine_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.Transparent;
            btnSquare.BackgroundImage = Properties.Resources.Square;
            resources.ApplyResources(btnSquare, "btnSquare");
            btnSquare.FlatAppearance.BorderColor = Color.Green;
            btnSquare.FlatAppearance.BorderSize = 0;
            btnSquare.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnSquare.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnSquare.Name = "btnSquare";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(mainLayout);
            Controls.Add(leftPanelLayout);
            Controls.Add(upperPanelLayout);
            DoubleBuffered = true;
            Name = "MainForm";
            Load += MainForm_Load;
            upperPanelLayout.ResumeLayout(false);
            upperPanelLayout.PerformLayout();
            leftPanelLayout.ResumeLayout(false);
            leftPanelLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainLayout;
        private ColorDialog colorDialog1;
        private Panel upperPanelLayout;
        private Panel leftPanelLayout;
        private Button pickColor;
        private Button logo;
        private Label label1;
        private Button btnRectangular;
        private Label label2;
        private Button btnSquare;
        private Button btnLine;
        private Button btnEraser;
        private Button btnFill;
        private Button btnMove;
        private Button btnCircle;
        private Label lblCurrColor;
    }
}