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

﻿/*
 * Created by SharpDevelop.
 * User: u
 * Date: 20.03.2011
 * Time: 08:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;

namespace turkerHR
{

	/// <summary>
	/// Description of frmListe.
	/// </summary>
	public partial class frmListe : Form
	{
		OleDbDataAdapter daturkerHR;
		DataSet dsturkerHR;
        string klasoryolu = Directory.GetCurrentDirectory().ToString();
		OleDbConnection con;
        string filtre;
        string filtreHafiza;
        string metin;
        DataView dtw;

		public frmListe()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			
		}
		
		
		
		
		
		void BindingSource1CurrentChanged(object sender, EventArgs e)
		{
			
		}

        private void frmListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.tblYasAraligi' table. You can move, or remove it, as needed.
            this.tblYasAraligiTableAdapter1.Fill(this.turkerHRveritabaniDataSet2.tblYasAraligi);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.tblEgitimDurumu' table. You can move, or remove it, as needed.
            this.tblEgitimDurumuTableAdapter1.Fill(this.turkerHRveritabaniDataSet2.tblEgitimDurumu);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.tblUyruk' table. You can move, or remove it, as needed.
            this.tblUyrukTableAdapter1.Fill(this.turkerHRveritabaniDataSet2.tblUyruk);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.tblCalismaSekli' table. You can move, or remove it, as needed.
            this.tblCalismaSekliTableAdapter1.Fill(this.turkerHRveritabaniDataSet2.tblCalismaSekli);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.tblDigerHizmetler' table. You can move, or remove it, as needed.
            this.tblDigerHizmetlerTableAdapter.Fill(this.turkerHRveritabaniDataSet2.tblDigerHizmetler);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.pozisyonlardiger' table. You can move, or remove it, as needed.
            this.pozisyonlardigerTableAdapter.Fill(this.turkerHRveritabaniDataSet2.pozisyonlardiger);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.tblUcretAraligiUSD' table. You can move, or remove it, as needed.
            this.tblUcretAraligiUSDTableAdapter1.Fill(this.turkerHRveritabaniDataSet2.tblUcretAraligiUSD);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.tblCinsiyet' table. You can move, or remove it, as needed.
            this.tblCinsiyetTableAdapter1.Fill(this.turkerHRveritabaniDataSet2.tblCinsiyet);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.pozisyonlar' table. You can move, or remove it, as needed.
            this.pozisyonlarTableAdapter1.Fill(this.turkerHRveritabaniDataSet2.pozisyonlar);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet2.tblucretaraligitl' table. You can move, or remove it, as needed.
            this.tblucretaraligitlTableAdapter1.Fill(this.turkerHRveritabaniDataSet2.tblucretaraligitl);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblUcretAraligiTL' table. You can move, or remove it, as needed.
            this.tblucretaraligitlTableAdapter.Fill(this.turkerHRDataSet.tblUcretAraligiTL);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblCinsiyet' table. You can move, or remove it, as needed.
            this.tblCinsiyetTableAdapter.Fill(this.turkerHRDataSet.tblCinsiyet);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.pozisyonlar' table. You can move, or remove it, as needed.
            this.pozisyonlarTableAdapter.Fill(this.turkerHRDataSet.pozisyonlar);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblUcretAraligiTL' table. You can move, or remove it, as needed.
            this.tblucretaraligitlTableAdapter.Fill(this.turkerHRDataSet.tblUcretAraligiTL);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblUcretAraligiUSD' table. You can move, or remove it, as needed.
            this.tblUcretAraligiUSDTableAdapter.Fill(this.turkerHRDataSet.tblUcretAraligiUSD);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblYasAraligi' table. You can move, or remove it, as needed.
            this.tblYasAraligiTableAdapter.Fill(this.turkerHRDataSet.tblYasAraligi);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblEgitimDurumu' table. You can move, or remove it, as needed.
            this.tblEgitimDurumuTableAdapter.Fill(this.turkerHRDataSet.tblEgitimDurumu);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblUyruk' table. You can move, or remove it, as needed.
            this.tblUyrukTableAdapter.Fill(this.turkerHRDataSet.tblUyruk);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblCalismaSekli' table. You can move, or remove it, as needed.
            this.tblCalismaSekliTableAdapter.Fill(this.turkerHRDataSet.tblCalismaSekli);
            // OleDbDataAdapter daIsis; // turkcekelimeler tablosundan kelimeleri getirmek için
            // DataSet dsIsis; // turkcekelimelerin yükleneceği salt okunur dataset, gride bağlamak için kullanılacak


            yenile();
        }

        void yenile()
        {
           
            
            // MessageBox.Show(klasoryolu);
            try
            {
                string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
        
                con = new OleDbConnection(constr);
                con.Open();
                
               /*
                string sorgu = "SELECT id, calismasekli FROM tblCalismaSekli;";
                OleDbCommand objKomut3=new OleDbCommand();
                objKomut3.CommandText = sorgu;
                objKomut3.Connection = con;
                OleDbDataReader sonuc3;
  			
		        try {
		        	 sonuc3 = objKomut3.ExecuteReader();
		        	 while (sonuc3.Read())
						{
		        	 	comboBox1.Items.Add(sonuc3["calismasekli"]);
		        	 	//comboBox1.Items.Add(new ComboBoxItem(sonuc3["calismasekli"].ToString(),Convert.ToInt32(sonuc3["id"])));
		        	 	
			     	 	}
		        	 comboBox1.SelectedItem = comboBox1.Items[0];
		        	// MessageBox.Show(comboBox1.Items[0].);
		        	
		        	 }
		        
					
		         catch (Exception ex) {
		        	
		            	MessageBox.Show(ex.ToString());
		        }
                
                */
                
                /*
                 * Grid üzerinde hangi tabloların hangi alanlarının görünmesi isteniyorsa bu sorguda belirtilir.
                 * İlişkisel tablolarda id numaraları yerine değerlerin görünmesi için gereken eşitlemeler yapılır.
                 * Eğer sütun başlıkları farklı görünmesi istenirse AS komutu kullanılır.
                 * Yalnız bunları yaptıktan sonra filtreleri kontrol ediniz çünkü yeni düzenlemeye göre onların da güncellenmesi gerekebilir.
                 */
                string sorgu1 = @"SELECT "; // case sensitive değil tablo ve alan isimleri, dikkat etmene gerek yok veritabanındakilerle aynı mı diye.
                sorgu1 += "insanlar.id, insanlar.isim, insanlar.soyad, tblcinsiyet.cinsiyet, insanlar.adresil, insanlar.adresilce,";
                sorgu1 += "insanlar.telefonev, insanlar.telefoncep, insanlar.eposta, tbluyruk.uyruk, tblcalismasekli.calismasekli,";
                sorgu1 += "insanlar.ucrettl, insanlar.ucretusd, tblEgitimDurumu.egitimdurumu, dogumtarihi";
                sorgu1 += " FROM ";
                sorgu1 += "insanlar, tblcinsiyet, tbluyruk, tblcalismasekli, tblEgitimDurumu"; // hangi tablolar işlem görecekse belirtilir.
                sorgu1 += " WHERE ";
                sorgu1 += "insanlar.cinsiyet = tblcinsiyet.id AND insanlar.uyruk = tbluyruk.id AND insanlar.id_calismasekli = tblcalismasekli.id AND ";
                sorgu1 += "insanlar.id_egitimdurumu = tblEgitimDurumu.id";
                sorgu1 += ";";
                

               // string sorgu1 = @"SELECT id, isim, soyad, id_calismasekli, ucrettl, ucretusd FROM insanlar";
                
                
                
                //OleDbCommand objKomut = new OleDbCommand();
                //objKomut.CommandText = sorgu1;
                //objKomut.Connection = con;
                //OleDbDataReader sonuc;
                //sonuc = objKomut.ExecuteReader();
                //   string sql = "SELECT id, en, tr FROM kelimeler WHERE tr='masa'";
                // string sql = "SELECT id, turkcekelime FROM turkcekelimeler WHERE turkcekelime LIKE '%,%'";
               // daIsis.SelectCommand = sorgu1;
                //daIsis.c
                daturkerHR = new OleDbDataAdapter(sorgu1, con);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(daturkerHR);

                dsturkerHR = new DataSet();
                daturkerHR.Fill(dsturkerHR, "insanlar");
                //dsIsis.Tables["insanlar"].DefaultView.Sort = "cinsiyet";
                dataGridView1.DataSource = dsturkerHR;
                dataGridView1.DataMember = "insanlar";          
				//((DataTable)this.dataGridView1.DataSource).DefaultView.RowFilter = @"cinsiyet=erkek";// + combobox.selectedtext
				//dsIsis.Tables["insanlar"].DefaultView.RowFilter = @"cinsiyet='erkek'";
                label2.Text = dataGridView1.Rows.Count.ToString();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
		
		void Button1Click(object sender, EventArgs e)
		{
            tazeleGrid();
		}
        void tazeleGrid()
        {
            //dataGridView1.Rows.Clear();
            dsturkerHR.Clear();
            dataGridView1.DataMember = ""; // 1. ancak sırasına dikkat ederek bu iki satırı yazınca gridi boşaltmam mümkün oldu.
            dataGridView1.DataSource = ""; // 2.

            // dataGridView1.Refresh(); 
            daturkerHR.Fill(dsturkerHR, "insanlar");
            dataGridView1.DataSource = dsturkerHR;
            dataGridView1.DataMember = "insanlar";
        }
		
		void DataGridView1RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            MainForm frmKullaniciDetay = new MainForm();
            //frmKullaniciDetay.isisInsanID = "3";
            //int satirBookmark = dataGridView1.SelectedRows[0].Index; // aslında çok sağlıklı değil çünkü unique olan şeyveritabanı tablosundaki ID, bu sadece eğer grid sıralaması değişmemmişse sonradan aynı konumu verecek ama burada ben yeterli kabul ettim.  amacımız grid yenileme ve filtre işleminden sonra da daha önce seçilmiş olan satırı yine seçili yapmak.
            int hucreBookmark = dataGridView1.SelectedRows[0].Cells[0].RowIndex;
            //int hucreBookmark = dataGridView1.fin
            frmKullaniciDetay.turkerHRInsanID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frmKullaniciDetay.ShowDialog();
            frmKullaniciDetay.Dispose();
            yenile();
            filtrele();
            //MessageBox.Show(satirBookmark.ToString());
            // amacımız grid yenileme ve filtre işleminden sonra da daha önce seçilmiş olan satırı yine seçili yapmak.
            //
            //dataGridView1.Rows[satirBookmark].Selected = true; //http://social.msdn.microsoft.com/forums/en-US/winformsdatacontrols/thread/47e9c3ef-a8de-48c9-8e0d-4f3fdd34517e/
            if (hucreBookmark < dataGridView1.Rows.Count) // çünkü detay penceresinden geri dönünce eğer filtre değiştirilmişse eski satırı yerinde bulamayıp hata verebiliyordu. Yani bu kısımlarçok sağlıklı değil ancak işimi görüyor çoğunlukla.
            {
                dataGridView1.Rows[hucreBookmark].Selected = true;
            }

            // bu önemli ve öğretici: http://www.exforsys.com/tutorials/vb.net-2005/finding-and-sorting-data-in-datasets.html
            
            // dtw.Find("id",2);
           // dataGridView1.DataSource = dtw;  //http://www.durgut.com/tag/dataview/
            

            // http://www.ahmetkaymaz.com/2007/04/11/windows-formunu-yonetmekshowdialog-show-metodlari/
      
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            MainForm frmKullaniciDetay = new MainForm();
            frmKullaniciDetay.turkerHRInsanID = "-1"; // bunu hard olarak yazdim ki id yerine bunu gönderince yeni kayıt yaptıracağım if then ile.
           // frmKullaniciDetay.isisInsanID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frmKullaniciDetay.ShowDialog();
            frmKullaniciDetay.Dispose();
            yenile();
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());

            /*
             * kişi ekleme veya güncelleme yaptıktan sonra listeleme sayfasına bu güncellemenin yansıması için veritabanından tekrar okuyoruz ve filtreyi tekrar uyguluyoruz.
             */
            //System.Threading.Thread.Sleep(3000); // 3 saniye beklettim. Yoksa daha veritabani hazir olmadiginda guncel hali gostermeyebiliyor.
            ////tazeleGrid(); BU FONKSIYONA GEREK KALMADI KULLANMIYORUM. TANIMI DAHİL KOMPLE SİLEBİLİRSİN. Çünkü bunun yerine yenile() metodu daha kolayıma gitti.
            //MessageBox.Show("grid tazelendi");
            filtrele();
            //MessageBox.Show("filtre çalıştırıldı");

            // http://www.ahmetkaymaz.com/2007/04/11/windows-formunu-yonetmekshowdialog-show-metodlari/
      
		}
		




		void Button3Click(object sender, EventArgs e)
        {
            filtrele();
        }

        void filtrele()
		{
            /*
                DataView dtw;
                dtw = dsIsis.Tables["insanlar"].DefaultView;
                dtw.Sort = ("cinsiyet");
                dtw.RowFilter = ("cinsiyet='erkek'");
              	dataGridView1.DataSource = dtw;  //http://www.durgut.com/tag/dataview/
             * */

            //DataView dtw;
            dtw = dsturkerHR.Tables["insanlar"].DefaultView;
            //dtw.Sort = ("cinsiyet");
            //dtw.RowFilter = ("cinsiyet='erkek'");
            filtre = ""; //başlangıçta.
            //filtre = filtreHafiza;


            if (chkIsim.Checked == true)
            {
                if (txtIsim.Text != "")
                {
                    filtre += "isim LIKE '%" + txtIsim.Text + "%' AND ";
                }
                
            }
            if (chkSoyad.Checked == true)
            {
                if (txtSoyad.Text != "")
                {
                    filtre += "soyad LIKE '%" + txtSoyad.Text + "%' AND ";
                }
            }
            if (chkUcretAraligiTL.Checked == true)
            {
                metin = cmbUcretAraligiTL.Text; // çözdüm nihayet: http://www.dreamincode.net/forums/topic/55162-c%23-combo-box-retrieving-selected-value-net20/
                // MessageBox.Show(metin); // Ancak bu yöntemle sorunu aşabildim. Yoksa selecteditem ile maalesefseçlen seçeneği değil  system.data.datarowview metnini getiriyor gıcık birşekilde.
                //MessageBox.Show(cmbUcretAraligiTL.Items[cmbUcretAraligiTL.SelectedIndex].ToString());
                // string aa = ((DataRowView)cmbIsIlce.SelectedItem).Row["IlceAdi"]; //http://www.csharpnedir.com/forum2/printer_friendly_posts.asp?TID=4492
                // MessageBox.Show(cmbUcretAraligiTL.SelectedValue.ToString());
                if (metin.Contains("-"))
                {
                    string[] ucretTL = metin.Split('-'); //ücret aralığı stringini ikiye ayırıp içinden sayı olan kısmı çekebilmek için. bulması 2 saatimi aldı.

                    Regex re = new Regex(@"\d+"); //http://www.dotnetspider.com/resources/22629-Find-number-from-string.aspx
                    Match m = re.Match(ucretTL[0]);
                    Match n = re.Match(ucretTL[1]);
                    string ucretMin = m.Value;
                    string ucretMax = n.Value;
                    // MessageBox.Show(ucretMin + " " + ucretMax);
                    //filtre += "ucrettl Between '" + ucretMin + "' AND '" + ucretMax + "' AND ";
                    filtre += "ucrettl >= " + ucretMin + " AND ucrettl <= " + ucretMax + " AND "; // between rowfilterde işe yaramaz, onun yerine >= ve <= kullan http://social.msdn.microsoft.com/Forums/en-US/adodotnetdataproviders/thread/1220e0f5-4bab-4b53-b8b6-a7a9e8420558/
                }
                else
                {
                    MessageBox.Show("Ücret Aralığı TL Filtresi - (Tire) İle Ayrılmış İki Değer İçermiyor!");
                }
            }
            if (chkMeslekGrubu.Checked == true)
            {
                // Burası beni biraz zorladı sebebi:
                // Başka tablodan elde edeceğim değerleri bu datasetin rowfilterine göndermem lazımdı.
                // Bu yüzden executereader ile bu değerleri normal yoldan elde ettim sorguyla.
                // ondan sonra
                // id IN (1, 2, 3) gibi rowfiltere gönderebilmek için parantez içini while döngüsüyle oluşturdum.
                // son virgül ve boşluk karakterini substring ile attım. Biraz çirkin bir kod belki ama işe yarıyor.

                //http://www.csharp-examples.net/dataview-rowfilter/  IN operatörü ve diğerleri için
                //con.Open(); //baglanti zaten açık hatası.
                //con.Close();
                string sql = "SELECT idinsanlar FROM idinsanlar_idpozisyonlar WHERE idpozisyonlar=" + cmbMeslekGrubu.SelectedValue.ToString() + ";";
                OleDbCommand objKomut;
                objKomut = new OleDbCommand();
                objKomut.Connection = con;
                objKomut.CommandText = sql;
                OleDbDataReader sonuc;
                sonuc = objKomut.ExecuteReader();
                string kuralaUyanIDler = "";
                 while (sonuc.Read())
                //for (int k = 0; k < bildigiToplamMeslekSayisi; k++)
                {
                    //sonuc.Read();
                    kuralaUyanIDler += sonuc["idinsanlar"].ToString() + ", ";
                    //bildigiMeslekIdleri[k] = Convert.ToInt32(sonuc["idpozisyonlar"]) - 1; // - 1 koydum çünkü koymazsam bir checkbox ileridekini seçiyor. düzeltmek maksadıyla.

                }

                //filtre += "id IN (1, 2, 3) AND ";
                 if (kuralaUyanIDler.Length > 2) // zaten en az bir id varsa idnumarasi bir karakter ve yanindaki virgul ve nokta ikikarakter yani toplamda 3>2 oluyor.
                 {
                     kuralaUyanIDler = kuralaUyanIDler.Substring(0, kuralaUyanIDler.Length - 2);
                     filtre += "id IN (" + kuralaUyanIDler + ") AND ";
                 }
                 else
                 {
                     MessageBox.Show("Filtrede seçilen meslek tanımı hiçbir adayda yok! Bu yüzden meslek filtresi bu arama için etkisiz.");
                 }
            }
            if (chkCinsiyet.Checked == true)
            {
                filtre += "cinsiyet='" + cmbCinsiyet.Text + "' AND ";
                //filtre += "cinsiyet='" + cmbCinsiyet.SelectedValue.ToString() + "' AND ";
            }
            if (chkUcretAraligiUSD.Checked == true)
            {
                metin = cmbUcretAraligiUSD.Text; // çözdüm nihayet: http://www.dreamincode.net/forums/topic/55162-c%23-combo-box-retrieving-selected-value-net20/
                // MessageBox.Show(metin); // Ancak bu yöntemle sorunu aşabildim. Yoksa selecteditem ile maalesefseçlen seçeneği değil  system.data.datarowview metnini getiriyor gıcık birşekilde.
                //MessageBox.Show(cmbUcretAraligiTL.Items[cmbUcretAraligiTL.SelectedIndex].ToString());
                // string aa = ((DataRowView)cmbIsIlce.SelectedItem).Row["IlceAdi"]; //http://www.csharpnedir.com/forum2/printer_friendly_posts.asp?TID=4492
                // MessageBox.Show(cmbUcretAraligiTL.SelectedValue.ToString());
                if (metin.Contains("-"))
                {
                    string[] ucretUSD = metin.Split('-'); //ücret aralığı stringini ikiye ayırıp içinden sayı olan kısmı çekebilmek için. bulması 2 saatimi aldı.

                    Regex re = new Regex(@"\d+"); //http://www.dotnetspider.com/resources/22629-Find-number-from-string.aspx
                    Match m = re.Match(ucretUSD[0]);
                    Match n = re.Match(ucretUSD[1]);
                    string ucretMin = m.Value;
                    string ucretMax = n.Value;
                    // MessageBox.Show(ucretMin + " " + ucretMax);
                    //filtre += "ucrettl Between '" + ucretMin + "' AND '" + ucretMax + "' AND ";
                    filtre += "ucretusd >= " + ucretMin + " AND ucretusd <= " + ucretMax + " AND "; // between rowfilterde işe yaramaz, onun yerine >= ve <= kullan http://social.msdn.microsoft.com/Forums/en-US/adodotnetdataproviders/thread/1220e0f5-4bab-4b53-b8b6-a7a9e8420558/
                }
                else
                {
                    MessageBox.Show("Ücret Aralığı USD Filtresi - (Tire) İle Ayrılmış İki Değer İçermiyor!");
                }
            }
            if (chkCalismaSekli.Checked == true)
            {
                filtre += "calismasekli='" + cmbCalismaSekli.Text + "' AND "; //ana sorguya bak şaşırırsan çünkü buradaki alan adları datagrid sütununda yazan adlarla aynı olmalı çünkü filtreleme dataset üzerinde yapılıyor.
                //filtre += "id_calismasekli='" + cmbCalismaSekli.SelectedValue.ToString() + "' AND ";
            }
            if (chkUyruk.Checked == true)
            {
                filtre += "uyruk='" + cmbUyruk.Text + "' AND ";
                //filtre += "uyruk='" + cmbUyruk.SelectedValue.ToString() + "' AND ";
            }
            if (chkEgitimDurumu.Checked == true)
            {
                filtre += "egitimdurumu='" + cmbEgitimDurumu.Text + "' AND "; //ana sorguya bak şaşırırsan çünkü buradaki alan adları datagrid sütununda yazan adlarla aynı olmalı çünkü filtreleme dataset üzerinde yapılıyor.
                //filtre += "id_egitimdurumu='" + cmbEgitimDurumu.SelectedValue.ToString() + "' AND ";
            }
            if (chkYasAraligi.Checked == true)
            {
                

                metin = cmbYasAraligi.Text; 
                if (metin.Contains("-"))
                {

                    // bugünün tarihini bul. formül gliştirip sqle yolla.
                    DateTime dt = DateTime.Today;// Now dan farki: saat 00:00:00 //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/Getcurrenttime.htm
                    //MessageBox.Show(dt.ToString());
                    //MessageBox.Show(dt.Year.ToString());

                    // string tarihBugun = dt.ToString("d"); // 30.03.2011 biçiminde verir. "D" olsaydı ek olarak gün ismi, "T" olsaydı sadecesaat dakika saniye verirdi değişkenin içerisinden.
                    //MessageBox.Show(tarihBugun);
                    //string deneme = "03.02.1975";
                    // string deneme2 = "3.30.2011"; // evet veritabanı maalesef ay.gun.yil biciminde aliyor halbuki doğrudan accessden sorgularken gün.ay.yıl olarak kabul ediyordu, bunu hallederim ancak bölgesel ayarı farklı bir bilgisayar için düşünerek yapmayacağımdan şimdilik onlarda hata çıkabilir.
                    // filtre += "dogumtarihi >=#03.02.1975# AND dogumtarihi <=#" + tarihBugun + "# AND ";
                    // filtre += "dogumtarihi >=#" + deneme + "# AND dogumtarihi <=#" + deneme2 + "# AND "; // bu deneme çalışıyor, yazılış biçimini önce access içerinde query oluşturup denedim sonra da aynen burada.

                    string[] ucretUSD = metin.Split('-'); //ücret aralığı stringini ikiye ayırıp içinden sayı olan kısmı çekebilmek için. bulması 2 saatimi aldı.

                    Regex re = new Regex(@"\d+"); //http://www.dotnetspider.com/resources/22629-Find-number-from-string.aspx
                    Match m = re.Match(ucretUSD[0]);
                    Match n = re.Match(ucretUSD[1]);
                    int yasMin = Convert.ToInt32(m.Value);
                    int yasMax = Convert.ToInt32(n.Value);
                   //  MessageBox.Show(yasMin.ToString() + " " + yasMax.ToString());
                     DateTime dt2 = new DateTime(dt.Year - yasMin,dt.Month,dt.Day);
                     DateTime dt3 = new DateTime(dt.Year - yasMax, dt.Month, dt.Day);
                     string tarihMax = dt2.Month.ToString() + "." + dt2.Day.ToString() + "." + dt2.Year.ToString();
                     string tarihMin = dt3.Month.ToString() + "." + dt3.Day.ToString() + "." + dt3.Year.ToString();
                    // MessageBox.Show(dt2.ToString());
                   // filtre += "ucretusd >= " + yasMin + " AND ucretusd <= " + yasMax + " AND "; // between rowfilterde işe yaramaz, onun yerine >= ve <= kullan http://social.msdn.microsoft.com/Forums/en-US/adodotnetdataproviders/thread/1220e0f5-4bab-4b53-b8b6-a7a9e8420558/
                     filtre += "dogumtarihi >=#" + tarihMin + "# AND dogumtarihi <=#" + tarihMax + "# AND "; // bu deneme çalışıyor, yazılış biçimini önce access içerinde query oluşturup denedim sonra da aynen burada.

                }
                else
                {
                    MessageBox.Show("Yaş Aralığı Filtresi - (Tire) İle Ayrılmış İki Değer İçermiyor!");
                }
            }
            if (chkMeslekGrubuDiger.Checked == true)
            {
                // Burası beni biraz zorladı sebebi:
                // Başka tablodan elde edeceğim değerleri bu datasetin rowfilterine göndermem lazımdı.
                // Bu yüzden executereader ile bu değerleri normal yoldan elde ettim sorguyla.
                // ondan sonra
                // id IN (1, 2, 3) gibi rowfiltere gönderebilmek için parantez içini while döngüsüyle oluşturdum.
                // son virgül ve boşluk karakterini substring ile attım. Biraz çirkin bir kod belki ama işe yarıyor.

                //http://www.csharp-examples.net/dataview-rowfilter/  IN operatörü ve diğerleri için
                //con.Open(); //baglanti zaten açık hatası.
                //con.Close();
                string sql = "SELECT idinsanlar FROM idinsanlar_idpozisyonlardiger WHERE idpozisyonlardiger=" + cmbMeslekGrubuDiger.SelectedValue.ToString() + ";";
                OleDbCommand objKomut;
                objKomut = new OleDbCommand();
                objKomut.Connection = con;
                objKomut.CommandText = sql;
                OleDbDataReader sonuc;
                sonuc = objKomut.ExecuteReader();
                string kuralaUyanIDler = "";
                while (sonuc.Read())
                //for (int k = 0; k < bildigiToplamMeslekSayisi; k++)
                {
                    //sonuc.Read();
                    kuralaUyanIDler += sonuc["idinsanlar"].ToString() + ", ";
                    //bildigiMeslekIdleri[k] = Convert.ToInt32(sonuc["idpozisyonlar"]) - 1; // - 1 koydum çünkü koymazsam bir checkbox ileridekini seçiyor. düzeltmek maksadıyla.

                }

                //filtre += "id IN (1, 2, 3) AND ";
                if (kuralaUyanIDler.Length > 2) // zaten en az bir id varsa idnumarasi bir karakter ve yanindaki virgul ve nokta ikikarakter yani toplamda 3>2 oluyor.
                {
                    kuralaUyanIDler = kuralaUyanIDler.Substring(0, kuralaUyanIDler.Length - 2);
                    filtre += "id IN (" + kuralaUyanIDler + ") AND ";
                }
                else
                {
                    MessageBox.Show("Filtrede seçilen meslekdiğer tanımı hiçbir adayda yok! Bu yüzden meslekdiğer filtresi bu arama için etkisiz.");
                }
            }
            if (chkDigerHizmetler.Checked == true)
            {
                // Burası beni biraz zorladı sebebi:
                // Başka tablodan elde edeceğim değerleri bu datasetin rowfilterine göndermem lazımdı.
                // Bu yüzden executereader ile bu değerleri normal yoldan elde ettim sorguyla.
                // ondan sonra
                // id IN (1, 2, 3) gibi rowfiltere gönderebilmek için parantez içini while döngüsüyle oluşturdum.
                // son virgül ve boşluk karakterini substring ile attım. Biraz çirkin bir kod belki ama işe yarıyor.

                //http://www.csharp-examples.net/dataview-rowfilter/  IN operatörü ve diğerleri için
                //con.Open(); //baglanti zaten açık hatası.
                //con.Close();
                string sql = "SELECT idinsanlar FROM idinsanlar_iddigerhizmetler WHERE iddigerhizmetler=" + cmbDigerHizmetler.SelectedValue.ToString() + ";";
                OleDbCommand objKomut;
                objKomut = new OleDbCommand();
                objKomut.Connection = con;
                objKomut.CommandText = sql;
                OleDbDataReader sonuc;
                sonuc = objKomut.ExecuteReader();
                string kuralaUyanIDler = "";
                while (sonuc.Read())
                //for (int k = 0; k < bildigiToplamMeslekSayisi; k++)
                {
                    //sonuc.Read();
                    kuralaUyanIDler += sonuc["idinsanlar"].ToString() + ", ";
                    //bildigiMeslekIdleri[k] = Convert.ToInt32(sonuc["idpozisyonlar"]) - 1; // - 1 koydum çünkü koymazsam bir checkbox ileridekini seçiyor. düzeltmek maksadıyla.

                }

                //filtre += "id IN (1, 2, 3) AND ";
                if (kuralaUyanIDler.Length > 2) // zaten en az bir id varsa idnumarasi bir karakter ve yanindaki virgul ve nokta ikikarakter yani toplamda 3>2 oluyor.
                {
                    kuralaUyanIDler = kuralaUyanIDler.Substring(0, kuralaUyanIDler.Length - 2);
                    filtre += "id IN (" + kuralaUyanIDler + ") AND ";
                }
                else
                {
                    MessageBox.Show("Filtrede seçilen DigerHizmetler tanımı hiçbir adayda yok! Bu yüzden meslekdiğer filtresi bu arama için etkisiz.");
                }
            }

            
            if (filtre.Length > 4) // bunu en sondaki "AND " kısmını atmak için yapıyoruz yoksa sorgu hatası verir sql
            {
                filtre = filtre.Substring(0, filtre.Length - 4);
               // MessageBox.Show(filtre);
                dtw.RowFilter = (filtre);
                dataGridView1.DataSource = dtw;  //http://www.durgut.com/tag/dataview/
            }
            else
            {
                filtre = "";
                dtw.RowFilter = (filtre);
                dataGridView1.DataSource = dtw;  //http://www.durgut.com/tag/dataview/
            }
            label1.Visible = false;
            //label1.Text = filtre; // kontrol amacıyla sorgu metnini gösterir.
            label2.Text = dataGridView1.Rows.Count.ToString();
            
		}

        private void chkCinsiyet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCinsiyet.Checked == true)
            {
                cmbCinsiyet.Enabled = true;
                

            }
            else
            {
                cmbCinsiyet.Enabled = false;
            }
        }

        private void chkUcretAraligiTL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUcretAraligiTL.Checked == true)
            {
                cmbUcretAraligiTL.Enabled = true;
                
            }
            else
            {
                cmbUcretAraligiTL.Enabled = false;
            }
        }

        private void chkMeslekGrubu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMeslekGrubu.Checked == true)
            {
                cmbMeslekGrubu.Enabled = true;
            }
            else
            {
                cmbMeslekGrubu.Enabled = false;
            }
        }

        private void chkUcretAraligiUSD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUcretAraligiUSD.Checked == true)
            {
                cmbUcretAraligiUSD.Enabled = true;
            }
            else
            {
                cmbUcretAraligiUSD.Enabled = false;
            }
        }

        private void chkCalismaSekli_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCalismaSekli.Checked == true)
            {
                cmbCalismaSekli.Enabled = true;
            }
            else
            {
                cmbCalismaSekli.Enabled = false;
            }
        }

        private void chkUyruk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUyruk.Checked == true)
            {
                cmbUyruk.Enabled = true;
            }
            else
            {
                cmbUyruk.Enabled = false;
            }
        }

        private void chkEgitimDurumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEgitimDurumu.Checked == true)
            {
                cmbEgitimDurumu.Enabled = true;
            }
            else
            {
                cmbEgitimDurumu.Enabled = false;
            }
        }

        private void chkYasAraligi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYasAraligi.Checked == true)
            {
                cmbYasAraligi.Enabled = true;
            }
            else
            {
                cmbYasAraligi.Enabled = false;
            }
        }

        private void cmbUcretAraligiTL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkIsim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsim.Checked == true)
            {
                txtIsim.Enabled = true;


            }
            else
            {
                txtIsim.Enabled = false;
            }
        }

        private void chkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoyad.Checked == true)
            {
                txtSoyad.Enabled = true;


            }
            else
            {
                txtSoyad.Enabled = false;
            }
        }

        private void chkMeslekGrubuDiger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMeslekGrubuDiger.Checked == true)
            {
                cmbMeslekGrubuDiger.Enabled = true;


            }
            else
            {
                 cmbMeslekGrubuDiger.Enabled = false;
            }
        }

        private void chkDigerHizmetler_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDigerHizmetler.Checked == true)
            {
                cmbDigerHizmetler.Enabled = true;


            }
            else
            {
                cmbDigerHizmetler.Enabled = false;
            }
        }

        private void cmbDigerHizmetler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // biraz kirli bir kod olsa da, veritabanında erişen ne varsa kapatınca işe yarıyor.
            con.Close();
            con.Dispose();
            turkerHRveritabaniDataSet2.Dispose();
            turkerHRDataSet.Dispose();
            turkerHRveritabaniDataSet1.Dispose(); 

            if (File.Exists(klasoryolu + @"\turkerHRveritabani.ldb")) //bu hala varsa kabaca yukarıda veritabına erişen tüm bağlantıları kapat.
            {
                MessageBox.Show("Dikkat: Veritabanı dosyası kilitli kalmış. Bu durumda yedek almam. Lütfen teknik destek isteyin.");
            }
            else
            {
                //http://www.netomatix.com/FolderBrowser.aspx
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string zamanDamgasi = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                    File.Copy(klasoryolu + @"\turkerHRveritabani.mdb", fbd.SelectedPath + @"\turkerHRveritabani" + zamanDamgasi + ".mdb" );
                    MessageBox.Show(fbd.SelectedPath + @"\turkerHRveritabani" + zamanDamgasi + ".mdb" + " yoluna veritabanı yedeği alındı.");
                }
            }
            
               

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://www.turkerozturk.com/ adresinden iletişim bilgilerime ve kaynak kodlara ulaşabilirsiniz. turkerHR-v1.0.1.rev19");
        }
	}



    public class ComboBoxItem // bu helper classi ile ekledim ama okutturamadim oyuzden kullanmiyorum sadece kaybolmasin diye burada duruyor zaten websitemdede var.
    {
        private string display;
        private int deger;

        public ComboBoxItem(string display, int deger)
        {
            this.display = display;
            this.deger = deger;
        }

        public override string ToString()
        {
            return display;
        }
    }

    //You'd add it to your ComboBox like this:

    //comboBox.Items.Add(new ComboBoxItem("asdf", yourObjectHere));
} // ana en son parantez
