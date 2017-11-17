namespace Backup_Scanner
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
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.backupLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.barcodeCheckBox = new System.Windows.Forms.CheckBox();
            this.locationCheckBox = new System.Windows.Forms.CheckBox();
            this.vaultCheckBox = new System.Windows.Forms.CheckBox();
            this.freeCheckBox = new System.Windows.Forms.CheckBox();
            this.expiredCheckBox = new System.Windows.Forms.CheckBox();
            this.expirationDatecheckBox = new System.Windows.Forms.CheckBox();
            this.outputCheckBox = new System.Windows.Forms.CheckBox();
            this.domainLabel = new System.Windows.Forms.Label();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverTextBox
            // 
            this.serverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.serverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTextBox.Location = new System.Drawing.Point(258, 11);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(198, 26);
            this.serverTextBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.settingsPanel.SetColumnSpan(this.saveButton, 2);
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(54, 444);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(402, 44);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "save settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backupLabel
            // 
            this.backupLabel.AutoSize = true;
            this.backupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupLabel.Location = new System.Drawing.Point(54, 0);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(198, 49);
            this.backupLabel.TabIndex = 0;
            this.backupLabel.Text = "Veeam backup server:";
            this.backupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settingsPanel
            // 
            this.settingsPanel.ColumnCount = 4;
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.Controls.Add(this.backupLabel, 1, 0);
            this.settingsPanel.Controls.Add(this.saveButton, 1, 9);
            this.settingsPanel.Controls.Add(this.barcodeCheckBox, 1, 2);
            this.settingsPanel.Controls.Add(this.locationCheckBox, 1, 3);
            this.settingsPanel.Controls.Add(this.vaultCheckBox, 1, 4);
            this.settingsPanel.Controls.Add(this.freeCheckBox, 1, 5);
            this.settingsPanel.Controls.Add(this.expiredCheckBox, 1, 6);
            this.settingsPanel.Controls.Add(this.expirationDatecheckBox, 1, 7);
            this.settingsPanel.Controls.Add(this.outputCheckBox, 1, 8);
            this.settingsPanel.Controls.Add(this.serverTextBox, 2, 0);
            this.settingsPanel.Controls.Add(this.domainLabel, 1, 1);
            this.settingsPanel.Controls.Add(this.domainTextBox, 2, 1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.RowCount = 10;
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settingsPanel.Size = new System.Drawing.Size(511, 491);
            this.settingsPanel.TabIndex = 0;
            // 
            // barcodeCheckBox
            // 
            this.barcodeCheckBox.AutoSize = true;
            this.barcodeCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.barcodeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeCheckBox.Location = new System.Drawing.Point(54, 101);
            this.barcodeCheckBox.Name = "barcodeCheckBox";
            this.barcodeCheckBox.Size = new System.Drawing.Size(198, 43);
            this.barcodeCheckBox.TabIndex = 10;
            this.barcodeCheckBox.Text = "display barcode";
            this.barcodeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.barcodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // locationCheckBox
            // 
            this.locationCheckBox.AutoSize = true;
            this.locationCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.locationCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationCheckBox.Location = new System.Drawing.Point(54, 150);
            this.locationCheckBox.Name = "locationCheckBox";
            this.locationCheckBox.Size = new System.Drawing.Size(198, 43);
            this.locationCheckBox.TabIndex = 11;
            this.locationCheckBox.Text = "display location";
            this.locationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.locationCheckBox.UseVisualStyleBackColor = true;
            // 
            // vaultCheckBox
            // 
            this.vaultCheckBox.AutoSize = true;
            this.vaultCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vaultCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaultCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaultCheckBox.Location = new System.Drawing.Point(54, 199);
            this.vaultCheckBox.Name = "vaultCheckBox";
            this.vaultCheckBox.Size = new System.Drawing.Size(198, 43);
            this.vaultCheckBox.TabIndex = 12;
            this.vaultCheckBox.Text = "display vault";
            this.vaultCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // freeCheckBox
            // 
            this.freeCheckBox.AutoSize = true;
            this.freeCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.freeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeCheckBox.Location = new System.Drawing.Point(54, 248);
            this.freeCheckBox.Name = "freeCheckBox";
            this.freeCheckBox.Size = new System.Drawing.Size(198, 43);
            this.freeCheckBox.TabIndex = 13;
            this.freeCheckBox.Text = "display isFree";
            this.freeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.freeCheckBox.UseVisualStyleBackColor = true;
            // 
            // expiredCheckBox
            // 
            this.expiredCheckBox.AutoSize = true;
            this.expiredCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expiredCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expiredCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredCheckBox.Location = new System.Drawing.Point(54, 297);
            this.expiredCheckBox.Name = "expiredCheckBox";
            this.expiredCheckBox.Size = new System.Drawing.Size(198, 43);
            this.expiredCheckBox.TabIndex = 14;
            this.expiredCheckBox.Text = "display isExpired";
            this.expiredCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // expirationDatecheckBox
            // 
            this.expirationDatecheckBox.AutoSize = true;
            this.expirationDatecheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expirationDatecheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expirationDatecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDatecheckBox.Location = new System.Drawing.Point(54, 346);
            this.expirationDatecheckBox.Name = "expirationDatecheckBox";
            this.expirationDatecheckBox.Size = new System.Drawing.Size(198, 43);
            this.expirationDatecheckBox.TabIndex = 15;
            this.expirationDatecheckBox.Text = "display expirationDate";
            this.expirationDatecheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expirationDatecheckBox.UseVisualStyleBackColor = true;
            // 
            // outputCheckBox
            // 
            this.outputCheckBox.AutoSize = true;
            this.outputCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.outputCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputCheckBox.Location = new System.Drawing.Point(54, 395);
            this.outputCheckBox.Name = "outputCheckBox";
            this.outputCheckBox.Size = new System.Drawing.Size(198, 43);
            this.outputCheckBox.TabIndex = 16;
            this.outputCheckBox.Text = "display output history";
            this.outputCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputCheckBox.UseVisualStyleBackColor = true;
            // 
            // domainLabel
            // 
            this.domainLabel.AutoSize = true;
            this.domainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainLabel.Location = new System.Drawing.Point(54, 49);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(198, 49);
            this.domainLabel.TabIndex = 17;
            this.domainLabel.Text = "domain name for login:";
            this.domainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // domainTextBox
            // 
            this.domainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.domainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainTextBox.Location = new System.Drawing.Point(258, 60);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(198, 26);
            this.domainTextBox.TabIndex = 18;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 491);
            this.Controls.Add(this.settingsPanel);
            this.Name = "SettingsForm";
            this.Text = "Settings Backup-Scanner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel settingsPanel;
        private System.Windows.Forms.Label backupLabel;
        private System.Windows.Forms.CheckBox barcodeCheckBox;
        private System.Windows.Forms.CheckBox locationCheckBox;
        private System.Windows.Forms.CheckBox vaultCheckBox;
        private System.Windows.Forms.CheckBox freeCheckBox;
        private System.Windows.Forms.CheckBox expiredCheckBox;
        private System.Windows.Forms.CheckBox expirationDatecheckBox;
        private System.Windows.Forms.CheckBox outputCheckBox;
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.TextBox domainTextBox;
    }
}