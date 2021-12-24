using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TAKIM_ULKE
{
    internal partial class AdderForm : Form
    {
        private Thread th;
        private static string filePath = @"C:\temp\data.txt";
        private List<string> output = new List<string>();
        internal AdderForm()
        {
            InitializeComponent();
            LoadUlke();
        }
        private void LoadUlke()
        {
            foreach (var item in Storage.takimlar.GetEnumeratorUlke())      //Ülkeleri listele
                ulkeComboBoxAdder.Items.Add(item);
        }
        private void Reload()
        {
            ulkeComboBoxAdder.Items.Clear();                          //
            ulkeComboBoxAdder.Text = "";                             //
            takimComboBoxAdder.Items.Clear();                       //  Temizlik
            takimComboBoxAdder.Text = "";                          //
            kurulusTextBoxAdder.Text = "";                        //
            LoadUlke();
        }
        private void takimEkleButtonAdder_Click(object sender, EventArgs e)
        {
            if (kurulusTextBoxAdder.Text != "" && takimComboBoxAdder.Text != "" && ulkeComboBoxAdder.Text != "")   //veri girildiyse yap
            {
                if (!Storage.takimlar.hasTakim(takimComboBoxAdder.Text) || !Storage.takimlar.hasUlke(ulkeComboBoxAdder.Text))    //yeni takım ya da ülke ise
                    Storage.takimlar.Add(kurulusTextBoxAdder.Text, takimComboBoxAdder.Text, ulkeComboBoxAdder.Text);             //Ekle

                else if (Storage.takimlar.hasTakim(takimComboBoxAdder.Text))                          //daha önce bir tarih girildiyse değiştirecek
                    Storage.takimlar.FindNodeTakim(takimComboBoxAdder.Text).tarih = kurulusTextBoxAdder.Text;

                Reload();
            }
            else
                MessageBox.Show("Bütün verileri girilmeden takım eklenemez !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ulkeComboBoxAdder_SelectedIndexChanged(object sender, EventArgs e)
        {
            takimComboBoxAdder.Text = "";                             //
            kurulusTextBoxAdder.Text = "";                           // temizlik
            takimComboBoxAdder.Items.Clear();                       //
            foreach (var item in Storage.takimlar.GetEnumeratorTakim(ulkeComboBoxAdder.Text))        //aynı ülkenin takımlarını listele
                takimComboBoxAdder.Items.Add(item);
        }
        private void takimComboBoxAdder_SelectedIndexChanged(object sender, EventArgs e)
        {
            kurulusTextBoxAdder.Text = "";                          //temizlik
            kurulusTextBoxAdder.Text = Storage.takimlar.FindNodeTakim(takimComboBoxAdder.Text).tarih;
        }
        private void AdderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (string item in Storage.takimlar.GetEnumerator()) //Olan biten "takımlar"da yapıldıktan sonra son halini
                output.Add(item);                                    //output listesine aktarıyor
            File.WriteAllLines(filePath, output);                   //output listesindekileri data.txt dosyasına yazdırıyor
        }
        
        private void openMain() => Application.Run(new MainForm());
        private void backButton_Click(object sender, EventArgs e)//Geri butonu
        {
            this.Close();                           //bu formu kapat
            th = new Thread(openMain);                                  //
            th.SetApartmentState(ApartmentState.STA);                  //  MainForm'u başlat
            th.Start();                                               //
        }
    }
}