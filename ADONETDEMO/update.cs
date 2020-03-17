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
    public partial class update : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public update()
        {
            InitializeComponent();
        }
        private void update_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-00PPEVI");
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Emp set ename=@en,deptno=@dn where empno=@ep", con);
                cmd.Parameters.AddWithValue("@en", txtename.Text);
                cmd.Parameters.AddWithValue("@dn", int.Parse(txtdeptno.Text));
                cmd.Parameters.AddWithValue("@ep", int.Parse(txteno.Text));
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                    MessageBox.Show(R + " rows updated");
                else
                    MessageBox.Show("no empno exists with this number");
            }
            catch (SqlException E)
            {
                MessageBox.Show("ename size out of bound ");
            }
            catch (FormatException E)
            {
                MessageBox.Show("deptno does ot exist");
            }
            catch(InvalidOperationException E)
            {
                MessageBox.Show("no empno exists with this no");
            }
            finally
            {
                con.Close();
            }
        }
        private void btnextract_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Emp where empno=@eno", con);
                cmd.Parameters.AddWithValue("@eno", int.Parse(txteno.Text));
                SqlDataReader R = cmd.ExecuteReader();
                R.Read();
                txtename.Text = R[1].ToString();
                cbbgender.Text = R[2].ToString();
                dtpdob.Text = R[3].ToString();
                txtdeptno.Text = R[4].ToString();
            }
            catch(InvalidOperationException E)
            {
                MessageBox.Show("no empno exists with this num ");
                txtename.Text = "";
                txtdeptno.Text = "";
                cbbgender.Text = "";
                dtpdob.Text = "";


            }
            catch(FormatException E)
            {
                MessageBox.Show("empno should be numbers");
            }
            
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Emp where empno=@eno", con);
                cmd.Parameters.AddWithValue("@eno", int.Parse(txteno.Text));
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                    MessageBox.Show(R + " row deleted ");
                else
                    MessageBox.Show("empno doesn't exist ");
            }
            catch (FormatException E)
            {
                MessageBox.Show(" enetr valid empno ");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
