using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lo_Fi_Radio
{
    public partial class Main_Form : Form
    {
        //some vars
        int x_coord = 0;
        bool first_bg_frame = false;
        bool is_hidden = false;
        bool is_playing = false;

        ContextMenuStrip menu = new ContextMenuStrip();

        public Main_Form()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            //showing start screen
            this.Visible = false;
            Init_Form _Form = new Init_Form();
            _Form.ShowDialog();
            //preparing UI
            BgPic1.Size = BgPic2.Size = BgPic1.Image.Size;
            BgPic1.Location = new Point(-BgPic1.Image.Size.Width, 0);
            BgPic2.Location = new Point(0, 0);
            Status_Label.Visible = false;
            Status_Label.Text = "Подключение к трансляции.";
            Status_Label.Location = new Point(Play_Pause_Button.Location.X - Status_Label.Width / 2, Play_Pause_Button.Location.Y - Status_Label.Height - 10);
            Status_Label.Visible = true;
            //this.Visible = true;
            Anim_Timer.Start();
            //setting URL up
            string txtUrl = "https://www.youtube.com/watch?v=5qap5aO4i9A";
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='420' height='250' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, txtUrl.Split('=')[1]);
            //adding dropmenu items
            menu.Items.Add("Подключение", null, null);
            //menu.Items.Add("Продолжить/Пауза", null, new EventHandler(MenuItemPlayPause_Click));
            menu.Items.Add("Свернуть/Развернуть", null, new EventHandler(MenuItemShowHide_Click));
            menu.Items.Add("Закрыть", null, new EventHandler(MenuItemClose_Click));
            TaskBarIcon.ContextMenuStrip = menu;
        }

        private void Show_Hide()
        {
            if (is_hidden)
            {
                this.Show();
                is_hidden = false;
            }
            else
            {
                this.Hide();
                is_hidden = true;
            }
        }
        private void Play_Pause()
        {
            if (!is_playing)
            {
                Play_Pause_Button.Image = Image.FromFile("src\\media\\pause.png");
                is_playing = true;
            }
            else
            {
                Play_Pause_Button.Image = Image.FromFile("src\\media\\play.png");
                is_playing = false;
            }
            webBrowser1.Focus();
            SendKeys.Send("{TAB}");
            SendKeys.Send("{TAB}");
            SendKeys.Send("k");
        }
        private void MenuItemPlayPause_Click(object sender, EventArgs e)
        {
            Play_Pause();
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemShowHide_Click(object sender, EventArgs e)
        {
            Show_Hide();
        }

        private void Anim_Timer_Tick(object sender, EventArgs e)
        {
            if (!first_bg_frame)
            {
                BgPic2.Location = new Point(++x_coord, 0);
                BgPic1.Location = new Point(BgPic1.Location.X + 1, 0);
                webBrowser1.Location = new Point(x_coord, 0);
                if (BgPic1.Location.X == 0)
                {
                    BgPic2.Location = new Point(-BgPic2.Image.Size.Width, 0);
                    first_bg_frame = true;
                    x_coord = 0;
                    webBrowser1.Location = new Point(x_coord, 0);
                }
            }
            else
            {
                BgPic1.Location = new Point(++x_coord, 0);
                BgPic2.Location = new Point(BgPic2.Location.X + 1, 0);
                webBrowser1.Location = new Point(x_coord, 0);
                if (BgPic2.Location.X == 0)
                {
                    BgPic1.Location = new Point(-BgPic1.Image.Size.Width, 0);
                    first_bg_frame = false;
                    x_coord = 0;
                    webBrowser1.Location = new Point(x_coord, 0);
                }
            }
        }

        private void Main_Form_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.Hide();
        }

        private void TaskBarIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.Show();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ShowInTaskbar = false;
        }

        private void Play_Pause_Button_Click(object sender, EventArgs e)
        {
            Play_Pause();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            menu.Items.RemoveAt(0);
            menu.Items.RemoveAt(0);
            menu.Items.RemoveAt(0);
           //menu.Items.RemoveAt(0);

            menu.Items.Add("Подключено", null, null);
            //menu.Items.Add("Продолжить/Пауза", null, new EventHandler(MenuItemPlayPause_Click));
            menu.Items.Add("Свернуть/Развернуть", null, new EventHandler(MenuItemShowHide_Click));
            menu.Items.Add("Закрыть", null, new EventHandler(MenuItemClose_Click));
            Status_Label.Text = "Подключение установлено";
            Status_Label.Location = new Point(Play_Pause_Button.Location.X - Status_Label.Width / 2, Play_Pause_Button.Location.Y - Status_Label.Height - 10);
            //Status_Label.Visible = true;
        }
    }
}
