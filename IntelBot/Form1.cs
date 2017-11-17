using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace IntelBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }
        private string chatOutput = "";
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\EVE\\logs\\Chatlogs\\";
        private string configPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\IntelBot\\";
        private System.Media.SoundPlayer player;
        private static string ReadConfig(string key, string configPath)
        {
            string inputFromConfig = "";
            var filestream = new System.IO.FileStream(configPath + "IntelBotConfig.txt", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
            System.IO.StreamReader file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
            string conftxt = file.ReadToEnd();
            file.Close();
            if (conftxt.Length > 0)
            {
                string[] lines = conftxt.Split(new char[] { '\n' });
                Dictionary<string, string> mysettings = new Dictionary<string, string>();
                foreach (string line in lines)
                {
                    string[] keyAndValue = line.Split(new char[] { '=' });
                    mysettings.Add(keyAndValue[0].Trim(), keyAndValue[1].Trim());
                }
                inputFromConfig = mysettings[key];
            }
            return inputFromConfig;

        }
        private static string GetFileName(string channel, string path)
        {
            System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(path);
            DateTime today = DateTime.Today;
            DateTime creationTime;
            string fileName = "";
            DateTime latest = new DateTime
                (
                    today.Year,
                    today.Month,
                    today.Day - 1
                );
            foreach (System.IO.FileInfo allFiles in ParentDirectory.GetFiles())
            {
                creationTime = allFiles.CreationTime;

                if (creationTime >= latest && allFiles.Name.Contains(channel))
                {
                    latest = creationTime;
                    fileName = allFiles.Name;
                }
            }
            return fileName;
        }
        private static List<string> ReadLinesFromFile(string filePath)
        {
            var filestream = new System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
            System.IO.StreamReader file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);

            string line;
            List<string> lines = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("[ ") && !line.Contains("MOTD"))
                {
                    lines.Add(line);
                }
            }
            file.Close();
            return lines;
        }
        private static bool SaveToConf(string configPath, string channel, string[] filters)
        {
            string[] lines = { "channel = " + channel, "filter1 = " + filters[0], "filter2 = " + filters[1], "filter3 = " + filters[2], "filter4 = " + filters[3], "filter5 = " + filters[4], "filter6 = " + filters[5], "filter7 = " + filters[6], "filter8 = " + filters[7], "filter9 = " + filters[8] };
            using (System.IO.StreamWriter sw = System.IO.File.CreateText(configPath + "IntelBotConfig.txt"))
            {
                for (int i = 0; i < 9; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                sw.Write(lines[9]);
            }
            return true;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();
        }
        private void LinkZKill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://zkillboard.com/character/95939134/");
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ChannelName.Text == "")
                chatOutput += "[WARNING] Please enter at least a Channel before Saving.\n";
            else
            {
                string[] filters = new string[] { System1.Text, System2.Text, System3.Text, System4.Text, System5.Text, System6.Text, System7.Text, System8.Text, System9.Text, };
                string channel = ChannelName.Text;
                bool done = SaveToConf(configPath, channel, filters);
                if (done == true)
                    chatOutput += "[info] Settings saved to Config.\n";
                else
                    chatOutput += "[ERROR] Settings could not be saved to Config!\n";
            }
            ChatOutput.Text = chatOutput;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var filestream = new System.IO.FileStream(configPath + "IntelBotConfig.txt", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
            System.IO.StreamReader file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
            string conftxt = file.ReadToEnd();
            file.Close();
            if (conftxt == "")
            {
                string[] filters = new string[] { "", "", "", "", "", "", "", "", "", };
                System.IO.Directory.CreateDirectory(configPath);
                bool done = SaveToConf(configPath, "Local", filters);
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileAsync(new System.Uri("https://dl.dropboxusercontent.com/s/xbs42i9b5q74p90/Jamaican%20Horn%20Siren.wav"),
                    configPath + "\\alarm.wav");
                }
                player = new System.Media.SoundPlayer(configPath + "alarm.wav");
                if (done == true)
                {
                    ChannelName.Text = "Local";
                    chatOutput += "[info] File: IntelBotConfig.txt Created.\n";
                    chatOutput += "[info] File: alarm.wav created. To change the alarm-sound go to " + configPath + " and change the file \"alarm.wav\".\n";
                }
                else
                    chatOutput += "[ERROR] Config could not be created!\n";
            }
            else
            {
                ChannelName.Text = ReadConfig("channel", configPath);
                System1.Text = ReadConfig("filter1", configPath);
                System2.Text = ReadConfig("filter2", configPath);
                System3.Text = ReadConfig("filter3", configPath);
                System4.Text = ReadConfig("filter4", configPath);
                System5.Text = ReadConfig("filter5", configPath);
                System6.Text = ReadConfig("filter6", configPath);
                System7.Text = ReadConfig("filter7", configPath);
                System8.Text = ReadConfig("filter8", configPath);
                System9.Text = ReadConfig("filter9", configPath);
                chatOutput += "[info] File: IntelBotConfig.txt found and applied.\n";
            }
            this.Invoke(new MethodInvoker(delegate { ChatOutput.Text = chatOutput; ChatOutput.SelectionStart = ChatOutput.Text.Length; ChatOutput.ScrollToCaret(); }));
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            chatOutput = "[info] Starting IntelBot...\n";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\EVE\\logs\\Chatlogs\\";
            string channelInput = ChannelName.Text;
            chatOutput += "[info] Path found: " + path + "\n";
            this.Invoke(new MethodInvoker(delegate { ChatOutput.Text = chatOutput; ChatOutput.SelectionStart = ChatOutput.Text.Length; ChatOutput.ScrollToCaret(); }));
            string fileName = GetFileName(channelInput, path);
            if (fileName == "")
            {
                chatOutput += "[ERROR] Channel not found. Please check your input and try again!\n";
                ChatOutput.Text = chatOutput;
                ChatOutput.SelectionStart = ChatOutput.Text.Length;
                ChatOutput.ScrollToCaret();
            }
            else
            {
                chatOutput += "[info] Chat found: " + fileName + "\n";
                this.Invoke(new MethodInvoker(delegate { ChatOutput.Text = chatOutput; ChatOutput.SelectionStart = ChatOutput.Text.Length; ChatOutput.ScrollToCaret(); }));
                string filePath = path + fileName;
                string keyword1 = System1.Text;
                if (keyword1 == "") { keyword1 = "nofilterusedasdf1234"; }
                string keyword2 = System2.Text;
                if (keyword2 == "") { keyword2 = "nofilterusedasdf1234"; }
                string keyword3 = System3.Text;
                if (keyword3 == "") { keyword3 = "nofilterusedasdf1234"; }
                string keyword4 = System4.Text;
                if (keyword4 == "") { keyword4 = "nofilterusedasdf1234"; }
                string keyword5 = System5.Text;
                if (keyword5 == "") { keyword5 = "nofilterusedasdf1234"; }
                string keyword6 = System6.Text;
                if (keyword6 == "") { keyword6 = "nofilterusedasdf1234"; }
                string keyword7 = System7.Text;
                if (keyword7 == "") { keyword7 = "nofilterusedasdf1234"; }
                string keyword8 = System8.Text;
                if (keyword8 == "") { keyword8 = "nofilterusedasdf1234"; }
                string keyword9 = System9.Text;
                if (keyword9 == "") { keyword9 = "nofilterusedasdf1234"; }
                string[] keywords = new string[] { keyword1, keyword2, keyword3, keyword4, keyword5, keyword6, keyword7, keyword8, keyword9 };

                chatOutput += "[info] Filters applied\n";
                this.Invoke(new MethodInvoker(delegate { ChatOutput.Text = chatOutput; ChatOutput.SelectionStart = ChatOutput.Text.Length; ChatOutput.ScrollToCaret(); }));
                chatOutput += "[info] IntelBot running...\n";
                this.Invoke(new MethodInvoker(delegate { ChatOutput.Text = chatOutput; ChatOutput.SelectionStart = ChatOutput.Text.Length; ChatOutput.ScrollToCaret(); }));

                int WrittenLines = 0;
                player = new System.Media.SoundPlayer(configPath + "alarm.wav");
                while (true)
                {
                    var allLines = ReadLinesFromFile(filePath);
                    for (int i = WrittenLines; i < allLines.Count; i++) //Alle Zeilen durchgehen
                    {
                        if (WrittenLines < allLines.Count) //Alte Zeilen ausfiltern
                        {
                            if (allLines[i].Contains(keywords[0]) || allLines[i].Contains(keywords[1]) || allLines[i].Contains(keywords[2]) || allLines[i].Contains(keywords[3]) || allLines[i].Contains(keywords[4]) || allLines[i].Contains(keywords[5]) || allLines[i].Contains(keywords[6]) || allLines[i].Contains(keywords[7]) || allLines[i].Contains(keywords[8])) //Nach Keywords filtern
                            {
                                chatOutput += "---WARNING!---  ";
                                player.Play();
                            }
                            chatOutput += allLines[i] + "\n";
                            this.Invoke(new MethodInvoker(delegate { ChatOutput.Text = chatOutput; ChatOutput.SelectionStart = ChatOutput.Text.Length; ChatOutput.ScrollToCaret(); }));
                            WrittenLines = i + 1;
                        }
                    }
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
                chatOutput += "[info] IntelBot was stopped.\n";
                this.Invoke(new MethodInvoker(delegate { ChatOutput.Text = chatOutput; ChatOutput.SelectionStart = ChatOutput.Text.Length; ChatOutput.ScrollToCaret(); }));
            }
        }
    }
}
