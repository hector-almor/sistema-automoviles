namespace Sistema_automóviles.Forms
{
    partial class Frm_detalles_auto
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
            components = new System.ComponentModel.Container();
            LblTitulo = new Label();
            TxtMarca = new TextBox();
            TxtModelo = new TextBox();
            TxtAño = new TextBox();
            TxtExistencia = new TextBox();
            TxtCosto = new TextBox();
            TxtPrecio = new TextBox();
            LblMarca = new Label();
            LblModelo = new Label();
            LblAño = new Label();
            LblExistencia = new Label();
            LblCosto = new Label();
            LblPrecio = new Label();
            ErrorP = new ErrorProvider(components);
            BtnAccion = new FontAwesome.Sharp.IconButton();
            PicBox = new FontAwesome.Sharp.IconPictureBox();
            BtnEditImg = new FontAwesome.Sharp.IconButton();
            LblID = new Label();
            TxtID = new TextBox();
            BtnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(314, 24);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(97, 20);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Detalles auto";
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(243, 119);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(186, 27);
            TxtMarca.TabIndex = 2;
            TxtMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(243, 175);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(186, 27);
            TxtModelo.TabIndex = 3;
            TxtModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtAño
            // 
            TxtAño.Location = new Point(243, 236);
            TxtAño.Name = "TxtAño";
            TxtAño.Size = new Size(186, 27);
            TxtAño.TabIndex = 4;
            TxtAño.TextAlign = HorizontalAlignment.Center;
            TxtAño.TextChanged += ValidarNumeros;
            // 
            // TxtExistencia
            // 
            TxtExistencia.Location = new Point(243, 295);
            TxtExistencia.Name = "TxtExistencia";
            TxtExistencia.Size = new Size(186, 27);
            TxtExistencia.TabIndex = 5;
            TxtExistencia.TextAlign = HorizontalAlignment.Center;
            TxtExistencia.TextChanged += ValidarNumeros;
            // 
            // TxtCosto
            // 
            TxtCosto.Location = new Point(243, 357);
            TxtCosto.Name = "TxtCosto";
            TxtCosto.Size = new Size(186, 27);
            TxtCosto.TabIndex = 6;
            TxtCosto.TextAlign = HorizontalAlignment.Center;
            TxtCosto.TextChanged += ValidarNumeros;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(243, 422);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(186, 27);
            TxtPrecio.TabIndex = 7;
            TxtPrecio.TextAlign = HorizontalAlignment.Center;
            TxtPrecio.TextChanged += ValidarNumeros;
            // 
            // LblMarca
            // 
            LblMarca.AutoSize = true;
            LblMarca.Location = new Point(90, 126);
            LblMarca.Name = "LblMarca";
            LblMarca.Size = new Size(53, 20);
            LblMarca.TabIndex = 0;
            LblMarca.Text = "Marca:";
            // 
            // LblModelo
            // 
            LblModelo.AutoSize = true;
            LblModelo.Location = new Point(90, 182);
            LblModelo.Name = "LblModelo";
            LblModelo.Size = new Size(64, 20);
            LblModelo.TabIndex = 0;
            LblModelo.Text = "Modelo:";
            // 
            // LblAño
            // 
            LblAño.AutoSize = true;
            LblAño.Location = new Point(90, 243);
            LblAño.Name = "LblAño";
            LblAño.Size = new Size(39, 20);
            LblAño.TabIndex = 0;
            LblAño.Text = "Año:";
            // 
            // LblExistencia
            // 
            LblExistencia.AutoSize = true;
            LblExistencia.Location = new Point(90, 302);
            LblExistencia.Name = "LblExistencia";
            LblExistencia.Size = new Size(77, 20);
            LblExistencia.TabIndex = 0;
            LblExistencia.Text = "Existencia:";
            // 
            // LblCosto
            // 
            LblCosto.AutoSize = true;
            LblCosto.Location = new Point(90, 360);
            LblCosto.Name = "LblCosto";
            LblCosto.Size = new Size(50, 20);
            LblCosto.TabIndex = 0;
            LblCosto.Text = "Costo:";
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.Location = new Point(90, 425);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(53, 20);
            LblPrecio.TabIndex = 0;
            LblPrecio.Text = "Precio:";
            // 
            // ErrorP
            // 
            ErrorP.ContainerControl = this;
            // 
            // BtnAccion
            // 
            BtnAccion.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnAccion.IconColor = Color.Black;
            BtnAccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAccion.Location = new Point(503, 387);
            BtnAccion.Name = "BtnAccion";
            BtnAccion.Size = new Size(142, 62);
            BtnAccion.TabIndex = 9;
            BtnAccion.UseVisualStyleBackColor = true;
            BtnAccion.Click += BtnAccion_Click;
            // 
            // PicBox
            // 
            PicBox.BackColor = SystemColors.Control;
            PicBox.ForeColor = Color.FromArgb(224, 224, 224);
            PicBox.IconChar = FontAwesome.Sharp.IconChar.None;
            PicBox.IconColor = Color.FromArgb(224, 224, 224);
            PicBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PicBox.IconSize = 202;
            PicBox.Location = new Point(462, 76);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(326, 202);
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox.TabIndex = 8;
            PicBox.TabStop = false;
            // 
            // BtnEditImg
            // 
            BtnEditImg.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnEditImg.IconColor = Color.Black;
            BtnEditImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditImg.Location = new Point(519, 284);
            BtnEditImg.Name = "BtnEditImg";
            BtnEditImg.Size = new Size(61, 52);
            BtnEditImg.TabIndex = 8;
            BtnEditImg.UseVisualStyleBackColor = true;
            BtnEditImg.Click += BtnEditImg_Click;
            // 
            // LblID
            // 
            LblID.AutoSize = true;
            LblID.Location = new Point(90, 72);
            LblID.Name = "LblID";
            LblID.Size = new Size(27, 20);
            LblID.TabIndex = 10;
            LblID.Text = "ID:";
            LblID.Visible = false;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(243, 65);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(186, 27);
            TxtID.TabIndex = 1;
            TxtID.TextAlign = HorizontalAlignment.Center;
            TxtID.Visible = false;
            TxtID.TextChanged += ValidarNumeros;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            BtnLimpiar.IconColor = Color.Black;
            BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLimpiar.Location = new Point(655, 288);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(69, 48);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // Frm_detalles_auto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(BtnLimpiar);
            Controls.Add(LblID);
            Controls.Add(TxtID);
            Controls.Add(BtnEditImg);
            Controls.Add(PicBox);
            Controls.Add(BtnAccion);
            Controls.Add(LblPrecio);
            Controls.Add(LblCosto);
            Controls.Add(LblExistencia);
            Controls.Add(LblAño);
            Controls.Add(LblModelo);
            Controls.Add(LblMarca);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtCosto);
            Controls.Add(TxtExistencia);
            Controls.Add(TxtAño);
            Controls.Add(TxtModelo);
            Controls.Add(TxtMarca);
            Controls.Add(LblTitulo);
            Name = "Frm_detalles_auto";
            Load += Frm_detalles_auto_Load;
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private TextBox TxtMarca;
        private TextBox TxtModelo;
        private TextBox TxtAño;
        private TextBox TxtExistencia;
        private TextBox TxtCosto;
        private TextBox TxtPrecio;
        private Label LblMarca;
        private Label LblModelo;
        private Label LblAño;
        private Label LblExistencia;
        private Label LblCosto;
        private Label LblPrecio;
        private ErrorProvider ErrorP;
        private FontAwesome.Sharp.IconButton BtnAccion;
        private FontAwesome.Sharp.IconPictureBox PicBox;
        private FontAwesome.Sharp.IconButton BtnEditImg;
        private Label LblID;
        private TextBox TxtID;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
    }
}