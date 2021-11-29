using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EncapsulationOrnekk
{
    class Daire
    {
        #region Özellikler
        public double Yaricap { get; set; }
        private double _cap = 0;

        public double Cap
        {
            get
            {
                if (Yaricap >0d)
                {
                    _cap = Yaricap * 2;
                }
                return _cap;
            }
            set
            {

            }
        }
        public double PiSayisi { get; set; }

        #endregion 

        #region Constructorlar Yani Yapıcı Metotlar

        public Daire()
        {
            PiSayisi = 3;
        }

        public Daire(double DisardanAlinanPiSayisi)
        {
            PiSayisi = DisardanAlinanPiSayisi;
        }
        #endregion

        #region  Metotlar
        public void AlanHesapla()
        {
            double sonuc = PiSayisi * Math.Pow(Yaricap, 2);
            Console.WriteLine("Alan= "+sonuc .ToString ("0.00"));
        }

        public void CevreHesapla() 
        {
            double sonuc = 2 * PiSayisi * Yaricap;
            Console.WriteLine("Çevre= "+sonuc.ToString ("0.00"));
        }
        #endregion 

        
    }
}
