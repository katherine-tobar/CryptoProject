
namespace DecryptionAlgorithm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlgoritmos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtImportText = new System.Windows.Forms.Button();
            this.btnDesecnriptar = new System.Windows.Forms.Button();
            this.txtTextoImportado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClavePrivada = new System.Windows.Forms.TextBox();
            this.txtClavePublica = new System.Windows.Forms.TextBox();
            this.btnImportKeys = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione algoritmo:";
            this.label1.UseWaitCursor = true;
            // 
            // cmbAlgoritmos
            // 
            this.cmbAlgoritmos.BackColor = System.Drawing.Color.LightSlateGray;
            this.cmbAlgoritmos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmos.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlgoritmos.FormattingEnabled = true;
            this.cmbAlgoritmos.IntegralHeight = false;
            this.cmbAlgoritmos.ItemHeight = 13;
            this.cmbAlgoritmos.Items.AddRange(new object[] {
            "RSA"});
            this.cmbAlgoritmos.Location = new System.Drawing.Point(277, 21);
            this.cmbAlgoritmos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAlgoritmos.Name = "cmbAlgoritmos";
            this.cmbAlgoritmos.Size = new System.Drawing.Size(139, 21);
            this.cmbAlgoritmos.TabIndex = 1;
            this.cmbAlgoritmos.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtImportText);
            this.panel1.Controls.Add(this.btnDesecnriptar);
            this.panel1.Controls.Add(this.txtTextoImportado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtClavePrivada);
            this.panel1.Controls.Add(this.txtClavePublica);
            this.panel1.Location = new System.Drawing.Point(43, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 421);
            this.panel1.TabIndex = 2;
            this.panel1.UseWaitCursor = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtImportText
            // 
            this.txtImportText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtImportText.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportText.ForeColor = System.Drawing.Color.Black;
            this.txtImportText.Location = new System.Drawing.Point(17, 251);
            this.txtImportText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImportText.Name = "txtImportText";
            this.txtImportText.Size = new System.Drawing.Size(138, 22);
            this.txtImportText.TabIndex = 4;
            this.txtImportText.Text = "Importar texto";
            this.txtImportText.UseVisualStyleBackColor = true;
            this.txtImportText.UseWaitCursor = true;
            this.txtImportText.Click += new System.EventHandler(this.txtImportText_Click);
            // 
            // btnDesecnriptar
            // 
            this.btnDesecnriptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesecnriptar.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesecnriptar.ForeColor = System.Drawing.Color.Black;
            this.btnDesecnriptar.Location = new System.Drawing.Point(516, 380);
            this.btnDesecnriptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesecnriptar.Name = "btnDesecnriptar";
            this.btnDesecnriptar.Size = new System.Drawing.Size(138, 22);
            this.btnDesecnriptar.TabIndex = 4;
            this.btnDesecnriptar.Text = "Desencriptar";
            this.btnDesecnriptar.UseVisualStyleBackColor = true;
            this.btnDesecnriptar.UseWaitCursor = true;
            this.btnDesecnriptar.Click += new System.EventHandler(this.btnDesecnriptar_Click_1);
            // 
            // txtTextoImportado
            // 
            this.txtTextoImportado.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtTextoImportado.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoImportado.ForeColor = System.Drawing.Color.Black;
            this.txtTextoImportado.Location = new System.Drawing.Point(17, 320);
            this.txtTextoImportado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTextoImportado.Multiline = true;
            this.txtTextoImportado.Name = "txtTextoImportado";
            this.txtTextoImportado.Size = new System.Drawing.Size(637, 52);
            this.txtTextoImportado.TabIndex = 6;
            this.txtTextoImportado.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Texto a desencriptar";
            this.label4.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(349, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave privada";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clave pública";
            this.label3.UseWaitCursor = true;
            // 
            // txtClavePrivada
            // 
            this.txtClavePrivada.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtClavePrivada.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClavePrivada.ForeColor = System.Drawing.Color.Black;
            this.txtClavePrivada.Location = new System.Drawing.Point(352, 49);
            this.txtClavePrivada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClavePrivada.MaxLength = 2147483647;
            this.txtClavePrivada.Multiline = true;
            this.txtClavePrivada.Name = "txtClavePrivada";
            this.txtClavePrivada.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtClavePrivada.Size = new System.Drawing.Size(306, 181);
            this.txtClavePrivada.TabIndex = 1;
            this.txtClavePrivada.UseWaitCursor = true;
            // 
            // txtClavePublica
            // 
            this.txtClavePublica.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtClavePublica.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClavePublica.ForeColor = System.Drawing.Color.Black;
            this.txtClavePublica.Location = new System.Drawing.Point(17, 49);
            this.txtClavePublica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClavePublica.MaxLength = 2147483647;
            this.txtClavePublica.Multiline = true;
            this.txtClavePublica.Name = "txtClavePublica";
            this.txtClavePublica.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtClavePublica.Size = new System.Drawing.Size(329, 181);
            this.txtClavePublica.TabIndex = 0;
            this.txtClavePublica.UseWaitCursor = true;
            this.txtClavePublica.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnImportKeys
            // 
            this.btnImportKeys.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportKeys.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportKeys.ForeColor = System.Drawing.Color.Black;
            this.btnImportKeys.Location = new System.Drawing.Point(449, 20);
            this.btnImportKeys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportKeys.Name = "btnImportKeys";
            this.btnImportKeys.Size = new System.Drawing.Size(138, 22);
            this.btnImportKeys.TabIndex = 3;
            this.btnImportKeys.Text = "Importar llaves";
            this.btnImportKeys.UseVisualStyleBackColor = true;
            this.btnImportKeys.UseWaitCursor = true;
            this.btnImportKeys.Click += new System.EventHandler(this.btnImportKeys_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(760, 486);
            this.Controls.Add(this.btnImportKeys);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbAlgoritmos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DESENCRIPTACIÓN DE FICHEROS DE TEXTO";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlgoritmos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClavePublica;
        private System.Windows.Forms.Button btnDesecnriptar;
        private System.Windows.Forms.TextBox txtTextoImportado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClavePrivada;
        private System.Windows.Forms.Button btnImportKeys;
        private System.Windows.Forms.Button txtImportText;
    }
}

