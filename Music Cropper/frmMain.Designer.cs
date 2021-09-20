
namespace Music_Cropper
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCrop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNowTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.btnGetStartTime = new System.Windows.Forms.Button();
            this.btnGetEndTime = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStartTime = new System.Windows.Forms.MaskedTextBox();
            this.txtEndTime = new System.Windows.Forms.MaskedTextBox();
            this.btnStartTimeToPlayer = new System.Windows.Forms.Button();
            this.btnEndTimeToPlayer = new System.Windows.Forms.Button();
            this.btnETToST = new System.Windows.Forms.Button();
            this.btnSTToET = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrop
            // 
            this.btnCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrop.Enabled = false;
            this.btnCrop.Location = new System.Drawing.Point(168, 186);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(143, 33);
            this.btnCrop.TabIndex = 0;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "End time";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(12, 120);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(299, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNowTime
            // 
            this.lblNowTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNowTime.AutoSize = true;
            this.lblNowTime.Enabled = false;
            this.lblNowTime.Location = new System.Drawing.Point(13, 168);
            this.lblNowTime.Name = "lblNowTime";
            this.lblNowTime.Size = new System.Drawing.Size(49, 15);
            this.lblNowTime.TabIndex = 7;
            this.lblNowTime.Text = "00:00:00";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Enabled = false;
            this.lblTotalTime.Location = new System.Drawing.Point(262, 168);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(49, 15);
            this.lblTotalTime.TabIndex = 8;
            this.lblTotalTime.Text = "00:00:00";
            // 
            // btnGetStartTime
            // 
            this.btnGetStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetStartTime.Enabled = false;
            this.btnGetStartTime.Location = new System.Drawing.Point(143, 61);
            this.btnGetStartTime.Name = "btnGetStartTime";
            this.btnGetStartTime.Size = new System.Drawing.Size(33, 23);
            this.btnGetStartTime.TabIndex = 9;
            this.btnGetStartTime.Text = "Get";
            this.btnGetStartTime.UseVisualStyleBackColor = true;
            this.btnGetStartTime.Click += new System.EventHandler(this.btnGetStartTime_Click);
            // 
            // btnGetEndTime
            // 
            this.btnGetEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetEndTime.Enabled = false;
            this.btnGetEndTime.Location = new System.Drawing.Point(143, 90);
            this.btnGetEndTime.Name = "btnGetEndTime";
            this.btnGetEndTime.Size = new System.Drawing.Size(33, 23);
            this.btnGetEndTime.TabIndex = 10;
            this.btnGetEndTime.Text = "Get";
            this.btnGetEndTime.UseVisualStyleBackColor = true;
            this.btnGetEndTime.Click += new System.EventHandler(this.btnGetEndTime_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(12, 186);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(87, 33);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(85, 7);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(170, 23);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Select File";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 36);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 15);
            this.lblFile.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 224);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(323, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Location = new System.Drawing.Point(85, 62);
            this.txtStartTime.Mask = "00:00:00";
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(52, 23);
            this.txtStartTime.TabIndex = 15;
            this.txtStartTime.Text = "000000";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Enabled = false;
            this.txtEndTime.Location = new System.Drawing.Point(85, 92);
            this.txtEndTime.Mask = "00:00:00";
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(52, 23);
            this.txtEndTime.TabIndex = 16;
            this.txtEndTime.Text = "000000";
            // 
            // btnStartTimeToPlayer
            // 
            this.btnStartTimeToPlayer.Enabled = false;
            this.btnStartTimeToPlayer.Location = new System.Drawing.Point(180, 61);
            this.btnStartTimeToPlayer.Name = "btnStartTimeToPlayer";
            this.btnStartTimeToPlayer.Size = new System.Drawing.Size(62, 23);
            this.btnStartTimeToPlayer.TabIndex = 17;
            this.btnStartTimeToPlayer.Text = "To Player";
            this.btnStartTimeToPlayer.UseVisualStyleBackColor = true;
            this.btnStartTimeToPlayer.Click += new System.EventHandler(this.btnStartTimeToPlayer_Click);
            // 
            // btnEndTimeToPlayer
            // 
            this.btnEndTimeToPlayer.Enabled = false;
            this.btnEndTimeToPlayer.Location = new System.Drawing.Point(180, 90);
            this.btnEndTimeToPlayer.Name = "btnEndTimeToPlayer";
            this.btnEndTimeToPlayer.Size = new System.Drawing.Size(62, 23);
            this.btnEndTimeToPlayer.TabIndex = 18;
            this.btnEndTimeToPlayer.Text = "To Player";
            this.btnEndTimeToPlayer.UseVisualStyleBackColor = true;
            this.btnEndTimeToPlayer.Click += new System.EventHandler(this.btnEndTimeToPlayer_Click);
            // 
            // btnETToST
            // 
            this.btnETToST.Enabled = false;
            this.btnETToST.Location = new System.Drawing.Point(248, 90);
            this.btnETToST.Name = "btnETToST";
            this.btnETToST.Size = new System.Drawing.Size(62, 23);
            this.btnETToST.TabIndex = 20;
            this.btnETToST.Text = "To ST";
            this.btnETToST.UseVisualStyleBackColor = true;
            this.btnETToST.Click += new System.EventHandler(this.btnETToST_Click);
            // 
            // btnSTToET
            // 
            this.btnSTToET.Enabled = false;
            this.btnSTToET.Location = new System.Drawing.Point(248, 61);
            this.btnSTToET.Name = "btnSTToET";
            this.btnSTToET.Size = new System.Drawing.Size(62, 23);
            this.btnSTToET.TabIndex = 19;
            this.btnSTToET.Text = "To ET";
            this.btnSTToET.UseVisualStyleBackColor = true;
            this.btnSTToET.Click += new System.EventHandler(this.btnSTToET_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 246);
            this.Controls.Add(this.btnETToST);
            this.Controls.Add(this.btnSTToET);
            this.Controls.Add(this.btnEndTimeToPlayer);
            this.Controls.Add(this.btnStartTimeToPlayer);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnGetEndTime);
            this.Controls.Add(this.btnGetStartTime);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblNowTime);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Cropper";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNowTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Button btnGetStartTime;
        private System.Windows.Forms.Button btnGetEndTime;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MaskedTextBox txtStartTime;
        private System.Windows.Forms.MaskedTextBox txtEndTime;
        private System.Windows.Forms.Button btnStartTimeToPlayer;
        private System.Windows.Forms.Button btnEndTimeToPlayer;
        private System.Windows.Forms.Button btnETToST;
        private System.Windows.Forms.Button btnSTToET;
    }
}