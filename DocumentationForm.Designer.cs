namespace FinalProject
{
    partial class DocumentationForm
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
            btnOK = new Button();
            lblFilling = new Label();
            lblCurrFig = new Label();
            lblUndo = new Label();
            lblMove = new Label();
            lblDrawingDesc = new Label();
            lblFillingDesc = new Label();
            lblMoveDesc = new Label();
            lblUndoDesc = new Label();
            lblCurrFigDesc = new Label();
            lblDrawing = new Label();
            lblCalculation = new Label();
            lblSaveOpen = new Label();
            lblCalcInfo = new Label();
            lblSaveInfo = new Label();
            lblExport = new Label();
            lblExportInfo = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(398, 1002);
            btnOK.Margin = new Padding(4, 2, 4, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(212, 92);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblFilling
            // 
            lblFilling.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilling.Location = new Point(54, 186);
            lblFilling.Margin = new Padding(4, 0, 4, 0);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(197, 58);
            lblFilling.TabIndex = 2;
            lblFilling.Text = "Filling: ";
            // 
            // lblCurrFig
            // 
            lblCurrFig.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrFig.Location = new Point(54, 559);
            lblCurrFig.Margin = new Padding(4, 0, 4, 0);
            lblCurrFig.Name = "lblCurrFig";
            lblCurrFig.Size = new Size(310, 109);
            lblCurrFig.TabIndex = 3;
            lblCurrFig.Text = "Current Figure:";
            // 
            // lblUndo
            // 
            lblUndo.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblUndo.Location = new Point(54, 433);
            lblUndo.Margin = new Padding(4, 0, 4, 0);
            lblUndo.Name = "lblUndo";
            lblUndo.Size = new Size(256, 58);
            lblUndo.TabIndex = 4;
            lblUndo.Text = "Undo/Redo:";
            // 
            // lblMove
            // 
            lblMove.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblMove.Location = new Point(54, 314);
            lblMove.Margin = new Padding(4, 0, 4, 0);
            lblMove.Name = "lblMove";
            lblMove.Size = new Size(262, 58);
            lblMove.TabIndex = 5;
            lblMove.Text = "Move/Erase:";
            // 
            // lblDrawingDesc
            // 
            lblDrawingDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrawingDesc.Location = new Point(256, 51);
            lblDrawingDesc.Margin = new Padding(4, 0, 4, 0);
            lblDrawingDesc.Name = "lblDrawingDesc";
            lblDrawingDesc.Size = new Size(520, 92);
            lblDrawingDesc.TabIndex = 6;
            lblDrawingDesc.Text = "Choose shape and drag with the left click";
            // 
            // lblFillingDesc
            // 
            lblFillingDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFillingDesc.Location = new Point(256, 173);
            lblFillingDesc.Margin = new Padding(4, 0, 4, 0);
            lblFillingDesc.Name = "lblFillingDesc";
            lblFillingDesc.Size = new Size(520, 92);
            lblFillingDesc.TabIndex = 7;
            lblFillingDesc.Text = "Choose filling bucket and right click the figure";
            // 
            // lblMoveDesc
            // 
            lblMoveDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMoveDesc.Location = new Point(318, 290);
            lblMoveDesc.Margin = new Padding(4, 0, 4, 0);
            lblMoveDesc.Name = "lblMoveDesc";
            lblMoveDesc.Size = new Size(520, 107);
            lblMoveDesc.TabIndex = 8;
            lblMoveDesc.Text = "Choose Move/Eraser and click the figure with left click";
            // 
            // lblUndoDesc
            // 
            lblUndoDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUndoDesc.Location = new Point(318, 439);
            lblUndoDesc.Margin = new Padding(4, 0, 4, 0);
            lblUndoDesc.Name = "lblUndoDesc";
            lblUndoDesc.Size = new Size(520, 58);
            lblUndoDesc.TabIndex = 9;
            lblUndoDesc.Text = "Ctrl + Z / Ctrl + X";
            // 
            // lblCurrFigDesc
            // 
            lblCurrFigDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrFigDesc.Location = new Point(371, 559);
            lblCurrFigDesc.Margin = new Padding(4, 0, 4, 0);
            lblCurrFigDesc.Name = "lblCurrFigDesc";
            lblCurrFigDesc.Size = new Size(520, 92);
            lblCurrFigDesc.TabIndex = 10;
            lblCurrFigDesc.Text = "Click the figure with middle  mouse button";
            // 
            // lblDrawing
            // 
            lblDrawing.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrawing.Location = new Point(54, 60);
            lblDrawing.Margin = new Padding(4, 0, 4, 0);
            lblDrawing.Name = "lblDrawing";
            lblDrawing.Size = new Size(197, 58);
            lblDrawing.TabIndex = 1;
            lblDrawing.Text = "Drawing: ";
            // 
            // lblCalculation
            // 
            lblCalculation.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalculation.Location = new Point(54, 684);
            lblCalculation.Margin = new Padding(4, 0, 4, 0);
            lblCalculation.Name = "lblCalculation";
            lblCalculation.Size = new Size(310, 65);
            lblCalculation.TabIndex = 11;
            lblCalculation.Text = "Calculation:";
            // 
            // lblSaveOpen
            // 
            lblSaveOpen.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaveOpen.Location = new Point(54, 784);
            lblSaveOpen.Margin = new Padding(4, 0, 4, 0);
            lblSaveOpen.Name = "lblSaveOpen";
            lblSaveOpen.Size = new Size(310, 65);
            lblSaveOpen.TabIndex = 12;
            lblSaveOpen.Text = "Save As/Open:";
            // 
            // lblCalcInfo
            // 
            lblCalcInfo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalcInfo.Location = new Point(318, 684);
            lblCalcInfo.Margin = new Padding(4, 0, 4, 0);
            lblCalcInfo.Name = "lblCalcInfo";
            lblCalcInfo.Size = new Size(520, 65);
            lblCalcInfo.TabIndex = 13;
            lblCalcInfo.Text = "Ctrl + C";
            // 
            // lblSaveInfo
            // 
            lblSaveInfo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaveInfo.Location = new Point(371, 784);
            lblSaveInfo.Margin = new Padding(4, 0, 4, 0);
            lblSaveInfo.Name = "lblSaveInfo";
            lblSaveInfo.Size = new Size(520, 65);
            lblSaveInfo.TabIndex = 14;
            lblSaveInfo.Text = "Shift + Ctrl + S / Ctrl + O";
            // 
            // lblExport
            // 
            lblExport.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblExport.Location = new Point(54, 882);
            lblExport.Margin = new Padding(4, 0, 4, 0);
            lblExport.Name = "lblExport";
            lblExport.Size = new Size(310, 65);
            lblExport.TabIndex = 15;
            lblExport.Text = "Export:";
            // 
            // lblExportInfo
            // 
            lblExportInfo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExportInfo.Location = new Point(256, 866);
            lblExportInfo.Margin = new Padding(4, 0, 4, 0);
            lblExportInfo.Name = "lblExportInfo";
            lblExportInfo.Size = new Size(644, 95);
            lblExportInfo.TabIndex = 16;
            lblExportInfo.Text = "Select export and you can export your drawing in two formats .png and .jpeg";
            // 
            // DocumentationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1023, 1114);
            Controls.Add(lblExportInfo);
            Controls.Add(lblExport);
            Controls.Add(lblSaveInfo);
            Controls.Add(lblCalcInfo);
            Controls.Add(lblSaveOpen);
            Controls.Add(lblCalculation);
            Controls.Add(lblCurrFigDesc);
            Controls.Add(lblUndoDesc);
            Controls.Add(lblMoveDesc);
            Controls.Add(lblFillingDesc);
            Controls.Add(lblDrawingDesc);
            Controls.Add(lblMove);
            Controls.Add(lblUndo);
            Controls.Add(lblCurrFig);
            Controls.Add(lblFilling);
            Controls.Add(lblDrawing);
            Controls.Add(btnOK);
            Margin = new Padding(4, 2, 4, 2);
            Name = "DocumentationForm";
            Text = "Documentation";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Label lblFilling;
        private Label lblCurrFig;
        private Label lblUndo;
        private Label lblMove;
        private Label lblDrawingDesc;
        private Label lblFillingDesc;
        private Label lblMoveDesc;
        private Label lblUndoDesc;
        private Label lblCurrFigDesc;
        private Label lblDrawing;
        private Label lblCalculation;
        private Label lblSaveOpen;
        private Label lblCalcInfo;
        private Label lblSaveInfo;
        private Label lblExport;
        private Label lblExportInfo;
    }
}