using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autohaladas
{
    public delegate void Halad(int megtett);
    public class auto
    {
        
        public event Halad fele;
        public event Halad kifogy;

        public double Üzemagyagszint {  get; set; }
        public int MaxÜzemanyag {get; set; }

        public int MegTettUt {  get; set; }

        public double Fogyasztas {  get; set; }

        public bool jelzes = false;

        public void Haladas(int km)
        {
            MegTettUt += km;
            Üzemagyagszint -= (km/100)*Fogyasztas;

            if (Üzemagyagszint <= MaxÜzemanyag / 2)
            {

                fele?.Invoke(MegTettUt);
                jelzes = true;

            }
            if (Üzemagyagszint == 0)
            {
                kifogy?.Invoke(MegTettUt);
                jelzes = true;
            }
            

        }
    }
}
