namespace FirmarXml
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DocumentXml = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Certificado = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentXml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Certificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DocumentXml
            // 
            this.DocumentXml.CaptionStyle.CaptionSize = 0;
            this.DocumentXml.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.DocumentXml.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.DocumentXml.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack;
            this.DocumentXml.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.DocumentXml.EditBoxStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DocumentXml.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.DocumentXml.EditBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentXml.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernSilver;
            this.DocumentXml.Location = new System.Drawing.Point(12, 89);
            this.DocumentXml.Name = "DocumentXml";
            this.DocumentXml.Size = new System.Drawing.Size(356, 25);
            this.DocumentXml.TabIndex = 0;
            this.DocumentXml.ValidationStyle.PasswordChar = '\0';
            this.DocumentXml.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firmar Xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seleccione el Documento XML:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seleccione el Certificado:";
            // 
            // Certificado
            // 
            this.Certificado.CaptionStyle.CaptionSize = 0;
            this.Certificado.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.Certificado.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.Certificado.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack;
            this.Certificado.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.Certificado.EditBoxStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Certificado.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.Certificado.EditBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Certificado.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernSilver;
            this.Certificado.Location = new System.Drawing.Point(12, 148);
            this.Certificado.Name = "Certificado";
            this.Certificado.Size = new System.Drawing.Size(356, 25);
            this.Certificado.TabIndex = 17;
            this.Certificado.ValidationStyle.PasswordChar = '\0';
            this.Certificado.Value = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Contraseña del Certificado:";
            // 
            // Password
            // 
            this.Password.CaptionStyle.CaptionSize = 0;
            this.Password.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.Password.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.Password.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlack;
            this.Password.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.Password.EditBoxStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Password.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.Password.EditBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernSilver;
            this.Password.Location = new System.Drawing.Point(12, 195);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(356, 25);
            this.Password.TabIndex = 19;
            this.Password.ValidationStyle.PasswordChar = '\0';
            this.Password.ValidationStyle.UseSystemPasswordChar = true;
            this.Password.Value = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(402, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(402, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 3;
            this.bunifuFlatButton1.ButtonText = "Procesar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(105, 247);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(224, 40);
            this.bunifuFlatButton1.TabIndex = 26;
            this.bunifuFlatButton1.Text = "Procesar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 307);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Certificado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentXml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DocumentXml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Certificado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox DocumentXml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox Password;
        private System.Windows.Forms.Label label6;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox Certificado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

