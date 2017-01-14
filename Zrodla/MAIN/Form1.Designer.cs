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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // chooseLibGroupBox
            // 
            this.chooseLibGroupBox.Controls.Add(this.cRadioButton);
            this.chooseLibGroupBox.Controls.Add(this.asmRadioButton);
            resources.ApplyResources(this.chooseLibGroupBox, "chooseLibGroupBox");
            this.chooseLibGroupBox.Name = "chooseLibGroupBox";
            this.chooseLibGroupBox.TabStop = false;
            // 
            // cRadioButton
            // 
            resources.ApplyResources(this.cRadioButton, "cRadioButton");
            this.cRadioButton.Name = "cRadioButton";
            this.cRadioButton.UseVisualStyleBackColor = true;
            this.cRadioButton.CheckedChanged += new System.EventHandler(this.cRadioButton_CheckedChanged);
            // 
            // asmRadioButton
            // 
            resources.ApplyResources(this.asmRadioButton, "asmRadioButton");
            this.asmRadioButton.Checked = true;
            this.asmRadioButton.Name = "asmRadioButton";
            this.asmRadioButton.TabStop = true;
            this.asmRadioButton.UseVisualStyleBackColor = true;
            this.asmRadioButton.CheckedChanged += new System.EventHandler(this.asmRadioButton_CheckedChanged);
            // 
            // openMatrixButton
            // 
            resources.ApplyResources(this.openMatrixButton, "openMatrixButton");
            this.openMatrixButton.Name = "openMatrixButton";
            this.openMatrixButton.UseVisualStyleBackColor = true;
            this.openMatrixButton.Click += new System.EventHandler(this.openMatrixButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // viewMatrixButton
            // 
            resources.ApplyResources(this.viewMatrixButton, "viewMatrixButton");
            this.viewMatrixButton.Name = "viewMatrixButton";
            this.viewMatrixButton.UseVisualStyleBackColor = true;
            this.viewMatrixButton.Click += new System.EventHandler(this.viewMatrixButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadedFileStatus});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // loadedFileStatus
            // 
            this.loadedFileStatus.Name = "loadedFileStatus";
            resources.ApplyResources(this.loadedFileStatus, "loadedFileStatus");
            // 
            // computeMatrixButton
            // 
            resources.ApplyResources(this.computeMatrixButton, "computeMatrixButton");
            this.computeMatrixButton.Name = "computeMatrixButton";
            this.computeMatrixButton.UseVisualStyleBackColor = true;
            this.computeMatrixButton.Click += new System.EventHandler(this.computeMatrixButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.computeMatrixButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.viewMatrixButton);
            this.Controls.Add(this.openMatrixButton);
            this.Controls.Add(this.chooseLibGroupBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
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

