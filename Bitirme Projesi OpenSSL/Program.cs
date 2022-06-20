using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitirme_Projesi_OpenSSL
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        /// /// 
        /// Oğuzhan BAL ve Hakkı BOZOK Bitirme Projesi Ödevi.
        /// @\White Corp./@ //yazılım donanım ve siber güvenlik....
        /// instagaram: @_white024
        /// telefon: 545 336 28 31
        /// mail: han.oguz2002@gmail.com
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Random_SSL_Generator());
        }
    }
}
