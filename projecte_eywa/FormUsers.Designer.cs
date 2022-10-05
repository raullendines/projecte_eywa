namespace projecte_eywa
{
    partial class FormUsers
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAndroid = new System.Windows.Forms.RadioButton();
            this.radioButtonDesktop = new System.Windows.Forms.RadioButton();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAndroidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDesktopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelActualUserData = new System.Windows.Forms.Panel();
            this.labelActualUserIcon = new System.Windows.Forms.Label();
            this.labelActualUserData = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndroidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDesktopBindingSource)).BeginInit();
            this.panelActualUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAndroid);
            this.groupBox1.Controls.Add(this.radioButtonDesktop);
            this.groupBox1.Location = new System.Drawing.Point(423, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonAndroid
            // 
            this.radioButtonAndroid.AutoSize = true;
            this.radioButtonAndroid.Location = new System.Drawing.Point(479, 48);
            this.radioButtonAndroid.Name = "radioButtonAndroid";
            this.radioButtonAndroid.Size = new System.Drawing.Size(75, 17);
            this.radioButtonAndroid.TabIndex = 1;
            this.radioButtonAndroid.Text = "ANDROID";
            this.radioButtonAndroid.UseVisualStyleBackColor = true;
            this.radioButtonAndroid.CheckedChanged += new System.EventHandler(this.radioButtonAndroid_CheckedChanged);
            // 
            // radioButtonDesktop
            // 
            this.radioButtonDesktop.AutoSize = true;
            this.radioButtonDesktop.Checked = true;
            this.radioButtonDesktop.Location = new System.Drawing.Point(59, 48);
            this.radioButtonDesktop.Name = "radioButtonDesktop";
            this.radioButtonDesktop.Size = new System.Drawing.Size(76, 17);
            this.radioButtonDesktop.TabIndex = 0;
            this.radioButtonDesktop.TabStop = true;
            this.radioButtonDesktop.Text = "DESKTOP";
            this.radioButtonDesktop.UseVisualStyleBackColor = true;
            this.radioButtonDesktop.CheckedChanged += new System.EventHandler(this.radioButtonDesktop_CheckedChanged);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.type,
            this.image,
            this.gender,
            this.age});
            this.dataGridViewUsers.DataSource = this.userAndroidBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(423, 243);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(630, 484);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn1.HeaderText = "username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Visible = false;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Visible = false;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Visible = false;
            // 
            // userAndroidBindingSource
            // 
            this.userAndroidBindingSource.DataSource = typeof(projecte_eywa.UserAndroid);
            // 
            // userDesktopBindingSource
            // 
            this.userDesktopBindingSource.DataSource = typeof(projecte_eywa.UserDesktop);
            // 
            // panelActualUserData
            // 
            this.panelActualUserData.Controls.Add(this.labelActualUserData);
            this.panelActualUserData.Controls.Add(this.labelActualUserIcon);
            this.panelActualUserData.Location = new System.Drawing.Point(0, 0);
            this.panelActualUserData.Name = "panelActualUserData";
            this.panelActualUserData.Size = new System.Drawing.Size(200, 100);
            this.panelActualUserData.TabIndex = 2;
            // 
            // labelActualUserIcon
            // 
            this.labelActualUserIcon.Image = global::projecte_eywa.Properties.Resources.person_FILL0_wght400_GRAD0_opsz48;
            this.labelActualUserIcon.Location = new System.Drawing.Point(74, 20);
            this.labelActualUserIcon.Name = "labelActualUserIcon";
            this.labelActualUserIcon.Size = new System.Drawing.Size(30, 30);
            this.labelActualUserIcon.TabIndex = 0;
            // 
            // labelActualUserData
            // 
            this.labelActualUserData.AutoSize = true;
            this.labelActualUserData.Location = new System.Drawing.Point(69, 68);
            this.labelActualUserData.Name = "labelActualUserData";
            this.labelActualUserData.Size = new System.Drawing.Size(0, 13);
            this.labelActualUserData.TabIndex = 1;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelActualUserData);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUsers";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndroidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDesktopBindingSource)).EndInit();
            this.panelActualUserData.ResumeLayout(false);
            this.panelActualUserData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAndroid;
        private System.Windows.Forms.RadioButton radioButtonDesktop;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.BindingSource userAndroidBindingSource;
        private System.Windows.Forms.BindingSource userDesktopBindingSource;
        private System.Windows.Forms.Panel panelActualUserData;
        private System.Windows.Forms.Label labelActualUserData;
        private System.Windows.Forms.Label labelActualUserIcon;
    }
}