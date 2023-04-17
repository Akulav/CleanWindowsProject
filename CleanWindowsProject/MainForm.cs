using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CleanWindowsProject
{
    public partial class MainForm : Form
    {
        public readonly string install = "winget install";
        public MainForm()
        {
            InitializeComponent();
        }

        private void discordBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Discord.Discord -e -h");
        }

        private void zipBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=7zip.7zip -e -h");
        }

        private void iTunesBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Apple.iTunes -e -h");
        }

        private void cpuzBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=CPUID.CPU-Z -e -h");
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=GitHub.GitHubDesktop -e -h");
        }

        private void wemodBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=WeMod.WeMod -e -h");
        }

        private void qbitBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=qBittorrent.qBittorrent -e -h");
        }

        private void keepassBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=KeePassXCTeam.KeePassXC -e -h");
        }

        private void libreBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=TheDocumentFoundation.LibreOffice -e -h");
        }

        private void visualstudioBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Microsoft.VisualStudio.2022.Community.Preview -e -h");
        }

        private void steamBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Valve.Steam -e -h");
        }

        private void firefoxBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Mozilla.Firefox -e -h");
        }

        private void notepadBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Notepad++.Notepad++ -e -h");
        }

        private void gpuzBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=TechPowerUp.GPU-Z -e -h");
        }

        private void veracryptBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=IDRIX.VeraCrypt -e -h");
        }

        private void windirstatBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=WinDirStat.WinDirStat -e -h");
        }

        private void bcuninstallerBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Klocman.BulkCrapUninstaller -e -h");
        }

        private void installAllBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Discord.Discord -e -h");
        }

        private void telegramBtn_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K {install} --id=Telegram.TelegramDesktop -e -h");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}