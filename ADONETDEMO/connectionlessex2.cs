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
    public partial class connectionlessex2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public connectionlessex2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           con=new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
           adp = new SqlDataAdapter("select * from EMPDATA", con);
           DataSet ds = new DataSet();
           SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
           SqlCommand cmd = cmb.GetInsertCommand();
           MessageBox.Show(cmd.CommandText);

        }

        private void connectionlessex2_Load(object sender, EventArgs e)
        {

        }



    }
}
