using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SpVoice objekspeech = new SpVoice();

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tengahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void kiriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 2f;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 1)
            {
                richTextBox1.ZoomFactor -= 2f;
            }
            
        }

        private void warnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK )
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK )
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
            
        }

        private void bukaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void simpanFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string namafile;
            namafile = openFileDialog1.FileName;
            //sMessageBox.Show(namafile);

            if (namafile != "")
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    namafile = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(namafile);
                }

            }
            else
            {
                richTextBox1.SaveFile(namafile);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            objekspeech.Speak(richTextBox1.Text.Trim(), SpeechVoiceSpeakFlags.SVSFDefault);
            objekspeech.WaitUntilDone(10);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            objekspeech.Pause();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
