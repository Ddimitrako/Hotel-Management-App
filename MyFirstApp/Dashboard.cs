using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            AddRoomBtn.PerformClick();
        }
        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = AddRoomBtn.Left + 22;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }
        private void CustomerRegistrationBtn_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = CustomerRegistrationBtn.Left + 22;
        }
        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = CheckOutBtn.Left + 22;
        }
        private void CustomerDetailsBtn_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = CustomerDetailsBtn.Left + 22;
        }
        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = EmployeesBtn.Left + 22;
        }      

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }
    }
}
