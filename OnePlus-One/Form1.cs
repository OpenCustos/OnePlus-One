using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using System.Diagnostics;//Prozesse auslesen -> adb.exe beenden
/* Checkliste: 
 * Entsperren - done
 * recovery ersetzen - done
 * root - ...
 * 
 */
namespace OnePlus_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //adb.exe läuft im hintergrund weiter, wenn folgendes nicht zum beenden erzwungen wird..
            Process[] pp = Process.GetProcessesByName("adb");
            foreach (Process p in pp) p.Kill();

            //Dieses Programm beenden
            Close();
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            
            if (rdB_unlock.Checked) 
            {
                try
                { System.Diagnostics.Process.Start(@"wk_unlock.bat"); } //Öffnen des Tools
                catch
                {
                    MessageBox.Show("wk_unlock.bat existiert nicht im Ordner!", "Nicht vorhanden!");
                }  //Fehlermeldung
            }


            if (rdB_root.Checked)
            {
                try
                { System.Diagnostics.Process.Start(@"wk_root.bat"); } //Öffnen des Tools
                catch
                {
                    MessageBox.Show("wk_root.bat existiert nicht im Ordner!", "Nicht vorhanden!");
                }  //Fehlermeldung
            }

            if(rdB_recovery.Checked)
            {
                try
                { System.Diagnostics.Process.Start(@"wk_recovery.bat"); } //Öffnen des Tools
                catch
                {
                    MessageBox.Show("wk_recovery.bat existiert nicht im Ordner!", "Nicht vorhanden!");
                }  //Fehlermeldung
            }
        }

        private void link_howto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.android-hilfe.de/anleitungen-fuer-oneplus-one/596012-how-oneplus-one-rootanleitung-unlock-recovery-rootvorgang-von-z.html");
        }

        private void btn_recovery_Click(object sender, EventArgs e)
        {
            try
            { System.Diagnostics.Process.Start(@"wk_recoverymode.bat"); } //Öffnen des Tools
            catch
            {
                MessageBox.Show("wk_recoverymode.bat existiert nicht im Ordner!", "Nicht vorhanden!");
            }  //Fehlermeldung
        }

        private void btn_bootloader_Click(object sender, EventArgs e)
        {
            try
            { System.Diagnostics.Process.Start(@"wk_bootloadermode.bat"); } //Öffnen des Tools
            catch
            {
                MessageBox.Show("wk_bootloadermode.bat existiert nicht im Ordner!", "Nicht vorhanden!");
            }  //Fehlermeldung
        }

        private void link_befehle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.androidpit.de/forum/470625/how-to-adb-tutorial-anfaengerfreundlich");
        }

        private void btn_backup_sd_Click(object sender, EventArgs e)
        {
            try
            { System.Diagnostics.Process.Start(@"wk_sdcard_pull.bat"); } //Öffnen des Tools
            catch
            {
                MessageBox.Show("wk_sdcard_pull.bat existiert nicht im Ordner!", "Nicht vorhanden!");
            }  //Fehlermeldung
        }

        private void btn_restore_sd_Click(object sender, EventArgs e)
        {
            try
            { System.Diagnostics.Process.Start(@"wk_sdcard_push.bat"); } //Öffnen des Tools
            catch
            {
                MessageBox.Show("wk_sdcard_push.bat existiert nicht im Ordner!", "Nicht vorhanden!");
            }  //Fehlermeldung
        }

        private void link_ADB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.android-user.de/erste-schritte-mit-usb-debugging-und-adb/");
        }
    }
}
