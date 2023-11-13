namespace Test
{
    partial class Login1
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
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.pibox_login = new System.Windows.Forms.PictureBox();
            this.btnLoginDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibox_login)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.txtPasswordLogin.Location = new System.Drawing.Point(66, 264);
            this.txtPasswordLogin.MaximumSize = new System.Drawing.Size(542, 40);
            this.txtPasswordLogin.MinimumSize = new System.Drawing.Size(442, 30);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(442, 22);
            this.txtPasswordLogin.TabIndex = 19;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameLogin.ForeColor = System.Drawing.Color.White;
            this.txtUsernameLogin.Location = new System.Drawing.Point(66, 137);
            this.txtUsernameLogin.MaximumSize = new System.Drawing.Size(542, 40);
            this.txtUsernameLogin.MinimumSize = new System.Drawing.Size(442, 30);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(442, 22);
            this.txtUsernameLogin.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 15;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(751, 386);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 40);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.lblRegister.Location = new System.Drawing.Point(101, 395);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(58, 16);
            this.lblRegister.TabIndex = 12;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "Register";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegister_LinkClicked);
            // 
            // pibox_login
            // 
            this.pibox_login.Image = global::Test.Properties.Resources.undraw_Sign_in_re_o58h;
            this.pibox_login.Location = new System.Drawing.Point(441, 96);
            this.pibox_login.Name = "pibox_login";
            this.pibox_login.Size = new System.Drawing.Size(501, 396);
            this.pibox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibox_login.TabIndex = 11;
            this.pibox_login.TabStop = false;
            // 
            // btnLoginDetails
            // 
            this.btnLoginDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnLoginDetails.FlatAppearance.BorderSize = 6;
            this.btnLoginDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLoginDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLoginDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginDetails.Location = new System.Drawing.Point(32, 48);
            this.btnLoginDetails.Name = "btnLoginDetails";
            this.btnLoginDetails.Size = new System.Drawing.Size(509, 304);
            this.btnLoginDetails.TabIndex = 13;
            this.btnLoginDetails.UseVisualStyleBackColor = true;
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 508);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLoginDetails);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.pibox_login);
            this.Name = "Login1";
            this.Text = "Login1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibox_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.PictureBox pibox_login;
        private System.Windows.Forms.Button btnLoginDetails;
    }
}