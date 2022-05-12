
namespace RendimentoVeicular.View
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.tbxKM = new System.Windows.Forms.TextBox();
            this.tbxLitros = new System.Windows.Forms.TextBox();
            this.lblRendimentoResultado = new System.Windows.Forms.Label();
            this.lblConsumoResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Artifakt Element", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(97, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo de Combustível";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKM.Location = new System.Drawing.Point(49, 153);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(34, 20);
            this.lblKM.TabIndex = 1;
            this.lblKM.Text = "KM:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLitros.Location = new System.Drawing.Point(38, 215);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(45, 20);
            this.lblLitros.TabIndex = 2;
            this.lblLitros.Text = "&Litros";
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRendimento.Location = new System.Drawing.Point(310, 134);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(168, 20);
            this.lblRendimento.TabIndex = 3;
            this.lblRendimento.Text = "Rendimento - Km/Litros";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConsumo.Location = new System.Drawing.Point(310, 195);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(157, 20);
            this.lblConsumo.TabIndex = 4;
            this.lblConsumo.Text = "Consumo - Litros / Km";
            // 
            // tbxKM
            // 
            this.tbxKM.Location = new System.Drawing.Point(89, 154);
            this.tbxKM.Name = "tbxKM";
            this.tbxKM.Size = new System.Drawing.Size(226, 23);
            this.tbxKM.TabIndex = 5;
            // 
            // tbxLitros
            // 
            this.tbxLitros.Location = new System.Drawing.Point(89, 215);
            this.tbxLitros.Name = "tbxLitros";
            this.tbxLitros.Size = new System.Drawing.Size(226, 23);
            this.tbxLitros.TabIndex = 6;
            // 
            // lblRendimentoResultado
            // 
            this.lblRendimentoResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRendimentoResultado.Location = new System.Drawing.Point(321, 154);
            this.lblRendimentoResultado.Name = "lblRendimentoResultado";
            this.lblRendimentoResultado.Size = new System.Drawing.Size(150, 23);
            this.lblRendimentoResultado.TabIndex = 7;
            this.lblRendimentoResultado.Tag = "1";
            // 
            // lblConsumoResultado
            // 
            this.lblConsumoResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConsumoResultado.Location = new System.Drawing.Point(321, 215);
            this.lblConsumoResultado.Name = "lblConsumoResultado";
            this.lblConsumoResultado.Size = new System.Drawing.Size(150, 23);
            this.lblConsumoResultado.TabIndex = 8;
            this.lblConsumoResultado.Tag = "1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(177, 290);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(173, 55);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(548, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblConsumoResultado);
            this.Controls.Add(this.lblRendimentoResultado);
            this.Controls.Add(this.tbxLitros);
            this.Controls.Add(this.tbxKM);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Consumo de Combustível";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaPrincipal_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox tbxKM;
        private System.Windows.Forms.TextBox tbxLitros;
        private System.Windows.Forms.Label lblRendimentoResultado;
        private System.Windows.Forms.Label lblConsumoResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}