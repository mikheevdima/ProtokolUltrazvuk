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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseChildForms()
        {
            Form[] form = MdiChildren;
            foreach (Form f in form)
            {
                f.Close();
            }
        }

        private void данныеУчасткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FirstForm")
                {
                    return;
                }
            }
            CloseChildForms();
            FirstForm fr1 = new FirstForm();
            fr1.MdiParent = this;
            fr1.Show();
        }

        private void вводДиаметровКамерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "ThirdForm")
                {
                    return;
                }
            }
            CloseChildForms();
            ThirdForm fr3 = new ThirdForm();
            fr3.MdiParent = this;
            fr3.Show();
        }
    }
}
