namespace cursor_extravaganza
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMain = new System.Windows.Forms.Button();
            this.richTextBoxCursors = new System.Windows.Forms.RichTextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioGooGoo = new System.Windows.Forms.RadioButton();
            this.radioGaGa = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMain
            // 
            this.buttonMain.Location = new System.Drawing.Point(27, 12);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(112, 34);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Main";
            this.buttonMain.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCursors
            // 
            this.richTextBoxCursors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCursors.Location = new System.Drawing.Point(249, 12);
            this.richTextBoxCursors.Name = "richTextBoxCursors";
            this.richTextBoxCursors.Size = new System.Drawing.Size(317, 220);
            this.richTextBoxCursors.TabIndex = 1;
            this.richTextBoxCursors.Text = "";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioGooGoo);
            this.groupBox.Controls.Add(this.radioGaGa);
            this.groupBox.Location = new System.Drawing.Point(27, 75);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(190, 150);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Radio";
            // 
            // radioGooGoo
            // 
            this.radioGooGoo.AutoSize = true;
            this.radioGooGoo.Location = new System.Drawing.Point(31, 94);
            this.radioGooGoo.Name = "radioGooGoo";
            this.radioGooGoo.Size = new System.Drawing.Size(110, 29);
            this.radioGooGoo.TabIndex = 0;
            this.radioGooGoo.Text = "Goo Goo";
            this.radioGooGoo.UseVisualStyleBackColor = true;
            // 
            // radioGaGa
            // 
            this.radioGaGa.AutoSize = true;
            this.radioGaGa.Checked = true;
            this.radioGaGa.Location = new System.Drawing.Point(31, 43);
            this.radioGaGa.Name = "radioGaGa";
            this.radioGaGa.Size = new System.Drawing.Size(84, 29);
            this.radioGaGa.TabIndex = 0;
            this.radioGaGa.TabStop = true;
            this.radioGaGa.Text = "Ga Ga";
            this.radioGaGa.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 244);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.richTextBoxCursors);
            this.Controls.Add(this.buttonMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonMain;
        private RichTextBox richTextBoxCursors;
        private GroupBox groupBox;
        private RadioButton radioGooGoo;
        private RadioButton radioGaGa;
    }
}