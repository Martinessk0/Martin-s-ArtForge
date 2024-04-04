namespace FinalProject
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
            btnSettings = new Button();
            btnEraser = new Button();
            button2 = new Button();
            button1 = new Button();
            btnMove = new Button();
            lblCurrColor = new Label();
            btnFill = new Button();
            label1 = new Label();
            logo = new Button();
            saveFileDialog1 = new SaveFileDialog();
            upperPanelLayout.SuspendLayout();
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
            upperPanelLayout.Controls.Add(btnSettings);
            upperPanelLayout.Controls.Add(btnEraser);
            upperPanelLayout.Controls.Add(button2);
            upperPanelLayout.Controls.Add(button1);
            upperPanelLayout.Controls.Add(btnMove);
            upperPanelLayout.Controls.Add(lblCurrColor);
            upperPanelLayout.Controls.Add(btnFill);
            upperPanelLayout.Controls.Add(label1);
            upperPanelLayout.Controls.Add(logo);
            resources.ApplyResources(upperPanelLayout, "upperPanelLayout");
            upperPanelLayout.Name = "upperPanelLayout";
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.BorderColor = Color.Cyan;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnSettings.ForeColor = Color.Transparent;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
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
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.Cyan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            button2.ForeColor = Color.Transparent;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.Cyan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            button1.ForeColor = Color.Transparent;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(mainLayout);
            Controls.Add(upperPanelLayout);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "MainForm";
            Load += MainForm_Load;
            upperPanelLayout.ResumeLayout(false);
            upperPanelLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainLayout;
        private ColorDialog colorDialog1;
        private Panel upperPanelLayout;
        private Button logo;
        private Label label1;
        private Button btnEraser;
        private Button btnFill;
        private Button btnMove;
        private Label lblCurrColor;
        private Button button2;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
        private Button btnSettings;
    }
}