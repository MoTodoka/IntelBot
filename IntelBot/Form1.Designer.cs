namespace IntelBot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.ChannelName = new System.Windows.Forms.TextBox();
            this.System1 = new System.Windows.Forms.TextBox();
            this.System4 = new System.Windows.Forms.TextBox();
            this.System3 = new System.Windows.Forms.TextBox();
            this.System2 = new System.Windows.Forms.TextBox();
            this.System6 = new System.Windows.Forms.TextBox();
            this.System5 = new System.Windows.Forms.TextBox();
            this.System7 = new System.Windows.Forms.TextBox();
            this.System8 = new System.Windows.Forms.TextBox();
            this.labelChan2 = new System.Windows.Forms.Label();
            this.labelSys2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.labelChan = new System.Windows.Forms.Label();
            this.labelSys = new System.Windows.Forms.Label();
            this.ChatOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkZKill = new System.Windows.Forms.LinkLabel();
            this.System9 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StartButton.Location = new System.Drawing.Point(488, 18);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // ChannelName
            // 
            this.ChannelName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChannelName.Location = new System.Drawing.Point(12, 34);
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.Size = new System.Drawing.Size(470, 20);
            this.ChannelName.TabIndex = 1;
            // 
            // System1
            // 
            this.System1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System1.Location = new System.Drawing.Point(12, 108);
            this.System1.Name = "System1";
            this.System1.Size = new System.Drawing.Size(206, 20);
            this.System1.TabIndex = 4;
            // 
            // System4
            // 
            this.System4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System4.Location = new System.Drawing.Point(12, 134);
            this.System4.Name = "System4";
            this.System4.Size = new System.Drawing.Size(206, 20);
            this.System4.TabIndex = 7;
            // 
            // System3
            // 
            this.System3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System3.Location = new System.Drawing.Point(438, 108);
            this.System3.Name = "System3";
            this.System3.Size = new System.Drawing.Size(206, 20);
            this.System3.TabIndex = 6;
            // 
            // System2
            // 
            this.System2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System2.Location = new System.Drawing.Point(226, 108);
            this.System2.Name = "System2";
            this.System2.Size = new System.Drawing.Size(206, 20);
            this.System2.TabIndex = 5;
            // 
            // System6
            // 
            this.System6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System6.Location = new System.Drawing.Point(438, 134);
            this.System6.Name = "System6";
            this.System6.Size = new System.Drawing.Size(206, 20);
            this.System6.TabIndex = 9;
            // 
            // System5
            // 
            this.System5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System5.Location = new System.Drawing.Point(226, 134);
            this.System5.Name = "System5";
            this.System5.Size = new System.Drawing.Size(206, 20);
            this.System5.TabIndex = 8;
            // 
            // System7
            // 
            this.System7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System7.Location = new System.Drawing.Point(12, 160);
            this.System7.Name = "System7";
            this.System7.Size = new System.Drawing.Size(206, 20);
            this.System7.TabIndex = 10;
            // 
            // System8
            // 
            this.System8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System8.Location = new System.Drawing.Point(226, 160);
            this.System8.Name = "System8";
            this.System8.Size = new System.Drawing.Size(206, 20);
            this.System8.TabIndex = 11;
            // 
            // labelChan2
            // 
            this.labelChan2.AutoSize = true;
            this.labelChan2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelChan2.Location = new System.Drawing.Point(275, 18);
            this.labelChan2.Name = "labelChan2";
            this.labelChan2.Size = new System.Drawing.Size(207, 13);
            this.labelChan2.TabIndex = 25;
            this.labelChan2.Text = "Please take care of upper and lower case.";
            // 
            // labelSys2
            // 
            this.labelSys2.AutoSize = true;
            this.labelSys2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSys2.Location = new System.Drawing.Point(374, 92);
            this.labelSys2.Name = "labelSys2";
            this.labelSys2.Size = new System.Drawing.Size(270, 13);
            this.labelSys2.TabIndex = 25;
            this.labelSys2.Text = "You can add max. 9 systems or names to your watchlist.";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SaveButton.Location = new System.Drawing.Point(569, 31);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // labelChan
            // 
            this.labelChan.AutoSize = true;
            this.labelChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelChan.Location = new System.Drawing.Point(9, 14);
            this.labelChan.Name = "labelChan";
            this.labelChan.Size = new System.Drawing.Size(110, 18);
            this.labelChan.TabIndex = 25;
            this.labelChan.Text = "Channelname";
            // 
            // labelSys
            // 
            this.labelSys.AutoSize = true;
            this.labelSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSys.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSys.Location = new System.Drawing.Point(9, 87);
            this.labelSys.Name = "labelSys";
            this.labelSys.Size = new System.Drawing.Size(55, 18);
            this.labelSys.TabIndex = 25;
            this.labelSys.Text = "Filters";
            // 
            // ChatOutput
            // 
            this.ChatOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChatOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatOutput.Location = new System.Drawing.Point(12, 198);
            this.ChatOutput.Name = "ChatOutput";
            this.ChatOutput.ReadOnly = true;
            this.ChatOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatOutput.Size = new System.Drawing.Size(630, 407);
            this.ChatOutput.TabIndex = 25;
            this.ChatOutput.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "© Gerrit Pasberg";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(418, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "If u like my work, dontate to:";
            // 
            // linkZKill
            // 
            this.linkZKill.ActiveLinkColor = System.Drawing.Color.Orange;
            this.linkZKill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkZKill.AutoSize = true;
            this.linkZKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkZKill.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.linkZKill.LinkColor = System.Drawing.Color.Orange;
            this.linkZKill.Location = new System.Drawing.Point(564, 608);
            this.linkZKill.Name = "linkZKill";
            this.linkZKill.Size = new System.Drawing.Size(78, 15);
            this.linkZKill.TabIndex = 13;
            this.linkZKill.TabStop = true;
            this.linkZKill.Text = "Mo Todoka";
            this.linkZKill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkZKill_LinkClicked);
            // 
            // System9
            // 
            this.System9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.System9.Location = new System.Drawing.Point(438, 160);
            this.System9.Name = "System9";
            this.System9.Size = new System.Drawing.Size(206, 20);
            this.System9.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "http://cdn1.eveonline.com/community/devblog/2014/ArtOfRubicon/Wreck_New_08.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(662, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1444, 168);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(488, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(658, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.System9);
            this.Controls.Add(this.linkZKill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChatOutput);
            this.Controls.Add(this.labelSys);
            this.Controls.Add(this.labelChan);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.labelSys2);
            this.Controls.Add(this.labelChan2);
            this.Controls.Add(this.System8);
            this.Controls.Add(this.System7);
            this.Controls.Add(this.System5);
            this.Controls.Add(this.System6);
            this.Controls.Add(this.System2);
            this.Controls.Add(this.System3);
            this.Controls.Add(this.System4);
            this.Controls.Add(this.System1);
            this.Controls.Add(this.ChannelName);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IntelBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        //Labels
        private System.Windows.Forms.Label labelSys;
        private System.Windows.Forms.Label labelChan;
        private System.Windows.Forms.Label labelChan2;
        private System.Windows.Forms.Label labelSys2;

        //InPut
        public System.Windows.Forms.TextBox ChannelName;
        public System.Windows.Forms.TextBox System1;
        public System.Windows.Forms.TextBox System4;
        public System.Windows.Forms.TextBox System3;
        public System.Windows.Forms.TextBox System2;
        public System.Windows.Forms.TextBox System6;
        public System.Windows.Forms.TextBox System5;
        public System.Windows.Forms.TextBox System7;
        public System.Windows.Forms.TextBox System8;
        public System.Windows.Forms.TextBox System9;

        //Buttons
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.Button StartButton;

        //Output
        public System.Windows.Forms.RichTextBox ChatOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkZKill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button button1;
    }
}

