namespace projecte_eywa
{
    partial class FormCharacters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacters));
            this.dataGridViewCharacters = new System.Windows.Forms.DataGridView();
            this.nameCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctNumCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlImageCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCharacter = new System.Windows.Forms.GroupBox();
            this.numericUpDownCorrectNum = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCategoryCharacter = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDecriptionCharacter = new System.Windows.Forms.TextBox();
            this.labelDescriptionCharacter = new System.Windows.Forms.Label();
            this.textBoxImgUrlCharacter = new System.Windows.Forms.TextBox();
            this.labelImgUrl = new System.Windows.Forms.Label();
            this.textBoxDifficultyCharacter = new System.Windows.Forms.TextBox();
            this.labelNumCorrecto = new System.Windows.Forms.Label();
            this.labelDifficultyCharacter = new System.Windows.Forms.Label();
            this.labelCategoryCharacter = new System.Windows.Forms.Label();
            this.labelFilmCharacter = new System.Windows.Forms.Label();
            this.textBoxFilmCharacter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameCharacter = new System.Windows.Forms.TextBox();
            this.labelNameCharacter = new System.Windows.Forms.Label();
            this.buttonCatalan = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.buttonSpanish = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.characterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formCharactersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.formCharactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formCharactersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formCharactersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrectNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCharacters
            // 
            this.dataGridViewCharacters.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCharacters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCharacters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCharacter,
            this.correctNumCharacter,
            this.urlImageCharacter,
            this.descCharacter,
            this.categoryCharacter,
            this.difficultyCharacter,
            this.filmCharacter});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCharacters.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCharacters.Location = new System.Drawing.Point(8, 58);
            this.dataGridViewCharacters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCharacters.Name = "dataGridViewCharacters";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCharacters.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCharacters.RowHeadersWidth = 62;
            this.dataGridViewCharacters.RowTemplate.Height = 28;
            this.dataGridViewCharacters.Size = new System.Drawing.Size(446, 298);
            this.dataGridViewCharacters.TabIndex = 1;
            this.dataGridViewCharacters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCharacters_CellClick);
            // 
            // nameCharacter
            // 
            this.nameCharacter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCharacter.DataPropertyName = "nameCharacter";
            this.nameCharacter.HeaderText = "Name";
            this.nameCharacter.MinimumWidth = 8;
            this.nameCharacter.Name = "nameCharacter";
            // 
            // correctNumCharacter
            // 
            this.correctNumCharacter.DataPropertyName = "correctNumCharacter";
            this.correctNumCharacter.HeaderText = "Correct number";
            this.correctNumCharacter.MinimumWidth = 8;
            this.correctNumCharacter.Name = "correctNumCharacter";
            this.correctNumCharacter.Visible = false;
            this.correctNumCharacter.Width = 150;
            // 
            // urlImageCharacter
            // 
            this.urlImageCharacter.DataPropertyName = "urlImageCharacter";
            this.urlImageCharacter.HeaderText = "Url image";
            this.urlImageCharacter.MinimumWidth = 8;
            this.urlImageCharacter.Name = "urlImageCharacter";
            this.urlImageCharacter.Visible = false;
            this.urlImageCharacter.Width = 150;
            // 
            // descCharacter
            // 
            this.descCharacter.DataPropertyName = "descCharacter";
            this.descCharacter.HeaderText = "Description";
            this.descCharacter.MinimumWidth = 8;
            this.descCharacter.Name = "descCharacter";
            this.descCharacter.Visible = false;
            this.descCharacter.Width = 150;
            // 
            // categoryCharacter
            // 
            this.categoryCharacter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryCharacter.DataPropertyName = "categoryCharacter";
            this.categoryCharacter.HeaderText = "Category";
            this.categoryCharacter.MinimumWidth = 8;
            this.categoryCharacter.Name = "categoryCharacter";
            this.categoryCharacter.Visible = false;
            // 
            // difficultyCharacter
            // 
            this.difficultyCharacter.DataPropertyName = "difficultyCharacter";
            this.difficultyCharacter.HeaderText = "Difficulty";
            this.difficultyCharacter.MinimumWidth = 8;
            this.difficultyCharacter.Name = "difficultyCharacter";
            this.difficultyCharacter.Visible = false;
            this.difficultyCharacter.Width = 150;
            // 
            // filmCharacter
            // 
            this.filmCharacter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filmCharacter.DataPropertyName = "filmCharacter";
            this.filmCharacter.HeaderText = "Film";
            this.filmCharacter.MinimumWidth = 8;
            this.filmCharacter.Name = "filmCharacter";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.questionsToolStripMenuItem.Text = "Questions";
            this.questionsToolStripMenuItem.Click += new System.EventHandler(this.questionsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // groupBoxCharacter
            // 
            this.groupBoxCharacter.Controls.Add(this.numericUpDownCorrectNum);
            this.groupBoxCharacter.Controls.Add(this.comboBoxCategoryCharacter);
            this.groupBoxCharacter.Controls.Add(this.buttonCancel);
            this.groupBoxCharacter.Controls.Add(this.buttonSave);
            this.groupBoxCharacter.Controls.Add(this.textBoxDecriptionCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelDescriptionCharacter);
            this.groupBoxCharacter.Controls.Add(this.textBoxImgUrlCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelImgUrl);
            this.groupBoxCharacter.Controls.Add(this.textBoxDifficultyCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelNumCorrecto);
            this.groupBoxCharacter.Controls.Add(this.labelDifficultyCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelCategoryCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelFilmCharacter);
            this.groupBoxCharacter.Controls.Add(this.textBoxFilmCharacter);
            this.groupBoxCharacter.Controls.Add(this.label1);
            this.groupBoxCharacter.Controls.Add(this.textBoxNameCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelNameCharacter);
            this.groupBoxCharacter.Location = new System.Drawing.Point(466, 58);
            this.groupBoxCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCharacter.Name = "groupBoxCharacter";
            this.groupBoxCharacter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCharacter.Size = new System.Drawing.Size(323, 357);
            this.groupBoxCharacter.TabIndex = 3;
            this.groupBoxCharacter.TabStop = false;
            this.groupBoxCharacter.Text = "Character";
            // 
            // numericUpDownCorrectNum
            // 
            this.numericUpDownCorrectNum.Enabled = false;
            this.numericUpDownCorrectNum.Location = new System.Drawing.Point(103, 130);
            this.numericUpDownCorrectNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownCorrectNum.Name = "numericUpDownCorrectNum";
            this.numericUpDownCorrectNum.Size = new System.Drawing.Size(214, 20);
            this.numericUpDownCorrectNum.TabIndex = 10;
            // 
            // comboBoxCategoryCharacter
            // 
            this.comboBoxCategoryCharacter.Enabled = false;
            this.comboBoxCategoryCharacter.FormattingEnabled = true;
            this.comboBoxCategoryCharacter.Location = new System.Drawing.Point(103, 83);
            this.comboBoxCategoryCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategoryCharacter.Name = "comboBoxCategoryCharacter";
            this.comboBoxCategoryCharacter.Size = new System.Drawing.Size(215, 21);
            this.comboBoxCategoryCharacter.TabIndex = 17;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(203, 287);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(55, 29);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(262, 287);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(55, 29);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDecriptionCharacter
            // 
            this.textBoxDecriptionCharacter.Enabled = false;
            this.textBoxDecriptionCharacter.Location = new System.Drawing.Point(103, 181);
            this.textBoxDecriptionCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDecriptionCharacter.Multiline = true;
            this.textBoxDecriptionCharacter.Name = "textBoxDecriptionCharacter";
            this.textBoxDecriptionCharacter.Size = new System.Drawing.Size(216, 89);
            this.textBoxDecriptionCharacter.TabIndex = 13;
            // 
            // labelDescriptionCharacter
            // 
            this.labelDescriptionCharacter.AutoSize = true;
            this.labelDescriptionCharacter.Location = new System.Drawing.Point(19, 183);
            this.labelDescriptionCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescriptionCharacter.Name = "labelDescriptionCharacter";
            this.labelDescriptionCharacter.Size = new System.Drawing.Size(60, 13);
            this.labelDescriptionCharacter.TabIndex = 14;
            this.labelDescriptionCharacter.Text = "Description";
            // 
            // textBoxImgUrlCharacter
            // 
            this.textBoxImgUrlCharacter.Enabled = false;
            this.textBoxImgUrlCharacter.Location = new System.Drawing.Point(103, 153);
            this.textBoxImgUrlCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxImgUrlCharacter.Name = "textBoxImgUrlCharacter";
            this.textBoxImgUrlCharacter.Size = new System.Drawing.Size(216, 20);
            this.textBoxImgUrlCharacter.TabIndex = 11;
            // 
            // labelImgUrl
            // 
            this.labelImgUrl.AutoSize = true;
            this.labelImgUrl.Location = new System.Drawing.Point(19, 155);
            this.labelImgUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImgUrl.Name = "labelImgUrl";
            this.labelImgUrl.Size = new System.Drawing.Size(50, 13);
            this.labelImgUrl.TabIndex = 12;
            this.labelImgUrl.Text = "Image url";
            // 
            // textBoxDifficultyCharacter
            // 
            this.textBoxDifficultyCharacter.Enabled = false;
            this.textBoxDifficultyCharacter.Location = new System.Drawing.Point(103, 105);
            this.textBoxDifficultyCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDifficultyCharacter.Name = "textBoxDifficultyCharacter";
            this.textBoxDifficultyCharacter.Size = new System.Drawing.Size(216, 20);
            this.textBoxDifficultyCharacter.TabIndex = 7;
            // 
            // labelNumCorrecto
            // 
            this.labelNumCorrecto.AutoSize = true;
            this.labelNumCorrecto.Location = new System.Drawing.Point(19, 131);
            this.labelNumCorrecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumCorrecto.Name = "labelNumCorrecto";
            this.labelNumCorrecto.Size = new System.Drawing.Size(79, 13);
            this.labelNumCorrecto.TabIndex = 10;
            this.labelNumCorrecto.Text = "Correct number";
            // 
            // labelDifficultyCharacter
            // 
            this.labelDifficultyCharacter.AutoSize = true;
            this.labelDifficultyCharacter.Location = new System.Drawing.Point(19, 107);
            this.labelDifficultyCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDifficultyCharacter.Name = "labelDifficultyCharacter";
            this.labelDifficultyCharacter.Size = new System.Drawing.Size(47, 13);
            this.labelDifficultyCharacter.TabIndex = 8;
            this.labelDifficultyCharacter.Text = "Difficulty";
            // 
            // labelCategoryCharacter
            // 
            this.labelCategoryCharacter.AutoSize = true;
            this.labelCategoryCharacter.Location = new System.Drawing.Point(19, 83);
            this.labelCategoryCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoryCharacter.Name = "labelCategoryCharacter";
            this.labelCategoryCharacter.Size = new System.Drawing.Size(49, 13);
            this.labelCategoryCharacter.TabIndex = 6;
            this.labelCategoryCharacter.Text = "Category";
            // 
            // labelFilmCharacter
            // 
            this.labelFilmCharacter.AutoSize = true;
            this.labelFilmCharacter.Location = new System.Drawing.Point(19, 60);
            this.labelFilmCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilmCharacter.Name = "labelFilmCharacter";
            this.labelFilmCharacter.Size = new System.Drawing.Size(25, 13);
            this.labelFilmCharacter.TabIndex = 4;
            this.labelFilmCharacter.Text = "Film";
            // 
            // textBoxFilmCharacter
            // 
            this.textBoxFilmCharacter.Enabled = false;
            this.textBoxFilmCharacter.Location = new System.Drawing.Point(103, 60);
            this.textBoxFilmCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilmCharacter.Name = "textBoxFilmCharacter";
            this.textBoxFilmCharacter.Size = new System.Drawing.Size(216, 20);
            this.textBoxFilmCharacter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // textBoxNameCharacter
            // 
            this.textBoxNameCharacter.Enabled = false;
            this.textBoxNameCharacter.Location = new System.Drawing.Point(103, 37);
            this.textBoxNameCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNameCharacter.Name = "textBoxNameCharacter";
            this.textBoxNameCharacter.Size = new System.Drawing.Size(216, 20);
            this.textBoxNameCharacter.TabIndex = 1;
            // 
            // labelNameCharacter
            // 
            this.labelNameCharacter.AutoSize = true;
            this.labelNameCharacter.Location = new System.Drawing.Point(19, 39);
            this.labelNameCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameCharacter.Name = "labelNameCharacter";
            this.labelNameCharacter.Size = new System.Drawing.Size(35, 13);
            this.labelNameCharacter.TabIndex = 0;
            this.labelNameCharacter.Text = "Name";
            // 
            // buttonCatalan
            // 
            this.buttonCatalan.Location = new System.Drawing.Point(615, 27);
            this.buttonCatalan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCatalan.Name = "buttonCatalan";
            this.buttonCatalan.Size = new System.Drawing.Size(55, 29);
            this.buttonCatalan.TabIndex = 4;
            this.buttonCatalan.Text = "Catalan";
            this.buttonCatalan.UseVisualStyleBackColor = true;
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Location = new System.Drawing.Point(733, 27);
            this.buttonEnglish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(55, 29);
            this.buttonEnglish.TabIndex = 5;
            this.buttonEnglish.Text = "English";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            // 
            // buttonSpanish
            // 
            this.buttonSpanish.Location = new System.Drawing.Point(674, 27);
            this.buttonSpanish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpanish.Name = "buttonSpanish";
            this.buttonSpanish.Size = new System.Drawing.Size(55, 29);
            this.buttonSpanish.TabIndex = 6;
            this.buttonSpanish.Text = "Spanish";
            this.buttonSpanish.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(67, 377);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(55, 29);
            this.buttonModify.TabIndex = 9;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(126, 377);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(55, 29);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(8, 377);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 29);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // formCharactersBindingSource2
            // 
            this.formCharactersBindingSource2.DataSource = typeof(projecte_eywa.FormCharacters);
            // 
            // formCharactersBindingSource
            // 
            this.formCharactersBindingSource.DataSource = typeof(projecte_eywa.FormCharacters);
            // 
            // formCharactersBindingSource1
            // 
            this.formCharactersBindingSource1.DataSource = typeof(projecte_eywa.FormCharacters);
            // 
            // formCharactersBindingSource3
            // 
            this.formCharactersBindingSource3.DataSource = typeof(projecte_eywa.FormCharacters);
            // 
            // FormCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSpanish);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.buttonCatalan);
            this.Controls.Add(this.groupBoxCharacter);
            this.Controls.Add(this.dataGridViewCharacters);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCharacters";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCharacters_FormClosed);
            this.Load += new System.EventHandler(this.FormCharacters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCharacter.ResumeLayout(false);
            this.groupBoxCharacter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrectNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCharacters;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCharacter;
        private System.Windows.Forms.Label labelNumCorrecto;
        private System.Windows.Forms.Label labelDifficultyCharacter;
        private System.Windows.Forms.TextBox textBoxDifficultyCharacter;
        private System.Windows.Forms.Label labelCategoryCharacter;
        private System.Windows.Forms.Label labelFilmCharacter;
        private System.Windows.Forms.TextBox textBoxFilmCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameCharacter;
        private System.Windows.Forms.Label labelNameCharacter;
        private System.Windows.Forms.TextBox textBoxDecriptionCharacter;
        private System.Windows.Forms.Label labelDescriptionCharacter;
        private System.Windows.Forms.TextBox textBoxImgUrlCharacter;
        private System.Windows.Forms.Label labelImgUrl;
        private System.Windows.Forms.Button buttonCatalan;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Button buttonSpanish;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.BindingSource formCharactersBindingSource;
        private System.Windows.Forms.BindingSource characterBindingSource1;
        private System.Windows.Forms.BindingSource formCharactersBindingSource1;
        private System.Windows.Forms.BindingSource formCharactersBindingSource2;
        private System.Windows.Forms.BindingSource formCharactersBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctNumCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlImageCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmCharacter;
        private System.Windows.Forms.ComboBox comboBoxCategoryCharacter;
        private System.Windows.Forms.NumericUpDown numericUpDownCorrectNum;
    }
}

