namespace SerialRelay
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
            this.lbAvailableCOMPorts = new System.Windows.Forms.ListBox();
            this.lblPortList = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.lblConfigFileName = new System.Windows.Forms.Label();
            this.tbConfigFile = new System.Windows.Forms.TextBox();
            this.cbBaudRates = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAvailableCOMPorts
            // 
            this.lbAvailableCOMPorts.FormattingEnabled = true;
            this.lbAvailableCOMPorts.Location = new System.Drawing.Point(16, 29);
            this.lbAvailableCOMPorts.Name = "lbAvailableCOMPorts";
            this.lbAvailableCOMPorts.Size = new System.Drawing.Size(185, 95);
            this.lbAvailableCOMPorts.TabIndex = 0;
            // 
            // lblPortList
            // 
            this.lblPortList.AutoSize = true;
            this.lblPortList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortList.Location = new System.Drawing.Point(13, 13);
            this.lblPortList.Name = "lblPortList";
            this.lblPortList.Size = new System.Drawing.Size(123, 13);
            this.lblPortList.TabIndex = 1;
            this.lblPortList.Text = "Available COM Ports";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudRate.Location = new System.Drawing.Point(13, 136);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(67, 13);
            this.lblBaudRate.TabIndex = 4;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSize.Location = new System.Drawing.Point(141, 136);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(60, 13);
            this.lblFontSize.TabIndex = 6;
            this.lblFontSize.Text = "Font Size";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(144, 152);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(44, 20);
            this.nudFontSize.TabIndex = 7;
            this.nudFontSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblConfigFileName
            // 
            this.lblConfigFileName.AutoSize = true;
            this.lblConfigFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigFileName.Location = new System.Drawing.Point(16, 190);
            this.lblConfigFileName.Name = "lblConfigFileName";
            this.lblConfigFileName.Size = new System.Drawing.Size(106, 13);
            this.lblConfigFileName.TabIndex = 8;
            this.lblConfigFileName.Text = "Configuration File";
            // 
            // tbConfigFile
            // 
            this.tbConfigFile.Location = new System.Drawing.Point(16, 207);
            this.tbConfigFile.Name = "tbConfigFile";
            this.tbConfigFile.Size = new System.Drawing.Size(185, 20);
            this.tbConfigFile.TabIndex = 9;
            // 
            // cbBaudRates
            // 
            this.cbBaudRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRates.FormattingEnabled = true;
            this.cbBaudRates.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudRates.Location = new System.Drawing.Point(16, 151);
            this.cbBaudRates.Name = "cbBaudRates";
            this.cbBaudRates.Size = new System.Drawing.Size(106, 21);
            this.cbBaudRates.TabIndex = 10;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 276);
            this.Controls.Add(this.cbBaudRates);
            this.Controls.Add(this.tbConfigFile);
            this.Controls.Add(this.lblConfigFileName);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPortList);
            this.Controls.Add(this.lbAvailableCOMPorts);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvailableCOMPorts;
        private System.Windows.Forms.Label lblPortList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label lblConfigFileName;
        private System.Windows.Forms.TextBox tbConfigFile;
        private System.Windows.Forms.ComboBox cbBaudRates;
    }
}