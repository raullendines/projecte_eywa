namespace projecte_eywa
{
    partial class FormQuestions
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxQuestionDescription = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxCategoryDescription = new System.Windows.Forms.ComboBox();
            this.comboBoxDifficultDescription = new System.Windows.Forms.ComboBox();
            this.textBoxIncorrectAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxIncorrectAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxIncorrectAnswer1 = new System.Windows.Forms.TextBox();
            this.labelDifficultyDescription = new System.Windows.Forms.Label();
            this.labelCategoryDescription = new System.Windows.Forms.Label();
            this.labelIncorrectAnswer2Description = new System.Windows.Forms.Label();
            this.labelIncorrectAnswer3Description = new System.Windows.Forms.Label();
            this.labelIncorrectAnswer1Description = new System.Windows.Forms.Label();
            this.textBoxCorrectAnswer = new System.Windows.Forms.TextBox();
            this.labelCorrectAnswerDescription = new System.Windows.Forms.Label();
            this.textBoxQuestionDescription = new System.Windows.Forms.TextBox();
            this.labelQuestionDescription = new System.Windows.Forms.Label();
            this.textBoxIdDescription = new System.Windows.Forms.TextBox();
            this.labelIdDescription = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.panelActualUserData = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelActualUserData = new System.Windows.Forms.Label();
            this.labelActualUserIcon = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUsersIcon = new System.Windows.Forms.Button();
            this.buttonCharactersIcon = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.buttonEspañol = new System.Windows.Forms.Button();
            this.buttonCatala = new System.Windows.Forms.Button();
            this.quizQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctanswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.groupBoxQuestionDescription.SuspendLayout();
            this.panelActualUserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizQuestionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.AllowUserToOrderColumns = true;
            this.dataGridViewQuestions.AutoGenerateColumns = false;
            this.dataGridViewQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.dataGridViewQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.difficultyDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.correctanswerDataGridViewTextBoxColumn});
            this.dataGridViewQuestions.DataSource = this.quizQuestionsBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuestions.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(52, 231);
            this.dataGridViewQuestions.MultiSelect = false;
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewQuestions.RowHeadersWidth = 62;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataGridViewQuestions.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewQuestions.RowTemplate.Height = 28;
            this.dataGridViewQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuestions.Size = new System.Drawing.Size(973, 652);
            this.dataGridViewQuestions.TabIndex = 1;
            this.dataGridViewQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuestions_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonAdd.Location = new System.Drawing.Point(52, 901);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 49);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonModify.Location = new System.Drawing.Point(169, 901);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(103, 49);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(291, 901);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 49);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxQuestionDescription
            // 
            this.groupBoxQuestionDescription.Controls.Add(this.buttonCancel);
            this.groupBoxQuestionDescription.Controls.Add(this.buttonOk);
            this.groupBoxQuestionDescription.Controls.Add(this.comboBoxCategoryDescription);
            this.groupBoxQuestionDescription.Controls.Add(this.comboBoxDifficultDescription);
            this.groupBoxQuestionDescription.Controls.Add(this.textBoxIncorrectAnswer3);
            this.groupBoxQuestionDescription.Controls.Add(this.textBoxIncorrectAnswer2);
            this.groupBoxQuestionDescription.Controls.Add(this.textBoxIncorrectAnswer1);
            this.groupBoxQuestionDescription.Controls.Add(this.labelDifficultyDescription);
            this.groupBoxQuestionDescription.Controls.Add(this.labelCategoryDescription);
            this.groupBoxQuestionDescription.Controls.Add(this.labelIncorrectAnswer2Description);
            this.groupBoxQuestionDescription.Controls.Add(this.labelIncorrectAnswer3Description);
            this.groupBoxQuestionDescription.Controls.Add(this.labelIncorrectAnswer1Description);
            this.groupBoxQuestionDescription.Controls.Add(this.textBoxCorrectAnswer);
            this.groupBoxQuestionDescription.Controls.Add(this.labelCorrectAnswerDescription);
            this.groupBoxQuestionDescription.Controls.Add(this.textBoxQuestionDescription);
            this.groupBoxQuestionDescription.Controls.Add(this.labelQuestionDescription);
            this.groupBoxQuestionDescription.Controls.Add(this.textBoxIdDescription);
            this.groupBoxQuestionDescription.Controls.Add(this.labelIdDescription);
            this.groupBoxQuestionDescription.Location = new System.Drawing.Point(1083, 231);
            this.groupBoxQuestionDescription.Name = "groupBoxQuestionDescription";
            this.groupBoxQuestionDescription.Size = new System.Drawing.Size(752, 652);
            this.groupBoxQuestionDescription.TabIndex = 5;
            this.groupBoxQuestionDescription.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonCancel.Location = new System.Drawing.Point(490, 588);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 49);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOk.Location = new System.Drawing.Point(628, 588);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(103, 49);
            this.buttonOk.TabIndex = 25;
            this.buttonOk.Text = "Save";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Visible = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBoxCategoryDescription
            // 
            this.comboBoxCategoryDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryDescription.Enabled = false;
            this.comboBoxCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoryDescription.FormattingEnabled = true;
            this.comboBoxCategoryDescription.Items.AddRange(new object[] {
            "Science Fiction",
            "Action",
            "Comedy",
            "Animation",
            "Horror",
            "Drama"});
            this.comboBoxCategoryDescription.Location = new System.Drawing.Point(246, 427);
            this.comboBoxCategoryDescription.Name = "comboBoxCategoryDescription";
            this.comboBoxCategoryDescription.Size = new System.Drawing.Size(482, 33);
            this.comboBoxCategoryDescription.TabIndex = 24;
            this.comboBoxCategoryDescription.Tag = "";
            // 
            // comboBoxDifficultDescription
            // 
            this.comboBoxDifficultDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficultDescription.Enabled = false;
            this.comboBoxDifficultDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDifficultDescription.FormattingEnabled = true;
            this.comboBoxDifficultDescription.Items.AddRange(new object[] {
            "Easy ",
            "Medium",
            "Hard",
            "Legend"});
            this.comboBoxDifficultDescription.Location = new System.Drawing.Point(246, 487);
            this.comboBoxDifficultDescription.Name = "comboBoxDifficultDescription";
            this.comboBoxDifficultDescription.Size = new System.Drawing.Size(482, 33);
            this.comboBoxDifficultDescription.TabIndex = 23;
            // 
            // textBoxIncorrectAnswer3
            // 
            this.textBoxIncorrectAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIncorrectAnswer3.Location = new System.Drawing.Point(246, 367);
            this.textBoxIncorrectAnswer3.Name = "textBoxIncorrectAnswer3";
            this.textBoxIncorrectAnswer3.ReadOnly = true;
            this.textBoxIncorrectAnswer3.Size = new System.Drawing.Size(482, 30);
            this.textBoxIncorrectAnswer3.TabIndex = 22;
            // 
            // textBoxIncorrectAnswer2
            // 
            this.textBoxIncorrectAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIncorrectAnswer2.Location = new System.Drawing.Point(246, 307);
            this.textBoxIncorrectAnswer2.Name = "textBoxIncorrectAnswer2";
            this.textBoxIncorrectAnswer2.ReadOnly = true;
            this.textBoxIncorrectAnswer2.Size = new System.Drawing.Size(482, 30);
            this.textBoxIncorrectAnswer2.TabIndex = 21;
            // 
            // textBoxIncorrectAnswer1
            // 
            this.textBoxIncorrectAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIncorrectAnswer1.Location = new System.Drawing.Point(246, 247);
            this.textBoxIncorrectAnswer1.Name = "textBoxIncorrectAnswer1";
            this.textBoxIncorrectAnswer1.ReadOnly = true;
            this.textBoxIncorrectAnswer1.Size = new System.Drawing.Size(482, 30);
            this.textBoxIncorrectAnswer1.TabIndex = 20;
            // 
            // labelDifficultyDescription
            // 
            this.labelDifficultyDescription.AutoSize = true;
            this.labelDifficultyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficultyDescription.Location = new System.Drawing.Point(32, 490);
            this.labelDifficultyDescription.Name = "labelDifficultyDescription";
            this.labelDifficultyDescription.Size = new System.Drawing.Size(94, 25);
            this.labelDifficultyDescription.TabIndex = 19;
            this.labelDifficultyDescription.Text = "Difficulty";
            // 
            // labelCategoryDescription
            // 
            this.labelCategoryDescription.AutoSize = true;
            this.labelCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryDescription.Location = new System.Drawing.Point(32, 430);
            this.labelCategoryDescription.Name = "labelCategoryDescription";
            this.labelCategoryDescription.Size = new System.Drawing.Size(100, 25);
            this.labelCategoryDescription.TabIndex = 18;
            this.labelCategoryDescription.Text = "Category";
            // 
            // labelIncorrectAnswer2Description
            // 
            this.labelIncorrectAnswer2Description.AutoSize = true;
            this.labelIncorrectAnswer2Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectAnswer2Description.Location = new System.Drawing.Point(32, 310);
            this.labelIncorrectAnswer2Description.Name = "labelIncorrectAnswer2Description";
            this.labelIncorrectAnswer2Description.Size = new System.Drawing.Size(171, 25);
            this.labelIncorrectAnswer2Description.TabIndex = 17;
            this.labelIncorrectAnswer2Description.Text = "Incorrect answer\r\n";
            this.labelIncorrectAnswer2Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIncorrectAnswer3Description
            // 
            this.labelIncorrectAnswer3Description.AutoSize = true;
            this.labelIncorrectAnswer3Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectAnswer3Description.Location = new System.Drawing.Point(32, 370);
            this.labelIncorrectAnswer3Description.Name = "labelIncorrectAnswer3Description";
            this.labelIncorrectAnswer3Description.Size = new System.Drawing.Size(171, 25);
            this.labelIncorrectAnswer3Description.TabIndex = 16;
            this.labelIncorrectAnswer3Description.Text = "Incorrect answer";
            this.labelIncorrectAnswer3Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIncorrectAnswer1Description
            // 
            this.labelIncorrectAnswer1Description.AutoSize = true;
            this.labelIncorrectAnswer1Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectAnswer1Description.Location = new System.Drawing.Point(32, 250);
            this.labelIncorrectAnswer1Description.Name = "labelIncorrectAnswer1Description";
            this.labelIncorrectAnswer1Description.Size = new System.Drawing.Size(171, 25);
            this.labelIncorrectAnswer1Description.TabIndex = 15;
            this.labelIncorrectAnswer1Description.Text = "Incorrect answer";
            this.labelIncorrectAnswer1Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCorrectAnswer
            // 
            this.textBoxCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorrectAnswer.Location = new System.Drawing.Point(246, 187);
            this.textBoxCorrectAnswer.Name = "textBoxCorrectAnswer";
            this.textBoxCorrectAnswer.ReadOnly = true;
            this.textBoxCorrectAnswer.Size = new System.Drawing.Size(482, 30);
            this.textBoxCorrectAnswer.TabIndex = 14;
            // 
            // labelCorrectAnswerDescription
            // 
            this.labelCorrectAnswerDescription.AutoSize = true;
            this.labelCorrectAnswerDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectAnswerDescription.Location = new System.Drawing.Point(32, 190);
            this.labelCorrectAnswerDescription.Name = "labelCorrectAnswerDescription";
            this.labelCorrectAnswerDescription.Size = new System.Drawing.Size(158, 25);
            this.labelCorrectAnswerDescription.TabIndex = 13;
            this.labelCorrectAnswerDescription.Text = "Correct answer";
            this.labelCorrectAnswerDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQuestionDescription
            // 
            this.textBoxQuestionDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuestionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestionDescription.Location = new System.Drawing.Point(246, 95);
            this.textBoxQuestionDescription.Multiline = true;
            this.textBoxQuestionDescription.Name = "textBoxQuestionDescription";
            this.textBoxQuestionDescription.ReadOnly = true;
            this.textBoxQuestionDescription.Size = new System.Drawing.Size(482, 77);
            this.textBoxQuestionDescription.TabIndex = 12;
            // 
            // labelQuestionDescription
            // 
            this.labelQuestionDescription.AutoSize = true;
            this.labelQuestionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionDescription.Location = new System.Drawing.Point(32, 98);
            this.labelQuestionDescription.Name = "labelQuestionDescription";
            this.labelQuestionDescription.Size = new System.Drawing.Size(99, 25);
            this.labelQuestionDescription.TabIndex = 11;
            this.labelQuestionDescription.Text = "Question";
            // 
            // textBoxIdDescription
            // 
            this.textBoxIdDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdDescription.Location = new System.Drawing.Point(246, 35);
            this.textBoxIdDescription.Name = "textBoxIdDescription";
            this.textBoxIdDescription.ReadOnly = true;
            this.textBoxIdDescription.Size = new System.Drawing.Size(482, 30);
            this.textBoxIdDescription.TabIndex = 10;
            // 
            // labelIdDescription
            // 
            this.labelIdDescription.AutoSize = true;
            this.labelIdDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdDescription.Location = new System.Drawing.Point(32, 38);
            this.labelIdDescription.Name = "labelIdDescription";
            this.labelIdDescription.Size = new System.Drawing.Size(33, 25);
            this.labelIdDescription.TabIndex = 9;
            this.labelIdDescription.Text = "ID";
            this.labelIdDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(55, 173);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(60, 25);
            this.labelFilter.TabIndex = 9;
            this.labelFilter.Text = "Filter";
            this.labelFilter.Click += new System.EventHandler(this.labelFilter_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(140, 170);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(528, 33);
            this.comboBoxFilter.TabIndex = 10;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(71)))));
            this.buttonApplyFilter.FlatAppearance.BorderSize = 0;
            this.buttonApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonApplyFilter.Location = new System.Drawing.Point(780, 163);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(103, 49);
            this.buttonApplyFilter.TabIndex = 11;
            this.buttonApplyFilter.Text = "Apply filter";
            this.buttonApplyFilter.UseVisualStyleBackColor = false;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.buttonClearFilter.FlatAppearance.BorderSize = 0;
            this.buttonClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClearFilter.Location = new System.Drawing.Point(922, 163);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(103, 49);
            this.buttonClearFilter.TabIndex = 12;
            this.buttonClearFilter.Text = "Clear filter";
            this.buttonClearFilter.UseVisualStyleBackColor = false;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
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
            this.panelActualUserData.TabIndex = 13;
            // 
            // labelLogout
            // 
            this.labelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.Location = new System.Drawing.Point(8, 89);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(185, 25);
            this.labelLogout.TabIndex = 2;
            this.labelLogout.Text = "Log Out";
            this.labelLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // labelActualUserData
            // 
            this.labelActualUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelActualUserData.Location = new System.Drawing.Point(7, 58);
            this.labelActualUserData.Name = "labelActualUserData";
            this.labelActualUserData.Size = new System.Drawing.Size(185, 25);
            this.labelActualUserData.TabIndex = 1;
            this.labelActualUserData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActualUserIcon
            // 
            this.labelActualUserIcon.Image = global::projecte_eywa.Properties.Resources.usuario__1_;
            this.labelActualUserIcon.Location = new System.Drawing.Point(66, 3);
            this.labelActualUserIcon.Name = "labelActualUserIcon";
            this.labelActualUserIcon.Size = new System.Drawing.Size(55, 55);
            this.labelActualUserIcon.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(232, 50);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 70);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUsersIcon
            // 
            this.buttonUsersIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUsersIcon.FlatAppearance.BorderSize = 0;
            this.buttonUsersIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersIcon.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsersIcon.Image")));
            this.buttonUsersIcon.Location = new System.Drawing.Point(142, 50);
            this.buttonUsersIcon.Name = "buttonUsersIcon";
            this.buttonUsersIcon.Size = new System.Drawing.Size(70, 70);
            this.buttonUsersIcon.TabIndex = 14;
            this.buttonUsersIcon.UseVisualStyleBackColor = true;
            this.buttonUsersIcon.Click += new System.EventHandler(this.buttonUsersIcon_Click);
            // 
            // buttonCharactersIcon
            // 
            this.buttonCharactersIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCharactersIcon.FlatAppearance.BorderSize = 0;
            this.buttonCharactersIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCharactersIcon.Image = ((System.Drawing.Image)(resources.GetObject("buttonCharactersIcon.Image")));
            this.buttonCharactersIcon.Location = new System.Drawing.Point(52, 50);
            this.buttonCharactersIcon.Name = "buttonCharactersIcon";
            this.buttonCharactersIcon.Size = new System.Drawing.Size(70, 70);
            this.buttonCharactersIcon.TabIndex = 3;
            this.buttonCharactersIcon.UseVisualStyleBackColor = true;
            this.buttonCharactersIcon.Click += new System.EventHandler(this.buttonCharactersIcon_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.buttonEnglish.Image = global::projecte_eywa.Properties.Resources.bandera_england__1_;
            this.buttonEnglish.Location = new System.Drawing.Point(1292, 176);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(103, 49);
            this.buttonEnglish.TabIndex = 8;
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // buttonEspañol
            // 
            this.buttonEspañol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEspañol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEspañol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.buttonEspañol.Image = global::projecte_eywa.Properties.Resources.españa_boton1;
            this.buttonEspañol.Location = new System.Drawing.Point(1183, 176);
            this.buttonEspañol.Name = "buttonEspañol";
            this.buttonEspañol.Size = new System.Drawing.Size(103, 49);
            this.buttonEspañol.TabIndex = 7;
            this.buttonEspañol.UseVisualStyleBackColor = true;
            this.buttonEspañol.Click += new System.EventHandler(this.buttonEspañol_Click);
            // 
            // buttonCatala
            // 
            this.buttonCatala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCatala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.buttonCatala.Image = global::projecte_eywa.Properties.Resources.cataluña_bandera__1_;
            this.buttonCatala.Location = new System.Drawing.Point(1083, 176);
            this.buttonCatala.Name = "buttonCatala";
            this.buttonCatala.Size = new System.Drawing.Size(103, 49);
            this.buttonCatala.TabIndex = 6;
            this.buttonCatala.UseMnemonic = false;
            this.buttonCatala.UseVisualStyleBackColor = true;
            this.buttonCatala.Click += new System.EventHandler(this.buttonCatala_Click);
            // 
            // quizQuestionsBindingSource
            // 
            this.quizQuestionsBindingSource.DataSource = typeof(projecte_eywa.QuizQuestion);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.FillWeight = 25.38071F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 47;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.questionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.questionDataGridViewTextBoxColumn.FillWeight = 118.6548F;
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionDataGridViewTextBoxColumn.Width = 221;
            // 
            // difficultyDataGridViewTextBoxColumn
            // 
            this.difficultyDataGridViewTextBoxColumn.DataPropertyName = "difficulty";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.difficultyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.difficultyDataGridViewTextBoxColumn.FillWeight = 118.6548F;
            this.difficultyDataGridViewTextBoxColumn.HeaderText = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.Name = "difficultyDataGridViewTextBoxColumn";
            this.difficultyDataGridViewTextBoxColumn.ReadOnly = true;
            this.difficultyDataGridViewTextBoxColumn.Width = 221;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.categoryDataGridViewTextBoxColumn.FillWeight = 118.6548F;
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 220;
            // 
            // correctanswerDataGridViewTextBoxColumn
            // 
            this.correctanswerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correctanswerDataGridViewTextBoxColumn.DataPropertyName = "correct_answer";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.correctanswerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.correctanswerDataGridViewTextBoxColumn.FillWeight = 118.6548F;
            this.correctanswerDataGridViewTextBoxColumn.HeaderText = "Correct Answer";
            this.correctanswerDataGridViewTextBoxColumn.Name = "correctanswerDataGridViewTextBoxColumn";
            this.correctanswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUsersIcon);
            this.Controls.Add(this.buttonCharactersIcon);
            this.Controls.Add(this.panelActualUserData);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.buttonEspañol);
            this.Controls.Add(this.buttonCatala);
            this.Controls.Add(this.groupBoxQuestionDescription);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewQuestions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuestions";
            this.Text = "Questions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuestions_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuestions_FormClosed);
            this.Load += new System.EventHandler(this.FormQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.groupBoxQuestionDescription.ResumeLayout(false);
            this.groupBoxQuestionDescription.PerformLayout();
            this.panelActualUserData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quizQuestionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxQuestionDescription;
        private System.Windows.Forms.Button buttonCatala;
        private System.Windows.Forms.Button buttonEspañol;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.TextBox textBoxQuestionDescription;
        private System.Windows.Forms.Label labelQuestionDescription;
        private System.Windows.Forms.TextBox textBoxIdDescription;
        private System.Windows.Forms.Label labelIdDescription;
        private System.Windows.Forms.TextBox textBoxIncorrectAnswer3;
        private System.Windows.Forms.TextBox textBoxIncorrectAnswer2;
        private System.Windows.Forms.TextBox textBoxIncorrectAnswer1;
        private System.Windows.Forms.Label labelDifficultyDescription;
        private System.Windows.Forms.Label labelCategoryDescription;
        private System.Windows.Forms.Label labelIncorrectAnswer2Description;
        private System.Windows.Forms.Label labelIncorrectAnswer3Description;
        private System.Windows.Forms.Label labelIncorrectAnswer1Description;
        private System.Windows.Forms.TextBox textBoxCorrectAnswer;
        private System.Windows.Forms.Label labelCorrectAnswerDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxCategoryDescription;
        private System.Windows.Forms.ComboBox comboBoxDifficultDescription;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.BindingSource quizQuestionsBindingSource;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Panel panelActualUserData;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelActualUserData;
        private System.Windows.Forms.Label labelActualUserIcon;
        private System.Windows.Forms.Button buttonCharactersIcon;
        private System.Windows.Forms.Button buttonUsersIcon;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctanswerDataGridViewTextBoxColumn;
    }
}

