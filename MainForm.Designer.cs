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
            lblCurrColor = new Label();
            btnFill = new Button();
            label1 = new Label();
            logo = new Button();
            pickColor = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            pngToolStripMenuItem = new ToolStripMenuItem();
            jpegToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            macrosToolStripMenuItem = new ToolStripMenuItem();
            documentationToolStripMenuItem = new ToolStripMenuItem();
            leftPanelLayout = new Panel();
            btnRectangular = new Button();
            btnEllipse = new Button();
            btnMove = new Button();
            btnEraser = new Button();
            btnLine = new Button();
            btnSquare = new Button();
            label2 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            upperPanelLayout.SuspendLayout();
            menuStrip1.SuspendLayout();
            leftPanelLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            resources.ApplyResources(mainLayout, "mainLayout");
            mainLayout.BackColor = Color.White;
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
            resources.ApplyResources(upperPanelLayout, "upperPanelLayout");
            upperPanelLayout.BackColor = Color.LightSeaGreen;
            upperPanelLayout.Controls.Add(lblCurrColor);
            upperPanelLayout.Controls.Add(btnFill);
            upperPanelLayout.Controls.Add(label1);
            upperPanelLayout.Controls.Add(logo);
            upperPanelLayout.Controls.Add(pickColor);
            upperPanelLayout.Controls.Add(menuStrip1);
            upperPanelLayout.Name = "upperPanelLayout";
            // 
            // lblCurrColor
            // 
            resources.ApplyResources(lblCurrColor, "lblCurrColor");
            lblCurrColor.BackColor = Color.Transparent;
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsToolStripMenuItem, openToolStripMenuItem, exportToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pngToolStripMenuItem, jpegToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            resources.ApplyResources(exportToolStripMenuItem, "exportToolStripMenuItem");
            // 
            // pngToolStripMenuItem
            // 
            pngToolStripMenuItem.Name = "pngToolStripMenuItem";
            resources.ApplyResources(pngToolStripMenuItem, "pngToolStripMenuItem");
            pngToolStripMenuItem.Click += pngToolStripMenuItem_Click;
            // 
            // jpegToolStripMenuItem
            // 
            jpegToolStripMenuItem.Name = "jpegToolStripMenuItem";
            resources.ApplyResources(jpegToolStripMenuItem, "jpegToolStripMenuItem");
            jpegToolStripMenuItem.Click += jpegToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, historyToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(undoToolStripMenuItem, "undoToolStripMenuItem");
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(redoToolStripMenuItem, "redoToolStripMenuItem");
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            resources.ApplyResources(historyToolStripMenuItem, "historyToolStripMenuItem");
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { macrosToolStripMenuItem, documentationToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // macrosToolStripMenuItem
            // 
            macrosToolStripMenuItem.Name = "macrosToolStripMenuItem";
            resources.ApplyResources(macrosToolStripMenuItem, "macrosToolStripMenuItem");
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            resources.ApplyResources(documentationToolStripMenuItem, "documentationToolStripMenuItem");
            documentationToolStripMenuItem.Click += documentationToolStripMenuItem_Click;
            // 
            // leftPanelLayout
            // 
            resources.ApplyResources(leftPanelLayout, "leftPanelLayout");
            leftPanelLayout.BackColor = Color.SpringGreen;
            leftPanelLayout.Controls.Add(btnRectangular);
            leftPanelLayout.Controls.Add(btnEllipse);
            leftPanelLayout.Controls.Add(btnMove);
            leftPanelLayout.Controls.Add(btnEraser);
            leftPanelLayout.Controls.Add(btnLine);
            leftPanelLayout.Controls.Add(btnSquare);
            leftPanelLayout.Controls.Add(label2);
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
            // btnEllipse
            // 
            btnEllipse.BackColor = Color.Transparent;
            btnEllipse.BackgroundImage = Properties.Resources.circle;
            resources.ApplyResources(btnEllipse, "btnEllipse");
            btnEllipse.FlatAppearance.BorderColor = Color.Green;
            btnEllipse.FlatAppearance.BorderSize = 0;
            btnEllipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnEllipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.UseVisualStyleBackColor = false;
            btnEllipse.Click += btnEllipse_Click;
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
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            upperPanelLayout.ResumeLayout(false);
            upperPanelLayout.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Button btnEllipse;
        private Label lblCurrColor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem macrosToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem pngToolStripMenuItem;
        private ToolStripMenuItem jpegToolStripMenuItem;
    }
}