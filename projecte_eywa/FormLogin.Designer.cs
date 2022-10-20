namespace projecte_eywa
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonVisibility = new System.Windows.Forms.Button();
            this.labelChangeFormsText = new System.Windows.Forms.Label();
            this.labelChangeForms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(631, 610);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 26);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(631, 548);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(114, 26);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(836, 545);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(441, 33);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUser_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(836, 610);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(441, 33);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(1130, 667);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(147, 34);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.Location = new System.Drawing.Point(631, 672);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(194, 26);
            this.labelConfirmPassword.TabIndex = 8;
            this.labelConfirmPassword.Text = "Confirm Password";
            this.labelConfirmPassword.Visible = false;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(836, 668);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(441, 33);
            this.textBoxConfirmPassword.TabIndex = 4;
            this.textBoxConfirmPassword.Visible = false;
            this.textBoxConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfirmPassword_KeyPress);
            // 
            // labelLogo
            // 
            this.labelLogo.Image = global::projecte_eywa.Properties.Resources.logo__2___1_;
            this.labelLogo.Location = new System.Drawing.Point(843, 147);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(330, 330);
            this.labelLogo.TabIndex = 10;
            // 
            // buttonVisibility
            // 
            this.buttonVisibility.BackColor = System.Drawing.Color.White;
            this.buttonVisibility.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonVisibility.FlatAppearance.BorderSize = 0;
            this.buttonVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisibility.Image = global::projecte_eywa.Properties.Resources.visibility_on;
            this.buttonVisibility.Location = new System.Drawing.Point(1236, 615);
            this.buttonVisibility.Name = "buttonVisibility";
            this.buttonVisibility.Size = new System.Drawing.Size(36, 22);
            this.buttonVisibility.TabIndex = 6;
            this.buttonVisibility.UseVisualStyleBackColor = false;
            this.buttonVisibility.Click += new System.EventHandler(this.buttonVisiblity_Click);
            // 
            // labelChangeFormsText
            // 
            this.labelChangeFormsText.AutoSize = true;
            this.labelChangeFormsText.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeFormsText.Location = new System.Drawing.Point(833, 674);
            this.labelChangeFormsText.Name = "labelChangeFormsText";
            this.labelChangeFormsText.Size = new System.Drawing.Size(95, 21);
            this.labelChangeFormsText.TabIndex = 11;
            this.labelChangeFormsText.Text = "New here? ";
            // 
            // labelChangeForms
            // 
            this.labelChangeForms.AutoSize = true;
            this.labelChangeForms.Font = new System.Drawing.Font("Montserrat", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeForms.ForeColor = System.Drawing.Color.Blue;
            this.labelChangeForms.Location = new System.Drawing.Point(922, 674);
            this.labelChangeForms.Name = "labelChangeForms";
            this.labelChangeForms.Size = new System.Drawing.Size(152, 21);
            this.labelChangeForms.TabIndex = 12;
            this.labelChangeForms.Text = "Create an account";
            this.labelChangeForms.Click += new System.EventHandler(this.labelChangeForms_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelChangeForms);
            this.Controls.Add(this.labelChangeFormsText);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.buttonVisibility);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonVisibility;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelChangeFormsText;
        private System.Windows.Forms.Label labelChangeForms;
    }
}