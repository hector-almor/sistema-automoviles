namespace Sistema_automóviles.Forms
{
    partial class Frm_hacer_venta
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
            LblAuto = new Label();
            ID_cliente = new Label();
            TxtDescripcion = new TextBox();
            LblDescripcion = new Label();
            NumAutos = new NumericUpDown();
            LblNumAutos = new Label();
            TxtPrecio = new TextBox();
            LblPrecio = new Label();
            TxtTotal = new TextBox();
            LblTotal = new Label();
            BtnVender = new FontAwesome.Sharp.IconButton();
            CmbCliente = new ComboBox();
            ErrorP = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NumAutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(315, 25);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(102, 20);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Realizar venta";
            // 
            // LblAuto
            // 
            LblAuto.AutoSize = true;
            LblAuto.Location = new Point(301, 73);
            LblAuto.Name = "LblAuto";
            LblAuto.Size = new Size(60, 20);
            LblAuto.TabIndex = 0;
            LblAuto.Text = "ID_auto";
            // 
            // ID_cliente
            // 
            ID_cliente.AutoSize = true;
            ID_cliente.Location = new Point(213, 127);
            ID_cliente.Name = "ID_cliente";
            ID_cliente.Size = new Size(74, 20);
            ID_cliente.TabIndex = 0;
            ID_cliente.Text = "ID_cliente";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(270, 187);
            TxtDescripcion.MaxLength = 200;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(487, 27);
            TxtDescripcion.TabIndex = 3;
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Location = new Point(112, 190);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(87, 20);
            LblDescripcion.TabIndex = 0;
            LblDescripcion.Text = "Descripción";
            // 
            // NumAutos
            // 
            NumAutos.Location = new Point(270, 244);
            NumAutos.Name = "NumAutos";
            NumAutos.Size = new Size(150, 27);
            NumAutos.TabIndex = 4;
            NumAutos.ValueChanged += NumAutos_ValueChanged;
            // 
            // LblNumAutos
            // 
            LblNumAutos.AutoSize = true;
            LblNumAutos.Location = new Point(112, 251);
            LblNumAutos.Name = "LblNumAutos";
            LblNumAutos.Size = new Size(124, 20);
            LblNumAutos.TabIndex = 0;
            LblNumAutos.Text = "Número de autos";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Enabled = false;
            TxtPrecio.Location = new Point(270, 297);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(225, 27);
            TxtPrecio.TabIndex = 5;
            TxtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.Location = new Point(112, 300);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(50, 20);
            LblPrecio.TabIndex = 0;
            LblPrecio.Text = "Precio";
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(270, 348);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(225, 27);
            TxtTotal.TabIndex = 6;
            TxtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(112, 351);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(42, 20);
            LblTotal.TabIndex = 0;
            LblTotal.Text = "Total";
            // 
            // BtnVender
            // 
            BtnVender.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnVender.IconColor = Color.Black;
            BtnVender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVender.Location = new Point(315, 394);
            BtnVender.Name = "BtnVender";
            BtnVender.Size = new Size(147, 64);
            BtnVender.TabIndex = 7;
            BtnVender.UseVisualStyleBackColor = true;
            BtnVender.Click += BtnVender_Click;
            // 
            // CmbCliente
            // 
            CmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCliente.FormattingEnabled = true;
            CmbCliente.Location = new Point(315, 127);
            CmbCliente.Name = "CmbCliente";
            CmbCliente.Size = new Size(337, 28);
            CmbCliente.TabIndex = 8;
            // 
            // ErrorP
            // 
            ErrorP.ContainerControl = this;
            // 
            // Frm_hacer_venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 513);
            Controls.Add(CmbCliente);
            Controls.Add(BtnVender);
            Controls.Add(TxtTotal);
            Controls.Add(LblTotal);
            Controls.Add(TxtPrecio);
            Controls.Add(LblPrecio);
            Controls.Add(LblNumAutos);
            Controls.Add(NumAutos);
            Controls.Add(TxtDescripcion);
            Controls.Add(LblDescripcion);
            Controls.Add(ID_cliente);
            Controls.Add(LblAuto);
            Controls.Add(LblTitulo);
            Name = "Frm_hacer_venta";
            Load += Frm_hacer_venta_Load;
            ((System.ComponentModel.ISupportInitialize)NumAutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Label LblAuto;
        private Label ID_cliente;
        private TextBox TxtDescripcion;
        private Label LblDescripcion;
        private NumericUpDown NumAutos;
        private Label LblNumAutos;
        private TextBox TxtPrecio;
        private Label LblPrecio;
        private TextBox TxtTotal;
        private Label LblTotal;
        private FontAwesome.Sharp.IconButton BtnVender;
        private ComboBox CmbCliente;
        private ErrorProvider ErrorP;
    }
}