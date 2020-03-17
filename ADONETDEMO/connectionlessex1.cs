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
    public partial class connectionlessex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public connectionlessex1()
        {
            InitializeComponent();
        }

        private void connectionlessex1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
            adp = new SqlDataAdapter("select * from DEPTDATA", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Dno");
            cmbdeptno.DataSource = ds.Tables["Dno"];
            cmbdeptno.ValueMember = "Deptno";
            cmbdeptno.DisplayMember = "Dname";
        }

        private void btnextract_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from EMPDATA where DEPTNO=@d", con);
            adp.SelectCommand.Parameters.AddWithValue("@d" , (cmbdeptno.SelectedValue));
            DataSet ds1 = new DataSet();
            adp.Fill(ds1, "Emp");
            dgvdata.DataSource = ds1.Tables["Emp"];
        }

        private void cmbdeptno_SelectedIndexChanged(object sender, EventArgs e)
        {     
        }
    }
}
