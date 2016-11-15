using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace ProtokolUltrazvuk
{
    public partial class ThirdForm : Form
    {
        Random rand = new Random();

        public static void ExportToWord(DataGridView dgv)
        {
            MessageBox.Show("Opening Word");

            word.Application word = null;



            word.Document doc = null;
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            try
            {
                word = new word.Application();
                word.Visible = true;
                doc = word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
            if (word != null && doc != null)
            {
                word.Table newTable;
                word.Range wrdRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                newTable = doc.Tables.Add(wrdRng, 1, dgv.Columns.Count - 1, ref oMissing, ref oMissing);
                newTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.AllowAutoFit = true;

                foreach (DataGridViewCell cell in dgv.Rows[0].Cells)
                {
                    newTable.Cell(newTable.Rows.Count, cell.ColumnIndex).Range.Text = dgv.Columns[cell.ColumnIndex].Name;

                }
                newTable.Rows.Add();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        newTable.Cell(newTable.Rows.Count, cell.ColumnIndex).Range.Text = cell.Value.ToString();
                    }
                    newTable.Rows.Add();
                }
            }

        }

        public ThirdForm()
        {
            InitializeComponent();
        }

        private string GetCalcThickness1(string text)
        {
            if (string.IsNullOrEmpty(text))
                return (string)null;
            double num = 0.8 + new Random().NextDouble() * (1.0 / 5.0);
            return Math.Round(Convert.ToDouble(text) * num, 1).ToString();
        }

        private string GetCalcThickness2(string text)
        {
            if (string.IsNullOrEmpty(text))
                return (string)null;
            double num = 0.8 + rand.NextDouble() * (1.0 / 5.0);
            return Math.Round(Convert.ToDouble(text) * num, 1).ToString();
        }

        private string GetCalcThickness3(string text)
        {
            if (string.IsNullOrEmpty(text))
                return (string)null;
            double num = 0.8 + rand.NextDouble() * (1.0 / 5.0);
            return Math.Round(Convert.ToDouble(text) * num, 1).ToString();
        }

        private string GetCalcThickness4(string text)
        {
            if (string.IsNullOrEmpty(text))
                return (string)null;
            double num = 0.8 + rand.NextDouble() * (1.0 / 5.0);
            return Math.Round(Convert.ToDouble(text) * num, 1).ToString();
        }

        private string GetCalcThickness5(string text)
        {
            if (string.IsNullOrEmpty(text))
                return (string)null;
            double num = 0.8 + rand.NextDouble() * (1.0 / 5.0);
            return Math.Round(Convert.ToDouble(text) * num, 1).ToString();
        }

        private string GetCalcThickness6(string text)
        {
            if (string.IsNullOrEmpty(text))
                return (string)null;
            double num = 0.8 + rand.NextDouble() * (1.0 / 5.0);
            return Math.Round(Convert.ToDouble(text) * num, 1).ToString();
        }

        private string GetCalcThickness7(string text)
        {
            if (string.IsNullOrEmpty(text))
                return (string)null;
            double num = 0.8 + rand.NextDouble() * (1.0 / 5.0);
            return Math.Round(Convert.ToDouble(text) * num, 1).ToString();
        }

        private string GetCalcThickness8(string text)
        {
            if (string.IsNullOrEmpty(text))
                return (string)null;
            double num = 0.8 + rand.NextDouble() * (1.0 / 5.0);
            return Math.Round(Convert.ToDouble(text) * num, 1).ToString();
        }

        private string GetThickness(string text)
        {
            string str = "";
            if (string.IsNullOrEmpty(text))
            {
                str = (string)null;
            }
            else
            {
                int int32 = Convert.ToInt32(text);
                if (int32 < 100)
                    str = "3";
                if (int32 >= 100 && int32 < 150)
                    str = "3,5";
                if (int32 >= 150 && int32 < 200)
                    str = "4,5";
                if (int32 >= 200 && int32 < 250)
                    str = "5";
                if (int32 >= 250 && int32 < 350)
                    str = "7";
                if (int32 >= 350 && int32 < 400)
                    str = "9";
                if (int32 >= 400 && int32 < 600)
                    str = "6";
                if (int32 >= 600 && int32 < 700)
                    str = "7";
                if (int32 >= 700 && int32 < 800)
                    str = "8";
                if (int32 >= 800 && int32 < 900)
                    str = "9";
                if (int32 >= 900 && int32 < 1000)
                    str = "10";
                if (int32 >= 1000 && int32 < 1200)
                    str = "11";
                if (int32 >= 1200 && int32 < 1400)
                    str = "14";
            }
            return str;
        }

        private void GenerateRandomValues(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6,TextBox t7, TextBox t8, string text)
        {
            t1.Text = GetCalcThickness1(text);
            t2.Text = GetCalcThickness2(text);
            t3.Text = GetCalcThickness3(text);
            t4.Text = GetCalcThickness4(text);
            t5.Text = GetCalcThickness5(text);
            t6.Text = GetCalcThickness6(text);
            t7.Text = GetCalcThickness7(text);
            t8.Text = GetCalcThickness8(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {



            
            string[,] array =
            {
                {"первое", "vtor", "tret", "chet"},
                { ot1.Text, ot2.Text, ot3.Text, ot4.Text },
                { ot5.Text, ot6.Text, ot7.Text, ot8.Text },
            };

            int m = array.GetLength(0);
            int n = array.GetLength(1);
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = m;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                }
            }

                        ExportToWord(dataGridView1);

            /*
            //List<DataEntry> list = new List<DataEntry>();
            //dataGridView1.Rows.Add(ar);
            
            List<string> list = new List<string>();
            string[] ar = { ot1.Text, ot2.Text, ot3.Text, ot4.Text };
            list.AddRange(ar);
            dataGridView1.DataSource = list;
            //dataGridView1.Rows.Add(array);
            */
        }

        private void from1textBox_TextChanged(object sender, EventArgs e)
        {
            GenerateRandomValues(ot1, ot2, ot3, ot4, ot5, ot6, ot7, ot8, GetThickness(from1textBox.Text));
        }

        private void from2textBox_TextChanged(object sender, EventArgs e)
        {
            GenerateRandomValues(ot9, ot10, ot11, ot12, ot13, ot14, ot15, ot16, GetThickness(from2textBox.Text));
        }

        private void from3textBox_TextChanged(object sender, EventArgs e)
        {
            GenerateRandomValues(ot17, ot18, ot19, ot20, ot21, ot22, ot23, ot24, GetThickness(from3textBox.Text));
        }

        private void from4textBox_TextChanged(object sender, EventArgs e)
        {
            GenerateRandomValues(ot25, ot26, ot27, ot28, ot29, ot30, ot31, ot32, GetThickness(from4textBox.Text));
        }

        private void from5textBox_TextChanged(object sender, EventArgs e)
        {
            GenerateRandomValues(ot33, ot34, ot35, ot36, ot37, ot38, ot39, ot40, GetThickness(from5textBox.Text));
        }

        private void from6textBox_TextChanged(object sender, EventArgs e)
        {
            GenerateRandomValues(ot41, ot42, ot43, ot44, ot45, ot46, ot47, ot48, GetThickness(from6textBox.Text));
        }
    }
}
