namespace Lo_Fi_Radio
{
    partial class Init_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FadeIn_Timer = new System.Windows.Forms.Timer(this.components);
            this.Load_Timer = new System.Windows.Forms.Timer(this.components);
            this.FadeOut_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FadeIn_Timer
            // 
            this.FadeIn_Timer.Enabled = true;
            this.FadeIn_Timer.Interval = 10;
            this.FadeIn_Timer.Tick += new System.EventHandler(this.FadeIn_Timer_Tick);
            // 
            // Load_Timer
            // 
            this.Load_Timer.Interval = 2000;
            this.Load_Timer.Tick += new System.EventHandler(this.Load_Timer_Tick);
            // 
            // FadeOut_Timer
            // 
            this.FadeOut_Timer.Interval = 10;
            this.FadeOut_Timer.Tick += new System.EventHandler(this.FadeOut_Timer_Tick);
            // 
            // Init_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 480);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Init_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Init_Form";
            this.Load += new System.EventHandler(this.Init_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer FadeIn_Timer;
        private System.Windows.Forms.Timer Load_Timer;
        private System.Windows.Forms.Timer FadeOut_Timer;
    }
}

