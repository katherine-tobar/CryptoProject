using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecryptionAlgorithm
{
    public partial class Form1 : Form
    {
        static String xml = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void getRSAkeys()
        {
            RSA rsa = RSA.Create();
            RSAParameters rsaKeyInfo = rsa.ExportParameters(true);
            xml = rsa.ToXmlString(true);
            txtClavePrivada.Text = Convert.ToBase64String(rsaKeyInfo.D);
            txtClavePublica.Text = Convert.ToBase64String(rsaKeyInfo.Modulus);
        }

        public void decriptRSA()
        {
            Form2 formResponse = new Form2();

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xml);
            RSAParameters key = rsa.ExportParameters(true);
            byte[] text = Convert.FromBase64String(txtTextoImportado.Text);
            byte[] resultado = new RSAAlgorithm().RSADecrypt(text, key, false);
            formResponse.txtTextoDesencriptado.Text = Encoding.Default.GetString(resultado);
            formResponse.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnImportKeys_Click(object sender, EventArgs e)
        {
            XMLProcessor import = new XMLProcessor();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "XML-File | *.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fileDialog.FileName);
                if (cmbAlgoritmos.SelectedIndex == 0)
                {
                    String[] data = import.GetRSAValues(import.ImportXML(fileDialog.FileName));
                    xml = data[2];
                    txtClavePrivada.Text = data[1];
                    txtClavePublica.Text = data[0];
                }
                else if (cmbAlgoritmos.SelectedIndex == -1) {
                    MessageBox.Show("Selecciona el tipo de algoritmo");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtImportText_Click(object sender, EventArgs e)
        {
            OpenFileDialog save = new OpenFileDialog();
            save.Filter = "Text-File | *.txt";
            string textImported = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(save.FileName);
                if (cmbAlgoritmos.SelectedIndex == 0)
                {
                    byte[] textAsBytes = Convert.FromBase64String(text);
                    textImported = Encoding.UTF8.GetString(textAsBytes);
                }
                else if (cmbAlgoritmos.SelectedIndex == -1) {
                    MessageBox.Show("Selecciona el tipo de algoritmo");
                }
                txtTextoImportado.Text = textImported;
            }
        }

        private void btnDesecnriptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbAlgoritmos.SelectedIndex == 0)
                {
                    decriptRSA();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor revisar los datos ingresados");
            }
        }
    }
}
