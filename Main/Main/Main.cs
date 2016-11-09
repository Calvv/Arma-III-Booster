using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class Main : Form
    {


        //Booeans

        bool FadeIn = true;
        bool FadeOut = false;

        bool Closable = false;
        bool ShouldClose = false;

        // Static Strings

        public static string cfg_standardPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Arma 3\\Arma3.cfg";
        public static string cfg_old = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Arma 3\\Arma3_old.cfg";

        // Lists

        List<string> old_CFG = new List<string>();
        List<string> new_CFG = new List<string>();


        public Main()
        {
            InitializeComponent();
            Load_Everything();
        }

        public void Load_Everything() //this is just so that the Main load up function doesn't get messy
        {
            CheckIfReadOnly(cfg_standardPath); //don't ask :) This isn't professional programming.
            CheckIfArmaIsRunning(); //Could just make this to a function returning a true of false statement but whatever.. 
            if (ShouldClose) //Checks if Arma III is running, if so then the program will close.
            {
                Load += (s, e) => Close();
                Application.ExitThread();
                return;
            }
        }

        //                                 Random Functions           
        /* Sorry about the messy code. I didn't optimize it or something, it is what it is. */

        public bool IsProcessOpen(string name) //Checks if a process is running
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ArmaCFG_exists(string path) //Checks if ArmaIII.cfg exits
        {
            if (System.IO.File.Exists(path))
            {
                SetToWriteAndRead(path);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckIfArmaIsRunning() // Checks if arma III is running
        {
            if (IsProcessOpen("arma3"))
            {
                MessageBox.Show("Please close Arma III before using this application", "Please close Arma III", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ShouldClose = true;
            }

        }
        private void SetToWriteAndRead(string path) //Sets the file to both read and write (if the file should have been set to read only before)
        {
            FileInfo newinfo = new FileInfo(path);
            if (newinfo.IsReadOnly)
            {
                newinfo.IsReadOnly = false;
            }
        }
        private void SetToOpposit(string path) //Sets the file to the opposit of it's write/read properties. (ex: read only turns in to write&read)
        {
            FileInfo newinfo = new FileInfo(path);
            if (newinfo.IsReadOnly)
            {
                newinfo.IsReadOnly = false;
            }
            else
            {
                newinfo.IsReadOnly = true;
            }
        }
        private void CheckIfReadOnly(string path) //Checks if the arma III cfg is .read only and checks if the file exists
        {
            if (System.IO.File.Exists(path))
            {
                FileInfo newinfo = new FileInfo(path);
                if (newinfo.IsReadOnly)
                {
                    btnLockUnlock.Text = "Unlock Configuration";
                }
                else
                {
                    btnLockUnlock.Text = "Lock Configuration";
                }
            }
            else if (System.IO.File.Exists("Arma3.cfg"))
            {
                MessageBox.Show("Custom .cfg Path = Enabled.", "Custom CFG Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cfg_standardPath = "Arma3.cfg";
                cfg_old = "Arma3_old.cfg";
            }
            else
            {
                MessageBox.Show("Arma3 Configuration file was not found in default path!\n\nPlace this application in the same folder as the Arma3.cfg file for the application to work! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShouldClose = true;

            }
        }
        private void LoadAndCreate_CFG(string Path) //Loads and changes the current .cfg in memory (does not change the file yet.)
        {
            using (var r = new StreamReader(Path))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    old_CFG.Add(line);
                    new_CFG.Add(ChangeSettings(line));
                }
            }
        }
        private void SaveToTxtFile() //saves the .cfg in memory to the file itself.
        {
            if (System.IO.File.Exists(cfg_old))
            {
                System.IO.File.Delete(cfg_old);
            }
            if (System.IO.File.Exists(cfg_standardPath))
            {
                System.IO.File.Delete(cfg_standardPath);
            }

            TextWriter tw_old = new StreamWriter(cfg_old);
            TextWriter tw_new = new StreamWriter(cfg_standardPath);

            foreach (String s in old_CFG)
            {
                tw_old.WriteLine(s);
            }
            tw_old.Close();

            foreach (String s in new_CFG)
            {
                tw_new.WriteLine(s);
            }
            tw_new.Close();
        }

        private string ChangeSettings(string s) //This function changes the values in the CFG. using a switch case.
        {
            string[] splitted = s.Split('=');
            string value = splitted[1];
            switch (splitted[0])
            {
                case "refresh":
                    value = "144" + ";";
                    break;

                case "multiSampleCount":
                    value = "1" + ";";
                    break;

                case "multiSampleQuality":
                    value = "0" + ";";
                    break;

                case "particlesQuality":
                    value = "1" + ";";
                    break;
                case "GPU_MaxFramesAhead":
                    value = "1" + ";";
                    break;
                case "GPU_DetectedFramesAhead":
                    value = "1" + ";";
                    break;
                case "vsync":
                    value = "0" + ";";
                    break;
                case "cloudsQuality":
                    value = "0" + ";";
                    break;
                case "ppBloom":
                    value = "0" + ";";
                    break;
                case "ppRotBlur":
                    value = "0" + ";";
                    break;
                case "ppRadialBlur":
                    value = "0" + ";";
                    break;
                case "AToC":
                    value = "15" + ";";
                    break;
                case "HDRPrecision":
                    value = "16" + ";";
                    break;
                case "pipQuality":
                    value = "16" + ";";
                    break;
                case "dynamicLightsQuality":
                    value = "0" + ";";
                    break;
                case "waterSSReflectionsQuality":
                    value = "0" + ";";
                    break;
                case "ppCaustics":
                    value = "0" + ";";
                    break;
                case "PPAA":
                    value = "0" + ";";
                    break;
                case "ppSSAO":
                    value = "4" + ";";
                    break;
            }
            return splitted[0] + "=" + value;
        }


        //                          Controls

        private void btnBoost_Click(object sender, EventArgs e)
        {
            if (ArmaCFG_exists(cfg_standardPath)) //if ArmaIII.cfg exists then boost the profile..
            {
                LoadAndCreate_CFG(cfg_standardPath);
                SaveToTxtFile();
                CheckIfReadOnly(cfg_standardPath);
                MessageBox.Show("Arma III Boosted Successfully!", "Credits - Calvv", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLockUnlock_Click(object sender, EventArgs e) //Toggles the armaIII.cfg's read/write properties. 
        {
            SetToOpposit(cfg_standardPath); 
            CheckIfReadOnly(cfg_standardPath);
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {

        }


    }
}
