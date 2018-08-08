using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace oop_gyak
{
    public partial class frm_jarmuvek : Form
    {
        //Globális változók
        public int salyat;
        public int ossz;
        public int gyartas;
        public bool forgalmi;
        public int kob;
        public int szszsz;
        public string marka;

        Szgk a;

        //Main program
        public frm_jarmuvek()
        {
            InitializeComponent();
        }

        //Kilépés
        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Radio buttons
        private void rb_szgk_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton s = (RadioButton)sender; //netről néztem
            la_text1.Text = "Kategória:";

            switch (s.TabIndex)
            {
                case 1: //szgk
                    {
                        la_text2.Text = "személygépkocsi";
                        Szgk();
                        break;
                    }
                case 2: //tgk
                    {
                        la_text2.Text = "tehergépkocsi";
                        Tgk();
                        break;
                    }
                case 3: //mkp
                    {
                        la_text2.Text = "motorkerékpár";
                        Mkp();
                        break;
                    }
            }
        }

        //Személygépkocsi
        private void Szgk()
        {
            gp_szgk.Visible = true;
            int ajtok;

            //Adatok megadása
            salyat = (int)nud_st.Value;
            ossz = (int)nud_ot.Value;
            gyartas = (int)nud_gye.Value;
            if (rb_van.Checked == true)
            {
                forgalmi = true;
            }
            else
            {
                forgalmi = false;
            }
            kob = (int)nud_ccm.Value;
            szszsz = (int)nud_szszsz.Value;
            marka = tb_marka.Text;
            ajtok = (int)nud_ajtok.Value;


            a = new Szgk(salyat, ossz, gyartas, forgalmi, kob, szszsz, marka, ajtok);

            //Default értékek
            nud_st.Value = 0;
            nud_ot.Value = 0;
            nud_gye.Value = 1900;
            rb_van.Checked = true;
            rb_nincs.Checked = false;
            nud_ccm.Value = 0;
            nud_szszsz.Value = 1;
            tb_marka.Text = "";
            nud_ajtok.Value = 3;
        }

        //Tehertgépkocsi
        private void Tgk()
        {
            gp_szgk.Visible = false;
        }

        //Motorkerékpár
        private void Mkp()
        {
            gp_szgk.Visible = false;
        }





        //Semmi
        private void label6_Click(object sender, EventArgs e)
        {

        }

        //Adatok feltöltése
        private void bt_feltolt_Click(object sender, EventArgs e)
        {
            Szgk();
            bt_kiir.Enabled = true;
            MessageBox.Show("Gratulálok! Ön sikeresen létrehozta az autóját!","Kész",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Szgk adatainak kiírása
        private void bt_kiir_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("sajat_autoja.txt");

            f.WriteLine("Üdvözlöm! Alább a saját autójának adatait látja:");
            f.WriteLine(" ");

            f.WriteLine("Márka: " + a.Marka);
            f.WriteLine("Salyát tömeg: " + a.Salyattomeg);
            f.WriteLine("Össztömeg: " + a.Ossztomeg);
            f.WriteLine("Gyártás éve: " + a.Gyartas_ev);

            if (a.Ervenyes_forgalmi==true)
            {
                f.WriteLine("Érvényes forgalmi engedély: van");
            }
            else
            {
                f.WriteLine("Érvényes forgalmi engedély: nincs");
            }

            f.WriteLine("Ccm3: " + a.Ccm);
            f.WriteLine("Szállítható személyek száma: " + a.Szall_szem);
            f.WriteLine("Ajtók száma: " + a.Ajtok);


            f.Close();

            MessageBox.Show("Az autójának adatait kiírtuk egy külön fileba!","Adatok kiírása",MessageBoxButtons.OK,MessageBoxIcon.Information);

            bt_kiir.Enabled = false;
        }
    }
}
