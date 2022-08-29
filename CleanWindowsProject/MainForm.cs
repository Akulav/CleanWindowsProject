using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CleanWindowsProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnforceAdminPrivilegesWorkaround();
        }

        private void edgeRemoveBtn_Click(object sender, EventArgs e)
        {
            executeScript("Remove-Edge.bat");
        }

        private void discordBtn_Click(object sender, EventArgs e)
        {
            executeScript("Discord.bat");
        }

        private void executeScript(string script)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = script;
            //p.StartInfo.CreateNoWindow = true;
            p.Start();
            //outputBox.Text = "";
            //while (!p.HasExited) { outputBox.Text += p.StandardOutput.ReadLine(); }
            p.WaitForExit();
        }

        public static void EnforceAdminPrivilegesWorkaround()
        {
            RegistryKey rk;
            string registryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\";

            try
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                }
                else
                {
                    rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                }

                rk = rk.OpenSubKey(registryPath, true);
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("Please run as administrator");
                Environment.Exit(1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void zipBtn_Click(object sender, EventArgs e)
        {
            executeScript("7-Zip.bat");
        }

        private void iTunesBtn_Click(object sender, EventArgs e)
        {
            executeScript("iTunes.bat");
        }

        private void cpuzBtn_Click(object sender, EventArgs e)
        {
            executeScript("CPU-Z.bat");
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            executeScript("Github.bat");
        }

        private void irfanBtn_Click(object sender, EventArgs e)
        {
            executeScript("IrfanView.bat");
        }

        private void wemodBtn_Click(object sender, EventArgs e)
        {
            executeScript("Wemod.bat");
        }

        private void qbitBtn_Click(object sender, EventArgs e)
        {
            executeScript("qBittorrent.bat");
        }

        private void keepassBtn_Click(object sender, EventArgs e)
        {
            executeScript("KeePass.bat");
        }

        private void libreBtn_Click(object sender, EventArgs e)
        {
            executeScript("LibreOffice.bat");
        }

        private void visualstudioBtn_Click(object sender, EventArgs e)
        {
            executeScript("VisualStudio.bat");
        }

        private void steamBtn_Click(object sender, EventArgs e)
        {
            executeScript("Steam.bat");
        }

        private void firefoxBtn_Click(object sender, EventArgs e)
        {
            executeScript("FireFox.bat");
        }

        private void notepadBtn_Click(object sender, EventArgs e)
        {
            executeScript("Notepad++.bat");
        }

        private void gpuzBtn_Click(object sender, EventArgs e)
        {
            executeScript("GPU-Z.bat");
        }

        private void veracryptBtn_Click(object sender, EventArgs e)
        {
            executeScript("VeraCrypt.bat");
        }

        private void vlcBtn_Click(object sender, EventArgs e)
        {
            executeScript("VLC.bat");
        }

        private void windirstatBtn_Click(object sender, EventArgs e)
        {
            executeScript("Windirstat.bat");
        }

        private void bcuninstallerBtn_Click(object sender, EventArgs e)
        {
            executeScript("BCUninstaller.bat");
        }

        private void installAllBtn_Click(object sender, EventArgs e)
        {
            executeScript("InstallAll.bat");
        }

        private void telegramBtn_Click(object sender, EventArgs e)
        {
            executeScript("Telegram.bat");
        }
    }
}