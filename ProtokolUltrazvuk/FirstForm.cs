using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtokolUltrazvuk
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void LoadListSeti(string tabl)
        {
            SqlConnection conn = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            string sql = string.Format("Select Distinct Seti From {0} Order By Seti", tabl);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                conn.Close();
                VvodycomboBox.DataSource = (object)dataSet.Tables[0];
                VvodycomboBox.DisplayMember = "Seti";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка Сетей!" + ex.Message);
            }
        }

        private string IfArea()
        {
            string str = "";
            if (TypecomboBox.Text == "Абон вводы")
            {
                if (AreacomboBox.Text == "1 район")
                    str = "Info1r";
                if (AreacomboBox.Text == "2 район")
                    str = "Info2r";
                if (AreacomboBox.Text == "3 район")
                    str = "Info3r";
                if (AreacomboBox.Text == "4 район")
                    str = "Info4r";
                if (AreacomboBox.Text == "5 район")
                    str = "Info5r";
                if (AreacomboBox.Text == "6 район")
                    str = "Info6r";
            }
            else
            {
                if (AreacomboBox.Text == "1 район")
                    str = "InfoRsTM1r";
                if (AreacomboBox.Text == "2 район")
                    str = "InfoRsTM2r";
                if (AreacomboBox.Text == "3 район")
                    str = "InfoRsTM3r";
                if (AreacomboBox.Text == "4 район")
                    str = "InfoRsTM4r";
                if (AreacomboBox.Text == "5 район")
                    str = "InfoRsTM5r";
                if (AreacomboBox.Text == "6 район")
                    str = "InfoRsTM6r";
            }
            return str;
        }

        private void LoadListLineFrom(string tabl)
        {
            string seti = VvodycomboBox.Text;
            SqlConnection conn = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            string sql = string.Format("Select Distinct linefrom From {0} where seti = '{1}'", tabl, seti);
            SqlDataAdapter cmd = new SqlDataAdapter(sql, conn);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                cmd.Fill(ds);
                conn.Close();
                LineFromcomboBox.DataSource = ds.Tables[0];
                LineFromcomboBox.DisplayMember = "linefrom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка участка от!" + ex.Message);
            }
        }

        private void LoadListUzelTo(string tabl)
        {
            string text = VvodycomboBox.Text;
            SqlConnection selectConnection = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select Distinct uzelto From {0} where seti = '{1}'", (object)tabl, (object)text), selectConnection);
            try
            {
                selectConnection.Open();
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                selectConnection.Close();
                UzelTocomboBox.DataSource = (object)dataSet.Tables[0];
                UzelTocomboBox.DisplayMember = "uzelto";
            }
            catch
            {
                MessageBox.Show("Ошибка участка от!");
            }
        }

        private void LoadListUzelFrom(string tabl)
        {
            string text = VvodycomboBox.Text;
            SqlConnection selectConnection = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select Distinct uzelfrom From {0} where seti = '{1}'", (object)tabl, (object)text), selectConnection);
            try
            {
                selectConnection.Open();
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                selectConnection.Close();
                UzelFromcomboBox.DataSource = (object)dataSet.Tables[0];
                UzelFromcomboBox.DisplayMember = "uzelfrom";
            }
            catch
            {
                MessageBox.Show("Ошибка участка от!");
            }
        }

        private void LoadListCamera(string tabl)
        {
            string seti = VvodycomboBox.Text;
            string uzelfrom = UzelFromcomboBox.Text;
            string uzelto = UzelTocomboBox.Text;
            List<string> list = new List<string>(); 
            SqlConnection conn = new SqlConnection(Program.Connection.GetConnectionStringByName("Conn"));
            string sql = string.Format("select distinct uzelfrom, uzelto from {0} where (seti = '{1}' and ID between (select top(1) ID from {2} where (uzelfrom = '{3}' and seti = '{4}')) and (select max(ID) from {5} where (uzelto = '{6}' and seti = '{7}')))", tabl, seti, tabl, uzelfrom, seti, tabl, uzelto, seti);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list = (from IDataRecord r in reader select (string)r["uzelfrom"]).ToList();
                    list.AddRange(from IDataRecord r in reader select (string)r["uzelto"]);
                }
                reader.Close();
                conn.Close();
                comboBox1.DataSource = list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypecomboBox.Text == "Абон вводы")
            {
                LineFromcomboBox.Enabled = true;
            }
            else
            {
                LineFromcomboBox.Enabled = false;
            }
            AreacomboBox.Text = "";
            VvodycomboBox.Text = "";
            LineFromcomboBox.Text = "";
            UzelFromcomboBox.Text = "";
            UzelTocomboBox.Text = "";
        }

        private void AreacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListSeti(IfArea());
        }

        private void VvodycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypecomboBox.Text == "Абон вводы")
            {
                LoadListLineFrom(IfArea());
            }

            LoadListUzelFrom(IfArea());
            LoadListUzelTo(IfArea());
        }

        private void LineFromcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            LoadListLineFrom(IfArea());
            LoadListUzelFrom(IfArea());
            LoadListUzelTo(IfArea());
        }

        private void UzelTocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListCamera(IfArea());
        }
    }
}
