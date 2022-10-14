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
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCharacter = new System.Windows.Forms.GroupBox();
            this.textBoxDescriptionCharacterCat = new System.Windows.Forms.TextBox();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.textBoxDescriptionCharacterEng = new System.Windows.Forms.TextBox();
            this.numericUpDownCorrectNum = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCategoryCharacter = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDescriptionCharacterEsp = new System.Windows.Forms.TextBox();
            this.labelDescriptionCharacter = new System.Windows.Forms.Label();
            this.textBoxImgUrlCharacter = new System.Windows.Forms.TextBox();
            this.labelImgUrl = new System.Windows.Forms.Label();
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
            this.filmCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlImageCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctNumCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCharacter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCharacters = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.formCharactersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.formCharactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formCharactersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formCharactersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrectNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
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
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // groupBoxCharacter
            // 
            this.groupBoxCharacter.Controls.Add(this.textBoxDescriptionCharacterCat);
            this.groupBoxCharacter.Controls.Add(this.comboBoxDifficulty);
            this.groupBoxCharacter.Controls.Add(this.textBoxDescriptionCharacterEng);
            this.groupBoxCharacter.Controls.Add(this.numericUpDownCorrectNum);
            this.groupBoxCharacter.Controls.Add(this.comboBoxCategoryCharacter);
            this.groupBoxCharacter.Controls.Add(this.buttonCancel);
            this.groupBoxCharacter.Controls.Add(this.buttonSave);
            this.groupBoxCharacter.Controls.Add(this.textBoxDescriptionCharacterEsp);
            this.groupBoxCharacter.Controls.Add(this.labelDescriptionCharacter);
            this.groupBoxCharacter.Controls.Add(this.textBoxImgUrlCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelImgUrl);
            this.groupBoxCharacter.Controls.Add(this.labelNumCorrecto);
            this.groupBoxCharacter.Controls.Add(this.labelDifficultyCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelCategoryCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelFilmCharacter);
            this.groupBoxCharacter.Controls.Add(this.textBoxFilmCharacter);
            this.groupBoxCharacter.Controls.Add(this.label1);
            this.groupBoxCharacter.Controls.Add(this.textBoxNameCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelNameCharacter);
            this.groupBoxCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCharacter.Location = new System.Drawing.Point(764, 96);
            this.groupBoxCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCharacter.Name = "groupBoxCharacter";
            this.groupBoxCharacter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCharacter.Size = new System.Drawing.Size(366, 490);
            this.groupBoxCharacter.TabIndex = 3;
            this.groupBoxCharacter.TabStop = false;
            this.groupBoxCharacter.Text = "Character";
            // 
            // textBoxDescriptionCharacterCat
            // 
            this.textBoxDescriptionCharacterCat.Enabled = false;
            this.textBoxDescriptionCharacterCat.Location = new System.Drawing.Point(114, 256);
            this.textBoxDescriptionCharacterCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescriptionCharacterCat.Multiline = true;
            this.textBoxDescriptionCharacterCat.Name = "textBoxDescriptionCharacterCat";
            this.textBoxDescriptionCharacterCat.Size = new System.Drawing.Size(243, 166);
            this.textBoxDescriptionCharacterCat.TabIndex = 22;
            this.textBoxDescriptionCharacterCat.Visible = false;
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficulty.Enabled = false;
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "E",
            "M",
            "H",
            "I"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(114, 151);
            this.comboBoxDifficulty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(242, 24);
            this.comboBoxDifficulty.TabIndex = 20;
            // 
            // textBoxDescriptionCharacterEng
            // 
            this.textBoxDescriptionCharacterEng.Enabled = false;
            this.textBoxDescriptionCharacterEng.Location = new System.Drawing.Point(114, 256);
            this.textBoxDescriptionCharacterEng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescriptionCharacterEng.Multiline = true;
            this.textBoxDescriptionCharacterEng.Name = "textBoxDescriptionCharacterEng";
            this.textBoxDescriptionCharacterEng.Size = new System.Drawing.Size(242, 160);
            this.textBoxDescriptionCharacterEng.TabIndex = 18;
            this.textBoxDescriptionCharacterEng.Visible = false;
            // 
            // numericUpDownCorrectNum
            // 
            this.numericUpDownCorrectNum.Enabled = false;
            this.numericUpDownCorrectNum.Location = new System.Drawing.Point(114, 186);
            this.numericUpDownCorrectNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownCorrectNum.Name = "numericUpDownCorrectNum";
            this.numericUpDownCorrectNum.Size = new System.Drawing.Size(242, 23);
            this.numericUpDownCorrectNum.TabIndex = 10;
            // 
            // comboBoxCategoryCharacter
            // 
            this.comboBoxCategoryCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryCharacter.Enabled = false;
            this.comboBoxCategoryCharacter.FormattingEnabled = true;
            this.comboBoxCategoryCharacter.Items.AddRange(new object[] {
            "drama",
            "science fiction",
            "action",
            "comedy",
            "animation",
            "horror"});
            this.comboBoxCategoryCharacter.Location = new System.Drawing.Point(113, 116);
            this.comboBoxCategoryCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategoryCharacter.Name = "comboBoxCategoryCharacter";
            this.comboBoxCategoryCharacter.Size = new System.Drawing.Size(242, 24);
            this.comboBoxCategoryCharacter.TabIndex = 17;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonCancel.Location = new System.Drawing.Point(158, 436);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 36);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.Location = new System.Drawing.Point(259, 436);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(97, 36);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDescriptionCharacterEsp
            // 
            this.textBoxDescriptionCharacterEsp.Enabled = false;
            this.textBoxDescriptionCharacterEsp.Location = new System.Drawing.Point(114, 256);
            this.textBoxDescriptionCharacterEsp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescriptionCharacterEsp.Multiline = true;
            this.textBoxDescriptionCharacterEsp.Name = "textBoxDescriptionCharacterEsp";
            this.textBoxDescriptionCharacterEsp.Size = new System.Drawing.Size(242, 159);
            this.textBoxDescriptionCharacterEsp.TabIndex = 13;
            // 
            // labelDescriptionCharacter
            // 
            this.labelDescriptionCharacter.AutoSize = true;
            this.labelDescriptionCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionCharacter.Location = new System.Drawing.Point(11, 257);
            this.labelDescriptionCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescriptionCharacter.Name = "labelDescriptionCharacter";
            this.labelDescriptionCharacter.Size = new System.Drawing.Size(79, 17);
            this.labelDescriptionCharacter.TabIndex = 14;
            this.labelDescriptionCharacter.Text = "Description";
            // 
            // textBoxImgUrlCharacter
            // 
            this.textBoxImgUrlCharacter.Enabled = false;
            this.textBoxImgUrlCharacter.Location = new System.Drawing.Point(113, 221);
            this.textBoxImgUrlCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxImgUrlCharacter.Name = "textBoxImgUrlCharacter";
            this.textBoxImgUrlCharacter.Size = new System.Drawing.Size(243, 23);
            this.textBoxImgUrlCharacter.TabIndex = 11;
            // 
            // labelImgUrl
            // 
            this.labelImgUrl.AutoSize = true;
            this.labelImgUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImgUrl.Location = new System.Drawing.Point(11, 221);
            this.labelImgUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImgUrl.Name = "labelImgUrl";
            this.labelImgUrl.Size = new System.Drawing.Size(66, 17);
            this.labelImgUrl.TabIndex = 12;
            this.labelImgUrl.Text = "Image url";
            // 
            // labelNumCorrecto
            // 
            this.labelNumCorrecto.AutoSize = true;
            this.labelNumCorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCorrecto.Location = new System.Drawing.Point(11, 187);
            this.labelNumCorrecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumCorrecto.Name = "labelNumCorrecto";
            this.labelNumCorrecto.Size = new System.Drawing.Size(106, 17);
            this.labelNumCorrecto.TabIndex = 10;
            this.labelNumCorrecto.Text = "Correct number";
            // 
            // labelDifficultyCharacter
            // 
            this.labelDifficultyCharacter.AutoSize = true;
            this.labelDifficultyCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficultyCharacter.Location = new System.Drawing.Point(11, 152);
            this.labelDifficultyCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDifficultyCharacter.Name = "labelDifficultyCharacter";
            this.labelDifficultyCharacter.Size = new System.Drawing.Size(61, 17);
            this.labelDifficultyCharacter.TabIndex = 8;
            this.labelDifficultyCharacter.Text = "Difficulty";
            // 
            // labelCategoryCharacter
            // 
            this.labelCategoryCharacter.AutoSize = true;
            this.labelCategoryCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryCharacter.Location = new System.Drawing.Point(13, 118);
            this.labelCategoryCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoryCharacter.Name = "labelCategoryCharacter";
            this.labelCategoryCharacter.Size = new System.Drawing.Size(65, 17);
            this.labelCategoryCharacter.TabIndex = 6;
            this.labelCategoryCharacter.Text = "Category";
            // 
            // labelFilmCharacter
            // 
            this.labelFilmCharacter.AutoSize = true;
            this.labelFilmCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilmCharacter.Location = new System.Drawing.Point(13, 83);
            this.labelFilmCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilmCharacter.Name = "labelFilmCharacter";
            this.labelFilmCharacter.Size = new System.Drawing.Size(33, 17);
            this.labelFilmCharacter.TabIndex = 4;
            this.labelFilmCharacter.Text = "Film";
            // 
            // textBoxFilmCharacter
            // 
            this.textBoxFilmCharacter.Enabled = false;
            this.textBoxFilmCharacter.Location = new System.Drawing.Point(113, 81);
            this.textBoxFilmCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilmCharacter.Name = "textBoxFilmCharacter";
            this.textBoxFilmCharacter.Size = new System.Drawing.Size(245, 23);
            this.textBoxFilmCharacter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // textBoxNameCharacter
            // 
            this.textBoxNameCharacter.Enabled = false;
            this.textBoxNameCharacter.Location = new System.Drawing.Point(113, 46);
            this.textBoxNameCharacter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNameCharacter.Name = "textBoxNameCharacter";
            this.textBoxNameCharacter.Size = new System.Drawing.Size(245, 23);
            this.textBoxNameCharacter.TabIndex = 1;
            // 
            // labelNameCharacter
            // 
            this.labelNameCharacter.AutoSize = true;
            this.labelNameCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameCharacter.Location = new System.Drawing.Point(11, 48);
            this.labelNameCharacter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameCharacter.Name = "labelNameCharacter";
            this.labelNameCharacter.Size = new System.Drawing.Size(45, 17);
            this.labelNameCharacter.TabIndex = 0;
            this.labelNameCharacter.Text = "Name";
            // 
            // buttonCatalan
            // 
            this.buttonCatalan.BackgroundImage = global::projecte_eywa.Properties.Resources.cataluña_bandera;
            this.buttonCatalan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCatalan.FlatAppearance.BorderSize = 0;
            this.buttonCatalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatalan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonCatalan.Location = new System.Drawing.Point(1001, 38);
            this.buttonCatalan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCatalan.Name = "buttonCatalan";
            this.buttonCatalan.Size = new System.Drawing.Size(37, 36);
            this.buttonCatalan.TabIndex = 4;
            this.buttonCatalan.UseVisualStyleBackColor = true;
            this.buttonCatalan.Click += new System.EventHandler(this.buttonCatalan_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackgroundImage = global::projecte_eywa.Properties.Resources.bandera_england__1_;
            this.buttonEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEnglish.FlatAppearance.BorderSize = 0;
            this.buttonEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnglish.Location = new System.Drawing.Point(1091, 38);
            this.buttonEnglish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(37, 36);
            this.buttonEnglish.TabIndex = 5;
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // buttonSpanish
            // 
            this.buttonSpanish.BackgroundImage = global::projecte_eywa.Properties.Resources.españa_boton;
            this.buttonSpanish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpanish.FlatAppearance.BorderSize = 0;
            this.buttonSpanish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpanish.Location = new System.Drawing.Point(1047, 38);
            this.buttonSpanish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpanish.Name = "buttonSpanish";
            this.buttonSpanish.Size = new System.Drawing.Size(37, 36);
            this.buttonSpanish.TabIndex = 6;
            this.buttonSpanish.UseVisualStyleBackColor = true;
            this.buttonSpanish.Click += new System.EventHandler(this.buttonSpanish_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.White;
            this.buttonModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonModify.Location = new System.Drawing.Point(126, 600);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(97, 36);
            this.buttonModify.TabIndex = 9;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(227, 600);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 36);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonAdd.Location = new System.Drawing.Point(25, 600);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 36);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // filmCharacter
            // 
            this.filmCharacter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filmCharacter.DataPropertyName = "film";
            this.filmCharacter.HeaderText = "Film";
            this.filmCharacter.MinimumWidth = 8;
            this.filmCharacter.Name = "filmCharacter";
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
            // categoryCharacter
            // 
            this.categoryCharacter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryCharacter.DataPropertyName = "category";
            this.categoryCharacter.HeaderText = "Category";
            this.categoryCharacter.MinimumWidth = 8;
            this.categoryCharacter.Name = "categoryCharacter";
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
            // urlImageCharacter
            // 
            this.urlImageCharacter.DataPropertyName = "urlImageCharacter";
            this.urlImageCharacter.HeaderText = "Url image";
            this.urlImageCharacter.MinimumWidth = 8;
            this.urlImageCharacter.Name = "urlImageCharacter";
            this.urlImageCharacter.Visible = false;
            this.urlImageCharacter.Width = 150;
            // 
            // correctNumCharacter
            // 
            this.correctNumCharacter.DataPropertyName = "corr";
            this.correctNumCharacter.HeaderText = "Correct number";
            this.correctNumCharacter.MinimumWidth = 8;
            this.correctNumCharacter.Name = "correctNumCharacter";
            this.correctNumCharacter.Visible = false;
            this.correctNumCharacter.Width = 150;
            // 
            // nameCharacter
            // 
            this.nameCharacter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCharacter.DataPropertyName = "name";
            this.nameCharacter.HeaderText = "Name";
            this.nameCharacter.MinimumWidth = 8;
            this.nameCharacter.Name = "nameCharacter";
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
            this.dataGridViewCharacters.Location = new System.Drawing.Point(25, 96);
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
            this.dataGridViewCharacters.Size = new System.Drawing.Size(735, 490);
            this.dataGridViewCharacters.TabIndex = 1;
            this.dataGridViewCharacters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCharacters_CellClick);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Drama",
            "Ciència ficció",
            "Acció",
            "Comedia",
            "Animació",
            "Terror"});
            this.comboBoxFilter.Location = new System.Drawing.Point(25, 49);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(515, 21);
            this.comboBoxFilter.TabIndex = 18;
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(71)))));
            this.buttonApplyFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.buttonApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyFilters.ForeColor = System.Drawing.Color.Black;
            this.buttonApplyFilters.Location = new System.Drawing.Point(560, 38);
            this.buttonApplyFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(97, 36);
            this.buttonApplyFilters.TabIndex = 20;
            this.buttonApplyFilters.Text = "Apply filter";
            this.buttonApplyFilters.UseVisualStyleBackColor = false;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.BackColor = System.Drawing.Color.White;
            this.buttonClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFilters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClearFilters.Location = new System.Drawing.Point(661, 38);
            this.buttonClearFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(97, 36);
            this.buttonClearFilters.TabIndex = 19;
            this.buttonClearFilters.Text = "Clear filter";
            this.buttonClearFilters.UseVisualStyleBackColor = false;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1141, 666);
            this.Controls.Add(this.buttonApplyFilters);
            this.Controls.Add(this.buttonClearFilters);
            this.Controls.Add(this.comboBoxFilter);
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
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCharacter.ResumeLayout(false);
            this.groupBoxCharacter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrectNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCharactersBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCharacter;
        private System.Windows.Forms.Label labelNumCorrecto;
        private System.Windows.Forms.Label labelDifficultyCharacter;
        private System.Windows.Forms.Label labelCategoryCharacter;
        private System.Windows.Forms.Label labelFilmCharacter;
        private System.Windows.Forms.TextBox textBoxFilmCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameCharacter;
        private System.Windows.Forms.Label labelNameCharacter;
        private System.Windows.Forms.TextBox textBoxDescriptionCharacterEsp;
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
        private System.Windows.Forms.ComboBox comboBoxCategoryCharacter;
        private System.Windows.Forms.NumericUpDown numericUpDownCorrectNum;
        private System.Windows.Forms.TextBox textBoxDescriptionCharacterEng;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlImageCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctNumCharacter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCharacter;
        private System.Windows.Forms.DataGridView dataGridViewCharacters;
        private System.Windows.Forms.TextBox textBoxDescriptionCharacterCat;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.Button buttonClearFilters;
    }
}

