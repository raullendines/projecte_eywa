namespace projecte_eywa
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelUsers = new System.Windows.Forms.Label();
            this.labelCharacters = new System.Windows.Forms.Label();
            this.buttonUsersIcon = new System.Windows.Forms.Button();
            this.buttonCharactersIcon = new System.Windows.Forms.Button();
            this.labelQuestions = new System.Windows.Forms.Label();
            this.buttonQuestionsIcon = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelActualUserData = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelActualUserIcon = new System.Windows.Forms.Label();
            this.panelActualUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.Location = new System.Drawing.Point(1235, 625);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(86, 31);
            this.labelUsers.TabIndex = 23;
            this.labelUsers.Text = "Users";
            // 
            // labelCharacters
            // 
            this.labelCharacters.AutoSize = true;
            this.labelCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharacters.Location = new System.Drawing.Point(588, 625);
            this.labelCharacters.Name = "labelCharacters";
            this.labelCharacters.Size = new System.Drawing.Size(148, 31);
            this.labelCharacters.TabIndex = 22;
            this.labelCharacters.Text = "Characters";
            // 
            // buttonUsersIcon
            // 
            this.buttonUsersIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUsersIcon.FlatAppearance.BorderSize = 0;
            this.buttonUsersIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersIcon.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsersIcon.Image")));
            this.buttonUsersIcon.Location = new System.Drawing.Point(1124, 339);
            this.buttonUsersIcon.Name = "buttonUsersIcon";
            this.buttonUsersIcon.Size = new System.Drawing.Size(303, 285);
            this.buttonUsersIcon.TabIndex = 20;
            this.buttonUsersIcon.UseVisualStyleBackColor = true;
            this.buttonUsersIcon.Click += new System.EventHandler(this.buttonUsersIcon_Click);
            // 
            // buttonCharactersIcon
            // 
            this.buttonCharactersIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCharactersIcon.FlatAppearance.BorderSize = 0;
            this.buttonCharactersIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCharactersIcon.Image = ((System.Drawing.Image)(resources.GetObject("buttonCharactersIcon.Image")));
            this.buttonCharactersIcon.Location = new System.Drawing.Point(506, 339);
            this.buttonCharactersIcon.Name = "buttonCharactersIcon";
            this.buttonCharactersIcon.Size = new System.Drawing.Size(303, 285);
            this.buttonCharactersIcon.TabIndex = 19;
            this.buttonCharactersIcon.UseVisualStyleBackColor = true;
            this.buttonCharactersIcon.Click += new System.EventHandler(this.buttonCharactersIcon_Click);
            // 
            // labelQuestions
            // 
            this.labelQuestions.AutoSize = true;
            this.labelQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestions.Location = new System.Drawing.Point(898, 625);
            this.labelQuestions.Name = "labelQuestions";
            this.labelQuestions.Size = new System.Drawing.Size(137, 31);
            this.labelQuestions.TabIndex = 27;
            this.labelQuestions.Text = "Questions";
            // 
            // buttonQuestionsIcon
            // 
            this.buttonQuestionsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonQuestionsIcon.FlatAppearance.BorderSize = 0;
            this.buttonQuestionsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuestionsIcon.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuestionsIcon.Image")));
            this.buttonQuestionsIcon.Location = new System.Drawing.Point(815, 339);
            this.buttonQuestionsIcon.Name = "buttonQuestionsIcon";
            this.buttonQuestionsIcon.Size = new System.Drawing.Size(303, 285);
            this.buttonQuestionsIcon.TabIndex = 26;
            this.buttonQuestionsIcon.UseVisualStyleBackColor = true;
            this.buttonQuestionsIcon.Click += new System.EventHandler(this.buttonQuestionsIcon_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(876, 86);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(173, 63);
            this.labelWelcome.TabIndex = 28;
            this.labelWelcome.Text = "label1";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActualUserData
            // 
            this.panelActualUserData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.panelActualUserData.Controls.Add(this.labelLogout);
            this.panelActualUserData.Controls.Add(this.labelActualUserIcon);
            this.panelActualUserData.Location = new System.Drawing.Point(1699, 12);
            this.panelActualUserData.Name = "panelActualUserData";
            this.panelActualUserData.Size = new System.Drawing.Size(193, 118);
            this.panelActualUserData.TabIndex = 29;
            // 
            // labelLogout
            // 
            this.labelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.Location = new System.Drawing.Point(3, 89);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(187, 25);
            this.labelLogout.TabIndex = 2;
            this.labelLogout.Text = "Log Out";
            this.labelLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // labelActualUserIcon
            // 
            this.labelActualUserIcon.Image = global::projecte_eywa.Properties.Resources.usuario__1_;
            this.labelActualUserIcon.Location = new System.Drawing.Point(56, 6);
            this.labelActualUserIcon.Name = "labelActualUserIcon";
            this.labelActualUserIcon.Size = new System.Drawing.Size(81, 83);
            this.labelActualUserIcon.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelActualUserData);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelQuestions);
            this.Controls.Add(this.buttonQuestionsIcon);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.labelCharacters);
            this.Controls.Add(this.buttonUsersIcon);
            this.Controls.Add(this.buttonCharactersIcon);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelActualUserData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label labelCharacters;
        private System.Windows.Forms.Button buttonUsersIcon;
        private System.Windows.Forms.Button buttonCharactersIcon;
        private System.Windows.Forms.Label labelQuestions;
        private System.Windows.Forms.Button buttonQuestionsIcon;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelActualUserData;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelActualUserIcon;
    }
}