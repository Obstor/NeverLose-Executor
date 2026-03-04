using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelocityAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NeverLose
{

    public partial class Form1 : Form
    {
        private readonly VelAPI Velo = new VelAPI();

        public Form1()
        {
            InitializeComponent();
            Velo.StartCommunication();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inject();

        }

        private async void Inject()
        {
            try
            {
                var proc = Process.GetProcessesByName("RobloxPlayerBeta").FirstOrDefault();

                if (proc == null)
                {
                    MessageBox.Show("Roblox process not found.", "Error");
                    return;
                }

                if (Velo.IsAttached(proc.Id))
                {
                    MessageBox.Show("The process is already injected.", "Info");
                    return;
                }

                await Velo.Attach(proc.Id);
                MessageBox.Show("Injection successful.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Injection failed: {ex.Message}", "Error");
            }
        }
        

        private void richTextBox1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Velo.Execute(ScriptTextBox.Text);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("RobloxPlayerBeta").FirstOrDefault();

            if (proc != null)
            {
                proc.Kill();
                MessageBox.Show("Roblox has been closed.", "Success");
            }
            else
            {
                MessageBox.Show("Roblox is not running.", "Info");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ScriptTextBox.Text = "";
        }





        private void FixRobloxVersion_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Others", "VersionFixer.bat");

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Missing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(path);
            }
            catch (Exception)
            {
            }
        }

        private void OpenDecompiler_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Others", "Decompiler.exe");

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Missing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(path);
            }
            catch (Exception)
            {
            }
        }

        private void Spoofer_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Others", "Spoofer.exe");

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Missing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(path);
            }
            catch (Exception)
            {
            }
        }

        private void Dex_Click(object sender, EventArgs e)
        {
            string basePath = Path.Combine(Application.StartupPath, "Others");
            string scriptsPath = Path.Combine(basePath, "Scripts");
            string filePath = Path.Combine(scriptsPath, "Dex.luau");

            if (!Directory.Exists(basePath) ||
                !Directory.Exists(scriptsPath) ||
                !File.Exists(filePath))
            {
                MessageBox.Show("Missing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ScriptTextBox.Text = File.ReadAllText(filePath);
        }

        private void InfiniteYield_Click(object sender, EventArgs e)
        {
            string basePath = Path.Combine(Application.StartupPath, "Others");
            string scriptsPath = Path.Combine(basePath, "Scripts");
            string filePath = Path.Combine(scriptsPath, "InfiniteYield.luau");

            if (!Directory.Exists(basePath) ||
                !Directory.Exists(scriptsPath) ||
                !File.Exists(filePath))
            {
                MessageBox.Show("Missing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ScriptTextBox.Text = File.ReadAllText(filePath);
        }

        private void RemoteSpy_Click(object sender, EventArgs e)
        {
            string basePath = Path.Combine(Application.StartupPath, "Others");
            string scriptsPath = Path.Combine(basePath, "Scripts");
            string filePath = Path.Combine(scriptsPath, "RemoteSpy.luau");

            if (!Directory.Exists(basePath) ||
                !Directory.Exists(scriptsPath) ||
                !File.Exists(filePath))
            {
                MessageBox.Show("Missing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ScriptTextBox.Text = File.ReadAllText(filePath);
        }

        private void NeverLose_Click(object sender, EventArgs e)
        {
            string basePath = Path.Combine(Application.StartupPath, "Others");
            string scriptsPath = Path.Combine(basePath, "Scripts");
            string filePath = Path.Combine(scriptsPath, "NeverLose.luau");

            if (!Directory.Exists(basePath) ||
                !Directory.Exists(scriptsPath) ||
                !File.Exists(filePath))
            {
                MessageBox.Show("Missing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ScriptTextBox.Text = File.ReadAllText(filePath);
        }
    }
}
