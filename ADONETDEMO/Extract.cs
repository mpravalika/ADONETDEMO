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
    public partial class Extract : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public Extract()
        {
            InitializeComponent();
        }

        private void Extract_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from EMPDATA where deptno=@dno",con);
            cmd.Parameters.AddWithValue("@dno", int.Parse(txtDeptno.Text));
            SqlDataReader R=cmd.ExecuteReader();
            DataSet ds = new DataSet();//create empty temp database.
            ds.Tables.Add("Deptdata");//adding table to database(empty table).
            ds.Tables["Deptdata"].Load(R);//table is loaded with R(executed query).
            dgvdata.DataSource = ds.Tables["Deptdata"];//loaded table is shown on grid view.
            con.Close();
        }
    }
}
