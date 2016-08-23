using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                // Insert code to read the stream here.
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Datei konnte nicht gelesen werden: " + ex.Message);
                    }
                }*/
            }

        }
        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog2 = new OpenFileDialog();

                openFileDialog2.InitialDirectory = "c:\\";
                openFileDialog2.Filter = "txt files (*.txt)|*.txt";
                openFileDialog2.FilterIndex = 2;
                openFileDialog2.RestoreDirectory = true;

                /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                // Insert code to read the stream here.
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Datei konnte nicht gelesen werden: " + ex.Message);
                    }
                }*/
            }

        }

        private void execute_btn_Click(object sender, EventArgs e)
        {
            // TO-DO conversion XML rows redefine


            convert_files();

        }

        private void convert_files()
        {
            StreamReader sr = new StreamReader(infile_text.Text);
            using (StreamWriter sw = new StreamWriter(outfile_text.Text))
            {
                while (sr.Peek() > -1) 
                {
                    //char[] row = new char[10];
                    //row[0] = (char)sr.Read();
                    sw.Write((char)sr.Read());
                    if ((char)sr.Peek() == ';')
                    {
                        //Console.Write((char)sr.Read());
                        
                        sw.Write(".");
                    }
                    checkBox1.Checked = true;
                }
            }
        }
        

        private void infile_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
            infile_text.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            is_button_clickable();
            //Console.WriteLine(result);
        }

        private void outfile_btn_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                Console.WriteLine("scheisse");
                              
            }
            //Console.WriteLine(result);
            outfile_text.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            is_button_clickable();
        }

        private void is_button_clickable()
        {
            if (infile_text.Text.Length > 0 && outfile_text.Text.Length > 0)
            {
                execute_btn.Enabled = true;
            }
        }
    }
}
