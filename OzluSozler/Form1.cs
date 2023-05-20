namespace OzluSozler
{
    public partial class Form1 : Form
    {
        List<OzluSoz> sozler = OrnekVeri.Getir();

        public Form1()
        {
            InitializeComponent();
            VerileriListele();
        }

        private void VerileriListele()
        {
            string ara = txtAra.Text;
            lstSozler.Items.Clear();
            foreach (OzluSoz soz in sozler)
            {
                if (soz.Soz.Contains(ara, StringComparison.CurrentCultureIgnoreCase) || soz.Yazar.Contains(ara, StringComparison.CurrentCultureIgnoreCase))
                    lstSozler.Items.Add(soz);

            }


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OzluSoz ozluSoz = new OzluSoz();
            ozluSoz.Soz = txtSoz.Text;
            ozluSoz.Yazar = txtYazar.Text;
            ozluSoz.Derece = (int)nudDerece.Value;
            sozler.Add(ozluSoz);
            VerileriListele();


            txtSoz.Clear();
            txtYazar.Clear();
            nudDerece.Value = 1;

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstSozler.SelectedItems != null)
            {
                OzluSoz soz = (OzluSoz)lstSozler.SelectedItem;
                sozler.Remove(soz);
                VerileriListele();
            }
        }
    }
}