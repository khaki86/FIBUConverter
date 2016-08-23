using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string user_defined_date = "";
        private string outfile_name = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
            }
        }
        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            {
                OpenFileDialog openFileDialog2 = new OpenFileDialog();
                openFileDialog2.InitialDirectory = "c:\\";
                openFileDialog2.Filter = "txt files (*.txt)|*.txt";
                openFileDialog2.FilterIndex = 2;
                openFileDialog2.RestoreDirectory = true;
            }
        }
        private void execute_btn_Click(object sender, EventArgs e){
            convert_files();
            sum_rows();
        }
        class SortArray{
            public string ErsterBuchungstext { get; set; }
            public string SummeSoll { get; set; }
            public string Kostenstelle { get; set; }                //gleich mit 
            public string frage1 { get; set; }
            public string Kostentraeger { get; set; }
            public string frage2 { get; set; }
            public string SollKonto { get; set; }
            public string HabenKonto { get; set; }
            public string frage3 { get; set; }
            public string frage4 { get; set; }
            public string frage5 { get; set; }
            public string frage6 { get; set; }
            public string Buchungsdatum { get; set; }
            public string frage7_anderesDatum { get; set; }
            public string summe_ident_konto { get; set; }
        }
        private void convert_files()
        {
            StreamReader sr = new StreamReader(infile_text.Text, System.Text.Encoding.Default);
            string[] row;
            string line1;
            using (StreamWriter sw = new StreamWriter("tmp_sorting_FIBUConverter.txt"))
            {
                while (sr.Peek() > -1)
                {
                    line1 = sr.ReadLine();
                    row = line1.Split(';');    
                    SortArray tmp = new SortArray();
                    tmp.ErsterBuchungstext = row[0];
                    tmp.SummeSoll = row[1];
                    tmp.Kostenstelle = row[2];          //zusammenfassen wenn identisch mit soll haben konto        aufaddieren betrag
                    tmp.frage1 = row[3];
                    tmp.Kostentraeger = row[4];
                    tmp.frage2 = row[5];
                    tmp.SollKonto = row[6];             //soll haben 
                    tmp.HabenKonto = row[7];            //soll haben identisch
                    tmp.frage3 = row[8];
                    tmp.frage4 = row[9];
                    tmp.frage5 = row[10];
                    tmp.frage6 = row[11];
                    tmp.Buchungsdatum = row[12];
                    tmp.frage7_anderesDatum = row[13];
                    for (int i = 0; i <= 13; i++)
                    {
                        row[i] = row[i].Replace("\"", "");
                    }
                    row[1] = row[1].Replace(",", ".");
                    sw.Write(';');
                    sw.Write(';');
                    row[12] = user_defined_date;
                    sw.Write(row[12]);
                    sw.Write(';');
                    sw.Write(row[0]);
                    sw.Write(';');
                    sw.Write(row[6]);
                    sw.Write(';');
                    sw.Write(row[7]);
                    sw.Write(';');
                    sw.Write(row[2]);
                    sw.Write(';');
                    sw.Write(row[1]);
                    sw.Write(';');
                    sw.Write('0');
                    sw.Write('.');
                    sw.Write('0');
                    sw.Write('0');
                    sw.Write(';');
                    sw.Write('E');
                    sw.Write('U');
                    sw.Write('R');
                    sw.Write(';');
                    sw.Write(';');
                    sw.Write(';');
                    sw.Write(';');
                    sw.Write(';');
                    sw.Write(row[4]);
                    sw.Write('\r');
                    sw.Write('\n');
                }
            }
            string lines = "tmp_sorting_FIBUConverter.txt";
            var contents = File.ReadAllLines(lines)
                .Select(x => x.Split(';').ToArray())
                .OrderBy(x => x[3])
                .ThenBy(x => x[4])
                .ThenBy(x => x[5])
                .ThenBy(x => x[6])
                .ThenBy(x => x[14])
                .Select(x => string.Join(";",x));
            File.WriteAllLines("tmp_sorting_FIBUConverter.txt", contents);
    }
        void sum_rows()
        {
            StreamReader sum_sr = new StreamReader("tmp_sorting_FIBUConverter.txt", System.Text.Encoding.Default);
            string[] sum_row;
            string[] last_row = new string[15];
            last_row[0] = "init_string";
            string sum_line;
            double ergebnis = 0;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM-yyyy";
            outfile_name = dateTimePicker1.Text;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            using (StreamWriter sum_sw = new StreamWriter("C-"+outfile_name +".txt", false, Encoding.Default))
            {
                while (sum_sr.Peek() > -1)
                {
                    SortArray sum_tmp = new SortArray();
                    sum_line = sum_sr.ReadLine();
                    sum_row = sum_line.Split(';');
                    if (last_row[0] == "init_string")
                    {
                        for (int i = 0; i <= 14; i++)
                        {
                            last_row[i] = sum_row[i];
                        }
                    }

                    if (sum_row[3] != last_row[3] || sum_row[4] != last_row[4] || sum_row[5] != last_row[5] || sum_row[6] != last_row[6] || sum_row[14] != last_row[14])
                    {
                        for (int i = 0; i <= 6; i++)
                        {
                            sum_sw.Write(last_row[i]);
                            sum_sw.Write(';');
                        }
                        sum_sw.Write(last_row[7]);
                        sum_sw.Write(';');
                        sum_sw.Write(last_row[8]);
                        sum_sw.Write(';');
                        sum_sw.Write(last_row[9]);
                        sum_sw.Write(';');
                        sum_sw.Write(last_row[10]);
                        sum_sw.Write(';');
                        sum_sw.Write(last_row[11]);
                        sum_sw.Write(';');
                        sum_sw.Write(last_row[12]);
                        sum_sw.Write(';');
                        sum_sw.Write(last_row[13]);
                        sum_sw.Write(';');
                        sum_sw.Write(last_row[14]);
                        sum_sw.Write('\r');
                        sum_sw.Write('\n');
                        for (int i = 0; i <= 14; i++)
                        {
                            last_row[i] = sum_row[i];
                        }
                        ergebnis = double.Parse(last_row[7], new NumberFormatInfo() { NumberDecimalSeparator = "." });
                    }

                    else
                    {
                        double m = double.Parse(sum_row[7], new NumberFormatInfo() { NumberDecimalSeparator = "." });
                        ergebnis += m;
                        for (int i = 0; i <= 14; i++)
                        {
                            last_row[i] = sum_row[i];
                        }
                        last_row[7] = ergebnis.ToString("0.00", new NumberFormatInfo() { NumberDecimalSeparator = "." });
                    }
                }
                for (int i = 0; i <= 13; i++)
                {
                    sum_sw.Write(last_row[i]);
                    sum_sw.Write(';');
                }
                sum_sw.Write(last_row[14]);
                checkBox1.Checked = true;
                sum_sw.Close();
                sum_sr.Close();
                File.Delete("tmp_sorting_FIBUConverter.txt");
                execute_btn.Enabled = false;
                execute_btn.Text = "Ende";
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
        }
        private void outfile_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                Console.WriteLine("scheisse");

            }
            outfile_text.Text = openFileDialog1.InitialDirectory + openFileDialog2.FileName;
            is_button_clickable();
        }
        private void is_button_clickable()
        {
            if (infile_text.Text.Length > 0 && user_defined_date.Length >= 8)
            {
                execute_btn.Enabled = true;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            user_defined_date = dateTimePicker1.Text;
            is_button_clickable();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void outfile_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void infile_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}