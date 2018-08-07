using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Notepad
{
    public partial class Form1 : Form
    {
     
        public static SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
        public static OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();

            SaveFileDialog1.InitialDirectory = @"C:\\";
            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog1.RestoreDirectory = true;
            OpenFileDialog1.InitialDirectory = @"C:\\";
            OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog1.RestoreDirectory = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CreateFile
            // File.Create

            SaveFileDialog1.ShowDialog();

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoadFile
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(OpenFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();

            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFile
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText);



            }
        }
    }
}
