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
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(223, 409);
            btnOK.Margin = new Padding(2, 1, 2, 1);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(114, 43);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblFilling
            // 
            lblFilling.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilling.Location = new Point(29, 87);
            lblFilling.Margin = new Padding(2, 0, 2, 0);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(106, 27);
            lblFilling.TabIndex = 2;
            lblFilling.Text = "Filling: ";
            // 
            // lblCurrFig
            // 
            lblCurrFig.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrFig.Location = new Point(29, 262);
            lblCurrFig.Margin = new Padding(2, 0, 2, 0);
            lblCurrFig.Name = "lblCurrFig";
            lblCurrFig.Size = new Size(167, 51);
            lblCurrFig.TabIndex = 3;
            lblCurrFig.Text = "Current Figure:";
            // 
            // lblUndo
            // 
            lblUndo.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblUndo.Location = new Point(29, 203);
            lblUndo.Margin = new Padding(2, 0, 2, 0);
            lblUndo.Name = "lblUndo";
            lblUndo.Size = new Size(138, 27);
            lblUndo.TabIndex = 4;
            lblUndo.Text = "Undo/Redo:";
            // 
            // lblMove
            // 
            lblMove.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblMove.Location = new Point(29, 147);
            lblMove.Margin = new Padding(2, 0, 2, 0);
            lblMove.Name = "lblMove";
            lblMove.Size = new Size(141, 27);
            lblMove.TabIndex = 5;
            lblMove.Text = "Move/Erase:";
            // 
            // lblDrawingDesc
            // 
            lblDrawingDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrawingDesc.Location = new Point(138, 24);
            lblDrawingDesc.Margin = new Padding(2, 0, 2, 0);
            lblDrawingDesc.Name = "lblDrawingDesc";
            lblDrawingDesc.Size = new Size(280, 43);
            lblDrawingDesc.TabIndex = 6;
            lblDrawingDesc.Text = "Choose shape and drag with the left click";
            // 
            // lblFillingDesc
            // 
            lblFillingDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFillingDesc.Location = new Point(138, 81);
            lblFillingDesc.Margin = new Padding(2, 0, 2, 0);
            lblFillingDesc.Name = "lblFillingDesc";
            lblFillingDesc.Size = new Size(280, 43);
            lblFillingDesc.TabIndex = 7;
            lblFillingDesc.Text = "Choose filling bucket and right click the figure";
            // 
            // lblMoveDesc
            // 
            lblMoveDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMoveDesc.Location = new Point(171, 136);
            lblMoveDesc.Margin = new Padding(2, 0, 2, 0);
            lblMoveDesc.Name = "lblMoveDesc";
            lblMoveDesc.Size = new Size(280, 50);
            lblMoveDesc.TabIndex = 8;
            lblMoveDesc.Text = "Choose Move/Eraser and click the figure with left click";
            // 
            // lblUndoDesc
            // 
            lblUndoDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUndoDesc.Location = new Point(171, 206);
            lblUndoDesc.Margin = new Padding(2, 0, 2, 0);
            lblUndoDesc.Name = "lblUndoDesc";
            lblUndoDesc.Size = new Size(280, 27);
            lblUndoDesc.TabIndex = 9;
            lblUndoDesc.Text = "Ctrl + Z / Ctrl + X";
            // 
            // lblCurrFigDesc
            // 
            lblCurrFigDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrFigDesc.Location = new Point(200, 262);
            lblCurrFigDesc.Margin = new Padding(2, 0, 2, 0);
            lblCurrFigDesc.Name = "lblCurrFigDesc";
            lblCurrFigDesc.Size = new Size(280, 43);
            lblCurrFigDesc.TabIndex = 10;
            lblCurrFigDesc.Text = "Click the figure with middle  mouse button";
            // 
            // lblDrawing
            // 
            lblDrawing.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrawing.Location = new Point(29, 28);
            lblDrawing.Margin = new Padding(2, 0, 2, 0);
            lblDrawing.Name = "lblDrawing";
            lblDrawing.Size = new Size(106, 27);
            lblDrawing.TabIndex = 1;
            lblDrawing.Text = "Drawing: ";
            // 
            // DocumentationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(551, 471);
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
            Margin = new Padding(2, 1, 2, 1);
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
    }
}