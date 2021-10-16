
namespace FormUI.Forms
{
    partial class Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new KLCToolbox.KLCControls.KLCButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new KLCToolbox.KLCControls.KLCTextBox();
            this.txtFirstName = new KLCToolbox.KLCControls.KLCTextBox();
            this.txtEmail = new KLCToolbox.KLCControls.KLCTextBox();
            this.txtPassword = new KLCToolbox.KLCControls.KLCTextBox();
            this.btnSignup = new KLCToolbox.KLCControls.KLCButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormUI.Properties.Resources.KLC_background;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(489, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "SIGN UP";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.KLCBackgroundColor = System.Drawing.Color.Black;
            this.btnExit.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.KLCBorderRadius = 40;
            this.btnExit.KLCBorderSize = 0;
            this.btnExit.KLCTextColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(392, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(397, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(397, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(397, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(397, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.KLCBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLastName.KLCBorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLastName.KLCBorderRadius = 0;
            this.txtLastName.KLCBorderSize = 2;
            this.txtLastName.KLCMultiline = false;
            this.txtLastName.KLCPasswordChar = false;
            this.txtLastName.KLCPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.KLCPlaceholderText = "Enter your last name";
            this.txtLastName.KLCText = "";
            this.txtLastName.KLCUnderlinedStyle = true;
            this.txtLastName.Location = new System.Drawing.Point(479, 111);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLastName.Size = new System.Drawing.Size(200, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.KLCBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFirstName.KLCBorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFirstName.KLCBorderRadius = 0;
            this.txtFirstName.KLCBorderSize = 2;
            this.txtFirstName.KLCMultiline = false;
            this.txtFirstName.KLCPasswordChar = false;
            this.txtFirstName.KLCPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.KLCPlaceholderText = "Enter your first name";
            this.txtFirstName.KLCText = "";
            this.txtFirstName.KLCUnderlinedStyle = true;
            this.txtFirstName.Location = new System.Drawing.Point(479, 72);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFirstName.Size = new System.Drawing.Size(200, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.KLCBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.KLCBorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.KLCBorderRadius = 0;
            this.txtEmail.KLCBorderSize = 2;
            this.txtEmail.KLCMultiline = false;
            this.txtEmail.KLCPasswordChar = false;
            this.txtEmail.KLCPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.KLCPlaceholderText = "example@example.com";
            this.txtEmail.KLCText = "";
            this.txtEmail.KLCUnderlinedStyle = true;
            this.txtEmail.Location = new System.Drawing.Point(479, 150);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.Size = new System.Drawing.Size(200, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.KLCBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.KLCBorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.KLCBorderRadius = 0;
            this.txtPassword.KLCBorderSize = 2;
            this.txtPassword.KLCMultiline = false;
            this.txtPassword.KLCPasswordChar = true;
            this.txtPassword.KLCPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.KLCPlaceholderText = "Enter Password";
            this.txtPassword.KLCText = "";
            this.txtPassword.KLCUnderlinedStyle = true;
            this.txtPassword.Location = new System.Drawing.Point(479, 189);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.Size = new System.Drawing.Size(200, 31);
            this.txtPassword.TabIndex = 4;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignup.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignup.KLCBorderRadius = 40;
            this.btnSignup.KLCBorderSize = 0;
            this.btnSignup.KLCTextColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(557, 264);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(150, 40);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "SIGN UP";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 314);
            this.ControlBox = false;
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private KLCToolbox.KLCControls.KLCButton btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private KLCToolbox.KLCControls.KLCTextBox txtLastName;
        private KLCToolbox.KLCControls.KLCTextBox txtFirstName;
        private KLCToolbox.KLCControls.KLCTextBox txtEmail;
        private KLCToolbox.KLCControls.KLCTextBox txtPassword;
        private KLCToolbox.KLCControls.KLCButton btnSignup;
    }
}