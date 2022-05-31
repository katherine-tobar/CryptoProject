
namespace DecryptionAlgorithm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextoDesencriptado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto desencriptado:";
            // 
            // txtTextoDesencriptado
            // 
            this.txtTextoDesencriptado.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtTextoDesencriptado.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoDesencriptado.ForeColor = System.Drawing.Color.Black;
            this.txtTextoDesencriptado.Location = new System.Drawing.Point(83, 87);
            this.txtTextoDesencriptado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTextoDesencriptado.Multiline = true;
            this.txtTextoDesencriptado.Name = "txtTextoDesencriptado";
            this.txtTextoDesencriptado.Size = new System.Drawing.Size(637, 129);
            this.txtTextoDesencriptado.TabIndex = 7;
            this.txtTextoDesencriptado.UseWaitCursor = true;
            this.txtTextoDesencriptado.TextChanged += new System.EventHandler(this.txtTextoDesencriptado_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.txtTextoDesencriptado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "TEXTO DESENCRIPTADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTextoDesencriptado;
    }
}