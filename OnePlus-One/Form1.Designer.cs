namespace OnePlus_One
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_do = new System.Windows.Forms.Button();
            this.rdB_root = new System.Windows.Forms.RadioButton();
            this.rdB_unlock = new System.Windows.Forms.RadioButton();
            this.rdB_recovery = new System.Windows.Forms.RadioButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.link_howto = new System.Windows.Forms.LinkLabel();
            this.btn_recovery = new System.Windows.Forms.Button();
            this.btn_bootloader = new System.Windows.Forms.Button();
            this.btn_backup_all = new System.Windows.Forms.Button();
            this.link_befehle = new System.Windows.Forms.LinkLabel();
            this.btn_backup_apps = new System.Windows.Forms.Button();
            this.btn_backup_sd = new System.Windows.Forms.Button();
            this.btn_restore_sd = new System.Windows.Forms.Button();
            this.btn_restore_apps = new System.Windows.Forms.Button();
            this.btn_restore_all = new System.Windows.Forms.Button();
            this.link_ADB = new System.Windows.Forms.LinkLabel();
            this.toolTipRed = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_flash = new System.Windows.Forms.Button();
            this.groupBox_Backup = new System.Windows.Forms.GroupBox();
            this.groupBoxRestore = new System.Windows.Forms.GroupBox();
            this.groupBoxRights = new System.Windows.Forms.GroupBox();
            this.groupBox_boot = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox_Backup.SuspendLayout();
            this.groupBoxRestore.SuspendLayout();
            this.groupBoxRights.SuspendLayout();
            this.groupBox_boot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_close.Location = new System.Drawing.Point(0, 245);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(736, 32);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Beenden";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_do
            // 
            this.btn_do.Location = new System.Drawing.Point(6, 89);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(119, 23);
            this.btn_do.TabIndex = 1;
            this.btn_do.Text = "Ausführen";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // rdB_root
            // 
            this.rdB_root.AutoSize = true;
            this.rdB_root.Location = new System.Drawing.Point(6, 64);
            this.rdB_root.Name = "rdB_root";
            this.rdB_root.Size = new System.Drawing.Size(51, 17);
            this.rdB_root.TabIndex = 2;
            this.rdB_root.TabStop = true;
            this.rdB_root.Text = "Root!";
            this.toolTip1.SetToolTip(this.rdB_root, "Über Recovery installieren");
            this.toolTipRed.SetToolTip(this.rdB_root, "Nur entsperrte Geräte!!! Kann sonst zu Schädigung des Systems führen!");
            this.rdB_root.UseVisualStyleBackColor = true;
            // 
            // rdB_unlock
            // 
            this.rdB_unlock.AutoSize = true;
            this.rdB_unlock.Location = new System.Drawing.Point(6, 41);
            this.rdB_unlock.Name = "rdB_unlock";
            this.rdB_unlock.Size = new System.Drawing.Size(76, 17);
            this.rdB_unlock.TabIndex = 1;
            this.rdB_unlock.TabStop = true;
            this.rdB_unlock.Text = "Entsperren";
            this.toolTip1.SetToolTip(this.rdB_unlock, "Daten sichern!");
            this.toolTipRed.SetToolTip(this.rdB_unlock, "Alle Daten (Videos, Bilder/Fotos, Privates) gehen verloren!");
            this.rdB_unlock.UseVisualStyleBackColor = true;
            // 
            // rdB_recovery
            // 
            this.rdB_recovery.AutoSize = true;
            this.rdB_recovery.Location = new System.Drawing.Point(6, 18);
            this.rdB_recovery.Name = "rdB_recovery";
            this.rdB_recovery.Size = new System.Drawing.Size(114, 17);
            this.rdB_recovery.TabIndex = 0;
            this.rdB_recovery.TabStop = true;
            this.rdB_recovery.Text = "Recovery ersetzen";
            this.toolTip1.SetToolTip(this.rdB_recovery, "Ersetzt das vorhandene Wiederherstellungs-System");
            this.rdB_recovery.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // link_howto
            // 
            this.link_howto.AutoSize = true;
            this.link_howto.Location = new System.Drawing.Point(568, 41);
            this.link_howto.Name = "link_howto";
            this.link_howto.Size = new System.Drawing.Size(134, 13);
            this.link_howto.TabIndex = 4;
            this.link_howto.TabStop = true;
            this.link_howto.Text = "HowTo zum Selber-basteln";
            this.toolTip1.SetToolTip(this.link_howto, "Handbuch für Selbstständige ^^");
            this.link_howto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_howto_LinkClicked);
            // 
            // btn_recovery
            // 
            this.btn_recovery.Location = new System.Drawing.Point(6, 54);
            this.btn_recovery.Name = "btn_recovery";
            this.btn_recovery.Size = new System.Drawing.Size(120, 23);
            this.btn_recovery.TabIndex = 5;
            this.btn_recovery.Text = "Ab ins Recovery!";
            this.toolTip1.SetToolTip(this.btn_recovery, "Wiederherstell Modus starten");
            this.btn_recovery.UseVisualStyleBackColor = true;
            this.btn_recovery.Click += new System.EventHandler(this.btn_recovery_Click);
            // 
            // btn_bootloader
            // 
            this.btn_bootloader.Location = new System.Drawing.Point(6, 18);
            this.btn_bootloader.Name = "btn_bootloader";
            this.btn_bootloader.Size = new System.Drawing.Size(120, 23);
            this.btn_bootloader.TabIndex = 6;
            this.btn_bootloader.Text = "Ab in den Bootloader!";
            this.toolTip1.SetToolTip(this.btn_bootloader, "Fastboot-Modus starten");
            this.btn_bootloader.UseVisualStyleBackColor = true;
            this.btn_bootloader.Click += new System.EventHandler(this.btn_bootloader_Click);
            // 
            // btn_backup_all
            // 
            this.btn_backup_all.Enabled = false;
            this.btn_backup_all.Location = new System.Drawing.Point(6, 19);
            this.btn_backup_all.Name = "btn_backup_all";
            this.btn_backup_all.Size = new System.Drawing.Size(134, 23);
            this.btn_backup_all.TabIndex = 7;
            this.btn_backup_all.Text = "Aller Dateien";
            this.toolTip1.SetToolTip(this.btn_backup_all, "pull all");
            this.btn_backup_all.UseVisualStyleBackColor = true;
            // 
            // link_befehle
            // 
            this.link_befehle.AutoSize = true;
            this.link_befehle.Location = new System.Drawing.Point(567, 14);
            this.link_befehle.Name = "link_befehle";
            this.link_befehle.Size = new System.Drawing.Size(135, 13);
            this.link_befehle.TabIndex = 9;
            this.link_befehle.TabStop = true;
            this.link_befehle.Text = "Befehlsübersicht für Bastler";
            this.toolTip1.SetToolTip(this.link_befehle, "Befehlsübersicht");
            this.link_befehle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_befehle_LinkClicked);
            // 
            // btn_backup_apps
            // 
            this.btn_backup_apps.Enabled = false;
            this.btn_backup_apps.Location = new System.Drawing.Point(6, 54);
            this.btn_backup_apps.Name = "btn_backup_apps";
            this.btn_backup_apps.Size = new System.Drawing.Size(134, 23);
            this.btn_backup_apps.TabIndex = 8;
            this.btn_backup_apps.Text = "Der Apps";
            this.toolTip1.SetToolTip(this.btn_backup_apps, "pull apps");
            this.btn_backup_apps.UseVisualStyleBackColor = true;
            // 
            // btn_backup_sd
            // 
            this.btn_backup_sd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup_sd.Location = new System.Drawing.Point(6, 89);
            this.btn_backup_sd.Name = "btn_backup_sd";
            this.btn_backup_sd.Size = new System.Drawing.Size(134, 23);
            this.btn_backup_sd.TabIndex = 9;
            this.btn_backup_sd.Text = "SD-Karte";
            this.toolTip1.SetToolTip(this.btn_backup_sd, "Inhalt(Bilder,Videos,Whatsapp.. auf der Karte) -> sichern!");
            this.toolTipRed.SetToolTip(this.btn_backup_sd, "Nicht vom Computer entfernen!");
            this.btn_backup_sd.UseVisualStyleBackColor = true;
            this.btn_backup_sd.Click += new System.EventHandler(this.btn_backup_sd_Click);
            // 
            // btn_restore_sd
            // 
            this.btn_restore_sd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore_sd.Location = new System.Drawing.Point(6, 89);
            this.btn_restore_sd.Name = "btn_restore_sd";
            this.btn_restore_sd.Size = new System.Drawing.Size(134, 23);
            this.btn_restore_sd.TabIndex = 9;
            this.btn_restore_sd.Text = "SD-Karte";
            this.toolTip1.SetToolTip(this.btn_restore_sd, "Bewegt den Inhalt der SD zurück @ Smartphone");
            this.toolTipRed.SetToolTip(this.btn_restore_sd, "Nicht vom Computer entfernen!");
            this.btn_restore_sd.UseVisualStyleBackColor = true;
            this.btn_restore_sd.Click += new System.EventHandler(this.btn_restore_sd_Click);
            // 
            // btn_restore_apps
            // 
            this.btn_restore_apps.Enabled = false;
            this.btn_restore_apps.Location = new System.Drawing.Point(6, 54);
            this.btn_restore_apps.Name = "btn_restore_apps";
            this.btn_restore_apps.Size = new System.Drawing.Size(134, 23);
            this.btn_restore_apps.TabIndex = 8;
            this.btn_restore_apps.Text = "Der Apps";
            this.toolTip1.SetToolTip(this.btn_restore_apps, "push apps");
            this.btn_restore_apps.UseVisualStyleBackColor = true;
            // 
            // btn_restore_all
            // 
            this.btn_restore_all.Enabled = false;
            this.btn_restore_all.Location = new System.Drawing.Point(6, 19);
            this.btn_restore_all.Name = "btn_restore_all";
            this.btn_restore_all.Size = new System.Drawing.Size(134, 23);
            this.btn_restore_all.TabIndex = 7;
            this.btn_restore_all.Text = "Aller Dateien";
            this.toolTip1.SetToolTip(this.btn_restore_all, "push all");
            this.toolTipRed.SetToolTip(this.btn_restore_all, "Experimentel!");
            this.btn_restore_all.UseVisualStyleBackColor = true;
            // 
            // link_ADB
            // 
            this.link_ADB.AutoSize = true;
            this.link_ADB.Location = new System.Drawing.Point(672, 67);
            this.link_ADB.Name = "link_ADB";
            this.link_ADB.Size = new System.Drawing.Size(29, 13);
            this.link_ADB.TabIndex = 15;
            this.link_ADB.TabStop = true;
            this.link_ADB.Text = "ADB";
            this.toolTip1.SetToolTip(this.link_ADB, "Handbuch für Selbstständige ^^");
            this.link_ADB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_ADB_LinkClicked);
            // 
            // toolTipRed
            // 
            this.toolTipRed.AutoPopDelay = 5000;
            this.toolTipRed.BackColor = System.Drawing.Color.Black;
            this.toolTipRed.ForeColor = System.Drawing.Color.Red;
            this.toolTipRed.InitialDelay = 500;
            this.toolTipRed.IsBalloon = true;
            this.toolTipRed.ReshowDelay = 100;
            this.toolTipRed.ShowAlways = true;
            this.toolTipRed.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipRed.ToolTipTitle = "Achtung!";
            this.toolTipRed.UseAnimation = false;
            this.toolTipRed.UseFading = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(541, 85);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btn_flash
            // 
            this.btn_flash.Location = new System.Drawing.Point(6, 89);
            this.btn_flash.Name = "btn_flash";
            this.btn_flash.Size = new System.Drawing.Size(120, 23);
            this.btn_flash.TabIndex = 10;
            this.btn_flash.Text = "Rom Flashen";
            this.btn_flash.UseVisualStyleBackColor = true;
            // 
            // groupBox_Backup
            // 
            this.groupBox_Backup.Controls.Add(this.btn_backup_sd);
            this.groupBox_Backup.Controls.Add(this.btn_backup_apps);
            this.groupBox_Backup.Controls.Add(this.btn_backup_all);
            this.groupBox_Backup.Location = new System.Drawing.Point(369, 104);
            this.groupBox_Backup.Name = "groupBox_Backup";
            this.groupBox_Backup.Size = new System.Drawing.Size(149, 118);
            this.groupBox_Backup.TabIndex = 11;
            this.groupBox_Backup.TabStop = false;
            this.groupBox_Backup.Text = "Sicherung";
            // 
            // groupBoxRestore
            // 
            this.groupBoxRestore.Controls.Add(this.btn_restore_sd);
            this.groupBoxRestore.Controls.Add(this.btn_restore_apps);
            this.groupBoxRestore.Controls.Add(this.btn_restore_all);
            this.groupBoxRestore.Location = new System.Drawing.Point(553, 104);
            this.groupBoxRestore.Name = "groupBoxRestore";
            this.groupBoxRestore.Size = new System.Drawing.Size(149, 118);
            this.groupBoxRestore.TabIndex = 12;
            this.groupBoxRestore.TabStop = false;
            this.groupBoxRestore.Text = "Wiederherstellung";
            // 
            // groupBoxRights
            // 
            this.groupBoxRights.Controls.Add(this.rdB_root);
            this.groupBoxRights.Controls.Add(this.rdB_unlock);
            this.groupBoxRights.Controls.Add(this.rdB_recovery);
            this.groupBoxRights.Controls.Add(this.btn_do);
            this.groupBoxRights.Location = new System.Drawing.Point(32, 104);
            this.groupBoxRights.Name = "groupBoxRights";
            this.groupBoxRights.Size = new System.Drawing.Size(134, 118);
            this.groupBoxRights.TabIndex = 13;
            this.groupBoxRights.TabStop = false;
            this.groupBoxRights.Text = "Rechte";
            // 
            // groupBox_boot
            // 
            this.groupBox_boot.Controls.Add(this.btn_recovery);
            this.groupBox_boot.Controls.Add(this.btn_bootloader);
            this.groupBox_boot.Controls.Add(this.btn_flash);
            this.groupBox_boot.Location = new System.Drawing.Point(200, 104);
            this.groupBox_boot.Name = "groupBox_boot";
            this.groupBox_boot.Size = new System.Drawing.Size(136, 118);
            this.groupBox_boot.TabIndex = 14;
            this.groupBox_boot.TabStop = false;
            this.groupBox_boot.Text = "BOOT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 277);
            this.Controls.Add(this.link_ADB);
            this.Controls.Add(this.groupBox_boot);
            this.Controls.Add(this.groupBoxRights);
            this.Controls.Add(this.groupBoxRestore);
            this.Controls.Add(this.groupBox_Backup);
            this.Controls.Add(this.link_befehle);
            this.Controls.Add(this.link_howto);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WKs OnePlus-One T00L";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox_Backup.ResumeLayout(false);
            this.groupBoxRestore.ResumeLayout(false);
            this.groupBoxRights.ResumeLayout(false);
            this.groupBoxRights.PerformLayout();
            this.groupBox_boot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.RadioButton rdB_unlock;
        private System.Windows.Forms.RadioButton rdB_recovery;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTipRed;
        private System.Windows.Forms.RadioButton rdB_root;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel link_howto;
        private System.Windows.Forms.Button btn_bootloader;
        private System.Windows.Forms.Button btn_recovery;
        private System.Windows.Forms.Button btn_backup_all;
        private System.Windows.Forms.LinkLabel link_befehle;
        private System.Windows.Forms.Button btn_flash;
        private System.Windows.Forms.GroupBox groupBox_Backup;
        private System.Windows.Forms.Button btn_backup_apps;
        private System.Windows.Forms.Button btn_backup_sd;
        private System.Windows.Forms.GroupBox groupBox_boot;
        private System.Windows.Forms.GroupBox groupBoxRights;
        private System.Windows.Forms.GroupBox groupBoxRestore;
        private System.Windows.Forms.Button btn_restore_sd;
        private System.Windows.Forms.Button btn_restore_apps;
        private System.Windows.Forms.Button btn_restore_all;
        private System.Windows.Forms.LinkLabel link_ADB;
    }
}

