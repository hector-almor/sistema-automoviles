namespace Sistema_automóviles.Forms
{
    partial class Frm_Inicio
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
            Contenedor = new Panel();
            Pnl_prueba = new Panel();
            button1 = new Button();
            Btn_actualizar = new Button();
            Btn_eliminar = new Button();
            Existencia = new Label();
            Precio = new Label();
            Año = new Label();
            Modelo_prueba = new Label();
            Marca_prueba = new Label();
            Pb_prueba = new PictureBox();
            TxtBusqueda = new TextBox();
            LblTitulo = new Label();
            Agregar = new FontAwesome.Sharp.IconButton();
            BtnVentas = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            Contenedor.SuspendLayout();
            Pnl_prueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_prueba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Contenedor
            // 
            Contenedor.AutoScroll = true;
            Contenedor.Controls.Add(Pnl_prueba);
            Contenedor.Location = new Point(15, 144);
            Contenedor.Margin = new Padding(4);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(2341, 1084);
            Contenedor.TabIndex = 0;
            // 
            // Pnl_prueba
            // 
            Pnl_prueba.BackColor = Color.Red;
            Pnl_prueba.Controls.Add(button1);
            Pnl_prueba.Controls.Add(Btn_actualizar);
            Pnl_prueba.Controls.Add(Btn_eliminar);
            Pnl_prueba.Controls.Add(Existencia);
            Pnl_prueba.Controls.Add(Precio);
            Pnl_prueba.Controls.Add(Año);
            Pnl_prueba.Controls.Add(Modelo_prueba);
            Pnl_prueba.Controls.Add(Marca_prueba);
            Pnl_prueba.Controls.Add(Pb_prueba);
            Pnl_prueba.Location = new Point(42, 91);
            Pnl_prueba.Margin = new Padding(4);
            Pnl_prueba.Name = "Pnl_prueba";
            Pnl_prueba.Size = new Size(365, 445);
            Pnl_prueba.TabIndex = 0;
            Pnl_prueba.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(249, 390);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(84, 36);
            button1.TabIndex = 3;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            Btn_actualizar.Location = new Point(50, 390);
            Btn_actualizar.Margin = new Padding(4);
            Btn_actualizar.Name = "Btn_actualizar";
            Btn_actualizar.Size = new Size(75, 36);
            Btn_actualizar.TabIndex = 2;
            Btn_actualizar.Text = "Actualizar";
            Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.Location = new Point(142, 390);
            Btn_eliminar.Margin = new Padding(4);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(84, 36);
            Btn_eliminar.TabIndex = 1;
            Btn_eliminar.Text = "Eliminar";
            Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Existencia
            // 
            Existencia.AutoSize = true;
            Existencia.Location = new Point(160, 314);
            Existencia.Margin = new Padding(4, 0, 4, 0);
            Existencia.Name = "Existencia";
            Existencia.Size = new Size(32, 25);
            Existencia.TabIndex = 0;
            Existencia.Text = "20";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(224, 340);
            Precio.Margin = new Padding(4, 0, 4, 0);
            Precio.Name = "Precio";
            Precio.Size = new Size(110, 25);
            Precio.TabIndex = 0;
            Precio.Text = "$200,000.00";
            // 
            // Año
            // 
            Año.AutoSize = true;
            Año.Location = new Point(252, 289);
            Año.Margin = new Padding(4, 0, 4, 0);
            Año.Name = "Año";
            Año.Size = new Size(52, 25);
            Año.TabIndex = 0;
            Año.Text = "2010";
            // 
            // Modelo_prueba
            // 
            Modelo_prueba.AutoSize = true;
            Modelo_prueba.Location = new Point(34, 340);
            Modelo_prueba.Margin = new Padding(4, 0, 4, 0);
            Modelo_prueba.Name = "Modelo_prueba";
            Modelo_prueba.Size = new Size(65, 25);
            Modelo_prueba.TabIndex = 0;
            Modelo_prueba.Text = "Mazda";
            // 
            // Marca_prueba
            // 
            Marca_prueba.AutoSize = true;
            Marca_prueba.Location = new Point(34, 289);
            Marca_prueba.Margin = new Padding(4, 0, 4, 0);
            Marca_prueba.Name = "Marca_prueba";
            Marca_prueba.Size = new Size(64, 25);
            Marca_prueba.TabIndex = 0;
            Marca_prueba.Text = "Nissan";
            // 
            // Pb_prueba
            // 
            Pb_prueba.Location = new Point(16, 18);
            Pb_prueba.Margin = new Padding(4);
            Pb_prueba.Name = "Pb_prueba";
            Pb_prueba.Size = new Size(332, 252);
            Pb_prueba.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_prueba.TabIndex = 0;
            Pb_prueba.TabStop = false;
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Location = new Point(1056, 82);
            TxtBusqueda.Margin = new Padding(4);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(223, 31);
            TxtBusqueda.TabIndex = 0;
            TxtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitulo.ForeColor = Color.FromArgb(42, 44, 65);
            LblTitulo.Location = new Point(978, 11);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(363, 54);
            LblTitulo.TabIndex = 2;
            LblTitulo.Text = "CATÁLOGO DE AUTOS";
            // 
            // Agregar
            // 
            Agregar.AutoSize = true;
            Agregar.BackColor = Color.FromArgb(50, 1, 47);
            Agregar.FlatAppearance.BorderSize = 0;
            Agregar.FlatStyle = FlatStyle.Flat;
            Agregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            Agregar.IconColor = Color.FromArgb(255, 95, 0);
            Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Agregar.Location = new Point(211, 44);
            Agregar.Margin = new Padding(4);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(72, 72);
            Agregar.TabIndex = 2;
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Btn_actualizar_auto;
            Agregar.MouseHover += Agregar_MouseHover;
            // 
            // BtnVentas
            // 
            BtnVentas.AutoSize = true;
            BtnVentas.BackColor = Color.FromArgb(50, 1, 47);
            BtnVentas.FlatAppearance.BorderSize = 0;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.ForeColor = SystemColors.ActiveCaption;
            BtnVentas.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnVentas.IconColor = Color.FromArgb(255, 95, 0);
            BtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVentas.Location = new Point(428, 44);
            BtnVentas.Margin = new Padding(4);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(72, 72);
            BtnVentas.TabIndex = 3;
            BtnVentas.UseVisualStyleBackColor = false;
            BtnVentas.Click += BtnVentas_Click;
            BtnVentas.MouseHover += BtnVentas_MouseHover;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.Cursor = Cursors.IBeam;
            iconPictureBox1.ForeColor = Color.FromArgb(50, 1, 47);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            iconPictureBox1.IconColor = Color.FromArgb(50, 1, 47);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 34;
            iconPictureBox1.Location = new Point(1001, 82);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(48, 34);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // Frm_Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1924, 1050);
            Controls.Add(iconPictureBox1);
            Controls.Add(BtnVentas);
            Controls.Add(Agregar);
            Controls.Add(LblTitulo);
            Controls.Add(TxtBusqueda);
            Controls.Add(Contenedor);
            Margin = new Padding(4);
            Name = "Frm_Inicio";
            Load += Frm_Inicio_Load;
            Contenedor.ResumeLayout(false);
            Pnl_prueba.ResumeLayout(false);
            Pnl_prueba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_prueba).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Contenedor;
        private Panel Pnl_prueba;
        private PictureBox Pb_prueba;
        private Label Marca_prueba;
        private Label Modelo_prueba;
        private Label Año;
        private Label Precio;
        private Label Existencia;
        private TextBox TxtBusqueda;
        private Button Btn_eliminar;
        private Button Btn_actualizar;
        private Label LblTitulo;
        private Button button1;
        private FontAwesome.Sharp.IconButton Agregar;
        private FontAwesome.Sharp.IconButton BtnVentas;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}