using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Threading;

namespace Speak_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        SpVoice sound = new SpVoice();
        Thread th;
        string text;
        bool k = true;
        private void Start_BTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Start_BTN.Visible = false;
                Stop_BTN.Visible = true;
                text = richTextBox1.Text;

                th = new Thread(SpeakText); th.Start();
            }
        }

        private void SpeakText()
        {
            richTextBox1.ReadOnly = true;
            richTextBox1.Cursor = Cursors.No;
            status_label.Text = "Reading...";
            if (!k)
            {
                sound.Resume();
                k = true;
            }
            else
            {
                sound.Speak(text, SpeechVoiceSpeakFlags.SVSFDefault);
                EndStream();
            }
            richTextBox1.ReadOnly = false;
            richTextBox1.Cursor= Cursors.IBeam;
        }
        private void EndStream()
        {
            Stop_BTN.Visible = false;
            Start_BTN.Visible = true;
            status_label.Text = "Write the text to be read";
            MessageBox.Show("Text successfully read","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Stop_BTN_Click(object sender, EventArgs e)
        {
            Stop_BTN.Visible = false;
            Start_BTN.Visible = true;
            sound.Pause();
            status_label.Text = "Paused";
            k = false;
        }

        private void Volume_trackBar_Scroll(object sender, EventArgs e)
        {
            int trackbarvolume = volume_trackBar.Value;
            sound.Volume = trackbarvolume;
            sound_value_label.Text = trackbarvolume.ToString() + "%";
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Restart the application ?","Warning !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult.Yes == dialog)
                Application.Restart();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                var dialog = MessageBox.Show("Do you want the text to be cleared ?", "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (DialogResult.Yes == dialog)
                    richTextBox1.Clear();
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //Thanks for watching :)
    }
}
