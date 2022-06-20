using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;
using System.Dynamic;
using System.Windows.Forms;

namespace Bitirme_Projesi_OpenSSL
{
    internal class RSA_key
    { 
        public static CryptoKey CreateNewRsaKey(int numberOfBits)
        {
            var rsa = new RSA();
            BigNumber exponent = 0x10001; // this needs to be a prime number
            rsa.GenerateKeys(numberOfBits, exponent, null, null);

            return new CryptoKey(rsa);

        }
        public static void WriteCert(X509Certificate cert, string adress0)
        {
            FileStream YazmaStream0 = new FileStream(Path.GetFileNameWithoutExtension(adress0), FileMode.Create, FileAccess.ReadWrite);
            YazmaStream0.Close();

            using (var biocert = BIO.File(adress0, "w"))
            {
                cert.Write(biocert);
            }
        }
        public static void WriteCert(X509CertificateAuthority cert, string adress1)
        {
            FileStream YazmaStream1 = new FileStream(Path.GetFileNameWithoutExtension(adress1), FileMode.Create, FileAccess.ReadWrite);
            YazmaStream1.Close();

            using (var biocert = BIO.File(adress1, "w"))
            {
                cert.Certificate.Write(biocert);
            }
        }

        public static void WriteKey(CryptoKey key, string password, string adress2)

        {
            FileStream YazmaStream2 = new FileStream(Path.GetFileNameWithoutExtension(adress2), FileMode.Create, FileAccess.ReadWrite);
            YazmaStream2.Close();

            using (var bioprivate = BIO.File(adress2, "w"))
            {
                key.WritePrivateKey(bioprivate, Cipher.DES_EDE3_CBC, password);
            }

        }
    }
}
