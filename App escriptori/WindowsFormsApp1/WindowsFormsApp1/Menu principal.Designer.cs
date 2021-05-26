namespace WindowsFormsApp1
{
    partial class Form1
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
            this.escolliridioma = new System.Windows.Forms.Label();
            this.groupboxedit = new System.Windows.Forms.GroupBox();
            this.groupBoxpreg = new System.Windows.Forms.GroupBox();
            this.dataGridViewpreguntes = new System.Windows.Forms.DataGridView();
            this.Nivell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoneliminarpreg = new System.Windows.Forms.Button();
            this.buttonmodificarpreg = new System.Windows.Forms.Button();
            this.buttonafegirpreg = new System.Windows.Forms.Button();
            this.Preguntes = new System.Windows.Forms.Label();
            this.groupBoxpers = new System.Windows.Forms.GroupBox();
            this.dataGridViewpersonatges = new System.Windows.Forms.DataGridView();
            this.Grup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoneliminarper = new System.Windows.Forms.Button();
            this.buttonmodificarper = new System.Windows.Forms.Button();
            this.buttonafegirper = new System.Windows.Forms.Button();
            this.Personatges = new System.Windows.Forms.Label();
            this.buttoncatala = new System.Windows.Forms.Button();
            this.buttonespaña = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.groupboxedit.SuspendLayout();
            this.groupBoxpreg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpreguntes)).BeginInit();
            this.groupBoxpers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersonatges)).BeginInit();
            this.SuspendLayout();
            // 
            // escolliridioma
            // 
            this.escolliridioma.AutoSize = true;
            this.escolliridioma.BackColor = System.Drawing.Color.Transparent;
            this.escolliridioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolliridioma.ForeColor = System.Drawing.Color.White;
            this.escolliridioma.Location = new System.Drawing.Point(287, 41);
            this.escolliridioma.Name = "escolliridioma";
            this.escolliridioma.Size = new System.Drawing.Size(71, 24);
            this.escolliridioma.TabIndex = 0;
            this.escolliridioma.Text = "Idioma:";
            // 
            // groupboxedit
            // 
            this.groupboxedit.BackColor = System.Drawing.Color.Transparent;
            this.groupboxedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupboxedit.Controls.Add(this.groupBoxpreg);
            this.groupboxedit.Controls.Add(this.groupBoxpers);
            this.groupboxedit.Location = new System.Drawing.Point(12, 112);
            this.groupboxedit.Name = "groupboxedit";
            this.groupboxedit.Size = new System.Drawing.Size(776, 326);
            this.groupboxedit.TabIndex = 2;
            this.groupboxedit.TabStop = false;
            // 
            // groupBoxpreg
            // 
            this.groupBoxpreg.Controls.Add(this.dataGridViewpreguntes);
            this.groupBoxpreg.Controls.Add(this.buttoneliminarpreg);
            this.groupBoxpreg.Controls.Add(this.buttonmodificarpreg);
            this.groupBoxpreg.Controls.Add(this.buttonafegirpreg);
            this.groupBoxpreg.Controls.Add(this.Preguntes);
            this.groupBoxpreg.Location = new System.Drawing.Point(386, 19);
            this.groupBoxpreg.Name = "groupBoxpreg";
            this.groupBoxpreg.Size = new System.Drawing.Size(384, 301);
            this.groupBoxpreg.TabIndex = 1;
            this.groupBoxpreg.TabStop = false;
            // 
            // dataGridViewpreguntes
            // 
            this.dataGridViewpreguntes.AllowUserToDeleteRows = false;
            this.dataGridViewpreguntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpreguntes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nivell,
            this.Pregunta,
            this.Opcio,
            this.Opcions});
            this.dataGridViewpreguntes.Location = new System.Drawing.Point(70, 109);
            this.dataGridViewpreguntes.Name = "dataGridViewpreguntes";
            this.dataGridViewpreguntes.ReadOnly = true;
            this.dataGridViewpreguntes.Size = new System.Drawing.Size(237, 186);
            this.dataGridViewpreguntes.TabIndex = 6;
            // 
            // Nivell
            // 
            this.Nivell.DataPropertyName = "nivell";
            this.Nivell.HeaderText = "Nivell";
            this.Nivell.Name = "Nivell";
            this.Nivell.ReadOnly = true;
            // 
            // Pregunta
            // 
            this.Pregunta.DataPropertyName = "pregunta";
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.ReadOnly = true;
            // 
            // Opcio
            // 
            this.Opcio.DataPropertyName = "opcio";
            this.Opcio.HeaderText = "Opcions";
            this.Opcio.Name = "Opcio";
            this.Opcio.ReadOnly = true;
            // 
            // Opcions
            // 
            this.Opcions.DataPropertyName = "resposta";
            this.Opcions.HeaderText = "Resposta";
            this.Opcions.Name = "Opcions";
            this.Opcions.ReadOnly = true;
            // 
            // buttoneliminarpreg
            // 
            this.buttoneliminarpreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoneliminarpreg.Location = new System.Drawing.Point(232, 77);
            this.buttoneliminarpreg.Name = "buttoneliminarpreg";
            this.buttoneliminarpreg.Size = new System.Drawing.Size(75, 23);
            this.buttoneliminarpreg.TabIndex = 6;
            this.buttoneliminarpreg.Text = "Eliminar";
            this.buttoneliminarpreg.UseVisualStyleBackColor = true;
            this.buttoneliminarpreg.Click += new System.EventHandler(this.buttoneliminarpreg_Click);
            // 
            // buttonmodificarpreg
            // 
            this.buttonmodificarpreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmodificarpreg.Location = new System.Drawing.Point(151, 77);
            this.buttonmodificarpreg.Name = "buttonmodificarpreg";
            this.buttonmodificarpreg.Size = new System.Drawing.Size(75, 23);
            this.buttonmodificarpreg.TabIndex = 5;
            this.buttonmodificarpreg.Text = "Modificar";
            this.buttonmodificarpreg.UseVisualStyleBackColor = true;
            this.buttonmodificarpreg.Click += new System.EventHandler(this.buttonmodificarpreg_Click);
            // 
            // buttonafegirpreg
            // 
            this.buttonafegirpreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonafegirpreg.Location = new System.Drawing.Point(70, 77);
            this.buttonafegirpreg.Name = "buttonafegirpreg";
            this.buttonafegirpreg.Size = new System.Drawing.Size(75, 23);
            this.buttonafegirpreg.TabIndex = 4;
            this.buttonafegirpreg.Text = "Afegir";
            this.buttonafegirpreg.UseVisualStyleBackColor = true;
            this.buttonafegirpreg.Click += new System.EventHandler(this.buttonafegirpreg_Click);
            // 
            // Preguntes
            // 
            this.Preguntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preguntes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Preguntes.Location = new System.Drawing.Point(90, 16);
            this.Preguntes.Name = "Preguntes";
            this.Preguntes.Size = new System.Drawing.Size(202, 46);
            this.Preguntes.TabIndex = 0;
            this.Preguntes.Text = "Preguntes";
            this.Preguntes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxpers
            // 
            this.groupBoxpers.Controls.Add(this.dataGridViewpersonatges);
            this.groupBoxpers.Controls.Add(this.buttoneliminarper);
            this.groupBoxpers.Controls.Add(this.buttonmodificarper);
            this.groupBoxpers.Controls.Add(this.buttonafegirper);
            this.groupBoxpers.Controls.Add(this.Personatges);
            this.groupBoxpers.Location = new System.Drawing.Point(7, 19);
            this.groupBoxpers.Name = "groupBoxpers";
            this.groupBoxpers.Size = new System.Drawing.Size(373, 301);
            this.groupBoxpers.TabIndex = 0;
            this.groupBoxpers.TabStop = false;
            // 
            // dataGridViewpersonatges
            // 
            this.dataGridViewpersonatges.AllowUserToDeleteRows = false;
            this.dataGridViewpersonatges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpersonatges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grup,
            this.Punt,
            this.punts});
            this.dataGridViewpersonatges.Location = new System.Drawing.Point(51, 109);
            this.dataGridViewpersonatges.Name = "dataGridViewpersonatges";
            this.dataGridViewpersonatges.ReadOnly = true;
            this.dataGridViewpersonatges.Size = new System.Drawing.Size(237, 186);
            this.dataGridViewpersonatges.TabIndex = 7;
            this.dataGridViewpersonatges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpersonatges_CellContentClick);
            // 
            // Grup
            // 
            this.Grup.DataPropertyName = "nom";
            this.Grup.HeaderText = "Nom";
            this.Grup.Name = "Grup";
            this.Grup.ReadOnly = true;
            // 
            // Punt
            // 
            this.Punt.DataPropertyName = "puntmin";
            this.Punt.HeaderText = "Puntuacio minima";
            this.Punt.Name = "Punt";
            this.Punt.ReadOnly = true;
            // 
            // punts
            // 
            this.punts.DataPropertyName = "puntmax";
            this.punts.HeaderText = "Puntuacio maxima";
            this.punts.Name = "punts";
            this.punts.ReadOnly = true;
            // 
            // buttoneliminarper
            // 
            this.buttoneliminarper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoneliminarper.Location = new System.Drawing.Point(213, 77);
            this.buttoneliminarper.Name = "buttoneliminarper";
            this.buttoneliminarper.Size = new System.Drawing.Size(75, 23);
            this.buttoneliminarper.TabIndex = 3;
            this.buttoneliminarper.Text = "Eliminar";
            this.buttoneliminarper.UseVisualStyleBackColor = true;
            this.buttoneliminarper.Click += new System.EventHandler(this.buttoneliminarper_Click);
            // 
            // buttonmodificarper
            // 
            this.buttonmodificarper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmodificarper.Location = new System.Drawing.Point(132, 77);
            this.buttonmodificarper.Name = "buttonmodificarper";
            this.buttonmodificarper.Size = new System.Drawing.Size(75, 23);
            this.buttonmodificarper.TabIndex = 2;
            this.buttonmodificarper.Text = "Modificar";
            this.buttonmodificarper.UseVisualStyleBackColor = true;
            this.buttonmodificarper.Click += new System.EventHandler(this.buttonmodificarper_Click);
            // 
            // buttonafegirper
            // 
            this.buttonafegirper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonafegirper.Location = new System.Drawing.Point(51, 77);
            this.buttonafegirper.Name = "buttonafegirper";
            this.buttonafegirper.Size = new System.Drawing.Size(75, 23);
            this.buttonafegirper.TabIndex = 1;
            this.buttonafegirper.Text = "Afegir";
            this.buttonafegirper.UseVisualStyleBackColor = true;
            this.buttonafegirper.Click += new System.EventHandler(this.buttonafegirper_Click);
            // 
            // Personatges
            // 
            this.Personatges.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personatges.ForeColor = System.Drawing.Color.White;
            this.Personatges.Location = new System.Drawing.Point(81, 16);
            this.Personatges.Name = "Personatges";
            this.Personatges.Size = new System.Drawing.Size(179, 46);
            this.Personatges.TabIndex = 0;
            this.Personatges.Text = "Personatges";
            this.Personatges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttoncatala
            // 
            this.buttoncatala.BackColor = System.Drawing.Color.Transparent;
            this.buttoncatala.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1200px_Flag_of_Catalonia_svg;
            this.buttoncatala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncatala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncatala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncatala.ForeColor = System.Drawing.Color.Transparent;
            this.buttoncatala.Location = new System.Drawing.Point(365, 36);
            this.buttoncatala.Name = "buttoncatala";
            this.buttoncatala.Size = new System.Drawing.Size(53, 30);
            this.buttoncatala.TabIndex = 3;
            this.buttoncatala.UseVisualStyleBackColor = false;
            this.buttoncatala.Click += new System.EventHandler(this.buttoncatala_Click);
            // 
            // buttonespaña
            // 
            this.buttonespaña.BackColor = System.Drawing.Color.Transparent;
            this.buttonespaña.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1_espana_400px;
            this.buttonespaña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonespaña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonespaña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonespaña.ForeColor = System.Drawing.Color.Transparent;
            this.buttonespaña.Location = new System.Drawing.Point(434, 36);
            this.buttonespaña.Name = "buttonespaña";
            this.buttonespaña.Size = new System.Drawing.Size(53, 30);
            this.buttonespaña.TabIndex = 4;
            this.buttonespaña.UseVisualStyleBackColor = false;
            this.buttonespaña.Click += new System.EventHandler(this.buttonespaña_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnglish.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Cf2W28RUMAIIjiz;
            this.buttonEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnglish.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEnglish.Location = new System.Drawing.Point(506, 35);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(53, 30);
            this.buttonEnglish.TabIndex = 5;
            this.buttonEnglish.UseVisualStyleBackColor = false;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.imagenfondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.buttonespaña);
            this.Controls.Add(this.buttoncatala);
            this.Controls.Add(this.groupboxedit);
            this.Controls.Add(this.escolliridioma);
            this.Name = "Form1";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxedit.ResumeLayout(false);
            this.groupBoxpreg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpreguntes)).EndInit();
            this.groupBoxpers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersonatges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label escolliridioma;
        private System.Windows.Forms.GroupBox groupboxedit;
        private System.Windows.Forms.GroupBox groupBoxpreg;
        private System.Windows.Forms.Label Preguntes;
        private System.Windows.Forms.GroupBox groupBoxpers;
        private System.Windows.Forms.Label Personatges;
        private System.Windows.Forms.Button buttoneliminarpreg;
        private System.Windows.Forms.Button buttonmodificarpreg;
        private System.Windows.Forms.Button buttonafegirpreg;
        private System.Windows.Forms.Button buttoneliminarper;
        private System.Windows.Forms.Button buttonmodificarper;
        private System.Windows.Forms.Button buttonafegirper;
        private System.Windows.Forms.Button buttoncatala;
        private System.Windows.Forms.Button buttonespaña;
        private System.Windows.Forms.DataGridView dataGridViewpreguntes;
        private System.Windows.Forms.DataGridView dataGridViewpersonatges;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punt;
        private System.Windows.Forms.DataGridViewTextBoxColumn punts;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcions;
    }
}

