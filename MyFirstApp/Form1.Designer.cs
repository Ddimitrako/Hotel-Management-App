
namespace MyFirstApp
{
    partial class Form1
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LoginBtn.Location = new System.Drawing.Point(462, 245);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(162, 75);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login ";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(this.labelError);
            panel1.Controls.Add(this.ExitBtn);
            panel1.Controls.Add(this.PasswordTextBox);
            panel1.Controls.Add(this.UsernameTextBox);
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.LoginBtn);
            panel1.Location = new System.Drawing.Point(215, 70);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(720, 394);
            panel1.TabIndex = 5;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelError.Location = new System.Drawing.Point(377, 345);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(341, 24);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Username or Password is Incorrect!";
            this.labelError.Visible = false;
            this.labelError.Click += new System.EventHandler(this.label2_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBtn.Location = new System.Drawing.Point(3, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(44, 43);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AccessibleDescription = "Username";
            this.PasswordTextBox.AccessibleName = "Username";
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordTextBox.Location = new System.Drawing.Point(451, 188);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(184, 38);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.AccessibleDescription = "Username";
            this.UsernameTextBox.AccessibleName = "Username";
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameTextBox.Location = new System.Drawing.Point(451, 123);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(184, 38);
            this.UsernameTextBox.TabIndex = 6;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(444, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "User  Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1150, 563);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label labelError;
    }
}

