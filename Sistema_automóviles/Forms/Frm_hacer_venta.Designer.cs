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
            label1 = new Label();
            PicBox = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)NumAutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            SuspendLayout();
            // 
            // LblAuto
            // 
            LblAuto.AutoSize = true;
            LblAuto.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblAuto.Location = new Point(263, 55);
            LblAuto.Name = "LblAuto";
            LblAuto.Size = new Size(60, 15);
            LblAuto.TabIndex = 0;
            LblAuto.Text = "ID_auto";
            // 
            // ID_cliente
            // 
            ID_cliente.AutoSize = true;
            ID_cliente.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ID_cliente.Location = new Point(147, 94);
            ID_cliente.Name = "ID_cliente";
            ID_cliente.Size = new Size(80, 15);
            ID_cliente.TabIndex = 0;
            ID_cliente.Text = "ID_cliente:";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(237, 140);
            TxtDescripcion.Margin = new Padding(3, 2, 3, 2);
            TxtDescripcion.MaxLength = 200;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(503, 23);
            TxtDescripcion.TabIndex = 3;
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblDescripcion.Location = new Point(98, 143);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(93, 15);
            LblDescripcion.TabIndex = 0;
            LblDescripcion.Text = "Descripción:";
            // 
            // NumAutos
            // 
            NumAutos.Location = new Point(237, 183);
            NumAutos.Margin = new Padding(3, 2, 3, 2);
            NumAutos.Name = "NumAutos";
            NumAutos.Size = new Size(65, 23);
            NumAutos.TabIndex = 4;
            NumAutos.TextAlign = HorizontalAlignment.Center;
            NumAutos.ValueChanged += NumAutos_ValueChanged;
            // 
            // LblNumAutos
            // 
            LblNumAutos.AutoSize = true;
            LblNumAutos.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblNumAutos.Location = new Point(98, 188);
            LblNumAutos.Name = "LblNumAutos";
            LblNumAutos.Size = new Size(124, 15);
            LblNumAutos.TabIndex = 0;
            LblNumAutos.Text = "Número de autos:";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Enabled = false;
            TxtPrecio.Location = new Point(237, 223);
            TxtPrecio.Margin = new Padding(3, 2, 3, 2);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(197, 23);
            TxtPrecio.TabIndex = 5;
            TxtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblPrecio.Location = new Point(98, 225);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(55, 15);
            LblPrecio.TabIndex = 0;
            LblPrecio.Text = "Precio:";
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(237, 261);
            TxtTotal.Margin = new Padding(3, 2, 3, 2);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(197, 23);
            TxtTotal.TabIndex = 6;
            TxtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblTotal.Location = new Point(98, 263);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(47, 15);
            LblTotal.TabIndex = 0;
            LblTotal.Text = "Total:";
            // 
            // BtnVender
            // 
            BtnVender.BackColor = Color.FromArgb(128, 136, 54);
            BtnVender.FlatStyle = FlatStyle.Flat;
            BtnVender.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnVender.IconColor = Color.White;
            BtnVender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVender.Location = new Point(98, 310);
            BtnVender.Margin = new Padding(3, 2, 3, 2);
            BtnVender.Name = "BtnVender";
            BtnVender.Size = new Size(129, 48);
            BtnVender.TabIndex = 7;
            BtnVender.UseVisualStyleBackColor = false;
            BtnVender.Click += BtnVender_Click;
            // 
            // CmbCliente
            // 
            CmbCliente.BackColor = SystemColors.Window;
            CmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCliente.FormattingEnabled = true;
            CmbCliente.Location = new Point(237, 94);
            CmbCliente.Margin = new Padding(3, 2, 3, 2);
            CmbCliente.Name = "CmbCliente";
            CmbCliente.Size = new Size(295, 23);
            CmbCliente.TabIndex = 8;
            // 
            // ErrorP
            // 
            ErrorP.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(42, 44, 65);
            label1.Location = new Point(263, 13);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 9;
            label1.Text = "REALIZAR VENTA";
            label1.Click += label1_Click;
            // 
            // PicBox
            // 
            PicBox.BackColor = SystemColors.Control;
            PicBox.ForeColor = Color.FromArgb(224, 224, 224);
            PicBox.IconChar = FontAwesome.Sharp.IconChar.None;
            PicBox.IconColor = Color.FromArgb(224, 224, 224);
            PicBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PicBox.IconSize = 151;
            PicBox.Location = new Point(454, 183);
            PicBox.Margin = new Padding(3, 2, 3, 2);
            PicBox.Name = "PicBox";
            PicBox.Size = new Size(286, 151);
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox.TabIndex = 10;
            PicBox.TabStop = false;
            // 
            // Frm_hacer_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 385);
            Controls.Add(PicBox);
            Controls.Add(label1);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_hacer_venta";
            Load += Frm_hacer_venta_Load;
            ((System.ComponentModel.ISupportInitialize)NumAutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox PicBox;
    }
}