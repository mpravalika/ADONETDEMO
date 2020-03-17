using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONETDEMO
{
    public partial class connectionlessex4 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public connectionlessex4()
        {
            InitializeComponent();
        }

        private void connectionlessex4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
            adp = new SqlDataAdapter("select * from DEPTDATA", con);
            ds = new DataSet();
            adp.Fill(ds, "D");
            cmbdeptno.DataSource = ds.Tables["D"];
            cmbdeptno.ValueMember = "Deptno";
            cmbdeptno.DisplayMember = "Dname";
        }

        private void txtempno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from EMPDATA where empno=@e",con);
            adp.SelectCommand.Parameters.AddWithValue("@e", int.Parse(txtempno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow R = ds.Tables["E"].Rows[0];
            txtename.Text = R[1].ToString();
            txtjob.Text = R[2].ToString();
            txtmgr.Text = R[3].ToString();
            dtphiredate.Text = R[4].ToString();
            txtsal.Text = R[5].ToString();
            txtcomm.Text = R[6].ToString();
            cmbdeptno.Text = R[7].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from EMPDATA where empno=@e", con);
            adp.SelectCommand.Parameters.AddWithValue("@e", int.Parse(txtempno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow R = ds.Tables["E"].Rows[0];
            R[2] = txtjob.Text;
            R[3] = txtmgr.Text;
            R[5] = int.Parse(txtsal.Text);
            if(txtcomm.MaxLength!=0)
                R[6] = int.Parse(txtcomm.Text);
            R[7] = cmbdeptno.SelectedValue;
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            adp.UpdateCommand = cmb.GetUpdateCommand();
            adp.Update(ds, "E");
            MessageBox.Show("1 row updated ");
          
        }
    }
}
