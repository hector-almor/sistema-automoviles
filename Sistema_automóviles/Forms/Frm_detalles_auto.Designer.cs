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
            Titulo = new Label();
            TxtMarca = new TextBox();
            TxtModelo = new TextBox();
            TxtID = new TextBox();
            TxtAño = new TextBox();
            TxtExistencia = new TextBox();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(317, 19);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(97, 20);
            Titulo.TabIndex = 0;
            Titulo.Text = "Detalles auto";
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(137, 137);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(186, 27);
            TxtMarca.TabIndex = 2;
            TxtMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(137, 194);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(186, 27);
            TxtModelo.TabIndex = 3;
            TxtModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(137, 83);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(186, 27);
            TxtID.TabIndex = 1;
            TxtID.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtAño
            // 
            TxtAño.Location = new Point(137, 248);
            TxtAño.Name = "TxtAño";
            TxtAño.Size = new Size(186, 27);
            TxtAño.TabIndex = 4;
            TxtAño.TextAlign = HorizontalAlignment.Center;
            TxtAño.TextChanged += ValidarNumeros;
            // 
            // TxtExistencia
            // 
            TxtExistencia.Location = new Point(137, 308);
            TxtExistencia.Name = "TxtExistencia";
            TxtExistencia.Size = new Size(186, 27);
            TxtExistencia.TabIndex = 5;
            TxtExistencia.TextAlign = HorizontalAlignment.Center;
            TxtExistencia.TextChanged += ValidarNumeros;
            // 
            // Frm_detalles_auto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(TxtExistencia);
            Controls.Add(TxtAño);
            Controls.Add(TxtID);
            Controls.Add(TxtModelo);
            Controls.Add(TxtMarca);
            Controls.Add(Titulo);
            Name = "Frm_detalles_auto";
            Load += Frm_detalles_auto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private TextBox TxtMarca;
        private TextBox TxtModelo;
        private TextBox TxtID;
        private TextBox TxtAño;
        private TextBox TxtExistencia;
    }
}