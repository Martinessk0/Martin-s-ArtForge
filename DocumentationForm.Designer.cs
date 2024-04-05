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
            lblDrawing = new Label();
            lblFilling = new Label();
            lblArea = new Label();
            lblUndo = new Label();
            lblMove = new Label();
            lblDrawingDesc = new Label();
            lblFillingDesc = new Label();
            lblMoveDesc = new Label();
            lblUndoDesc = new Label();
            lblAreaDesc = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(414, 872);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(212, 92);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblDrawing
            // 
            lblDrawing.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrawing.Location = new Point(53, 60);
            lblDrawing.Name = "lblDrawing";
            lblDrawing.Size = new Size(197, 57);
            lblDrawing.TabIndex = 1;
            lblDrawing.Text = "Drawing: ";
            // 
            // lblFilling
            // 
            lblFilling.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblFilling.Location = new Point(53, 185);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(197, 57);
            lblFilling.TabIndex = 2;
            lblFilling.Text = "Filling: ";
            // 
            // lblArea
            // 
            lblArea.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblArea.Location = new Point(53, 559);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(197, 57);
            lblArea.TabIndex = 3;
            lblArea.Text = "Area:";
            // 
            // lblUndo
            // 
            lblUndo.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblUndo.Location = new Point(53, 434);
            lblUndo.Name = "lblUndo";
            lblUndo.Size = new Size(257, 57);
            lblUndo.TabIndex = 4;
            lblUndo.Text = "Undo/Redo:";
            // 
            // lblMove
            // 
            lblMove.Font = new Font("Verdana", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblMove.Location = new Point(53, 313);
            lblMove.Name = "lblMove";
            lblMove.Size = new Size(262, 57);
            lblMove.TabIndex = 5;
            lblMove.Text = "Move/Erase:";
            // 
            // lblDrawingDesc
            // 
            lblDrawingDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrawingDesc.Location = new Point(256, 51);
            lblDrawingDesc.Name = "lblDrawingDesc";
            lblDrawingDesc.Size = new Size(520, 92);
            lblDrawingDesc.TabIndex = 6;
            lblDrawingDesc.Text = "Choose shape and drag with the left click";
            // 
            // lblFillingDesc
            // 
            lblFillingDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFillingDesc.Location = new Point(256, 172);
            lblFillingDesc.Name = "lblFillingDesc";
            lblFillingDesc.Size = new Size(520, 92);
            lblFillingDesc.TabIndex = 7;
            lblFillingDesc.Text = "Choose filling bucket and right click the figure";
            // 
            // lblMoveDesc
            // 
            lblMoveDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMoveDesc.Location = new Point(321, 303);
            lblMoveDesc.Name = "lblMoveDesc";
            lblMoveDesc.Size = new Size(520, 92);
            lblMoveDesc.TabIndex = 8;
            lblMoveDesc.Text = "Choose Move/Eraser and click the figure with left click";
            // 
            // lblUndoDesc
            // 
            lblUndoDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUndoDesc.Location = new Point(316, 434);
            lblUndoDesc.Name = "lblUndoDesc";
            lblUndoDesc.Size = new Size(520, 57);
            lblUndoDesc.TabIndex = 9;
            lblUndoDesc.Text = "Ctrl + Z / Ctrl + X";
            // 
            // lblAreaDesc
            // 
            lblAreaDesc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAreaDesc.Location = new Point(178, 542);
            lblAreaDesc.Name = "lblAreaDesc";
            lblAreaDesc.Size = new Size(520, 92);
            lblAreaDesc.TabIndex = 10;
            lblAreaDesc.Text = "Click the figure with mouse middle button";
            // 
            // DocumentationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1023, 1004);
            Controls.Add(lblAreaDesc);
            Controls.Add(lblUndoDesc);
            Controls.Add(lblMoveDesc);
            Controls.Add(lblFillingDesc);
            Controls.Add(lblDrawingDesc);
            Controls.Add(lblMove);
            Controls.Add(lblUndo);
            Controls.Add(lblArea);
            Controls.Add(lblFilling);
            Controls.Add(lblDrawing);
            Controls.Add(btnOK);
            Name = "DocumentationForm";
            Text = "Documentation";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Label lblDrawing;
        private Label lblFilling;
        private Label lblArea;
        private Label lblUndo;
        private Label lblMove;
        private Label lblDrawingDesc;
        private Label lblFillingDesc;
        private Label lblMoveDesc;
        private Label lblUndoDesc;
        private Label lblAreaDesc;
    }
}