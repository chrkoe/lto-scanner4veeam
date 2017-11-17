namespace Backup_Scanner
{
    partial class DefaultWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.connectLabel = new System.Windows.Forms.Label();
            this.tapeInfoButton = new System.Windows.Forms.Button();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.vaultLabel = new System.Windows.Forms.Label();
            this.freeLabel = new System.Windows.Forms.Label();
            this.expiredLabel = new System.Windows.Forms.Label();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.vaultTextBox = new System.Windows.Forms.TextBox();
            this.freeTextBox = new System.Windows.Forms.TextBox();
            this.expiredTextBox = new System.Windows.Forms.TextBox();
            this.expirationDateTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.inputPanel, 0, 2);
            this.MainPanel.Controls.Add(this.outputTextBox, 0, 3);
            this.MainPanel.Controls.Add(this.loginPanel, 0, 1);
            this.MainPanel.Controls.Add(this.mainMenu, 0, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 4;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.MainPanel.Size = new System.Drawing.Size(1194, 846);
            this.MainPanel.TabIndex = 0;
            // 
            // inputPanel
            // 
            this.inputPanel.ColumnCount = 3;
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.inputPanel.Controls.Add(this.inputTextBox, 1, 1);
            this.inputPanel.Controls.Add(this.inputLabel, 0, 1);
            this.inputPanel.Controls.Add(this.connectLabel, 0, 0);
            this.inputPanel.Controls.Add(this.tapeInfoButton, 2, 1);
            this.inputPanel.Controls.Add(this.barcodeLabel, 0, 2);
            this.inputPanel.Controls.Add(this.locationLabel, 0, 3);
            this.inputPanel.Controls.Add(this.vaultLabel, 0, 4);
            this.inputPanel.Controls.Add(this.freeLabel, 0, 5);
            this.inputPanel.Controls.Add(this.expiredLabel, 0, 6);
            this.inputPanel.Controls.Add(this.expirationDateLabel, 0, 7);
            this.inputPanel.Controls.Add(this.barcodeTextBox, 1, 2);
            this.inputPanel.Controls.Add(this.locationTextBox, 1, 3);
            this.inputPanel.Controls.Add(this.vaultTextBox, 1, 4);
            this.inputPanel.Controls.Add(this.freeTextBox, 1, 5);
            this.inputPanel.Controls.Add(this.expiredTextBox, 1, 6);
            this.inputPanel.Controls.Add(this.expirationDateTextBox, 1, 7);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(3, 129);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.RowCount = 8;
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputPanel.Size = new System.Drawing.Size(1188, 332);
            this.inputPanel.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(398, 36);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(390, 26);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputKeyPressed);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(3, 33);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(113, 20);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Tape Barcode:";
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.BackColor = System.Drawing.Color.Red;
            this.inputPanel.SetColumnSpan(this.connectLabel, 3);
            this.connectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectLabel.Location = new System.Drawing.Point(3, 0);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(1182, 33);
            this.connectLabel.TabIndex = 2;
            this.connectLabel.Text = "Not connected";
            this.connectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tapeInfoButton
            // 
            this.tapeInfoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tapeInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tapeInfoButton.Location = new System.Drawing.Point(794, 36);
            this.tapeInfoButton.Name = "tapeInfoButton";
            this.tapeInfoButton.Size = new System.Drawing.Size(391, 93);
            this.tapeInfoButton.TabIndex = 3;
            this.tapeInfoButton.Text = "Hole Tape Informationen";
            this.tapeInfoButton.UseVisualStyleBackColor = true;
            this.tapeInfoButton.Click += new System.EventHandler(this.getTapeInfo);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLabel.Location = new System.Drawing.Point(3, 132);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(389, 33);
            this.barcodeLabel.TabIndex = 4;
            this.barcodeLabel.Text = "Barcode:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(3, 165);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(389, 33);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "Location:";
            // 
            // vaultLabel
            // 
            this.vaultLabel.AutoSize = true;
            this.vaultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaultLabel.Location = new System.Drawing.Point(3, 198);
            this.vaultLabel.Name = "vaultLabel";
            this.vaultLabel.Size = new System.Drawing.Size(389, 33);
            this.vaultLabel.TabIndex = 6;
            this.vaultLabel.Text = "Vault:";
            // 
            // freeLabel
            // 
            this.freeLabel.AutoSize = true;
            this.freeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeLabel.Location = new System.Drawing.Point(3, 231);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(389, 33);
            this.freeLabel.TabIndex = 7;
            this.freeLabel.Text = "is Free:";
            // 
            // expiredLabel
            // 
            this.expiredLabel.AutoSize = true;
            this.expiredLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredLabel.Location = new System.Drawing.Point(3, 264);
            this.expiredLabel.Name = "expiredLabel";
            this.expiredLabel.Size = new System.Drawing.Size(389, 33);
            this.expiredLabel.TabIndex = 8;
            this.expiredLabel.Text = "is Expired:";
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDateLabel.Location = new System.Drawing.Point(3, 297);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(389, 35);
            this.expirationDateLabel.TabIndex = 9;
            this.expirationDateLabel.Text = "Expiration Date:";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTextBox.Location = new System.Drawing.Point(398, 135);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.ReadOnly = true;
            this.barcodeTextBox.Size = new System.Drawing.Size(390, 26);
            this.barcodeTextBox.TabIndex = 10;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(398, 168);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(390, 26);
            this.locationTextBox.TabIndex = 11;
            // 
            // vaultTextBox
            // 
            this.vaultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaultTextBox.Location = new System.Drawing.Point(398, 201);
            this.vaultTextBox.Name = "vaultTextBox";
            this.vaultTextBox.ReadOnly = true;
            this.vaultTextBox.Size = new System.Drawing.Size(390, 26);
            this.vaultTextBox.TabIndex = 12;
            // 
            // freeTextBox
            // 
            this.freeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeTextBox.Location = new System.Drawing.Point(398, 234);
            this.freeTextBox.Name = "freeTextBox";
            this.freeTextBox.ReadOnly = true;
            this.freeTextBox.Size = new System.Drawing.Size(390, 26);
            this.freeTextBox.TabIndex = 13;
            // 
            // expiredTextBox
            // 
            this.expiredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expiredTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiredTextBox.Location = new System.Drawing.Point(398, 267);
            this.expiredTextBox.Name = "expiredTextBox";
            this.expiredTextBox.ReadOnly = true;
            this.expiredTextBox.Size = new System.Drawing.Size(390, 26);
            this.expiredTextBox.TabIndex = 14;
            // 
            // expirationDateTextBox
            // 
            this.expirationDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expirationDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDateTextBox.Location = new System.Drawing.Point(398, 300);
            this.expirationDateTextBox.Name = "expirationDateTextBox";
            this.expirationDateTextBox.ReadOnly = true;
            this.expirationDateTextBox.Size = new System.Drawing.Size(390, 26);
            this.expirationDateTextBox.TabIndex = 15;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(3, 467);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(1188, 376);
            this.outputTextBox.TabIndex = 1;
            // 
            // loginPanel
            // 
            this.loginPanel.ColumnCount = 5;
            this.loginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.loginPanel.Controls.Add(this.usernameLabel, 0, 0);
            this.loginPanel.Controls.Add(this.passwordLabel, 2, 0);
            this.loginPanel.Controls.Add(this.usernameTextBox, 1, 0);
            this.loginPanel.Controls.Add(this.passwordTextBox, 3, 0);
            this.loginPanel.Controls.Add(this.loginButton, 4, 0);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(3, 45);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.RowCount = 1;
            this.loginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginPanel.Size = new System.Drawing.Size(1188, 78);
            this.loginPanel.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(118, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Benutzername:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(477, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Passwort:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(240, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(231, 26);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginPressed);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(714, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(231, 26);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginPressed);
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(951, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(234, 72);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.login_clicked);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.toolStripMenuItem1});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenu.Size = new System.Drawing.Size(1194, 42);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "Menü";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 38);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 38);
            this.toolStripMenuItem1.Text = "?";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // DefaultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 846);
            this.Controls.Add(this.MainPanel);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "DefaultWindow";
            this.Text = "LTO Scanner 4 Veeam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClose);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel inputPanel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.TableLayoutPanel loginPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button tapeInfoButton;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label vaultLabel;
        private System.Windows.Forms.Label freeLabel;
        private System.Windows.Forms.Label expiredLabel;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox vaultTextBox;
        private System.Windows.Forms.TextBox freeTextBox;
        private System.Windows.Forms.TextBox expiredTextBox;
        private System.Windows.Forms.TextBox expirationDateTextBox;
        public System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

