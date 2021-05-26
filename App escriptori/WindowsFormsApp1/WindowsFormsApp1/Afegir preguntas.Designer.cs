namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxpreg = new System.Windows.Forms.TextBox();
            this.buttonafegiropcio = new System.Windows.Forms.Button();
            this.buttoneliminaropcio = new System.Windows.Forms.Button();
            this.textBoxopcio = new System.Windows.Forms.TextBox();
            this.buttonguardar3 = new System.Windows.Forms.Button();
            this.buttonsortir3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelidioma = new System.Windows.Forms.Label();
            this.groupBoxidioma = new System.Windows.Forms.GroupBox();
            this.radioButtonEng = new System.Windows.Forms.RadioButton();
            this.radioButtonCas = new System.Windows.Forms.RadioButton();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonnivell3 = new System.Windows.Forms.RadioButton();
            this.radioButtonnivell2 = new System.Windows.Forms.RadioButton();
            this.radioButtonnivell1 = new System.Windows.Forms.RadioButton();
            this.labelnivell = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxresposta = new System.Windows.Forms.TextBox();
            this.listBoxOpcions = new System.Windows.Forms.ListBox();
            this.groupBoxidioma.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opcions";
            // 
            // textBoxpreg
            // 
            this.textBoxpreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpreg.Location = new System.Drawing.Point(323, 95);
            this.textBoxpreg.Multiline = true;
            this.textBoxpreg.Name = "textBoxpreg";
            this.textBoxpreg.Size = new System.Drawing.Size(342, 80);
            this.textBoxpreg.TabIndex = 3;
            this.textBoxpreg.TextChanged += new System.EventHandler(this.textBoxpreg_TextChanged);
            // 
            // buttonafegiropcio
            // 
            this.buttonafegiropcio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonafegiropcio.Location = new System.Drawing.Point(680, 199);
            this.buttonafegiropcio.Name = "buttonafegiropcio";
            this.buttonafegiropcio.Size = new System.Drawing.Size(75, 23);
            this.buttonafegiropcio.TabIndex = 6;
            this.buttonafegiropcio.Text = "Afegir";
            this.buttonafegiropcio.UseVisualStyleBackColor = true;
            this.buttonafegiropcio.Click += new System.EventHandler(this.buttonafegiropcio_Click);
            // 
            // buttoneliminaropcio
            // 
            this.buttoneliminaropcio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoneliminaropcio.Location = new System.Drawing.Point(680, 249);
            this.buttoneliminaropcio.Name = "buttoneliminaropcio";
            this.buttoneliminaropcio.Size = new System.Drawing.Size(75, 23);
            this.buttoneliminaropcio.TabIndex = 8;
            this.buttoneliminaropcio.Text = "Eliminar";
            this.buttoneliminaropcio.UseVisualStyleBackColor = true;
            this.buttoneliminaropcio.Click += new System.EventHandler(this.buttoneliminaropcio_Click);
            // 
            // textBoxopcio
            // 
            this.textBoxopcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxopcio.Location = new System.Drawing.Point(323, 190);
            this.textBoxopcio.Multiline = true;
            this.textBoxopcio.Name = "textBoxopcio";
            this.textBoxopcio.Size = new System.Drawing.Size(342, 40);
            this.textBoxopcio.TabIndex = 10;
            // 
            // buttonguardar3
            // 
            this.buttonguardar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonguardar3.Location = new System.Drawing.Point(680, 372);
            this.buttonguardar3.Name = "buttonguardar3";
            this.buttonguardar3.Size = new System.Drawing.Size(75, 23);
            this.buttonguardar3.TabIndex = 11;
            this.buttonguardar3.Text = "Guardar";
            this.buttonguardar3.UseVisualStyleBackColor = true;
            this.buttonguardar3.Click += new System.EventHandler(this.buttonguardar3_Click);
            // 
            // buttonsortir3
            // 
            this.buttonsortir3.Location = new System.Drawing.Point(680, 401);
            this.buttonsortir3.Name = "buttonsortir3";
            this.buttonsortir3.Size = new System.Drawing.Size(75, 23);
            this.buttonsortir3.TabIndex = 12;
            this.buttonsortir3.Text = "Sortir";
            this.buttonsortir3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(680, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sortir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelidioma
            // 
            this.labelidioma.AutoSize = true;
            this.labelidioma.BackColor = System.Drawing.Color.Transparent;
            this.labelidioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidioma.ForeColor = System.Drawing.Color.White;
            this.labelidioma.Location = new System.Drawing.Point(74, 372);
            this.labelidioma.Name = "labelidioma";
            this.labelidioma.Size = new System.Drawing.Size(86, 29);
            this.labelidioma.TabIndex = 14;
            this.labelidioma.Text = "Idioma";
            // 
            // groupBoxidioma
            // 
            this.groupBoxidioma.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxidioma.Controls.Add(this.radioButtonEng);
            this.groupBoxidioma.Controls.Add(this.radioButtonCas);
            this.groupBoxidioma.Controls.Add(this.radioButtonCat);
            this.groupBoxidioma.ForeColor = System.Drawing.Color.White;
            this.groupBoxidioma.Location = new System.Drawing.Point(323, 365);
            this.groupBoxidioma.Name = "groupBoxidioma";
            this.groupBoxidioma.Size = new System.Drawing.Size(342, 50);
            this.groupBoxidioma.TabIndex = 15;
            this.groupBoxidioma.TabStop = false;
            // 
            // radioButtonEng
            // 
            this.radioButtonEng.AutoSize = true;
            this.radioButtonEng.Location = new System.Drawing.Point(251, 21);
            this.radioButtonEng.Name = "radioButtonEng";
            this.radioButtonEng.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEng.TabIndex = 2;
            this.radioButtonEng.Text = "English";
            this.radioButtonEng.UseVisualStyleBackColor = true;
            // 
            // radioButtonCas
            // 
            this.radioButtonCas.AutoSize = true;
            this.radioButtonCas.Location = new System.Drawing.Point(142, 21);
            this.radioButtonCas.Name = "radioButtonCas";
            this.radioButtonCas.Size = new System.Drawing.Size(74, 17);
            this.radioButtonCas.TabIndex = 1;
            this.radioButtonCas.Text = "Castellano";
            this.radioButtonCas.UseVisualStyleBackColor = true;
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.AutoSize = true;
            this.radioButtonCat.Location = new System.Drawing.Point(36, 21);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCat.TabIndex = 0;
            this.radioButtonCat.Text = "Català";
            this.radioButtonCat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonnivell3);
            this.groupBox1.Controls.Add(this.radioButtonnivell2);
            this.groupBox1.Controls.Add(this.radioButtonnivell1);
            this.groupBox1.Location = new System.Drawing.Point(323, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 65);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonnivell3
            // 
            this.radioButtonnivell3.AutoSize = true;
            this.radioButtonnivell3.ForeColor = System.Drawing.Color.White;
            this.radioButtonnivell3.Location = new System.Drawing.Point(251, 28);
            this.radioButtonnivell3.Name = "radioButtonnivell3";
            this.radioButtonnivell3.Size = new System.Drawing.Size(60, 17);
            this.radioButtonnivell3.TabIndex = 2;
            this.radioButtonnivell3.TabStop = true;
            this.radioButtonnivell3.Text = "Nivell 3";
            this.radioButtonnivell3.UseVisualStyleBackColor = true;
            // 
            // radioButtonnivell2
            // 
            this.radioButtonnivell2.AutoSize = true;
            this.radioButtonnivell2.ForeColor = System.Drawing.Color.White;
            this.radioButtonnivell2.Location = new System.Drawing.Point(137, 28);
            this.radioButtonnivell2.Name = "radioButtonnivell2";
            this.radioButtonnivell2.Size = new System.Drawing.Size(60, 17);
            this.radioButtonnivell2.TabIndex = 1;
            this.radioButtonnivell2.TabStop = true;
            this.radioButtonnivell2.Text = "Nivell 2";
            this.radioButtonnivell2.UseVisualStyleBackColor = true;
            // 
            // radioButtonnivell1
            // 
            this.radioButtonnivell1.AutoSize = true;
            this.radioButtonnivell1.ForeColor = System.Drawing.Color.White;
            this.radioButtonnivell1.Location = new System.Drawing.Point(24, 28);
            this.radioButtonnivell1.Name = "radioButtonnivell1";
            this.radioButtonnivell1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonnivell1.TabIndex = 0;
            this.radioButtonnivell1.TabStop = true;
            this.radioButtonnivell1.Text = "Nivell 1";
            this.radioButtonnivell1.UseVisualStyleBackColor = true;
            // 
            // labelnivell
            // 
            this.labelnivell.AutoSize = true;
            this.labelnivell.BackColor = System.Drawing.Color.Transparent;
            this.labelnivell.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnivell.ForeColor = System.Drawing.Color.White;
            this.labelnivell.Location = new System.Drawing.Point(74, 40);
            this.labelnivell.Name = "labelnivell";
            this.labelnivell.Size = new System.Drawing.Size(140, 29);
            this.labelnivell.TabIndex = 17;
            this.labelnivell.Text = "Escull nivell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Resposta correcte";
            // 
            // textBoxresposta
            // 
            this.textBoxresposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxresposta.Location = new System.Drawing.Point(323, 318);
            this.textBoxresposta.Name = "textBoxresposta";
            this.textBoxresposta.Size = new System.Drawing.Size(342, 38);
            this.textBoxresposta.TabIndex = 19;
            // 
            // listBoxOpcions
            // 
            this.listBoxOpcions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOpcions.FormattingEnabled = true;
            this.listBoxOpcions.ItemHeight = 24;
            this.listBoxOpcions.Location = new System.Drawing.Point(323, 237);
            this.listBoxOpcions.Name = "listBoxOpcions";
            this.listBoxOpcions.Size = new System.Drawing.Size(342, 76);
            this.listBoxOpcions.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.imagenfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOpcions);
            this.Controls.Add(this.textBoxresposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelnivell);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxidioma);
            this.Controls.Add(this.labelidioma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonsortir3);
            this.Controls.Add(this.buttonguardar3);
            this.Controls.Add(this.textBoxopcio);
            this.Controls.Add(this.buttoneliminaropcio);
            this.Controls.Add(this.buttonafegiropcio);
            this.Controls.Add(this.textBoxpreg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Afegir preguntes";
            this.groupBoxidioma.ResumeLayout(false);
            this.groupBoxidioma.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox textBoxpreg;
        private System.Windows.Forms.Button buttonafegiropcio;
        private System.Windows.Forms.Button buttoneliminaropcio;
        protected internal System.Windows.Forms.TextBox textBoxopcio;
        private System.Windows.Forms.Button buttonguardar3;
        private System.Windows.Forms.Button buttonsortir3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelidioma;
        private System.Windows.Forms.GroupBox groupBoxidioma;
        private System.Windows.Forms.RadioButton radioButtonEng;
        private System.Windows.Forms.RadioButton radioButtonCas;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonnivell3;
        private System.Windows.Forms.RadioButton radioButtonnivell2;
        private System.Windows.Forms.RadioButton radioButtonnivell1;
        private System.Windows.Forms.Label labelnivell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxresposta;
        private System.Windows.Forms.ListBox listBoxOpcions;
    }
}