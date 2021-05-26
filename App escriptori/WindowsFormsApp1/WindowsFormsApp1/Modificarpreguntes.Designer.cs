namespace WindowsFormsApp1
{
    partial class Modificarpreguntes
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
            this.labelpreg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelopcion2 = new System.Windows.Forms.Label();
            this.textBoxopcion2 = new System.Windows.Forms.TextBox();
            this.labelresposta2 = new System.Windows.Forms.Label();
            this.textBoxrespcorrecte = new System.Windows.Forms.TextBox();
            this.buttonguardar4 = new System.Windows.Forms.Button();
            this.buttonsortir4 = new System.Windows.Forms.Button();
            this.listBoxopcions2 = new System.Windows.Forms.ListBox();
            this.buttonafegir2 = new System.Windows.Forms.Button();
            this.buttoneliminar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelpreg
            // 
            this.labelpreg.AutoSize = true;
            this.labelpreg.BackColor = System.Drawing.Color.Transparent;
            this.labelpreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpreg.ForeColor = System.Drawing.Color.White;
            this.labelpreg.Location = new System.Drawing.Point(107, 56);
            this.labelpreg.Name = "labelpreg";
            this.labelpreg.Size = new System.Drawing.Size(124, 31);
            this.labelpreg.TabIndex = 0;
            this.labelpreg.Text = "Pregunta";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(357, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 75);
            this.textBox1.TabIndex = 1;
            // 
            // labelopcion2
            // 
            this.labelopcion2.AutoSize = true;
            this.labelopcion2.BackColor = System.Drawing.Color.Transparent;
            this.labelopcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelopcion2.ForeColor = System.Drawing.Color.White;
            this.labelopcion2.Location = new System.Drawing.Point(107, 166);
            this.labelopcion2.Name = "labelopcion2";
            this.labelopcion2.Size = new System.Drawing.Size(114, 31);
            this.labelopcion2.TabIndex = 2;
            this.labelopcion2.Text = "Opcions";
            // 
            // textBoxopcion2
            // 
            this.textBoxopcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxopcion2.Location = new System.Drawing.Point(357, 155);
            this.textBoxopcion2.Multiline = true;
            this.textBoxopcion2.Name = "textBoxopcion2";
            this.textBoxopcion2.Size = new System.Drawing.Size(330, 39);
            this.textBoxopcion2.TabIndex = 3;
            // 
            // labelresposta2
            // 
            this.labelresposta2.AutoSize = true;
            this.labelresposta2.BackColor = System.Drawing.Color.Transparent;
            this.labelresposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresposta2.ForeColor = System.Drawing.Color.White;
            this.labelresposta2.Location = new System.Drawing.Point(92, 344);
            this.labelresposta2.Name = "labelresposta2";
            this.labelresposta2.Size = new System.Drawing.Size(236, 31);
            this.labelresposta2.TabIndex = 4;
            this.labelresposta2.Text = "Resposta correcte";
            // 
            // textBoxrespcorrecte
            // 
            this.textBoxrespcorrecte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrespcorrecte.Location = new System.Drawing.Point(357, 344);
            this.textBoxrespcorrecte.Multiline = true;
            this.textBoxrespcorrecte.Name = "textBoxrespcorrecte";
            this.textBoxrespcorrecte.Size = new System.Drawing.Size(330, 41);
            this.textBoxrespcorrecte.TabIndex = 5;
            // 
            // buttonguardar4
            // 
            this.buttonguardar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonguardar4.Location = new System.Drawing.Point(697, 386);
            this.buttonguardar4.Name = "buttonguardar4";
            this.buttonguardar4.Size = new System.Drawing.Size(75, 23);
            this.buttonguardar4.TabIndex = 6;
            this.buttonguardar4.Text = "Guardar";
            this.buttonguardar4.UseVisualStyleBackColor = true;
            // 
            // buttonsortir4
            // 
            this.buttonsortir4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsortir4.Location = new System.Drawing.Point(697, 415);
            this.buttonsortir4.Name = "buttonsortir4";
            this.buttonsortir4.Size = new System.Drawing.Size(75, 23);
            this.buttonsortir4.TabIndex = 7;
            this.buttonsortir4.Text = "Sortir";
            this.buttonsortir4.UseVisualStyleBackColor = true;
            this.buttonsortir4.Click += new System.EventHandler(this.buttonsortir4_Click);
            // 
            // listBoxopcions2
            // 
            this.listBoxopcions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxopcions2.FormattingEnabled = true;
            this.listBoxopcions2.HorizontalScrollbar = true;
            this.listBoxopcions2.ItemHeight = 31;
            this.listBoxopcions2.Location = new System.Drawing.Point(357, 216);
            this.listBoxopcions2.Name = "listBoxopcions2";
            this.listBoxopcions2.ScrollAlwaysVisible = true;
            this.listBoxopcions2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxopcions2.Size = new System.Drawing.Size(330, 97);
            this.listBoxopcions2.TabIndex = 8;
            // 
            // buttonafegir2
            // 
            this.buttonafegir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonafegir2.Location = new System.Drawing.Point(697, 166);
            this.buttonafegir2.Name = "buttonafegir2";
            this.buttonafegir2.Size = new System.Drawing.Size(75, 23);
            this.buttonafegir2.TabIndex = 9;
            this.buttonafegir2.Text = "Afegir";
            this.buttonafegir2.UseVisualStyleBackColor = true;
            this.buttonafegir2.Click += new System.EventHandler(this.buttonafegir2_Click);
            // 
            // buttoneliminar2
            // 
            this.buttoneliminar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoneliminar2.Location = new System.Drawing.Point(697, 216);
            this.buttoneliminar2.Name = "buttoneliminar2";
            this.buttoneliminar2.Size = new System.Drawing.Size(75, 23);
            this.buttoneliminar2.TabIndex = 10;
            this.buttoneliminar2.Text = "Eliminar";
            this.buttoneliminar2.UseVisualStyleBackColor = true;
            this.buttoneliminar2.Click += new System.EventHandler(this.buttoneliminar2_Click);
            // 
            // Modificarpreguntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.imagenfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoneliminar2);
            this.Controls.Add(this.buttonafegir2);
            this.Controls.Add(this.listBoxopcions2);
            this.Controls.Add(this.buttonsortir4);
            this.Controls.Add(this.buttonguardar4);
            this.Controls.Add(this.textBoxrespcorrecte);
            this.Controls.Add(this.labelresposta2);
            this.Controls.Add(this.textBoxopcion2);
            this.Controls.Add(this.labelopcion2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelpreg);
            this.DoubleBuffered = true;
            this.Name = "Modificarpreguntes";
            this.Text = "Modificar preguntes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpreg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelopcion2;
        private System.Windows.Forms.TextBox textBoxopcion2;
        private System.Windows.Forms.Label labelresposta2;
        private System.Windows.Forms.TextBox textBoxrespcorrecte;
        private System.Windows.Forms.Button buttonguardar4;
        private System.Windows.Forms.Button buttonsortir4;
        private System.Windows.Forms.ListBox listBoxopcions2;
        private System.Windows.Forms.Button buttonafegir2;
        private System.Windows.Forms.Button buttoneliminar2;
    }
}