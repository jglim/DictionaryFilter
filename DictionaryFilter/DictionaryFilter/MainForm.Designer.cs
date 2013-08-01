namespace DictionaryFilter
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
            this.txtCharset = new System.Windows.Forms.TextBox();
            this.lblDescCharset = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.lblDescInputfile = new System.Windows.Forms.Label();
            this.txtFrontFilter = new System.Windows.Forms.TextBox();
            this.lblDescFrontfilter = new System.Windows.Forms.Label();
            this.txtLimitLength = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnSetInputFile = new System.Windows.Forms.Button();
            this.btnSetOutputFile = new System.Windows.Forms.Button();
            this.gbOutputFormatting = new System.Windows.Forms.GroupBox();
            this.cbOriginal = new System.Windows.Forms.CheckBox();
            this.cbUppercase = new System.Windows.Forms.CheckBox();
            this.cbLowercase = new System.Windows.Forms.CheckBox();
            this.cbProperCase = new System.Windows.Forms.CheckBox();
            this.cbUnique = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.gbOutputFormatting.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCharset
            // 
            this.txtCharset.Location = new System.Drawing.Point(144, 12);
            this.txtCharset.Name = "txtCharset";
            this.txtCharset.Size = new System.Drawing.Size(453, 20);
            this.txtCharset.TabIndex = 0;
            this.txtCharset.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // lblDescCharset
            // 
            this.lblDescCharset.AutoSize = true;
            this.lblDescCharset.Location = new System.Drawing.Point(12, 15);
            this.lblDescCharset.Name = "lblDescCharset";
            this.lblDescCharset.Size = new System.Drawing.Size(97, 13);
            this.lblDescCharset.TabIndex = 1;
            this.lblDescCharset.Text = "Character Set Filter";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Enabled = false;
            this.txtInputFile.Location = new System.Drawing.Point(144, 38);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(372, 20);
            this.txtInputFile.TabIndex = 2;
            // 
            // lblDescInputfile
            // 
            this.lblDescInputfile.AutoSize = true;
            this.lblDescInputfile.Location = new System.Drawing.Point(12, 41);
            this.lblDescInputfile.Name = "lblDescInputfile";
            this.lblDescInputfile.Size = new System.Drawing.Size(81, 13);
            this.lblDescInputfile.TabIndex = 3;
            this.lblDescInputfile.Text = "Input Dictionary";
            // 
            // txtFrontFilter
            // 
            this.txtFrontFilter.Location = new System.Drawing.Point(144, 90);
            this.txtFrontFilter.Name = "txtFrontFilter";
            this.txtFrontFilter.Size = new System.Drawing.Size(453, 20);
            this.txtFrontFilter.TabIndex = 4;
            // 
            // lblDescFrontfilter
            // 
            this.lblDescFrontfilter.AutoSize = true;
            this.lblDescFrontfilter.Location = new System.Drawing.Point(12, 93);
            this.lblDescFrontfilter.Name = "lblDescFrontfilter";
            this.lblDescFrontfilter.Size = new System.Drawing.Size(121, 13);
            this.lblDescFrontfilter.TabIndex = 5;
            this.lblDescFrontfilter.Text = "Front Filter (blank: none)";
            // 
            // txtLimitLength
            // 
            this.txtLimitLength.Location = new System.Drawing.Point(144, 116);
            this.txtLimitLength.Name = "txtLimitLength";
            this.txtLimitLength.Size = new System.Drawing.Size(453, 20);
            this.txtLimitLength.TabIndex = 6;
            this.txtLimitLength.Text = "8";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 119);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(129, 13);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Length Limit (blank: none)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output Dictionary";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Enabled = false;
            this.txtOutputFile.Location = new System.Drawing.Point(144, 64);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(372, 20);
            this.txtOutputFile.TabIndex = 8;
            // 
            // btnSetInputFile
            // 
            this.btnSetInputFile.Location = new System.Drawing.Point(522, 36);
            this.btnSetInputFile.Name = "btnSetInputFile";
            this.btnSetInputFile.Size = new System.Drawing.Size(75, 23);
            this.btnSetInputFile.TabIndex = 10;
            this.btnSetInputFile.Text = "Browse";
            this.btnSetInputFile.UseVisualStyleBackColor = true;
            this.btnSetInputFile.Click += new System.EventHandler(this.btnSetInputFile_Click);
            // 
            // btnSetOutputFile
            // 
            this.btnSetOutputFile.Location = new System.Drawing.Point(522, 62);
            this.btnSetOutputFile.Name = "btnSetOutputFile";
            this.btnSetOutputFile.Size = new System.Drawing.Size(75, 23);
            this.btnSetOutputFile.TabIndex = 11;
            this.btnSetOutputFile.Text = "Browse";
            this.btnSetOutputFile.UseVisualStyleBackColor = true;
            this.btnSetOutputFile.Click += new System.EventHandler(this.btnSetOutputFile_Click);
            // 
            // gbOutputFormatting
            // 
            this.gbOutputFormatting.Controls.Add(this.cbUnique);
            this.gbOutputFormatting.Controls.Add(this.cbProperCase);
            this.gbOutputFormatting.Controls.Add(this.cbLowercase);
            this.gbOutputFormatting.Controls.Add(this.cbUppercase);
            this.gbOutputFormatting.Controls.Add(this.cbOriginal);
            this.gbOutputFormatting.Location = new System.Drawing.Point(12, 142);
            this.gbOutputFormatting.Name = "gbOutputFormatting";
            this.gbOutputFormatting.Size = new System.Drawing.Size(585, 46);
            this.gbOutputFormatting.TabIndex = 12;
            this.gbOutputFormatting.TabStop = false;
            this.gbOutputFormatting.Text = "Output Formatting";
            // 
            // cbOriginal
            // 
            this.cbOriginal.AutoSize = true;
            this.cbOriginal.Checked = true;
            this.cbOriginal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOriginal.Location = new System.Drawing.Point(6, 19);
            this.cbOriginal.Name = "cbOriginal";
            this.cbOriginal.Size = new System.Drawing.Size(61, 17);
            this.cbOriginal.TabIndex = 0;
            this.cbOriginal.Text = "Original";
            this.cbOriginal.UseVisualStyleBackColor = true;
            // 
            // cbUppercase
            // 
            this.cbUppercase.AutoSize = true;
            this.cbUppercase.Location = new System.Drawing.Point(86, 19);
            this.cbUppercase.Name = "cbUppercase";
            this.cbUppercase.Size = new System.Drawing.Size(78, 17);
            this.cbUppercase.TabIndex = 1;
            this.cbUppercase.Text = "Uppercase";
            this.cbUppercase.UseVisualStyleBackColor = true;
            // 
            // cbLowercase
            // 
            this.cbLowercase.AutoSize = true;
            this.cbLowercase.Location = new System.Drawing.Point(166, 19);
            this.cbLowercase.Name = "cbLowercase";
            this.cbLowercase.Size = new System.Drawing.Size(78, 17);
            this.cbLowercase.TabIndex = 2;
            this.cbLowercase.Text = "Lowercase";
            this.cbLowercase.UseVisualStyleBackColor = true;
            // 
            // cbProperCase
            // 
            this.cbProperCase.AutoSize = true;
            this.cbProperCase.Location = new System.Drawing.Point(246, 19);
            this.cbProperCase.Name = "cbProperCase";
            this.cbProperCase.Size = new System.Drawing.Size(84, 17);
            this.cbProperCase.TabIndex = 3;
            this.cbProperCase.Text = "Proper Case";
            this.cbProperCase.UseVisualStyleBackColor = true;
            // 
            // cbUnique
            // 
            this.cbUnique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUnique.AutoSize = true;
            this.cbUnique.Checked = true;
            this.cbUnique.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUnique.Location = new System.Drawing.Point(519, 19);
            this.cbUnique.Name = "cbUnique";
            this.cbUnique.Size = new System.Drawing.Size(60, 17);
            this.cbUnique.TabIndex = 4;
            this.cbUnique.Text = "Unique";
            this.cbUnique.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(522, 194);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 225);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gbOutputFormatting);
            this.Controls.Add(this.btnSetOutputFile);
            this.Controls.Add(this.btnSetInputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtLimitLength);
            this.Controls.Add(this.lblDescFrontfilter);
            this.Controls.Add(this.txtFrontFilter);
            this.Controls.Add(this.lblDescInputfile);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.lblDescCharset);
            this.Controls.Add(this.txtCharset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary Filter";
            this.gbOutputFormatting.ResumeLayout(false);
            this.gbOutputFormatting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCharset;
        private System.Windows.Forms.Label lblDescCharset;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label lblDescInputfile;
        private System.Windows.Forms.TextBox txtFrontFilter;
        private System.Windows.Forms.Label lblDescFrontfilter;
        private System.Windows.Forms.TextBox txtLimitLength;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnSetInputFile;
        private System.Windows.Forms.Button btnSetOutputFile;
        private System.Windows.Forms.GroupBox gbOutputFormatting;
        private System.Windows.Forms.CheckBox cbUnique;
        private System.Windows.Forms.CheckBox cbProperCase;
        private System.Windows.Forms.CheckBox cbLowercase;
        private System.Windows.Forms.CheckBox cbUppercase;
        private System.Windows.Forms.CheckBox cbOriginal;
        private System.Windows.Forms.Button btnRun;
    }
}

