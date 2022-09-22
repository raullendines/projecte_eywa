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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCharacters = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCharacter = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDecriptionCharacter = new System.Windows.Forms.TextBox();
            this.labelDescriptionCharacter = new System.Windows.Forms.Label();
            this.textBoxImgUrlCharacter = new System.Windows.Forms.TextBox();
            this.labelImgUrl = new System.Windows.Forms.Label();
            this.textBoxDifficultyCharacter = new System.Windows.Forms.TextBox();
            this.textBoxCategroyCharacter = new System.Windows.Forms.TextBox();
            this.textBoxCorrectAnsCharacter = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacters)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCharacters
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCharacters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCharacters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnFilm});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCharacters.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCharacters.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewCharacters.Name = "dataGridViewCharacters";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCharacters.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCharacters.RowHeadersWidth = 62;
            this.dataGridViewCharacters.RowTemplate.Height = 28;
            this.dataGridViewCharacters.Size = new System.Drawing.Size(669, 458);
            this.dataGridViewCharacters.TabIndex = 1;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // ColumnFilm
            // 
            this.ColumnFilm.HeaderText = "Film";
            this.ColumnFilm.MinimumWidth = 8;
            this.ColumnFilm.Name = "ColumnFilm";
            this.ColumnFilm.Width = 300;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.questionsToolStripMenuItem.Text = "Questions";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // groupBoxCharacter
            // 
            this.groupBoxCharacter.Controls.Add(this.buttonCancel);
            this.groupBoxCharacter.Controls.Add(this.buttonSave);
            this.groupBoxCharacter.Controls.Add(this.textBoxDecriptionCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelDescriptionCharacter);
            this.groupBoxCharacter.Controls.Add(this.textBoxImgUrlCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelImgUrl);
            this.groupBoxCharacter.Controls.Add(this.textBoxDifficultyCharacter);
            this.groupBoxCharacter.Controls.Add(this.textBoxCategroyCharacter);
            this.groupBoxCharacter.Controls.Add(this.textBoxCorrectAnsCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelNumCorrecto);
            this.groupBoxCharacter.Controls.Add(this.labelDifficultyCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelCategoryCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelFilmCharacter);
            this.groupBoxCharacter.Controls.Add(this.textBoxFilmCharacter);
            this.groupBoxCharacter.Controls.Add(this.label1);
            this.groupBoxCharacter.Controls.Add(this.textBoxNameCharacter);
            this.groupBoxCharacter.Controls.Add(this.labelNameCharacter);
            this.groupBoxCharacter.Location = new System.Drawing.Point(699, 89);
            this.groupBoxCharacter.Name = "groupBoxCharacter";
            this.groupBoxCharacter.Size = new System.Drawing.Size(484, 549);
            this.groupBoxCharacter.TabIndex = 3;
            this.groupBoxCharacter.TabStop = false;
            this.groupBoxCharacter.Text = "Character";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(304, 442);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 45);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(393, 442);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 45);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            // 
            // textBoxDecriptionCharacter
            // 
            this.textBoxDecriptionCharacter.Location = new System.Drawing.Point(154, 278);
            this.textBoxDecriptionCharacter.Multiline = true;
            this.textBoxDecriptionCharacter.Name = "textBoxDecriptionCharacter";
            this.textBoxDecriptionCharacter.Size = new System.Drawing.Size(322, 135);
            this.textBoxDecriptionCharacter.TabIndex = 13;
            // 
            // labelDescriptionCharacter
            // 
            this.labelDescriptionCharacter.AutoSize = true;
            this.labelDescriptionCharacter.Location = new System.Drawing.Point(28, 282);
            this.labelDescriptionCharacter.Name = "labelDescriptionCharacter";
            this.labelDescriptionCharacter.Size = new System.Drawing.Size(89, 20);
            this.labelDescriptionCharacter.TabIndex = 14;
            this.labelDescriptionCharacter.Text = "Description";
            // 
            // textBoxImgUrlCharacter
            // 
            this.textBoxImgUrlCharacter.Location = new System.Drawing.Point(154, 235);
            this.textBoxImgUrlCharacter.Name = "textBoxImgUrlCharacter";
            this.textBoxImgUrlCharacter.Size = new System.Drawing.Size(322, 26);
            this.textBoxImgUrlCharacter.TabIndex = 11;
            // 
            // labelImgUrl
            // 
            this.labelImgUrl.AutoSize = true;
            this.labelImgUrl.Location = new System.Drawing.Point(28, 238);
            this.labelImgUrl.Name = "labelImgUrl";
            this.labelImgUrl.Size = new System.Drawing.Size(75, 20);
            this.labelImgUrl.TabIndex = 12;
            this.labelImgUrl.Text = "Image url";
            // 
            // textBoxDifficultyCharacter
            // 
            this.textBoxDifficultyCharacter.Location = new System.Drawing.Point(154, 162);
            this.textBoxDifficultyCharacter.Name = "textBoxDifficultyCharacter";
            this.textBoxDifficultyCharacter.Size = new System.Drawing.Size(322, 26);
            this.textBoxDifficultyCharacter.TabIndex = 7;
            // 
            // textBoxCategroyCharacter
            // 
            this.textBoxCategroyCharacter.Location = new System.Drawing.Point(154, 128);
            this.textBoxCategroyCharacter.Name = "textBoxCategroyCharacter";
            this.textBoxCategroyCharacter.Size = new System.Drawing.Size(322, 26);
            this.textBoxCategroyCharacter.TabIndex = 5;
            // 
            // textBoxCorrectAnsCharacter
            // 
            this.textBoxCorrectAnsCharacter.Location = new System.Drawing.Point(154, 198);
            this.textBoxCorrectAnsCharacter.Name = "textBoxCorrectAnsCharacter";
            this.textBoxCorrectAnsCharacter.Size = new System.Drawing.Size(322, 26);
            this.textBoxCorrectAnsCharacter.TabIndex = 9;
            // 
            // labelNumCorrecto
            // 
            this.labelNumCorrecto.AutoSize = true;
            this.labelNumCorrecto.Location = new System.Drawing.Point(28, 202);
            this.labelNumCorrecto.Name = "labelNumCorrecto";
            this.labelNumCorrecto.Size = new System.Drawing.Size(119, 20);
            this.labelNumCorrecto.TabIndex = 10;
            this.labelNumCorrecto.Text = "Correct number";
            // 
            // labelDifficultyCharacter
            // 
            this.labelDifficultyCharacter.AutoSize = true;
            this.labelDifficultyCharacter.Location = new System.Drawing.Point(28, 165);
            this.labelDifficultyCharacter.Name = "labelDifficultyCharacter";
            this.labelDifficultyCharacter.Size = new System.Drawing.Size(69, 20);
            this.labelDifficultyCharacter.TabIndex = 8;
            this.labelDifficultyCharacter.Text = "Difficulty";
            // 
            // labelCategoryCharacter
            // 
            this.labelCategoryCharacter.AutoSize = true;
            this.labelCategoryCharacter.Location = new System.Drawing.Point(28, 128);
            this.labelCategoryCharacter.Name = "labelCategoryCharacter";
            this.labelCategoryCharacter.Size = new System.Drawing.Size(73, 20);
            this.labelCategoryCharacter.TabIndex = 6;
            this.labelCategoryCharacter.Text = "Category";
            // 
            // labelFilmCharacter
            // 
            this.labelFilmCharacter.AutoSize = true;
            this.labelFilmCharacter.Location = new System.Drawing.Point(28, 92);
            this.labelFilmCharacter.Name = "labelFilmCharacter";
            this.labelFilmCharacter.Size = new System.Drawing.Size(38, 20);
            this.labelFilmCharacter.TabIndex = 4;
            this.labelFilmCharacter.Text = "Film";
            // 
            // textBoxFilmCharacter
            // 
            this.textBoxFilmCharacter.Location = new System.Drawing.Point(154, 92);
            this.textBoxFilmCharacter.Name = "textBoxFilmCharacter";
            this.textBoxFilmCharacter.Size = new System.Drawing.Size(322, 26);
            this.textBoxFilmCharacter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // textBoxNameCharacter
            // 
            this.textBoxNameCharacter.Location = new System.Drawing.Point(154, 57);
            this.textBoxNameCharacter.Name = "textBoxNameCharacter";
            this.textBoxNameCharacter.Size = new System.Drawing.Size(322, 26);
            this.textBoxNameCharacter.TabIndex = 1;
            // 
            // labelNameCharacter
            // 
            this.labelNameCharacter.AutoSize = true;
            this.labelNameCharacter.Location = new System.Drawing.Point(28, 60);
            this.labelNameCharacter.Name = "labelNameCharacter";
            this.labelNameCharacter.Size = new System.Drawing.Size(51, 20);
            this.labelNameCharacter.TabIndex = 0;
            this.labelNameCharacter.Text = "Name";
            // 
            // buttonCatalan
            // 
            this.buttonCatalan.Location = new System.Drawing.Point(922, 42);
            this.buttonCatalan.Name = "buttonCatalan";
            this.buttonCatalan.Size = new System.Drawing.Size(82, 45);
            this.buttonCatalan.TabIndex = 4;
            this.buttonCatalan.Text = "Catalan";
            this.buttonCatalan.UseVisualStyleBackColor = true;
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Location = new System.Drawing.Point(1100, 42);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(82, 45);
            this.buttonEnglish.TabIndex = 5;
            this.buttonEnglish.Text = "English";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            // 
            // buttonSpanish
            // 
            this.buttonSpanish.Location = new System.Drawing.Point(1011, 42);
            this.buttonSpanish.Name = "buttonSpanish";
            this.buttonSpanish.Size = new System.Drawing.Size(82, 45);
            this.buttonSpanish.TabIndex = 6;
            this.buttonSpanish.Text = "Spanish";
            this.buttonSpanish.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(100, 580);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(82, 45);
            this.buttonModify.TabIndex = 9;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(189, 580);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 45);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 580);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 45);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSpanish);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.buttonCatalan);
            this.Controls.Add(this.groupBoxCharacter);
            this.Controls.Add(this.dataGridViewCharacters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCharacters";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacters)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCharacter.ResumeLayout(false);
            this.groupBoxCharacter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCharacters;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCharacter;
        private System.Windows.Forms.Label labelNumCorrecto;
        private System.Windows.Forms.TextBox textBoxCorrectAnsCharacter;
        private System.Windows.Forms.Label labelDifficultyCharacter;
        private System.Windows.Forms.TextBox textBoxDifficultyCharacter;
        private System.Windows.Forms.Label labelCategoryCharacter;
        private System.Windows.Forms.TextBox textBoxCategroyCharacter;
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
    }
}

