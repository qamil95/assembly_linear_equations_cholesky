namespace MAIN
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chooseLibGroupBox = new System.Windows.Forms.GroupBox();
            this.cRadioButton = new System.Windows.Forms.RadioButton();
            this.asmRadioButton = new System.Windows.Forms.RadioButton();
            this.openMatrixButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.viewMatrixButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadedFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.computeMatrixButton = new System.Windows.Forms.Button();
            this.chooseLibGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(352, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // chooseLibGroupBox
            // 
            this.chooseLibGroupBox.Controls.Add(this.cRadioButton);
            this.chooseLibGroupBox.Controls.Add(this.asmRadioButton);
            this.chooseLibGroupBox.Location = new System.Drawing.Point(12, 41);
            this.chooseLibGroupBox.Name = "chooseLibGroupBox";
            this.chooseLibGroupBox.Size = new System.Drawing.Size(130, 67);
            this.chooseLibGroupBox.TabIndex = 5;
            this.chooseLibGroupBox.TabStop = false;
            this.chooseLibGroupBox.Text = "Wybierz bibliotekę";
            // 
            // cRadioButton
            // 
            this.cRadioButton.AutoSize = true;
            this.cRadioButton.Location = new System.Drawing.Point(7, 43);
            this.cRadioButton.Name = "cRadioButton";
            this.cRadioButton.Size = new System.Drawing.Size(87, 17);
            this.cRadioButton.TabIndex = 1;
            this.cRadioButton.Text = "odejmowanie";
            this.cRadioButton.UseVisualStyleBackColor = true;
            this.cRadioButton.CheckedChanged += new System.EventHandler(this.cRadioButton_CheckedChanged);
            // 
            // asmRadioButton
            // 
            this.asmRadioButton.AutoSize = true;
            this.asmRadioButton.Checked = true;
            this.asmRadioButton.Location = new System.Drawing.Point(7, 20);
            this.asmRadioButton.Name = "asmRadioButton";
            this.asmRadioButton.Size = new System.Drawing.Size(77, 17);
            this.asmRadioButton.TabIndex = 0;
            this.asmRadioButton.TabStop = true;
            this.asmRadioButton.Text = "dodawanie";
            this.asmRadioButton.UseVisualStyleBackColor = true;
            this.asmRadioButton.CheckedChanged += new System.EventHandler(this.asmRadioButton_CheckedChanged);
            // 
            // openMatrixButton
            // 
            this.openMatrixButton.Location = new System.Drawing.Point(12, 12);
            this.openMatrixButton.Name = "openMatrixButton";
            this.openMatrixButton.Size = new System.Drawing.Size(130, 23);
            this.openMatrixButton.TabIndex = 6;
            this.openMatrixButton.Text = "Otwórz macierz";
            this.openMatrixButton.UseVisualStyleBackColor = true;
            this.openMatrixButton.Click += new System.EventHandler(this.openMatrixButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "|*.txt";
            this.openFileDialog1.Title = "Otwórz macierz";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // viewMatrixButton
            // 
            this.viewMatrixButton.Enabled = false;
            this.viewMatrixButton.Location = new System.Drawing.Point(148, 12);
            this.viewMatrixButton.Name = "viewMatrixButton";
            this.viewMatrixButton.Size = new System.Drawing.Size(130, 23);
            this.viewMatrixButton.TabIndex = 7;
            this.viewMatrixButton.Text = "Podgląd macierzy";
            this.viewMatrixButton.UseVisualStyleBackColor = true;
            this.viewMatrixButton.Click += new System.EventHandler(this.viewMatrixButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadedFileStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loadedFileStatus
            // 
            this.loadedFileStatus.Name = "loadedFileStatus";
            this.loadedFileStatus.Size = new System.Drawing.Size(109, 17);
            this.loadedFileStatus.Text = "Wczytany plik: brak";
            // 
            // computeMatrixButton
            // 
            this.computeMatrixButton.Location = new System.Drawing.Point(149, 42);
            this.computeMatrixButton.Name = "computeMatrixButton";
            this.computeMatrixButton.Size = new System.Drawing.Size(129, 23);
            this.computeMatrixButton.TabIndex = 9;
            this.computeMatrixButton.Text = "Oblicz";
            this.computeMatrixButton.UseVisualStyleBackColor = true;
            this.computeMatrixButton.Click += new System.EventHandler(this.computeMatrixButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.computeMatrixButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.viewMatrixButton);
            this.Controls.Add(this.openMatrixButton);
            this.Controls.Add(this.chooseLibGroupBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.chooseLibGroupBox.ResumeLayout(false);
            this.chooseLibGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox chooseLibGroupBox;
        private System.Windows.Forms.RadioButton cRadioButton;
        private System.Windows.Forms.RadioButton asmRadioButton;
        private System.Windows.Forms.Button openMatrixButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button viewMatrixButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel loadedFileStatus;
        private System.Windows.Forms.Button computeMatrixButton;
    }
}

