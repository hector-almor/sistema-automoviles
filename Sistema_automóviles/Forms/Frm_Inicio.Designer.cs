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
            TxtBusqueda = new TextBox();
            Pnl_prueba = new Panel();
            Existencia = new Label();
            Precio = new Label();
            Año = new Label();
            Modelo_prueba = new Label();
            Marca_prueba = new Label();
            Pb_prueba = new PictureBox();
            Contenedor.SuspendLayout();
            Pnl_prueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_prueba).BeginInit();
            SuspendLayout();
            // 
            // Contenedor
            // 
            Contenedor.AutoScroll = true;
            Contenedor.Controls.Add(TxtBusqueda);
            Contenedor.Controls.Add(Pnl_prueba);
            Contenedor.Location = new Point(12, 12);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1900, 970);
            Contenedor.TabIndex = 0;
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Enabled = false;
            TxtBusqueda.Location = new Point(520, 27);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(179, 27);
            TxtBusqueda.TabIndex = 0;
            TxtBusqueda.Visible = false;
            TxtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            // 
            // Pnl_prueba
            // 
            Pnl_prueba.BackColor = Color.Red;
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
            // Frm_Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 994);
            Controls.Add(Contenedor);
            Name = "Frm_Inicio";
            Text = "Frm_Inicio";
            Load += Frm_Inicio_Load;
            Shown += Frm_Inicio_Shown;
            Contenedor.ResumeLayout(false);
            Contenedor.PerformLayout();
            Pnl_prueba.ResumeLayout(false);
            Pnl_prueba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_prueba).EndInit();
            ResumeLayout(false);
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
    }
}