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

namespace MyFirstApp.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        Sqlparce fn = new Sqlparce();
        String query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms";
            DataSet ds= fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];


        }

        private void AddRoomCommitBtn_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text!="" && txtRoomType.Text!=""&& txtBed.Text !=""  && txtPrice.Text != "")
            {
                String roomNo = txtRoomNo.Text;
                String type = txtRoomType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "INSERT INTO rooms (roomNo,roomType,bed,price) values('"+roomNo+"','"+type+"','"+bed+"',"+price+")";
                fn.SetData(query,"Room Added.");
                UC_AddRoom_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void ClearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e) //added from Events - Leave
        {
            ClearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
