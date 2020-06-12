namespace Lo_Fi_Radio
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Anim_Timer = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TaskBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Play_Pause_Button = new System.Windows.Forms.PictureBox();
            this.BgPic2 = new System.Windows.Forms.PictureBox();
            this.BgPic1 = new System.Windows.Forms.PictureBox();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Image_List = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Play_Pause_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Anim_Timer
            // 
            this.Anim_Timer.Interval = 80;
            this.Anim_Timer.Tick += new System.EventHandler(this.Anim_Timer_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-1, -1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // TaskBarIcon
            // 
            this.TaskBarIcon.BalloonTipText = "Дважды щелкните на значок приложения в строке состояния для разворачивания прилож" +
    "ения";
            this.TaskBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskBarIcon.Icon")));
            this.TaskBarIcon.Text = "Lo-Fi Radio";
            this.TaskBarIcon.Visible = true;
            this.TaskBarIcon.DoubleClick += new System.EventHandler(this.TaskBarIcon_DoubleClick);
            // 
            // Play_Pause_Button
            // 
            this.Play_Pause_Button.Image = global::Lo_Fi_Radio.Properties.Resources.play;
            this.Play_Pause_Button.Location = new System.Drawing.Point(437, 428);
            this.Play_Pause_Button.Name = "Play_Pause_Button";
            this.Play_Pause_Button.Size = new System.Drawing.Size(102, 97);
            this.Play_Pause_Button.TabIndex = 3;
            this.Play_Pause_Button.TabStop = false;
            this.Play_Pause_Button.Click += new System.EventHandler(this.Play_Pause_Button_Click);
            // 
            // BgPic2
            // 
            this.BgPic2.Image = global::Lo_Fi_Radio.Properties.Resources.bg1;
            this.BgPic2.Location = new System.Drawing.Point(129, 25);
            this.BgPic2.Name = "BgPic2";
            this.BgPic2.Size = new System.Drawing.Size(111, 136);
            this.BgPic2.TabIndex = 1;
            this.BgPic2.TabStop = false;
            // 
            // BgPic1
            // 
            this.BgPic1.Image = global::Lo_Fi_Radio.Properties.Resources.bg1;
            this.BgPic1.Location = new System.Drawing.Point(12, 25);
            this.BgPic1.Name = "BgPic1";
            this.BgPic1.Size = new System.Drawing.Size(111, 136);
            this.BgPic1.TabIndex = 0;
            this.BgPic1.TabStop = false;
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.BackColor = System.Drawing.Color.Transparent;
            this.Status_Label.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Status_Label.Location = new System.Drawing.Point(448, 401);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(82, 24);
            this.Status_Label.TabIndex = 4;
            this.Status_Label.Text = "Status";
            this.Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Image_List
            // 
            this.Image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Image_List.ImageStream")));
            this.Image_List.TransparentColor = System.Drawing.Color.Transparent;
            this.Image_List.Images.SetKeyName(0, "play.png");
            this.Image_List.Images.SetKeyName(1, "pause.png");
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Play_Pause_Button);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BgPic2);
            this.Controls.Add(this.BgPic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Play_Pause_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgPic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BgPic1;
        private System.Windows.Forms.PictureBox BgPic2;
        private System.Windows.Forms.Timer Anim_Timer;
        private System.Windows.Forms.NotifyIcon TaskBarIcon;
        private System.Windows.Forms.PictureBox Play_Pause_Button;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.ImageList Image_List;
    }
}