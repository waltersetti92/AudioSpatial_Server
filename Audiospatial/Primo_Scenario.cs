using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Audiospatial
{
    public partial class Primo_Scenario : UserControl
    {
        public Main parentForm { get; set; }
        public Speakers speakers = null;
        public int timeleft = 10;
        public int timer_game = 0;
        private int total_seconds;
        public int seconds = 0;
        public int minutes = 5;
        public string put_started;
        public string put_wait_data;

        public Primo_Scenario()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.lion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            speakers = new Speakers();
            put_started = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=1&k=7";
            put_wait_data = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=1&k=14" + "&data=" + "{\"answer\": \"Inserisci il risultato corretto\", \"input_type\":\"\"}";
        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }
        public void setMessage_ps(string bt_text)
        {
            Visible = true;
            if (bt_text.Length > 0)
            {
   
                //Start.Visible = true;
               //Start.Select();
            }
            else
            {
                //Start.Text = "";
                //Start.Visible = false;
            }
        }

        private void Primo_Scenario_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            total_seconds = (minutes * 60) + seconds;
            parentForm.playbackResourceAudio("Alarm_sound");
            timer1.Start();
        }

        private void Start_Click(object sender, EventArgs e)
        {
           parentForm.closeMessage();
        }

        private void Alarm_Click_1(object sender, EventArgs e)
        {
            parentForm.playbackResourceAudio("Alarm_sound09");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //parentForm.playbackResourceAudio("Alarm_sound");
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timeleft > 0)
            {
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10)
                        {
                            await uda_server_communication.Server_Request(put_started);
                        }
                        Thread.Sleep(1000);
                        timeleft--;
                        timerlabel.Text = timeleft.ToString();
                    }
                    break;
                }
            }
            else if (timeleft == 0)
            {
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10)
                        {
                            await uda_server_communication.Server_Request(put_wait_data);
                        }
                        this.timer1.Stop();
                        timerlabel.Enabled = false;
                        timerlabel.Visible = false;
                        await uda_server_communication.Server_Request(put_wait_data);
                        parentForm.closeMessage();
                    }
                    break;
                }

            }
        }
    }
}
