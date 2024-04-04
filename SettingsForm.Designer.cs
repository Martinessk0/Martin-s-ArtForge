namespace FinalProject
{
    partial class SettingsForm
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
            pickColor = new Button();
            SuspendLayout();
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
            pickColor.Location = new Point(329, 251);
            pickColor.Margin = new Padding(6);
            pickColor.Name = "pickColor";
            pickColor.Size = new Size(176, 186);
            pickColor.TabIndex = 4;
            pickColor.UseVisualStyleBackColor = false;
            pickColor.Click += pickColor_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 680);
            Controls.Add(pickColor);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pickColor;
    }
}