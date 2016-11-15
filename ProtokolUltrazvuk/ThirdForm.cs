using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtokolUltrazvuk
{
    public partial class ThirdForm : Form
    {
        public ThirdForm()
        {
            InitializeComponent();
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




            //List<DataEntry> list = new List<DataEntry>();
            //dataGridView1.Rows.Add(ar);
            /*
            List<string> list = new List<string>();
            string[] ar = { ot1.Text, ot2.Text, ot3.Text, ot4.Text };
            list.AddRange(ar);
            dataGridView1.DataSource = list;
            //dataGridView1.Rows.Add(array);
            */
        }
    }
}
