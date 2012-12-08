namespace Factoring
{
    partial class Form1
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
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.formulaLabel = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.quadraticLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.quadraticRadio = new System.Windows.Forms.RadioButton();
            this.trinomialRadio = new System.Windows.Forms.RadioButton();
            this.noteLabel = new System.Windows.Forms.Label();
            this.graphBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aBox
            // 
            this.aBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aBox.Location = new System.Drawing.Point(32, 61);
            this.aBox.MaxLength = 7;
            this.aBox.Name = "aBox";
            this.aBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aBox.Size = new System.Drawing.Size(93, 20);
            this.aBox.TabIndex = 0;
            this.aBox.Text = "1";
            this.aBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abcBox_KeyPress);
            // 
            // bBox
            // 
            this.bBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bBox.Location = new System.Drawing.Point(32, 87);
            this.bBox.MaxLength = 7;
            this.bBox.Name = "bBox";
            this.bBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bBox.Size = new System.Drawing.Size(93, 20);
            this.bBox.TabIndex = 1;
            this.bBox.Text = "0";
            this.bBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abcBox_KeyPress);
            // 
            // formulaLabel
            // 
            this.formulaLabel.AutoSize = true;
            this.formulaLabel.Location = new System.Drawing.Point(29, 28);
            this.formulaLabel.Name = "formulaLabel";
            this.formulaLabel.Size = new System.Drawing.Size(71, 13);
            this.formulaLabel.TabIndex = 3;
            this.formulaLabel.Text = "ax^2 + bx + c";
            // 
            // cBox
            // 
            this.cBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cBox.Location = new System.Drawing.Point(32, 113);
            this.cBox.MaxLength = 7;
            this.cBox.Name = "cBox";
            this.cBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBox.Size = new System.Drawing.Size(93, 20);
            this.cBox.TabIndex = 2;
            this.cBox.Text = "0";
            this.cBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abcBox_KeyPress);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(32, 139);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 20);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(12, 168);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 13);
            this.answerLabel.TabIndex = 6;
            // 
            // quadraticLabel
            // 
            this.quadraticLabel.AutoSize = true;
            this.quadraticLabel.Location = new System.Drawing.Point(9, 28);
            this.quadraticLabel.Name = "quadraticLabel";
            this.quadraticLabel.Size = new System.Drawing.Size(21, 13);
            this.quadraticLabel.TabIndex = 8;
            this.quadraticLabel.Text = "y =";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(9, 63);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(16, 13);
            this.aLabel.TabIndex = 9;
            this.aLabel.Text = "a:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(9, 89);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(16, 13);
            this.bLabel.TabIndex = 10;
            this.bLabel.Text = "b:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(9, 115);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(16, 13);
            this.cLabel.TabIndex = 11;
            this.cLabel.Text = "c:";
            // 
            // quadraticRadio
            // 
            this.quadraticRadio.AutoSize = true;
            this.quadraticRadio.Checked = true;
            this.quadraticRadio.Location = new System.Drawing.Point(106, 26);
            this.quadraticRadio.Name = "quadraticRadio";
            this.quadraticRadio.Size = new System.Drawing.Size(71, 17);
            this.quadraticRadio.TabIndex = 12;
            this.quadraticRadio.TabStop = true;
            this.quadraticRadio.Text = "Quadratic";
            this.quadraticRadio.UseVisualStyleBackColor = true;
            this.quadraticRadio.CheckedChanged += new System.EventHandler(this.quadraticRadio_CheckedChanged);
            // 
            // trinomialRadio
            // 
            this.trinomialRadio.AutoSize = true;
            this.trinomialRadio.Location = new System.Drawing.Point(183, 26);
            this.trinomialRadio.Name = "trinomialRadio";
            this.trinomialRadio.Size = new System.Drawing.Size(67, 17);
            this.trinomialRadio.TabIndex = 13;
            this.trinomialRadio.TabStop = true;
            this.trinomialRadio.Text = "Trinomial";
            this.trinomialRadio.UseVisualStyleBackColor = true;
            this.trinomialRadio.CheckedChanged += new System.EventHandler(this.trinomialRadio_CheckedChanged);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.BackColor = System.Drawing.SystemColors.Window;
            this.noteLabel.Location = new System.Drawing.Point(9, 9);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(238, 13);
            this.noteLabel.TabIndex = 14;
            this.noteLabel.Text = "Note: Check for common factors before and after";
            // 
            // graphBox
            // 
            this.graphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphBox.Location = new System.Drawing.Point(150, 59);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(100, 100);
            this.graphBox.TabIndex = 16;
            this.graphBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(265, 261);
            this.Controls.Add(this.graphBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.trinomialRadio);
            this.Controls.Add(this.quadraticRadio);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.quadraticLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.formulaLabel);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Quadratic and Factoring Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Label formulaLabel;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label quadraticLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.RadioButton quadraticRadio;
        private System.Windows.Forms.RadioButton trinomialRadio;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.PictureBox graphBox;
    }
}

