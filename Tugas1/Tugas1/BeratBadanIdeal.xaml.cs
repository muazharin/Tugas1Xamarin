using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Tugas1
{
    public partial class BeratBadanIdeal : ContentPage
    {
        public BeratBadanIdeal()
        {
            InitializeComponent();

            btnBeratIdealLk.Clicked += BtnBerat_Clicked;
            btnBeratIdealPr.Clicked += BtnBerat_Clicked;
        }
        
        private void BtnBerat_Clicked(object sender, EventArgs e)
        {
            double berat = 0, nilai = 0, kesimpulan = 0;
            double b = Convert.ToDouble(entryBerat.Text);
            double t = Convert.ToDouble(entryTinggi.Text);
            var myBtn = (Button)sender;
            switch (myBtn.Text)
            {
                case "HITUNG BERAT BADAN IDEAL LAKI-LAKI":
                    {
                        berat = ((t - 100) - (0.1 * (t - 100)));
                        nilai = b / ((t / 100) * (t / 100));
                        if (nilai < 17)
                        {
                            entryKesimpulan.Text = kesimpulan.ToString("Kurus ( < 17 kg)");
                        }else if(nilai>=17 && nilai < 23)
                        {
                            entryKesimpulan.Text = kesimpulan.ToString("Normal (17 - 23 kg)");
                        }else if(nilai>=23 && nilai < 27)
                        {
                            entryKesimpulan.Text = kesimpulan.ToString("Kegemukan (23 - 27 kg)");
                        }
                        else
                        {
                            entryKesimpulan.Text = kesimpulan.ToString("Obesitas ( > 27 kg)");
                        }
                        break;
                    }
                case "HITUNG BERAT BADAN IDEAL PEREMPUAN":
                    {
                        berat = ((t - 100) - (0.15 * (t - 100)));
                        nilai = b / ((t / 100) * (t / 100));
                        if (nilai < 18)
                        {
                            entryKesimpulan.Text = kesimpulan.ToString("Kurus ( < 18 kg)");
                        }
                        else if (nilai >= 18 && nilai < 25)
                        {
                            entryKesimpulan.Text = kesimpulan.ToString("Normal (18 - 25 kg)");
                        }
                        else if (nilai >= 25 && nilai < 27)
                        {
                            entryKesimpulan.Text = kesimpulan.ToString("Kegemukan (25 - 27 kg)");
                        }
                        else
                        {
                            entryKesimpulan.Text = kesimpulan.ToString("Obesitas ( > 27 kg)");
                        }
                        break;
                    }
            }
            entryBeratBadanIdeal.Text = ((int)berat).ToString();    //nilai diubah menjadi int jika nilainya 12.5 maka nilai int-nya adalah 12
            entryNilai.Text = Convert.ToInt16(nilai).ToString();    //nilai diubah menjadi int juga tetapi jika nilainya 12.5 maka nilai int-nya adalah 13
        }    
    }
}
