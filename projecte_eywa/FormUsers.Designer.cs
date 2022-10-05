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
            this.userAndroidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDesktopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndroidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDesktopBindingSource)).BeginInit();
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
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.type,
            this.image,
            this.gender,
            this.age});
            this.dataGridViewUsers.DataSource = this.userAndroidBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(423, 243);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(630, 484);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // userAndroidBindingSource
            // 
            this.userAndroidBindingSource.DataSource = typeof(projecte_eywa.UserAndroid);
            // 
            // userDesktopBindingSource
            // 
            this.userDesktopBindingSource.DataSource = typeof(projecte_eywa.UserDesktop);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.Visible = false;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            this.gender.Visible = false;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "age";
            this.age.Name = "age";
            this.age.Visible = false;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAndroid;
        private System.Windows.Forms.RadioButton radioButtonDesktop;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.BindingSource userDesktopBindingSource;
        private System.Windows.Forms.BindingSource userAndroidBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
    }
}