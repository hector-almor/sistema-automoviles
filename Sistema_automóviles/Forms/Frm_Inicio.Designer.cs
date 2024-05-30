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
            Contenedor.SuspendLayout();
            Pnl_prueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_prueba).BeginInit();
            SuspendLayout();
            // 
            // Contenedor
            // 
            Contenedor.AutoScroll = true;
            Contenedor.Controls.Add(Pnl_prueba);
            Contenedor.Location = new Point(12, 115);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1873, 867);
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
            Pnl_prueba.Location = new Point(34, 73);
            Pnl_prueba.Name = "Pnl_prueba";
            Pnl_prueba.Size = new Size(292, 356);
            Pnl_prueba.TabIndex = 0;
            Pnl_prueba.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(199, 312);
            button1.Name = "button1";
            button1.Size = new Size(67, 29);
            button1.TabIndex = 3;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            Btn_actualizar.Location = new Point(40, 312);
            Btn_actualizar.Name = "Btn_actualizar";
            Btn_actualizar.Size = new Size(60, 29);
            Btn_actualizar.TabIndex = 2;
            Btn_actualizar.Text = "Actualizar";
            Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.Location = new Point(114, 312);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(67, 29);
            Btn_eliminar.TabIndex = 1;
            Btn_eliminar.Text = "Eliminar";
            Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Existencia
            // 
            Existencia.AutoSize = true;
            Existencia.Location = new Point(128, 251);
            Existencia.Name = "Existencia";
            Existencia.Size = new Size(25, 20);
            Existencia.TabIndex = 0;
            Existencia.Text = "20";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(179, 272);
            Precio.Name = "Precio";
            Precio.Size = new Size(87, 20);
            Precio.TabIndex = 0;
            Precio.Text = "$200,000.00";
            // 
            // Año
            // 
            Año.AutoSize = true;
            Año.Location = new Point(202, 231);
            Año.Name = "Año";
            Año.Size = new Size(41, 20);
            Año.TabIndex = 0;
            Año.Text = "2010";
            // 
            // Modelo_prueba
            // 
            Modelo_prueba.AutoSize = true;
            Modelo_prueba.Location = new Point(27, 272);
            Modelo_prueba.Name = "Modelo_prueba";
            Modelo_prueba.Size = new Size(54, 20);
            Modelo_prueba.TabIndex = 0;
            Modelo_prueba.Text = "Mazda";
            // 
            // Marca_prueba
            // 
            Marca_prueba.AutoSize = true;
            Marca_prueba.Location = new Point(27, 231);
            Marca_prueba.Name = "Marca_prueba";
            Marca_prueba.Size = new Size(52, 20);
            Marca_prueba.TabIndex = 0;
            Marca_prueba.Text = "Nissan";
            // 
            // Pb_prueba
            // 
            Pb_prueba.Location = new Point(13, 14);
            Pb_prueba.Name = "Pb_prueba";
            Pb_prueba.Size = new Size(266, 202);
            Pb_prueba.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_prueba.TabIndex = 0;
            Pb_prueba.TabStop = false;
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Location = new Point(845, 66);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(179, 27);
            TxtBusqueda.TabIndex = 0;
            TxtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Impact", 22F);
            LblTitulo.ForeColor = Color.FromArgb(42, 44, 65);
            LblTitulo.Location = new Point(782, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(309, 45);
            LblTitulo.TabIndex = 2;
            LblTitulo.Text = "CATÁLOGO DE AUTOS";
            // 
            // Agregar
            // 
            Agregar.AutoSize = true;
            Agregar.BackColor = Color.DodgerBlue;
            Agregar.FlatAppearance.BorderSize = 0;
            Agregar.FlatStyle = FlatStyle.Flat;
            Agregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            Agregar.IconColor = Color.Black;
            Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Agregar.Location = new Point(413, 35);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(58, 58);
            Agregar.TabIndex = 2;
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Btn_actualizar_auto;
            // 
            // BtnVentas
            // 
            BtnVentas.AutoSize = true;
            BtnVentas.BackColor = Color.Yellow;
            BtnVentas.FlatAppearance.BorderSize = 0;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnVentas.IconColor = Color.Black;
            BtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVentas.Location = new Point(553, 35);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(58, 58);
            BtnVentas.TabIndex = 3;
            BtnVentas.UseVisualStyleBackColor = false;
            BtnVentas.Click += BtnVentas_Click;
            // 
            // Frm_Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 994);
            Controls.Add(BtnVentas);
            Controls.Add(Agregar);
            Controls.Add(LblTitulo);
            Controls.Add(TxtBusqueda);
            Controls.Add(Contenedor);
            Name = "Frm_Inicio";
            Load += Frm_Inicio_Load;
            Contenedor.ResumeLayout(false);
            Pnl_prueba.ResumeLayout(false);
            Pnl_prueba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_prueba).EndInit();
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
    }
}