
namespace MyFirstApp
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.EmployeesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerDetailsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CheckOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerRegistrationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Exitbtn = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_AddRoom1 = new MyFirstApp.All_User_Control.UC_AddRoom();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.EmployeesBtn);
            this.panel1.Controls.Add(this.CustomerDetailsBtn);
            this.panel1.Controls.Add(this.CheckOutBtn);
            this.panel1.Controls.Add(this.CustomerRegistrationBtn);
            this.panel1.Controls.Add(this.AddRoomBtn);
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.LawnGreen;
            this.MovingPanel.Location = new System.Drawing.Point(76, 112);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(140, 5);
            this.MovingPanel.TabIndex = 0;
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.AutoRoundedCorners = true;
            this.EmployeesBtn.BorderColor = System.Drawing.Color.White;
            this.EmployeesBtn.BorderRadius = 32;
            this.EmployeesBtn.BorderThickness = 3;
            this.EmployeesBtn.CheckedState.Parent = this.EmployeesBtn;
            this.EmployeesBtn.CustomImages.Parent = this.EmployeesBtn;
            this.EmployeesBtn.FillColor = System.Drawing.Color.PaleVioletRed;
            this.EmployeesBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.EmployeesBtn.ForeColor = System.Drawing.Color.Black;
            this.EmployeesBtn.HoverState.Parent = this.EmployeesBtn;
            this.EmployeesBtn.IndicateFocus = true;
            this.EmployeesBtn.Location = new System.Drawing.Point(988, 12);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.ShadowDecoration.Parent = this.EmployeesBtn;
            this.EmployeesBtn.Size = new System.Drawing.Size(207, 94);
            this.EmployeesBtn.TabIndex = 5;
            this.EmployeesBtn.Text = "Employees";
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // CustomerDetailsBtn
            // 
            this.CustomerDetailsBtn.AutoRoundedCorners = true;
            this.CustomerDetailsBtn.BorderColor = System.Drawing.Color.White;
            this.CustomerDetailsBtn.BorderRadius = 32;
            this.CustomerDetailsBtn.BorderThickness = 3;
            this.CustomerDetailsBtn.CheckedState.Parent = this.CustomerDetailsBtn;
            this.CustomerDetailsBtn.CustomImages.Parent = this.CustomerDetailsBtn;
            this.CustomerDetailsBtn.FillColor = System.Drawing.Color.PaleVioletRed;
            this.CustomerDetailsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CustomerDetailsBtn.ForeColor = System.Drawing.Color.Black;
            this.CustomerDetailsBtn.HoverState.Parent = this.CustomerDetailsBtn;
            this.CustomerDetailsBtn.IndicateFocus = true;
            this.CustomerDetailsBtn.Location = new System.Drawing.Point(750, 12);
            this.CustomerDetailsBtn.Name = "CustomerDetailsBtn";
            this.CustomerDetailsBtn.ShadowDecoration.Parent = this.CustomerDetailsBtn;
            this.CustomerDetailsBtn.Size = new System.Drawing.Size(207, 94);
            this.CustomerDetailsBtn.TabIndex = 4;
            this.CustomerDetailsBtn.Text = "Customer Details";
            this.CustomerDetailsBtn.Click += new System.EventHandler(this.CustomerDetailsBtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.AutoRoundedCorners = true;
            this.CheckOutBtn.BorderColor = System.Drawing.Color.White;
            this.CheckOutBtn.BorderRadius = 32;
            this.CheckOutBtn.BorderThickness = 3;
            this.CheckOutBtn.CheckedState.Parent = this.CheckOutBtn;
            this.CheckOutBtn.CustomImages.Parent = this.CheckOutBtn;
            this.CheckOutBtn.FillColor = System.Drawing.Color.PaleVioletRed;
            this.CheckOutBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CheckOutBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckOutBtn.HoverState.Parent = this.CheckOutBtn;
            this.CheckOutBtn.IndicateFocus = true;
            this.CheckOutBtn.Location = new System.Drawing.Point(512, 12);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.ShadowDecoration.Parent = this.CheckOutBtn;
            this.CheckOutBtn.Size = new System.Drawing.Size(207, 94);
            this.CheckOutBtn.TabIndex = 3;
            this.CheckOutBtn.Text = "Check out";
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // CustomerRegistrationBtn
            // 
            this.CustomerRegistrationBtn.AutoRoundedCorners = true;
            this.CustomerRegistrationBtn.BorderColor = System.Drawing.Color.White;
            this.CustomerRegistrationBtn.BorderRadius = 32;
            this.CustomerRegistrationBtn.BorderThickness = 3;
            this.CustomerRegistrationBtn.CheckedState.Parent = this.CustomerRegistrationBtn;
            this.CustomerRegistrationBtn.CustomImages.Parent = this.CustomerRegistrationBtn;
            this.CustomerRegistrationBtn.FillColor = System.Drawing.Color.PaleVioletRed;
            this.CustomerRegistrationBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CustomerRegistrationBtn.ForeColor = System.Drawing.Color.Black;
            this.CustomerRegistrationBtn.HoverState.Parent = this.CustomerRegistrationBtn;
            this.CustomerRegistrationBtn.IndicateFocus = true;
            this.CustomerRegistrationBtn.Location = new System.Drawing.Point(274, 12);
            this.CustomerRegistrationBtn.Name = "CustomerRegistrationBtn";
            this.CustomerRegistrationBtn.ShadowDecoration.Parent = this.CustomerRegistrationBtn;
            this.CustomerRegistrationBtn.Size = new System.Drawing.Size(207, 94);
            this.CustomerRegistrationBtn.TabIndex = 2;
            this.CustomerRegistrationBtn.Text = "Customer Registration";
            this.CustomerRegistrationBtn.Click += new System.EventHandler(this.CustomerRegistrationBtn_Click);
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.AutoRoundedCorners = true;
            this.AddRoomBtn.BorderColor = System.Drawing.Color.White;
            this.AddRoomBtn.BorderRadius = 32;
            this.AddRoomBtn.BorderThickness = 3;
            this.AddRoomBtn.CheckedState.Parent = this.AddRoomBtn;
            this.AddRoomBtn.CustomImages.Parent = this.AddRoomBtn;
            this.AddRoomBtn.FillColor = System.Drawing.Color.PaleVioletRed;
            this.AddRoomBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.AddRoomBtn.ForeColor = System.Drawing.Color.Black;
            this.AddRoomBtn.HoverState.Parent = this.AddRoomBtn;
            this.AddRoomBtn.IndicateFocus = true;
            this.AddRoomBtn.Location = new System.Drawing.Point(50, 12);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.ShadowDecoration.Parent = this.AddRoomBtn;
            this.AddRoomBtn.Size = new System.Drawing.Size(193, 94);
            this.AddRoomBtn.TabIndex = 1;
            this.AddRoomBtn.Text = "Add Room";
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 123);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Exitbtn);
            this.panel4.Controls.Add(this.MinimizeBtn);
            this.panel4.Location = new System.Drawing.Point(1398, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 123);
            this.panel4.TabIndex = 3;
            // 
            // Exitbtn
            // 
            this.Exitbtn.CheckedState.Parent = this.Exitbtn;
            this.Exitbtn.CustomImages.Parent = this.Exitbtn;
            this.Exitbtn.FillColor = System.Drawing.Color.Red;
            this.Exitbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Exitbtn.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.HoverState.Parent = this.Exitbtn;
            this.Exitbtn.Location = new System.Drawing.Point(2, 14);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.ShadowDecoration.Parent = this.Exitbtn;
            this.Exitbtn.Size = new System.Drawing.Size(53, 39);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.CheckedState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.CustomImages.Parent = this.MinimizeBtn;
            this.MinimizeBtn.FillColor = System.Drawing.Color.MediumAquamarine;
            this.MinimizeBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.HoverState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Location = new System.Drawing.Point(2, 69);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.ShadowDecoration.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Size = new System.Drawing.Size(53, 39);
            this.MinimizeBtn.TabIndex = 4;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Text = "Minimize";
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(12, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1448, 525);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_AddRoom1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uC_AddRoom1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_AddRoom1.ForeColor = System.Drawing.Color.BurlyWood;
            this.uC_AddRoom1.Location = new System.Drawing.Point(-2, -2);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1448, 525);
            this.uC_AddRoom1.TabIndex = 0;
            this.uC_AddRoom1.Visible = false;
            this.uC_AddRoom1.Load += new System.EventHandler(this.uC_AddRoom1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1471, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button CustomerDetailsBtn;
        private Guna.UI2.WinForms.Guna2Button CheckOutBtn;
        private Guna.UI2.WinForms.Guna2Button CustomerRegistrationBtn;
        private Guna.UI2.WinForms.Guna2Button AddRoomBtn;
        private Guna.UI2.WinForms.Guna2Button EmployeesBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Button MinimizeBtn;
        private Guna.UI2.WinForms.Guna2Button Exitbtn;
        private System.Windows.Forms.Panel panel2;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
    }
}