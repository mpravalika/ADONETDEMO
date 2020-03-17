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
    public partial class Insert : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            //step1-connection
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADODB;Data Source=DESKTOP-00PPEVI");
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 -open the connection
                con.Open();
                //step3
                cmd = new SqlCommand("insert into emp values(@eno,@en,@g,@d)", con);
                cmd.Parameters.AddWithValue("@eno", int.Parse(txteno.Text));
                cmd.Parameters.AddWithValue("@en", txtename.Text);
                cmd.Parameters.AddWithValue("@g", cbbgender.Text);
                cmd.Parameters.AddWithValue("@d", DateTime.Parse(dtpdob.Text));
                //step4
                int R = cmd.ExecuteNonQuery();
                MessageBox.Show(R + "one row inserted");
            }
            catch (SqlException E)
            {
                if (E.Message.Contains("PK_Emp"))
                    MessageBox.Show("employee num must be unique");
                if (E.Message.Contains("CK_gender"))
                    MessageBox.Show("gender should be selectd frm drp dwn");
                if (E.Message.Contains("CK_dob"))
                    MessageBox.Show("age must be > 21");
            }
            catch(FormatException E)
            {
                MessageBox.Show("enter all details");
            }
            finally
            {
                //step5
                con.Close();
            }
        }
    }
}
