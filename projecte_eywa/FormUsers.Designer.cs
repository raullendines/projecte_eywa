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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActualUserData = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelActualUserData = new System.Windows.Forms.Label();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDesktop = new System.Windows.Forms.Button();
            this.buttonAndroid = new System.Windows.Forms.Button();
            this.buttonSaveJSON = new System.Windows.Forms.Button();
            this.buttonCharactersIcon = new System.Windows.Forms.Button();
            this.buttonQuestionsIcon = new System.Windows.Forms.Button();
            this.labelActualUserIcon = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAndroidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDesktopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panelActualUserData.SuspendLayout();
            this.groupBoxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAndroidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDesktopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.type,
            this.image,
            this.gender,
            this.age});
            this.dataGridViewUsers.DataSource = this.userAndroidBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(52, 231);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat Medium", 12F);
            this.dataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUsers.Size = new System.Drawing.Size(973, 652);
            this.dataGridViewUsers.TabIndex = 1;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.DefaultCellStyle = dataGridViewCellStyle4;
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.DataPropertyName = "image";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.DefaultCellStyle = dataGridViewCellStyle5;
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Visible = false;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.DefaultCellStyle = dataGridViewCellStyle6;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Visible = false;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.age.DataPropertyName = "age";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.age.DefaultCellStyle = dataGridViewCellStyle7;
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Visible = false;
            // 
            // panelActualUserData
            // 
            this.panelActualUserData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.panelActualUserData.Controls.Add(this.labelLogout);
            this.panelActualUserData.Controls.Add(this.labelActualUserData);
            this.panelActualUserData.Controls.Add(this.labelActualUserIcon);
            this.panelActualUserData.Location = new System.Drawing.Point(1642, 27);
            this.panelActualUserData.Name = "panelActualUserData";
            this.panelActualUserData.Size = new System.Drawing.Size(193, 118);
            this.panelActualUserData.TabIndex = 2;
            // 
            // labelLogout
            // 
            this.labelLogout.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.Location = new System.Drawing.Point(8, 89);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(185, 25);
            this.labelLogout.TabIndex = 2;
            this.labelLogout.Text = "Log Out";
            this.labelLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogout.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelActualUserData
            // 
            this.labelActualUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualUserData.Location = new System.Drawing.Point(7, 58);
            this.labelActualUserData.Name = "labelActualUserData";
            this.labelActualUserData.Size = new System.Drawing.Size(185, 25);
            this.labelActualUserData.TabIndex = 1;
            this.labelActualUserData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.comboBoxType);
            this.groupBoxUsers.Controls.Add(this.buttonCancel);
            this.groupBoxUsers.Controls.Add(this.buttonSave);
            this.groupBoxUsers.Controls.Add(this.textBoxAge);
            this.groupBoxUsers.Controls.Add(this.textBoxGender);
            this.groupBoxUsers.Controls.Add(this.textBoxImage);
            this.groupBoxUsers.Controls.Add(this.textBoxPassword);
            this.groupBoxUsers.Controls.Add(this.textBoxUsername);
            this.groupBoxUsers.Controls.Add(this.labelAge);
            this.groupBoxUsers.Controls.Add(this.labelGender);
            this.groupBoxUsers.Controls.Add(this.labelImage);
            this.groupBoxUsers.Controls.Add(this.labelType);
            this.groupBoxUsers.Controls.Add(this.labelPassword);
            this.groupBoxUsers.Controls.Add(this.labelUsername);
            this.groupBoxUsers.Location = new System.Drawing.Point(1083, 231);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Size = new System.Drawing.Size(752, 652);
            this.groupBoxUsers.TabIndex = 3;
            this.groupBoxUsers.TabStop = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Enabled = false;
            this.comboBoxType.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "user",
            "admin",
            "superadmin"});
            this.comboBoxType.Location = new System.Drawing.Point(237, 157);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(498, 35);
            this.comboBoxType.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonCancel.Location = new System.Drawing.Point(490, 588);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 49);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(628, 588);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(103, 49);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(237, 277);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(498, 32);
            this.textBoxAge.TabIndex = 11;
            this.textBoxAge.Visible = false;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGender.Location = new System.Drawing.Point(237, 217);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(498, 32);
            this.textBoxGender.TabIndex = 10;
            this.textBoxGender.Visible = false;
            // 
            // textBoxImage
            // 
            this.textBoxImage.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImage.Location = new System.Drawing.Point(237, 157);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.ReadOnly = true;
            this.textBoxImage.Size = new System.Drawing.Size(498, 32);
            this.textBoxImage.TabIndex = 9;
            this.textBoxImage.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(237, 97);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(498, 32);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(237, 35);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(498, 32);
            this.textBoxUsername.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(32, 280);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(53, 27);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age";
            this.labelAge.Visible = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(32, 220);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(87, 27);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            this.labelGender.Visible = false;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.Location = new System.Drawing.Point(32, 160);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(77, 27);
            this.labelImage.TabIndex = 3;
            this.labelImage.Text = "Image";
            this.labelImage.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(32, 162);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(61, 27);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(32, 100);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(112, 27);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Montserrat SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(32, 40);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(117, 27);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonAdd.Location = new System.Drawing.Point(52, 901);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 49);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonModify.Location = new System.Drawing.Point(169, 901);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(103, 49);
            this.buttonModify.TabIndex = 5;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(291, 901);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 49);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDesktop
            // 
            this.buttonDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(186)))));
            this.buttonDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesktop.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.buttonDesktop.ForeColor = System.Drawing.Color.White;
            this.buttonDesktop.Location = new System.Drawing.Point(1715, 182);
            this.buttonDesktop.Name = "buttonDesktop";
            this.buttonDesktop.Size = new System.Drawing.Size(103, 49);
            this.buttonDesktop.TabIndex = 7;
            this.buttonDesktop.Text = "Desktop";
            this.buttonDesktop.UseVisualStyleBackColor = false;
            this.buttonDesktop.Click += new System.EventHandler(this.buttonDesktop_Click);
            // 
            // buttonAndroid
            // 
            this.buttonAndroid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.buttonAndroid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAndroid.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.buttonAndroid.ForeColor = System.Drawing.Color.Black;
            this.buttonAndroid.Location = new System.Drawing.Point(1606, 182);
            this.buttonAndroid.Name = "buttonAndroid";
            this.buttonAndroid.Size = new System.Drawing.Size(103, 49);
            this.buttonAndroid.TabIndex = 8;
            this.buttonAndroid.Text = "Android";
            this.buttonAndroid.UseVisualStyleBackColor = false;
            this.buttonAndroid.Click += new System.EventHandler(this.buttonAndroid_Click);
            // 
            // buttonSaveJSON
            // 
            this.buttonSaveJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSaveJSON.FlatAppearance.BorderSize = 0;
            this.buttonSaveJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveJSON.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveJSON.Image")));
            this.buttonSaveJSON.Location = new System.Drawing.Point(232, 50);
            this.buttonSaveJSON.Name = "buttonSaveJSON";
            this.buttonSaveJSON.Size = new System.Drawing.Size(70, 70);
            this.buttonSaveJSON.TabIndex = 18;
            this.buttonSaveJSON.UseVisualStyleBackColor = true;
            this.buttonSaveJSON.Click += new System.EventHandler(this.buttonSaveJSON_Click);
            // 
            // buttonCharactersIcon
            // 
            this.buttonCharactersIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCharactersIcon.FlatAppearance.BorderSize = 0;
            this.buttonCharactersIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCharactersIcon.Image = ((System.Drawing.Image)(resources.GetObject("buttonCharactersIcon.Image")));
            this.buttonCharactersIcon.Location = new System.Drawing.Point(142, 50);
            this.buttonCharactersIcon.Name = "buttonCharactersIcon";
            this.buttonCharactersIcon.Size = new System.Drawing.Size(70, 70);
            this.buttonCharactersIcon.TabIndex = 17;
            this.buttonCharactersIcon.UseVisualStyleBackColor = true;
            this.buttonCharactersIcon.Click += new System.EventHandler(this.buttonCharactersIcon_Click);
            // 
            // buttonQuestionsIcon
            // 
            this.buttonQuestionsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonQuestionsIcon.FlatAppearance.BorderSize = 0;
            this.buttonQuestionsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuestionsIcon.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuestionsIcon.Image")));
            this.buttonQuestionsIcon.Location = new System.Drawing.Point(52, 50);
            this.buttonQuestionsIcon.Name = "buttonQuestionsIcon";
            this.buttonQuestionsIcon.Size = new System.Drawing.Size(70, 70);
            this.buttonQuestionsIcon.TabIndex = 16;
            this.buttonQuestionsIcon.UseVisualStyleBackColor = true;
            this.buttonQuestionsIcon.Click += new System.EventHandler(this.buttonQuestionsIcon_Click);
            // 
            // labelActualUserIcon
            // 
            this.labelActualUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelActualUserIcon.Image")));
            this.labelActualUserIcon.Location = new System.Drawing.Point(79, 4);
            this.labelActualUserIcon.Name = "labelActualUserIcon";
            this.labelActualUserIcon.Size = new System.Drawing.Size(55, 55);
            this.labelActualUserIcon.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // userAndroidBindingSource
            // 
            this.userAndroidBindingSource.DataSource = typeof(projecte_eywa.UserAndroid);
            // 
            // userDesktopBindingSource
            // 
            this.userDesktopBindingSource.DataSource = typeof(projecte_eywa.UserDesktop);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonSaveJSON);
            this.Controls.Add(this.buttonCharactersIcon);
            this.Controls.Add(this.buttonQuestionsIcon);
            this.Controls.Add(this.buttonAndroid);
            this.Controls.Add(this.buttonDesktop);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxUsers);
            this.Controls.Add(this.panelActualUserData);
            this.Controls.Add(this.dataGridViewUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsers";
            this.Text = "Users";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUsers_FormClosed);
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panelActualUserData.ResumeLayout(false);
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAndroidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDesktopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userAndroidBindingSource;
        private System.Windows.Forms.BindingSource userDesktopBindingSource;
        private System.Windows.Forms.Panel panelActualUserData;
        private System.Windows.Forms.Label labelActualUserData;
        private System.Windows.Forms.Label labelActualUserIcon;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonDesktop;
        private System.Windows.Forms.Button buttonAndroid;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.Button buttonQuestionsIcon;
        private System.Windows.Forms.Button buttonCharactersIcon;
        private System.Windows.Forms.Button buttonSaveJSON;
    }
}