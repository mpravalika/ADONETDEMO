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
    public partial class connectionlessex3 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public connectionlessex3()
        {
            InitializeComponent();
        }


        private void connectionlessex3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-00PPEVI");
            adp = new SqlDataAdapter("select * from DEPTDATA",con);
            ds = new DataSet();
            adp.Fill(ds, "D");
            cmbdeptno.DataSource = ds.Tables["D"];
            cmbdeptno.ValueMember = "Deptno";
            cmbdeptno.DisplayMember = "Dname";
        
        }

        private void cmbdeptno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adp = new SqlDataAdapter("select * from EMPDATA", con);
                ds = new DataSet();
                adp.Fill(ds, "E");
                DataRow R = ds.Tables["E"].NewRow();//create memory for a row //storing values in fields
                R[0] = int.Parse(txtempno.Text);
                R[1] = txtename.Text;
                R[2] = txtjob.Text;
                R[3] = int.Parse(txtmgr.Text);
                R[4] = DateTime.Parse(dtphiredate.Text);
                R[5] = int.Parse(txtsal.Text);
                R[6] = int.Parse(txtcomm.Text);
                R[7] = cmbdeptno.SelectedValue;
                ds.Tables["E"].Rows.Add(R);//to link to the table
                SqlCommandBuilder cmb = new SqlCommandBuilder(adp);//sending data from dataset ds to database
                adp.InsertCommand = cmb.GetInsertCommand();
                adp.Update(ds, "E");//only during fill,update DB is connected to appln
                MessageBox.Show("1 row inserted ");
                clear();
            }
            catch (SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void clear()
        {
            txtempno.Text = " ";
            txtename.Text = " ";
            txtjob.Text = " ";
            txtmgr.Text = " ";
            dtphiredate.Text ="";
            txtsal.Text = " ";
            txtcomm.Text = " ";
            cmbdeptno.Text = " ";
        }
        
    }
}
