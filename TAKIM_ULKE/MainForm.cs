using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace TAKIM_ULKE
{// Veri Yapıları ve Algoritmalar :::: depolama: txt
    internal partial class MainForm : Form
    {
        private static string filePath = @"C:\temp\data.txt";
        private List<string> lines = new List<string>();
        private List<string> output = new List<string>();
        private Thread th;
        internal MainForm()
        {
            InitializeComponent();
            
            if (!File.Exists(filePath))               //Aradığım dosya yoksa
            {
                Directory.CreateDirectory(@"C:\temp");               //klosörleri oluştur
                using (FileStream fs = File.Create(filePath)) { }   //data.txt oluştur
            }
            else
                lines = File.ReadAllLines(filePath).ToList();        //data.txt içindeki her bir satır liste olarak kaydediliyor.
            foreach (string line in lines)  //Her bir satır için
            {
                string[] entries = line.Split(',');                               //string ifadeyi virgülleri kullanarak tarihi, takımı ve ülkeyi ayıkla
                if (!Storage.takimlar.hasTakim(entries[1]))                      //Sadece daha önce eklenmemiş verileri
                    Storage.takimlar.Add(entries[0], entries[1], entries[2]);   //Takımlar listesine ekle
            }
            LoadUlke();
        }
        void openAdder() => Application.Run(new AdderForm());
        private void takimEkleButton_Click(object sender, EventArgs e)
        {
            this.Close();                           //bu formu kapat
            th = new Thread(openAdder);                                 //
            th.SetApartmentState(ApartmentState.STA);                  //  AdderForm'u başlat
            th.Start();                                               //            
        }
        private void LoadUlke()
        {
            foreach (var item in Storage.takimlar.GetEnumeratorUlke())      //Ülkeleri listele
                ulkeComboBox.Items.Add(item);
        }
        internal void Reload()
        {
            ulkeComboBox.Items.Clear();               //
            ulkeComboBox.Text = "";                  //
            takimComboBox.Items.Clear();            //  Temizlik
            takimComboBox.Text = "";               //
            kurulusLabel.Text = "";               //
            LoadUlke();                  
        }
        private void ulkeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            takimComboBox.Text = "";           //
            kurulusLabel.Text = "";           //   Temizlik
            takimComboBox.Items.Clear();     //
            foreach (var item in Storage.takimlar.GetEnumeratorTakim(ulkeComboBox.Text)) //Aynı ülkeye mensup bütün takımları
                takimComboBox.Items.Add(item);                                          //takım Combobox'ına ekle
        }
        private void takimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kurulusLabel.Text = "";                          //temizlik
            kurulusLabel.Text = Storage.takimlar.FindNodeTakim(takimComboBox.Text).tarih; //ilgili takımın tarihini ekrana yazdırır.
        }
        private void takimCikarButton_Click(object sender, EventArgs e)
        {
            if (takimComboBox.Text != "") //belirli takımı siler
                Storage.takimlar.Remove(takimComboBox.Text);

            else //bütün bir ülkenin tüm takımlarını siler
                foreach(var item in Storage.takimlar.GetEnumeratorNodeUlke(ulkeComboBox.Text))
                    Storage.takimlar.Remove(item.takim);

            Reload();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (string item in Storage.takimlar.GetEnumerator()) //Olan biten "takımlar"da yapıldıktan sonra son halini
                output.Add(item);                                    //output listesine aktarıyor
            File.WriteAllLines(filePath, output);                   //output listesindekileri data.txt dosyasına yazdırıyor.
        }
    }
}