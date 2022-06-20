using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;
using System.Dynamic;
using System.IO;

namespace Bitirme_Projesi_OpenSSL
{
    public partial class Random_SSL_Generator : Form
    {

        public Random_SSL_Generator()
        {
            InitializeComponent();            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
              
                SaveFileDialog saveFile = new SaveFileDialog();
                 if (saveFile.ShowDialog() == DialogResult.Cancel)
                    return;
                var save = saveFile.FileName;
               




                ISequenceNumber sn = new SimpleSerialNumber();

                CryptoKey key = RSA_key.CreateNewRsaKey(int.Parse(private_key.Text));
                System.Random rnd = new System.Random();
                int num = rnd.Next();
                X509Name certificateProperties = new X509Name()
                {



                    Country = country_shorts.Text,
                    Organization = organization_t.Text,
                    OrganizationUnit = organization_unit_t.Text,
                    Locality = district_t.Text,
                    StateOrProvince = city_t.Text,
                    X509 = mail_t.Text,
                    SerialNumber = num.ToString(),
                    Common = web_adress_t.Text,
                    //Surname = sn.ToString(),
                };


                var extensions = new List<OpenSSL.X509.X509V3ExtensionValue>();
                extensions.Add(new OpenSSL.X509.X509V3ExtensionValue("basicConstraints", true, "CA:TRUE"));
                extensions.Add(new OpenSSL.X509.X509V3ExtensionValue("subjectKeyIdentifier", false, "hash"));
                extensions.Add(new OpenSSL.X509.X509V3ExtensionValue("authorityKeyIdentifier", false, "keyid:always,issuer:always"));

                X509CertificateAuthority CA = X509CertificateAuthority.SelfSigned(sn, key, MessageDigest.SHA256, certificateProperties, DateTime.Now, TimeSpan.FromDays(int.Parse(gun_l.Text)), extensions);
                // Write the CA certificate and it's private key to file so that it can be re-used.
                RSA_key.WriteCert(CA, save+"CA.cer");
                RSA_key.WriteKey(key, "123456", save+"PrivateCA.key");


                //Create Signed Request
                CryptoKey key2 = RSA_key.CreateNewRsaKey(int.Parse(private_key.Text));
                X509Name certificateProperties2 = new X509Name()
                {

                    Country = country_shorts.Text,
                    Organization = organization_t.Text,
                    OrganizationUnit = organization_unit_t.Text,
                    Locality = district_t.Text,
                    StateOrProvince = city_t.Text,
                    X509 = mail_t.Text,
                    SerialNumber = num.ToString(),
                    Common = web_adress_t.Text,
                    //Given = "oguzhan"
                    //IsOwner = "cccc.bbb@aaaa.com"
                };

                X509Request request = new X509Request(10, certificateProperties2, key2);
                //string path2 = "C:/Users/Administrator/Desktop";
                string path = Path.GetFullPath("Config\\openssl.cnf");
                OpenSSL.X509.Configuration temp = new Configuration("Config\\openssl.cnf");

                var signedcert = CA.ProcessRequest(request, DateTime.UtcNow, DateTime.UtcNow.AddYears(int.Parse(yil_l.Text)), temp, "v3_ca", MessageDigest.SHA256);
                RSA_key.WriteCert(signedcert, save+".cer");
                RSA_key.WriteKey(key2, "123456", save+"Private.key");
                hata.Text = "";
                error.Text = "";
                




            }
            catch (Exception)
            {
                if (private_key.Text == "")
                {
                    error.ForeColor = Color.Red;
                    error.Text = "Hata boş bırakılamaz.";
                }
                hata.ForeColor = Color.Red;
                hata.Text =("Lütfen gerekli bilgileri giriniz...");

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Uygulamadan çıkmak ister misiniz ?", "Dikkat", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {

                this.Close();
            }
            if (cikis == DialogResult.No)
            {
               clear();
            }
        }

        public void clear_all_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            foreach (Control tbox in this.Controls)
            {
                if (tbox is TextBox)
                {
                    TextBox textclear = (TextBox)tbox;
                    private_key.Clear();
                    textclear.Clear();
                }
            }
            country_t.ResetText();
            country_t.SelectedIndexChanged -= default;
            country_shorts.ResetText();
            country_shorts.SelectedIndexChanged -= default;
            validity_t.ResetText();
            validity_t.SelectedIndexChanged -= default;
            hata.Text = "";
            error.Text = "";
        }


        private void country_t_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = 0;
            a = country_t.SelectedIndex;
            country_shorts.SelectedIndex = a;
            country_ll.Text = country_shorts.SelectedItem.ToString();
           

        }
        private void country_shorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            b = country_shorts.SelectedIndex;
            country_t.SelectedIndex = b;
            contry_s_l.Text = country_t.SelectedItem.ToString();
        }


        public void name_t_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void one_key_Click(object sender, EventArgs e)
        {
            private_key.Text = "1024";
        }

        private void two_key_Click(object sender, EventArgs e)
        {
            private_key.Text = "2048";

        }
        public void yıl()
        {
            int c = 0;
            c = validity_t.SelectedIndex;
            c++;
            yil_l.Text = c.ToString();
        }
        public void gun()
        {
            int d = 0;
            d = validity_t.SelectedIndex;
            if (d == 0)
            {
                gun_l.Text = "365";
            }
            if (d == 1)
            {
                gun_l.Text = "730";
            }
            if (d == 2)
            {
                gun_l.Text = "1095";
            }
            if (d == 3)
            {
                gun_l.Text = "1460";
            }
            if (d == 4)
            {
                gun_l.Text = "1850";
            }
        }
        private void validity_t_SelectedIndexChanged(object sender, EventArgs e)
        {
            yıl();
            gun();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
