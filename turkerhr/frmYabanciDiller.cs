/***********************************************************************
 * Copyright 2023 Turker Ozturk
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 ***********************************************************************/

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace turkerHR
{
    public partial class frmYabanciDiller : Form
    {

        string klasoryolu = Directory.GetCurrentDirectory().ToString();

        private string _turkerHRInsanID; //forma parametre alisverisi icin
        public string turkerHRInsanID
        {
            get { return _turkerHRInsanID; }
            set { _turkerHRInsanID = value; }
        } //http://www.vcskicks.com/data-between-forms.php

        private string _turkerHRIsim; //forma parametre alisverisi icin
        public string turkerHRIsim
        {
            get { return _turkerHRIsim; }
            set { _turkerHRIsim = value; }
        } //http://www.vcskicks.com/data-between-forms.php

        private string _turkerHRSoyad; //forma parametre alisverisi icin
        public string turkerHRSoyad
        {
            get { return _turkerHRSoyad; }
            set { _turkerHRSoyad = value; }
        } //http://www.vcskicks.com/data-between-forms.php


        OleDbConnection con;
        OleDbCommand objKomut;

        public frmYabanciDiller()
        {
            InitializeComponent();
        }

        private void frmYabanciDiller_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.seviye' table. You can move, or remove it, as needed.
            this.seviyeTableAdapter.Fill(this.turkerHRveritabaniDataSet2.seviye);

            label1.Text = turkerHRInsanID.ToString();
            label2.Text = turkerHRIsim.ToString() + " " + turkerHRSoyad.ToString();

            string sorgu1 = "SELECT count(*) FROM idinsanlar_idyabancidiller WHERE idinsanlar=" + turkerHRInsanID.ToString() + ";";
            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
            con = new OleDbConnection(constr);


            //bu sefer de meslek itemlerini siraya check etmeye calisacagim.
            con.Open();

            objKomut = new OleDbCommand();
            objKomut.CommandText = sorgu1;
            objKomut.Connection = con;
            int bildigiToplamMeslekSayisi = Convert.ToInt32(objKomut.ExecuteScalar());
            int[] bildigiMeslekIdleri = new int[bildigiToplamMeslekSayisi];
            //label3.Text = "toplam: " + bildigiToplamMeslekSayisi.ToString() + ". ";


            con.Close();

            con.Open();
            string sql = "SELECT idyabancidiller FROM idinsanlar_idyabancidiller WHERE idinsanlar=" + turkerHRInsanID.ToString() + ";";

            objKomut.CommandText = sql;
            OleDbDataReader sonuc;
            sonuc = objKomut.ExecuteReader();

            // while (sonuc.Read())
            for (int k = 0; k < bildigiToplamMeslekSayisi; k++)
            {
                sonuc.Read();
                //label3.Text += " " + sonuc["idpozisyonlar"].ToString();
                bildigiMeslekIdleri[k] = Convert.ToInt32(sonuc["idyabancidiller"]) - 1; // - 1 koydum çünkü koymazsam bir checkbox ileridekini seçiyor. düzeltmek maksadıyla.

            }

            con.Close();

            // http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DoarowcountusingSqlCommand.htm

            con.Open();
            string sorgu2 = "SELECT count(*) FROM tblYabanciDil;";
            objKomut.CommandText = sorgu2;
            int mesleksayisi = Convert.ToInt32(objKomut.ExecuteScalar());

            //MessageBox.Show(boxes.Length.ToString());
            //bu checkboxların
            string sorgu3 = "SELECT id, dil FROM tblYabanciDil;";
            objKomut.CommandText = sorgu3;
            OleDbDataReader sonuc2;
            sonuc2 = objKomut.ExecuteReader();


            

            



            // dbdeki pozisyon yani meslek sayisi kadar checkboz oluşturuyoruz
            CheckBox[] boxes = new CheckBox[mesleksayisi];

            string[] komboSeciliDegerler = new string[mesleksayisi]; // az ilerideki dinamik kombolarda kullanmak üzere, yabancı dil seviyelerinden hangilerinin seçili olduklarını veritabanından öğrenip diziye aktarıyoruz.

            for (int i = 0; i < mesleksayisi; i++)
            {
                sonuc2.Read();
                boxes[i] = new CheckBox(); //çözüm http://bytes.com/topic/c-sharp/answers/278998-adding-checkboxes-screen-runtime sayfasında en alt satırda.
                boxes[i].Enabled = true;
                boxes[i].Visible = true;
                boxes[i].Name = "kutu" + i.ToString();
                boxes[i].Text = sonuc2["dil"].ToString();
                boxes[i].Location = new Point(15, 15 + (i * 25));// http://en.csharp-online.net/CheckBox
                boxes[i].Width = 200;
                boxes[i].Parent = groupBox1;
                for (int j = 0; j < bildigiToplamMeslekSayisi; j++)
                {
                    if (i == bildigiMeslekIdleri[j])
                    {
                        boxes[i].Checked = true;
                    }

                }

                OleDbCommand objKomut2 = new OleDbCommand();
                objKomut2.Connection = con;
                string sorguseviye = "SELECT idseviye FROM idinsanlar_idyabancidiller WHERE idinsanlar = " + turkerHRInsanID.ToString() + " AND idyabancidiller =" + (i+1).ToString() + ";";

                objKomut2.CommandText = sorguseviye;
                OleDbDataReader sonucseviye;
                sonucseviye = objKomut2.ExecuteReader();

                int idseviye = 1;
                while (sonucseviye.Read())
                {

                    idseviye = Convert.ToInt32(sonucseviye["idseviye"]);
                    //MessageBox.Show(idseviye.ToString() + " " + sonuc2["dil"].ToString());
                }
                //if (idseviye == 1)
                komboSeciliDegerler[i] = idseviye.ToString();
               // MessageBox.Show(komboSeciliDegerler[i] + " " + sonuc2["dil"].ToString());

            }
            sonuc2.Close();

            /*
            // kaç tane seviye olduğunu öğreniyoruz ki o boyutta dizi oluşturacağız.
            string sorgu5 = "SELECT count(*) FROM seviye;";
            objKomut.CommandText = sorgu5;
            int seviyesayisi = Convert.ToInt32(objKomut.ExecuteScalar());
            string[,] seviyeler = new string[seviyesayisi, 2]; //http://msdn.microsoft.com/en-us/library/2yd9wwz4%28v=vs.71%29.aspx


            // seviye id ve değerlerini bir diziye dolduruyoruz ileride dinamik combolarda kullanmak için
            string sorgu4 = "SELECT id, seviye FROM seviye;";
            objKomut.CommandText = sorgu4;
            OleDbDataReader sonuc3;
            sonuc3 = objKomut.ExecuteReader();
            for (int k = 0; k < seviyesayisi; k++)
            {
                sonuc3.Read();
                seviyeler[k, 0] = sonuc3["id"].ToString();
                seviyeler[k, 1] = sonuc3["seviye"].ToString();
            }
             * */

       // http://social.msdn.microsoft.com/forums/en-US/winformsdatacontrols/thread/b3c4f093-3c32-4034-bdd8-2c2c560e268b/
            // bir de bununla value classolusturmayi dene  http://www.codeproject.com/KB/combobox/valuemembersample.aspx

            //http://www.canbal.com/index.php?/Using-C-Sharp/combobox-and-databinding-waeaeaeae.html
            ComboBox[] cmbSeviye = new ComboBox[mesleksayisi];
             for (int i = 0; i < mesleksayisi; i++)
            {

                // comboların hazırlanışı
                cmbSeviye[i] = new ComboBox();
                cmbSeviye[i].DataSource = new DataView(turkerHRveritabaniDataSet2.Tables["seviye"]); // hayatımı kurtardı, yoksa tüm combolar bir değeri değiştirince hepsi değişiyordu. bu sayfa sayesinde anladım: //http://wiki.visualwebgui.com/pages/index.php/ComboBox_CodeSample_-_Populating_multiple_ComboBoxes_that_all_use_the_same_DataSource
                //cmbSeviye[i].BindingContext = new System.Windows.Forms.BindingContext(); // dinamik komboda birşey seçince diğer kombolarda da aynı şeyin seçilmesini istemiyoruz, bunun çözümü diyor ama bende işe yaramadı: http://bytes.com/topic/c-sharp/answers/642171-multiple-comboboxes-one-data-source
              
                cmbSeviye[i].Enabled = true;
                cmbSeviye[i].Visible = true;
                cmbSeviye[i].DropDownStyle = ComboBoxStyle.DropDownList;
                cmbSeviye[i].ValueMember = "id";
               
                
                
                cmbSeviye[i].DisplayMember = "seviye";
                cmbSeviye[i].Name = "seviye" + i.ToString();

                

                cmbSeviye[i].Location = new Point(15, 15 + (i * 25));// http://en.csharp-online.net/CheckBox
                cmbSeviye[i].Width = 100;
                cmbSeviye[i].Parent = groupBox2;
               // cmbSeviye[i].SelectedIndex = 1;
                cmbSeviye[i].SelectedValue = komboSeciliDegerler[i]; // sıralama önemli bu satırın çalışması için, diğer tanımlamaların en sonuna koy.
                //MessageBox.Show(komboSeciliDegerler[i] + " abc " + cmbSeviye[i].SelectedValue);
                // bitti commboların hazırlanışı

            }

















            con.Close();
            tusKilidi();
            //boxes[1].Checked = true;
            //boxes[1].CheckState = CheckState.Checked
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sorgu3 = "SELECT count(*) FROM tblYabanciDil;";
            objKomut.CommandText = sorgu3;
            int mesleksayisi = Convert.ToInt32(objKomut.ExecuteScalar());
            //label4.Text = mesleksayisi.ToString() + " ";

            int sayi = 0; // foreach ile kullanıyorum for döngüsü niyetine
            foreach (Control kontrol in this.groupBox1.Controls)
            {
                // this.controls yazsaydık form öğesindeki kontrol sayısı kadar, 
                // yani alt grup öğelerinin içlerindeki öğelere bakmaz.
                // benim oluşturduğum checkboxlar groupbox1 içerisinde olduğundan,
                // ki orada bu checkboxlardan başka nesne yok,
                // this.groupBox1.Controls yazdım ki onların sayısını öğreneyim.
                // kaynak: http://bytes.com/topic/c-sharp/answers/870039-checkbox-array-access-through-index
                if (kontrol is CheckBox) // aslında bizim zaten sadece tek tip nesnelerimiz var ancak iyi bir ayırdedici.
                {
                    if (((CheckBox)kontrol).Name.ToString().Equals("kutu" + sayi.ToString())) // benim dinamik nesnelerimin isimleri kutu1,kutu2,... şeklinde.
                    {
                        if (((CheckBox)kontrol).Checked == true) // sadece seçili olan kutular.
                        {
                            // örneğin label4 etiketine bunların Text değerlerini yazdırıyoruz.
                            // gerçekte tümünün check edilip edilmediğini veritabanına
                            // kaydetmek için kullanıyorum.
                            //label4.Text += sayi.ToString() + "." + ((CheckBox)kontrol).Text.ToString() + " ";
                            try
                            {
                                //string sorgu4 = "INSERT INTO idinsanlar_idpozisyonlar(idinsanlar, idpozisyonlar) SELECT DISTINCT 5 as idinsanlar, 5 as idpozisyonlar ";
                                //sorgu4 += "FROM idinsanlar_idpozisyonlar WHERE 5 AND 5 NOT In  (select idinsanlar, idpozisyonlar from idinsanlar_idpozisyonlar)";
                                string sorgu6 = "SELECT DISTINCT idinsanlar,idyabancidiller FROM idinsanlar_idyabancidiller WHERE ";
                                sorgu6 += "idinsanlar=" + turkerHRInsanID.ToString() + " AND ";
                                sorgu6 += "idyabancidiller=" + (sayi + 1).ToString() + ";";
                                objKomut.CommandText = sorgu6;
                                int sonuc6 = Convert.ToInt32(objKomut.ExecuteScalar());
                                if (sonuc6 > 0)
                                {
                                    //kayit zaten var. birsey yapmayacagiz veritabaninda cunku hata verir.
                                    //buralar beni en az yarım gün zorladı.
                                    //çünkü access 2003 veritabanında IF EXISTS komutu tam yok yani diğer sqllerdeki gibi tanımıyot exists komutunu.
                                    // bu yüzden bir sürü sayfaya baktım internette buladım. bazıları accessdeki DCount fonksiyonunu kullanmışlar bazıları distinct.
                                    //ben kendim çözdüm. zaten her satır unique değerli bende o yğzden distincte gerek yok.
                                    // çözümüm şu şekilde maalesef:
                                    // önce bir select sorgusu ile o değer var mı diye bakıyorum varsa 0 dan buyuk bir sayı veriyor yani kurala uyan satır sayısını kizaten 1 olabilir bendeki satırlar unique çünkü.
                                    // 0 sayısı verirse anlıyoruz ki veritabanında önceden kaydı yok.
                                    // yani aşağıdaki else kısmındaki insert sorgusunu çalıştırarak hatasız birbiimde verimizi eklemek kalıyor geriye.
                                    // benim rahatsızlığım bu iş için iki sorgu kullanmak zorunda kalmamonun dışında işini yapıyor kodlar.
                                    foreach (Control kontrol2 in this.groupBox2.Controls) // bu kısım biraz hantal kod oldu belki ama, seçili yabancı dil checkboxuna karşılık gelen comboyu bulup, seçili değeri yabancı dilseviyesini öğrenip hepsini veritabanına kaydetmeyi sağlıyor yani başarılı.
                                    {
                                        if (kontrol2 is ComboBox) // aslında bizim zaten sadece tek tip nesnelerimiz var ancak iyi bir ayırdedici.
                                        {
                                            if (((ComboBox)kontrol2).Name.ToString().Equals("seviye" + sayi.ToString())) // benim dinamik combobox nesnelerimin isimleri seviye0,seviye1,... şeklinde.
                                            {
                                                //(ComboBox)this.groupBox2.cont
                                                int seviye = Convert.ToInt32(((ComboBox)kontrol2).SelectedValue);
                                                //int seviye = 1; // gecici olarak 3. sütünla ilişkili seviye tablosunu kullanacağım programlayacağım ileriki bir tarihe kadar böyle.
                                                string sorgu4 = "UPDATE idinsanlar_idyabancidiller SET idseviye = " + seviye.ToString() + " WHERE ";
                                                sorgu4 += "idinsanlar=" + turkerHRInsanID.ToString() + " AND ";
                                                sorgu4 += "idyabancidiller=" + (sayi + 1).ToString() + ";";
                                                objKomut.CommandText = sorgu4;
                                                int sonuc5 = Convert.ToInt32(objKomut.ExecuteScalar());
                                            }
                                        }
                                    }
                                
                                }
                                else
                                {
                                    foreach (Control kontrol2 in this.groupBox2.Controls) // bu kısım biraz hantal kod oldu belki ama, seçili yabancı dil checkboxuna karşılık gelen comboyu bulup, seçili değeri yabancı dilseviyesini öğrenip hepsini veritabanına kaydetmeyi sağlıyor yani başarılı.
                                    {
                                        if (kontrol2 is ComboBox) // aslında bizim zaten sadece tek tip nesnelerimiz var ancak iyi bir ayırdedici.
                                        {
                                            if (((ComboBox)kontrol2).Name.ToString().Equals("seviye" + sayi.ToString())) // benim dinamik combobox nesnelerimin isimleri seviye0,seviye1,... şeklinde.
                                            {
                                                //(ComboBox)this.groupBox2.cont
                                                int seviye = Convert.ToInt32(((ComboBox)kontrol2).SelectedValue);
                                                //int seviye = 1; // gecici olarak 3. sütünla ilişkili seviye tablosunu kullanacağım programlayacağım ileriki bir tarihe kadar böyle.
                                                string sorgu4 = "INSERT INTO idinsanlar_idyabancidiller(idinsanlar, idyabancidiller, idseviye) VALUES (" + turkerHRInsanID.ToString() + ", " + (sayi + 1).ToString() + ", " + seviye.ToString() + ");";
                                                objKomut.CommandText = sorgu4;
                                                int sonuc5 = Convert.ToInt32(objKomut.ExecuteScalar());
                                            }
                                        }
                                    }



                                   
                                }



                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                        }
                        else if (((CheckBox)kontrol).Checked == false) // sadece seçili olan kutular.
                        {

                            string sorgu4 = "DELETE FROM idinsanlar_idyabancidiller WHERE idinsanlar=" + turkerHRInsanID.ToString() + " AND idyabancidiller=" + (sayi + 1).ToString() + ";";
                            objKomut.CommandText = sorgu4;
                            int sonuc5 = Convert.ToInt32(objKomut.ExecuteScalar());
                        }
                    }
                }
                sayi++; // sayaç lazımdı. for döngüsü gibi foreach kullanırken 1 artırmam lazım dinamik nesnelerimi belirtmek için.
            }
            sayi = 0; // işimiz bitince neolu ne olmaz sayacı sıfırlayalım. 



            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            tusKilidi();
        }
        void tusKilidi()
        {
            if (button1.Enabled == true)
            {
                button1.Enabled = false;
                button2.Text = "Emniyet Kilidini Aç";
            }
            else
            {
                button1.Enabled = true;
                button2.Text = "Emniyet Kilidini Kapa";
            }

            foreach (Control kontrol in this.groupBox1.Controls)
            {
                // this.controls yazsaydık form öğesindeki kontrol sayısı kadar, 
                // yani alt grup öğelerinin içlerindeki öğelere bakmaz.
                // kaynak: http://bytes.com/topic/c-sharp/answers/870039-checkbox-array-access-through-index

                if (kontrol is CheckBox)
                    if (((CheckBox)kontrol).Enabled == true)
                    {
                        ((CheckBox)kontrol).Enabled = false;
                        ((CheckBox)kontrol).BackColor = Color.LightYellow;
                        ((CheckBox)kontrol).ForeColor = Color.Black;
                    }
                    else
                    {
                        ((CheckBox)kontrol).Enabled = true;
                        ((CheckBox)kontrol).BackColor = Color.White;
                        ((CheckBox)kontrol).ForeColor = Color.Black;
                    }
            }
            foreach (Control kontrol in this.groupBox2.Controls)
            {
                if (kontrol is ComboBox)
                    if (((ComboBox)kontrol).Enabled == true)
                    {
                        ((ComboBox)kontrol).Enabled = false;
                        ((ComboBox)kontrol).BackColor = Color.LightYellow;
                        ((ComboBox)kontrol).ForeColor = Color.Black;
                    }
                    else
                    {
                        ((ComboBox)kontrol).Enabled = true;
                        ((ComboBox)kontrol).BackColor = Color.White;
                        ((ComboBox)kontrol).ForeColor = Color.Black;
                    }
            

            }
        }




    }
}
