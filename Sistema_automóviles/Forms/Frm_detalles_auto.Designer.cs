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
            PicBox = new FontAwesome.Sharp.IconPictureBox();
            BtnEditImg = new FontAwesome.Sharp.IconButton();
            LblID = new Label();
            TxtID = new TextBox();
            BtnLimpiar = new FontAwesome.Sharp.IconButton();
            BtnAccion = new FontAwesome.Sharp.IconButton();
            LblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            SuspendLayout();
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(121, 89);
            TxtMarca.Margin = new Padding(3, 2, 3, 2);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(164, 23);
            TxtMarca.TabIndex = 2;
            TxtMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(121, 131);
            TxtModelo.Margin = new Padding(3, 2, 3, 2);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(164, 23);
            TxtModelo.TabIndex = 3;
            TxtModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtAño
            // 
            TxtAño.Location = new Point(121, 177);
            TxtAño.Margin = new Padding(3, 2, 3, 2);
            TxtAño.Name = "TxtAño";
            TxtAño.Size = new Size(164, 23);
            TxtAño.TabIndex = 4;
            TxtAño.TextAlign = HorizontalAlignment.Center;
            TxtAño.TextChanged += ValidarNumeros;
            // 
            // TxtExistencia
            // 
            TxtExistencia.Location = new Point(121, 221);
            TxtExistencia.Margin = new Padding(3, 2, 3, 2);
            TxtExistencia.Name = "TxtExistencia";
            TxtExistencia.Size = new Size(164, 23);
            TxtExistencia.TabIndex = 5;
            TxtExistencia.TextAlign = HorizontalAlignment.Center;
            TxtExistencia.TextChanged += ValidarNumeros;
            // 
            // TxtCosto
            // 
            TxtCosto.Location = new Point(121, 268);
            TxtCosto.Margin = new Padding(3, 2, 3, 2);
            TxtCosto.Name = "TxtCosto";
            TxtCosto.Size = new Size(164, 23);
            TxtCosto.TabIndex = 6;
            TxtCosto.TextAlign = HorizontalAlignment.Center;
            TxtCosto.TextChanged += ValidarNumeros;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(121, 317);
            TxtPrecio.Margin = new Padding(3, 2, 3, 2);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(164, 23);
            TxtPrecio.TabIndex = 7;
            TxtPrecio.TextAlign = HorizontalAlignment.Center;
            TxtPrecio.TextChanged += ValidarNumeros;
            // 
            // LblMarca
            // 
            LblMarca.AutoSize = true;
            LblMarca.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblMarca.Location = new Point(18, 92);
            LblMarca.Name = "LblMarca";
            LblMarca.Size = new Size(51, 15);
            LblMarca.TabIndex = 0;
            LblMarca.Text = "Marca:";
            // 
            // LblModelo
            // 
            LblModelo.AutoSize = true;
            LblModelo.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblModelo.Location = new Point(18, 134);
            LblModelo.Name = "LblModelo";
            LblModelo.Size = new Size(63, 15);
            LblModelo.TabIndex = 0;
            LblModelo.Text = "Modelo:";
            // 
            // LblAño
            // 
            LblAño.AutoSize = true;
            LblAño.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblAño.Location = new Point(18, 179);
            LblAño.Name = "LblAño";
            LblAño.Size = new Size(36, 15);
            LblAño.TabIndex = 0;
            LblAño.Text = "Año:";
            // 
            // LblExistencia
            // 
            LblExistencia.AutoSize = true;
            LblExistencia.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblExistencia.Location = new Point(18, 224);
            LblExistencia.Name = "LblExistencia";
            LblExistencia.Size = new Size(81, 15);
            LblExistencia.TabIndex = 0;
            LblExistencia.Text = "Existencia:";
            // 
            // LblCosto
            // 
            LblCosto.AutoSize = true;
            LblCosto.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblCosto.Location = new Point(20, 270);
            LblCosto.Name = "LblCosto";
            LblCosto.Size = new Size(50, 15);
            LblCosto.TabIndex = 0;
            LblCosto.Text = "Costo:";
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblPrecio.Location = new Point(18, 319);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(55, 15);
            LblPrecio.TabIndex = 0;
            LblPrecio.Text = "Precio:";
            // 
            // ErrorP
            // 
            ErrorP.ContainerControl = this;
            // 
            // PicBox
            // 
            PicBox.BackColor = SystemColors.Control;
            PicBox.ForeColor = Color.FromArgb(224, 224, 224);
            PicBox.IconChar = FontAwesome.Sharp.IconChar.None;
            PicBox.IconColor = Color.FromArgb(224, 224, 224);
            PicBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PicBox.IconSize = 151;
            PicBox.Location = new Point(313, 57);
            PicBox.Margin = new Padding(3, 2, 3, 2);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(286, 151);
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox.TabIndex = 8;
            PicBox.TabStop = false;
            // 
            // BtnEditImg
            // 
            BtnEditImg.BackColor = Color.FromArgb(20, 30, 70);
            BtnEditImg.FlatStyle = FlatStyle.Flat;
            BtnEditImg.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            BtnEditImg.IconColor = Color.FromArgb(220, 95, 0);
            BtnEditImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditImg.Location = new Point(319, 213);
            BtnEditImg.Margin = new Padding(3, 2, 3, 2);
            BtnEditImg.Name = "BtnEditImg";
            BtnEditImg.Size = new Size(53, 39);
            BtnEditImg.TabIndex = 8;
            BtnEditImg.UseVisualStyleBackColor = false;
            BtnEditImg.Click += BtnEditImg_Click;
            // 
            // LblID
            // 
            LblID.AutoSize = true;
            LblID.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblID.Location = new Point(20, 49);
            LblID.Name = "LblID";
            LblID.Size = new Size(26, 15);
            LblID.TabIndex = 10;
            LblID.Text = "ID:";
            LblID.Visible = false;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(121, 49);
            TxtID.Margin = new Padding(3, 2, 3, 2);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(164, 23);
            TxtID.TabIndex = 1;
            TxtID.TextAlign = HorizontalAlignment.Center;
            TxtID.Visible = false;
            TxtID.TextChanged += ValidarNumeros;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Red;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            BtnLimpiar.IconColor = Color.White;
            BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLimpiar.Location = new Point(528, 216);
            BtnLimpiar.Margin = new Padding(3, 2, 3, 2);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(60, 36);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnAccion
            // 
            BtnAccion.BackColor = Color.FromArgb(128, 136, 54);
            BtnAccion.FlatStyle = FlatStyle.Flat;
            BtnAccion.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnAccion.IconColor = Color.White;
            BtnAccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAccion.Location = new Point(319, 287);
            BtnAccion.Margin = new Padding(3, 2, 3, 2);
            BtnAccion.Name = "BtnAccion";
            BtnAccion.Size = new Size(129, 48);
            BtnAccion.TabIndex = 12;
            BtnAccion.UseVisualStyleBackColor = false;
            BtnAccion.Click += BtnAcción_Click;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitulo.ForeColor = Color.FromArgb(42, 44, 65);
            LblTitulo.Location = new Point(239, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(119, 23);
            LblTitulo.TabIndex = 13;
            LblTitulo.Text = "DETALLES AUTO";
            // 
            // Frm_detalles_auto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(609, 390);
            Controls.Add(LblTitulo);
            Controls.Add(BtnAccion);
            Controls.Add(BtnLimpiar);
            Controls.Add(LblID);
            Controls.Add(TxtID);
            Controls.Add(BtnEditImg);
            Controls.Add(PicBox);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_detalles_auto";
            Load += Frm_detalles_auto_Load;
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private FontAwesome.Sharp.IconPictureBox PicBox;
        private FontAwesome.Sharp.IconButton BtnEditImg;
        private Label LblID;
        private TextBox TxtID;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnAccion;
        private Label LblTitulo;
    }
}