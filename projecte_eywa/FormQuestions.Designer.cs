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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestions));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPersonatgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buttonEspañol = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.buttonCatala = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctanswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.groupBoxQuestionDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizQuestionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPersonatgesToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.charactersToolStripMenuItem.Text = "File";
            // 
            // gestionarPersonatgesToolStripMenuItem
            // 
            this.gestionarPersonatgesToolStripMenuItem.Name = "gestionarPersonatgesToolStripMenuItem";
            this.gestionarPersonatgesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.gestionarPersonatgesToolStripMenuItem.Text = "Charcater management";
            this.gestionarPersonatgesToolStripMenuItem.Click += new System.EventHandler(this.gestionarPersonatgesToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.userManagementToolStripMenuItem.Text = "User management";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuestions.AutoGenerateColumns = false;
            this.dataGridViewQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.difficultyDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.correctanswerDataGridViewTextBoxColumn});
            this.dataGridViewQuestions.DataSource = this.quizQuestionBindingSource;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(8, 58);
            this.dataGridViewQuestions.MultiSelect = false;
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.ReadOnly = true;
            this.dataGridViewQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuestions.Size = new System.Drawing.Size(446, 298);
            this.dataGridViewQuestions.TabIndex = 1;
            this.dataGridViewQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuestions_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(8, 377);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 29);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(69, 377);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(55, 29);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(130, 377);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(55, 29);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
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
            this.groupBoxQuestionDescription.Location = new System.Drawing.Point(465, 64);
            this.groupBoxQuestionDescription.Name = "groupBoxQuestionDescription";
            this.groupBoxQuestionDescription.Size = new System.Drawing.Size(323, 357);
            this.groupBoxQuestionDescription.TabIndex = 5;
            this.groupBoxQuestionDescription.TabStop = false;
            this.groupBoxQuestionDescription.Text = "Question";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 313);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(55, 29);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Location = new System.Drawing.Point(262, 313);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(55, 29);
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
            this.comboBoxCategoryDescription.FormattingEnabled = true;
            this.comboBoxCategoryDescription.Items.AddRange(new object[] {
            "Science Fiction",
            "Action",
            "Comedy",
            "Animation",
            "Horror",
            "Drama"});
            this.comboBoxCategoryDescription.Location = new System.Drawing.Point(59, 248);
            this.comboBoxCategoryDescription.Name = "comboBoxCategoryDescription";
            this.comboBoxCategoryDescription.Size = new System.Drawing.Size(258, 21);
            this.comboBoxCategoryDescription.TabIndex = 24;
            this.comboBoxCategoryDescription.Tag = "";
            // 
            // comboBoxDifficultDescription
            // 
            this.comboBoxDifficultDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficultDescription.Enabled = false;
            this.comboBoxDifficultDescription.FormattingEnabled = true;
            this.comboBoxDifficultDescription.Items.AddRange(new object[] {
            "Easy ",
            "Medium",
            "Hard",
            "Legend"});
            this.comboBoxDifficultDescription.Location = new System.Drawing.Point(59, 278);
            this.comboBoxDifficultDescription.Name = "comboBoxDifficultDescription";
            this.comboBoxDifficultDescription.Size = new System.Drawing.Size(258, 21);
            this.comboBoxDifficultDescription.TabIndex = 23;
            // 
            // textBoxIncorrectAnswer3
            // 
            this.textBoxIncorrectAnswer3.Location = new System.Drawing.Point(59, 213);
            this.textBoxIncorrectAnswer3.Name = "textBoxIncorrectAnswer3";
            this.textBoxIncorrectAnswer3.ReadOnly = true;
            this.textBoxIncorrectAnswer3.Size = new System.Drawing.Size(258, 20);
            this.textBoxIncorrectAnswer3.TabIndex = 22;
            // 
            // textBoxIncorrectAnswer2
            // 
            this.textBoxIncorrectAnswer2.Location = new System.Drawing.Point(59, 174);
            this.textBoxIncorrectAnswer2.Name = "textBoxIncorrectAnswer2";
            this.textBoxIncorrectAnswer2.ReadOnly = true;
            this.textBoxIncorrectAnswer2.Size = new System.Drawing.Size(258, 20);
            this.textBoxIncorrectAnswer2.TabIndex = 21;
            // 
            // textBoxIncorrectAnswer1
            // 
            this.textBoxIncorrectAnswer1.Location = new System.Drawing.Point(59, 135);
            this.textBoxIncorrectAnswer1.Name = "textBoxIncorrectAnswer1";
            this.textBoxIncorrectAnswer1.ReadOnly = true;
            this.textBoxIncorrectAnswer1.Size = new System.Drawing.Size(258, 20);
            this.textBoxIncorrectAnswer1.TabIndex = 20;
            // 
            // labelDifficultyDescription
            // 
            this.labelDifficultyDescription.AutoSize = true;
            this.labelDifficultyDescription.Location = new System.Drawing.Point(6, 281);
            this.labelDifficultyDescription.Name = "labelDifficultyDescription";
            this.labelDifficultyDescription.Size = new System.Drawing.Size(47, 13);
            this.labelDifficultyDescription.TabIndex = 19;
            this.labelDifficultyDescription.Text = "Difficulty";
            // 
            // labelCategoryDescription
            // 
            this.labelCategoryDescription.AutoSize = true;
            this.labelCategoryDescription.Location = new System.Drawing.Point(6, 251);
            this.labelCategoryDescription.Name = "labelCategoryDescription";
            this.labelCategoryDescription.Size = new System.Drawing.Size(49, 13);
            this.labelCategoryDescription.TabIndex = 18;
            this.labelCategoryDescription.Text = "Category";
            // 
            // labelIncorrectAnswer2Description
            // 
            this.labelIncorrectAnswer2Description.AutoSize = true;
            this.labelIncorrectAnswer2Description.Location = new System.Drawing.Point(6, 170);
            this.labelIncorrectAnswer2Description.Name = "labelIncorrectAnswer2Description";
            this.labelIncorrectAnswer2Description.Size = new System.Drawing.Size(49, 26);
            this.labelIncorrectAnswer2Description.TabIndex = 17;
            this.labelIncorrectAnswer2Description.Text = "Incorrect\r\nanswer\r\n";
            this.labelIncorrectAnswer2Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIncorrectAnswer3Description
            // 
            this.labelIncorrectAnswer3Description.AutoSize = true;
            this.labelIncorrectAnswer3Description.Location = new System.Drawing.Point(6, 209);
            this.labelIncorrectAnswer3Description.Name = "labelIncorrectAnswer3Description";
            this.labelIncorrectAnswer3Description.Size = new System.Drawing.Size(52, 39);
            this.labelIncorrectAnswer3Description.TabIndex = 16;
            this.labelIncorrectAnswer3Description.Text = "Incorrect \r\nanswer\r\n\r\n";
            this.labelIncorrectAnswer3Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIncorrectAnswer1Description
            // 
            this.labelIncorrectAnswer1Description.AutoSize = true;
            this.labelIncorrectAnswer1Description.Location = new System.Drawing.Point(6, 131);
            this.labelIncorrectAnswer1Description.Name = "labelIncorrectAnswer1Description";
            this.labelIncorrectAnswer1Description.Size = new System.Drawing.Size(49, 26);
            this.labelIncorrectAnswer1Description.TabIndex = 15;
            this.labelIncorrectAnswer1Description.Text = "Incorrect\r\nanswer\r\n";
            this.labelIncorrectAnswer1Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCorrectAnswer
            // 
            this.textBoxCorrectAnswer.Location = new System.Drawing.Point(59, 93);
            this.textBoxCorrectAnswer.Name = "textBoxCorrectAnswer";
            this.textBoxCorrectAnswer.ReadOnly = true;
            this.textBoxCorrectAnswer.Size = new System.Drawing.Size(258, 20);
            this.textBoxCorrectAnswer.TabIndex = 14;
            // 
            // labelCorrectAnswerDescription
            // 
            this.labelCorrectAnswerDescription.AutoSize = true;
            this.labelCorrectAnswerDescription.Location = new System.Drawing.Point(6, 83);
            this.labelCorrectAnswerDescription.Name = "labelCorrectAnswerDescription";
            this.labelCorrectAnswerDescription.Size = new System.Drawing.Size(44, 26);
            this.labelCorrectAnswerDescription.TabIndex = 13;
            this.labelCorrectAnswerDescription.Text = "Correct \r\nanswer\r\n";
            this.labelCorrectAnswerDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQuestionDescription
            // 
            this.textBoxQuestionDescription.Location = new System.Drawing.Point(59, 52);
            this.textBoxQuestionDescription.Multiline = true;
            this.textBoxQuestionDescription.Name = "textBoxQuestionDescription";
            this.textBoxQuestionDescription.ReadOnly = true;
            this.textBoxQuestionDescription.Size = new System.Drawing.Size(258, 24);
            this.textBoxQuestionDescription.TabIndex = 12;
            // 
            // labelQuestionDescription
            // 
            this.labelQuestionDescription.AutoSize = true;
            this.labelQuestionDescription.Location = new System.Drawing.Point(6, 55);
            this.labelQuestionDescription.Name = "labelQuestionDescription";
            this.labelQuestionDescription.Size = new System.Drawing.Size(49, 13);
            this.labelQuestionDescription.TabIndex = 11;
            this.labelQuestionDescription.Text = "Question";
            // 
            // textBoxIdDescription
            // 
            this.textBoxIdDescription.Location = new System.Drawing.Point(59, 19);
            this.textBoxIdDescription.Name = "textBoxIdDescription";
            this.textBoxIdDescription.ReadOnly = true;
            this.textBoxIdDescription.Size = new System.Drawing.Size(258, 20);
            this.textBoxIdDescription.TabIndex = 10;
            // 
            // labelIdDescription
            // 
            this.labelIdDescription.AutoSize = true;
            this.labelIdDescription.Location = new System.Drawing.Point(6, 22);
            this.labelIdDescription.Name = "labelIdDescription";
            this.labelIdDescription.Size = new System.Drawing.Size(16, 13);
            this.labelIdDescription.TabIndex = 9;
            this.labelIdDescription.Text = "Id";
            this.labelIdDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEspañol
            // 
            this.buttonEspañol.Location = new System.Drawing.Point(672, 27);
            this.buttonEspañol.Name = "buttonEspañol";
            this.buttonEspañol.Size = new System.Drawing.Size(55, 29);
            this.buttonEspañol.TabIndex = 7;
            this.buttonEspañol.Text = "Español";
            this.buttonEspañol.UseVisualStyleBackColor = true;
            this.buttonEspañol.Click += new System.EventHandler(this.buttonEspañol_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Location = new System.Drawing.Point(733, 27);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(55, 29);
            this.buttonEnglish.TabIndex = 8;
            this.buttonEnglish.Text = "English";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // buttonCatala
            // 
            this.buttonCatala.Location = new System.Drawing.Point(611, 27);
            this.buttonCatala.Name = "buttonCatala";
            this.buttonCatala.Size = new System.Drawing.Size(55, 29);
            this.buttonCatala.TabIndex = 6;
            this.buttonCatala.Text = "Català";
            this.buttonCatala.UseMnemonic = false;
            this.buttonCatala.UseVisualStyleBackColor = true;
            this.buttonCatala.Click += new System.EventHandler(this.buttonCatala_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(12, 35);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(29, 13);
            this.labelFilter.TabIndex = 9;
            this.labelFilter.Text = "Filter";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(47, 31);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(224, 21);
            this.comboBoxFilter.TabIndex = 10;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Location = new System.Drawing.Point(287, 27);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(68, 29);
            this.buttonApplyFilter.TabIndex = 11;
            this.buttonApplyFilter.Text = "Apply Filter";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(372, 27);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(68, 29);
            this.buttonClearFilter.TabIndex = 12;
            this.buttonClearFilter.Text = "Clear Filter";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // difficultyDataGridViewTextBoxColumn
            // 
            this.difficultyDataGridViewTextBoxColumn.DataPropertyName = "difficulty";
            this.difficultyDataGridViewTextBoxColumn.HeaderText = "difficulty";
            this.difficultyDataGridViewTextBoxColumn.Name = "difficultyDataGridViewTextBoxColumn";
            this.difficultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctanswerDataGridViewTextBoxColumn
            // 
            this.correctanswerDataGridViewTextBoxColumn.DataPropertyName = "correct_answer";
            this.correctanswerDataGridViewTextBoxColumn.HeaderText = "correct_answer";
            this.correctanswerDataGridViewTextBoxColumn.Name = "correctanswerDataGridViewTextBoxColumn";
            this.correctanswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quizQuestionBindingSource
            // 
            this.quizQuestionBindingSource.DataSource = typeof(projecte_eywa.QuizQuestion);
            // 
            // FormQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormQuestions";
            this.Text = "Preguntes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuestions_FormClosed);
            this.Load += new System.EventHandler(this.FormQuestions_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.groupBoxQuestionDescription.ResumeLayout(false);
            this.groupBoxQuestionDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizQuestionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem gestionarPersonatgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.BindingSource quizQuestionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctanswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonClearFilter;
    }
}

