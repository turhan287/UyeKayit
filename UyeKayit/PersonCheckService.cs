using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UyeKayit.PersonCheck;
using System.Windows.Forms;

namespace UyeKayit
{
    public class PersonCheckService
    {
        public void Control(string NationalityNo, string Name, string LastName, string Year)
        {
            
            PersonCheck.KPSPublicSoapClient client = new PersonCheck.KPSPublicSoapClient();

            bool durum = client.TCKimlikNoDogrula(Convert.ToInt64(NationalityNo), Name,LastName, Convert.ToInt32(Year));
            if (durum)
            {
                MessageBox.Show("Kayıt Yapıldı.");
            }
            else
            {
                MessageBox.Show("Geçersiz Kişi");
            }

        }
    }
}
