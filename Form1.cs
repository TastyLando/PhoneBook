using System.Collections;

namespace phonebook
{
    public partial class Form1 : Form
    {
        ArrayList _al_adsoyad;
        ArrayList _al_tel;

        int durum;
        public Form1()
        {
            InitializeComponent();
            _al_adsoyad = new ArrayList();
            _al_tel = new ArrayList();
            _al_adsoyad.Add("Ali Gültekin");
            _al_adsoyad.Add("Feyyaz Uçar");
            _al_adsoyad.Add("Metin Tekin");
            _al_tel.Add("10");
            _al_tel.Add("7");
            _al_tel.Add("11");
            listbox_Guncelle();

            btn_Kaydet.Enabled = false;
            txt_AdSoyad.ReadOnly = true;
            txt_Tel.ReadOnly = true;

        }
        private void listbox_Guncelle()
        {
            listbox_AdSoyad.Items.Clear();
            foreach (string item in _al_adsoyad)
            {
                listbox_AdSoyad.Items.Add(item);
            }
        }

        private void GoruntuDegistir()
        {
            btn_Kaydet.Enabled = !btn_Kaydet.Enabled;
            btn_Ekle.Enabled = !btn_Ekle.Enabled;
            btn_Duzelt.Enabled = !btn_Duzelt.Enabled;
            btn_Sil.Enabled = !btn_Sil.Enabled;
            txt_AdSoyad.ReadOnly = !txt_AdSoyad.ReadOnly;
            txt_Tel.ReadOnly = !txt_Tel.ReadOnly;
        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            txt_AdSoyad.Text = "";
            txt_Tel.Text = "";
            durum = 1;

            GoruntuDegistir();

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_AdSoyad.Text == "" || txt_Tel.Text == "")
                MessageBox.Show("Boþ deðer girilemez...");
            else
            {
                if (durum == 1)
                {
                    _al_adsoyad.Add(txt_AdSoyad.Text);
                    _al_tel.Add(txt_Tel.Text);
                }
                else
                {
                    int ind = listbox_AdSoyad.SelectedIndex;
                    _al_adsoyad[ind] = txt_AdSoyad.Text;
                    _al_tel[ind] = txt_Tel.Text;
                }


                GoruntuDegistir();
                listbox_Guncelle();
            }

        }

        private void listbox_AdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = listbox_AdSoyad.SelectedIndex;
            if (ind != -1)
            {
                txt_AdSoyad.Text = (string)_al_adsoyad[ind];
                txt_Tel.Text = (string)_al_tel[ind];
            }
            else
            {
                txt_AdSoyad.Text = "";
                txt_Tel.Text = "";

            }

        }

        private void btn_Duzelt_Click(object sender, EventArgs e)
        {
            int ind = listbox_AdSoyad.SelectedIndex;
            if (ind >= 0)
            {
                GoruntuDegistir();
                durum = 2;
            }
            else
                MessageBox.Show("Lütfen yandan bir seçim yapýn...");

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int ind = listbox_AdSoyad.SelectedIndex;
            if (ind >= 0)
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediðinize emin misiniz?",
                    "Silme Ýþlemi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    _al_adsoyad.RemoveAt(ind);
                    _al_tel.RemoveAt(ind);
                    listbox_Guncelle();
                }
            }
            else
                MessageBox.Show("Lütfen yandan bir seçim yapýn...");

        }
    }
}
