namespace FinalProject
{
    partial class HistoryForm
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
            historyListBox = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // historyListBox
            // 
            historyListBox.Enabled = false;
            historyListBox.Location = new Point(107, 44);
            historyListBox.Multiline = true;
            historyListBox.Name = "historyListBox";
            historyListBox.ScrollBars = ScrollBars.Vertical;
            historyListBox.Size = new Size(964, 790);
            historyListBox.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(461, 886);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(239, 94);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1188, 1017);
            Controls.Add(btnOK);
            Controls.Add(historyListBox);
            Name = "HistoryForm";
            Text = "History";
            Load += HistoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox historyListBox;
        private Button btnOK;
    }
}