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
 * Date: 18.03.2011
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;

namespace turkerHR
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        string klasoryolu = Directory.GetCurrentDirectory();

        private string _turkerHRInsanID; //forma parametre alisverisi icin

        public string turkerHRInsanID
        {
            get { return _turkerHRInsanID; }
            set { _turkerHRInsanID = value; }
        } //http://www.vcskicks.com/data-between-forms.php


		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}




        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (turkerHRInsanID != "-1")
            {
                tusKilidi();
            }

            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet.tblEvetHayir' table. You can move, or remove it, as needed.
            this.tblEvetHayirTableAdapter.Fill(this.turkerHRveritabaniDataSet.tblEvetHayir);
            // TODO: This line of code loads data into the 'turkerHRveritabaniDataSet.tblAskerlikDurumu' table. You can move, or remove it, as needed.
            this.tblAskerlikDurumuTableAdapter.Fill(this.turkerHRveritabaniDataSet.tblAskerlikDurumu);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblUyruk' table. You can move, or remove it, as needed.
            this.tblUyrukTableAdapter.Fill(this.turkerHRDataSet.tblUyruk);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet1.tblMedeniDurum' table. You can move, or remove it, as needed.
            this.tblMedeniDurumTableAdapter.Fill(this.turkerHRDataSet1.tblMedeniDurum);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblCinsiyet' table. You can move, or remove it, as needed.
            this.tblCinsiyetTableAdapter.Fill(this.turkerHRDataSet.tblCinsiyet);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblCalismaSekli' table. You can move, or remove it, as needed.
            this.tblCalismaSekliTableAdapter.Fill(this.turkerHRDataSet.tblCalismaSekli);
            // TODO: This line of code loads data into the 'isisveritabaniDataSet.tblEgitimDurumu' table. You can move, or remove it, as needed.
            this.tblEgitimDurumuTableAdapter.Fill(this.turkerHRDataSet.tblEgitimDurumu);
        	//MessageBox.Show(isisInsanID.ToString());
           // string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\csprojeler\isisveritabani\isisveritabani\bin\Debug\turkerHRveritabani.mdb;";
            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
            OleDbConnection con; con = new OleDbConnection(constr);
            
            con.Open();
            
            //string sorgu1 = @"SELECT * FROM insanlar WHERE isim='ali';";
            string sorgu1 = @"SELECT * FROM insanlar WHERE id=" + turkerHRInsanID.ToString() + @";";
            OleDbCommand objKomut=new OleDbCommand();
            objKomut.CommandText = sorgu1;
            objKomut.Connection = con;
            OleDbDataReader sonuc;
            sonuc = objKomut.ExecuteReader();
            
			while (sonuc.Read())
			{
				//MessageBox.Show(sonuc["id"].ToString());
				label0.Text = sonuc["id"].ToString();
				textBox1.Text = sonuc["isim"].ToString();
				textBox2.Text = sonuc["soyad"].ToString();				
                comboBox3.SelectedValue = Convert.ToInt32(sonuc["cinsiyet"]);
				textBox4.Text = sonuc["tckimlik"].ToString();
                maskedTextBox1.Text = sonuc["dogumtarihi"].ToString();
                //MessageBox.Show(maskedTextBox1.Text);
                //MessageBox.Show(sonuc["dogumtarihi"].ToString());
				textBox5.Text = sonuc["dogumyeriil"].ToString();
				textBox6.Text = sonuc["dogumyeriilce"].ToString();
                comboBox4.SelectedValue = Convert.ToInt32(sonuc["medenidurum"]);
                comboBox5.SelectedValue = Convert.ToInt32(sonuc["uyruk"]);
				textBox9.Text = sonuc["telefonev"].ToString();
				textBox10.Text = sonuc["telefoncep"].ToString();
				textBox11.Text = sonuc["telefoncep2"].ToString();
				textBox12.Text = sonuc["eposta"].ToString();
				textBox13.Text = sonuc["adres"].ToString();
				textBox14.Text = sonuc["adresil"].ToString();
				textBox15.Text = sonuc["adresilce"].ToString();
                comboBox6.SelectedValue = Convert.ToInt32(sonuc["askerlikdurumu"]);
                comboBox7.SelectedValue = Convert.ToInt32(sonuc["kalicisaglikdurumu"]);
                comboBox8.SelectedValue = Convert.ToInt32(sonuc["sigarakullanimi"]);
                comboBox9.SelectedValue = Convert.ToInt32(sonuc["alerjidurumu"]);
                comboBox10.SelectedValue = Convert.ToInt32(sonuc["yuzmedurumu"]);
                comboBox11.SelectedValue = Convert.ToInt32(sonuc["evcilhayvanlievdurumu"]);
                comboBox12.SelectedValue = Convert.ToInt32(sonuc["pasaportdurumu"]);
                comboBox13.SelectedValue = Convert.ToInt32(sonuc["seyahatdurumu"]);
                comboBox14.SelectedValue = Convert.ToInt32(sonuc["cocukgelisimimezunudurumu"]);
                comboBox15.SelectedValue = Convert.ToInt32(sonuc["tesetturdurumu"]);
                comboBox16.SelectedValue = Convert.ToInt32(sonuc["ilkyardimbilgisidurumu"]);
                comboBox2.SelectedValue = Convert.ToInt32(sonuc["id_calismasekli"]);
				textBox28.Text = sonuc["ucrettl"].ToString();
				textBox29.Text = sonuc["ucretusd"].ToString();
                comboBox1.SelectedValue = Convert.ToInt32(sonuc["id_egitimdurumu"]);
                txtSaglikAciklama.Text = sonuc["saglikproblemiaciklama"].ToString();
                txtSigaraAdedi.Text = sonuc["sigaraadedigunluk"].ToString();
                txtAlerjiAciklama.Text = sonuc["alerjidurumuaciklama"].ToString();
                txtEvcilHayvanAciklama.Text = sonuc["evcilhayvanaciklama"].ToString();
                txtTesetturAciklama.Text = sonuc["tesetturaciklama"].ToString();
                txtEklemekIstedikleri.Text = sonuc["aciklamalar"].ToString();
			}
            
            con.Close();
           // MessageBox.Show("baglanti testi tamam");
            // MessageBox.Show(isisInsanID);

            
        }
		
		void Button1Click(object sender, EventArgs e)
		{
            if (turkerHRInsanID != "-1")
			{
            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
            OleDbConnection con; con = new OleDbConnection(constr);
            con.Open();
            string sorgu1 = @"UPDATE insanlar SET";
            sorgu1 += " isim='"+ textBox1.Text +"',";
            sorgu1 += " soyad='"+ textBox2.Text +"',";            
            sorgu1 += " cinsiyet=" + comboBox3.SelectedValue + ",";
            sorgu1 += " tckimlik='"+ textBox4.Text +"',";
            if (maskedTextBox1.Text.Length == 6)
            {
                //DateTime dt = new DateTime(1900, 01, 01, 0, 0, 0, 0); // create date time 2008-03-09 16:05:07.123             http://www.csharp-examples.net/string-format-datetime/
                sorgu1 += " dogumtarihi='" + "01.01.1900" + "',";
            }
            else
            {
                sorgu1 += " dogumtarihi='" + maskedTextBox1.Text + "',";
            }
            sorgu1 += " dogumyeriil='" + textBox5.Text + "',";
            sorgu1 += " dogumyeriilce='"+ textBox6.Text +"',";
            sorgu1 += " medenidurum=" + comboBox4.SelectedValue + ",";
            sorgu1 += " uyruk=" + comboBox5.SelectedValue + ",";
            sorgu1 += " telefonev='"+ textBox9.Text +"',";
            sorgu1 += " telefoncep='"+ textBox10.Text +"',";
            sorgu1 += " telefoncep2='"+ textBox11.Text +"',";
            sorgu1 += " eposta='"+ textBox12.Text +"',";
            sorgu1 += " adres='"+ textBox13.Text +"',";
            sorgu1 += " adresil='"+ textBox14.Text +"',";
            sorgu1 += " adresilce='"+ textBox15.Text +"',";
            sorgu1 += " askerlikdurumu=" + comboBox6.SelectedValue + ",";
            sorgu1 += " kalicisaglikdurumu=" + comboBox7.SelectedValue + ",";
            sorgu1 += " sigarakullanimi=" + comboBox8.SelectedValue + ",";
            sorgu1 += " alerjidurumu=" + comboBox9.SelectedValue + ",";
            sorgu1 += " yuzmedurumu=" + comboBox10.SelectedValue + ",";
            sorgu1 += " evcilhayvanlievdurumu=" + comboBox11.SelectedValue + ",";
            sorgu1 += " pasaportdurumu=" + comboBox12.SelectedValue + ",";
            sorgu1 += " seyahatdurumu=" + comboBox13.SelectedValue + ",";
            sorgu1 += " cocukgelisimimezunudurumu=" + comboBox14.SelectedValue + ",";
            sorgu1 += " tesetturdurumu=" + comboBox15.SelectedValue + ",";
            sorgu1 += " ilkyardimbilgisidurumu=" + comboBox16.SelectedValue + ",";
            sorgu1 += " id_calismasekli=" + comboBox2.SelectedValue + ",";
            if (textBox28.Text != "")
            {
                sorgu1 += " ucrettl=" + textBox28.Text + ",";
            }
            else
            {
                sorgu1 += " ucrettl=0 ,";
            }
            if (textBox29.Text != "")
            {
                sorgu1 += " ucretusd=" + textBox29.Text + ",";
            }
            else
            {
                sorgu1 += " ucretusd=0 ,";
            }
            sorgu1 += " id_egitimdurumu=" + comboBox1.SelectedValue + ",";
            sorgu1 += " saglikproblemiaciklama='" + txtSaglikAciklama.Text + "',"; 
            if (txtSigaraAdedi.Text != "")
            {
                sorgu1 += " sigaraadedigunluk=" + txtSigaraAdedi.Text + ",";
            }
            else
            {
                sorgu1 += " sigaraadedigunluk=0 ,";
            }
            sorgu1 += " alerjidurumuaciklama='" + txtAlerjiAciklama.Text + "',";
            sorgu1 += " evcilhayvanaciklama='" + txtEvcilHayvanAciklama.Text + "',";
            sorgu1 += " tesetturaciklama='" + txtTesetturAciklama.Text + "',";
            sorgu1 += " aciklamalar='" + txtEklemekIstedikleri.Text + "'";
            sorgu1 += " WHERE id=" + turkerHRInsanID.ToString() + @";";
            
            
            
            
            OleDbCommand objKomut=new OleDbCommand();
            objKomut.CommandText = sorgu1;
            objKomut.Connection = con;
		        try {
		        	 objKomut.ExecuteNonQuery();
		        	 MessageBox.Show("Güncelleme Başarıyla Yapıldı.");
					
		        } catch (Exception ex) {
		        	
		            	MessageBox.Show(ex.ToString());
		        }
       
            
            con.Close();
           }
			else // yani yeni kayıt
			{

            //MessageBox.Show(turkerHRInsanID.ToString());
            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
            OleDbConnection con; con = new OleDbConnection(constr);
     
            con.Open();
            
            
            string sorgu1 = @"INSERT INTO insanlar ";
            sorgu1 += "(";
            sorgu1 += "isim, soyad, cinsiyet, tckimlik, dogumyeriil, dogumyeriilce, medenidurum, uyruk,";
            sorgu1 += "telefonev, telefoncep, telefoncep2, eposta, adres, adresil, adresilce, askerlikdurumu,";
            sorgu1 += "kalicisaglikdurumu, sigarakullanimi, alerjidurumu, yuzmedurumu,";
            sorgu1 += "evcilhayvanlievdurumu, pasaportdurumu, seyahatdurumu, cocukgelisimimezunudurumu,";
            sorgu1 += "tesetturdurumu, ilkyardimbilgisidurumu, id_calismasekli, ucrettl, ucretusd, id_egitimdurumu,";
            sorgu1 += "dogumtarihi, saglikproblemiaciklama, sigaraadedigunluk, alerjidurumuaciklama, evcilhayvanaciklama, tesetturaciklama, aciklamalar";
            sorgu1 += ") VALUES (";
           // sorgu1 += "VALUES (";
           // sorgu1 += "NULL, ";
            sorgu1 += "'" + textBox1.Text + "', ";
            sorgu1 += "'" + textBox2.Text + "', ";
            sorgu1 += comboBox3.SelectedValue + ", ";
            sorgu1 += "'" + textBox4.Text + "', ";
            sorgu1 += "'" + textBox5.Text + "', ";
            sorgu1 += "'" + textBox6.Text + "', ";
            sorgu1 += comboBox4.SelectedValue + ", ";
            sorgu1 += comboBox5.SelectedValue + ", ";
            sorgu1 += "'" + textBox9.Text + "', ";
            sorgu1 += "'" + textBox10.Text + "', ";
            sorgu1 += "'" + textBox11.Text + "', ";
            sorgu1 += "'" + textBox12.Text + "', ";
            sorgu1 += "'" + textBox13.Text + "', ";
            sorgu1 += "'" + textBox14.Text + "', ";
            sorgu1 += "'" + textBox15.Text + "', ";
            sorgu1 += comboBox6.SelectedValue + ", ";
            sorgu1 += comboBox7.SelectedValue + ", ";
            sorgu1 += comboBox8.SelectedValue + ", ";
            sorgu1 += comboBox9.SelectedValue + ", ";
            sorgu1 += comboBox10.SelectedValue + ", ";
            sorgu1 += comboBox11.SelectedValue + ", ";
            sorgu1 += comboBox12.SelectedValue + ", ";
            sorgu1 += comboBox13.SelectedValue + ", ";
            sorgu1 += comboBox14.SelectedValue + ", ";
            sorgu1 += comboBox15.SelectedValue + ", ";
            sorgu1 += comboBox16.SelectedValue + ", ";
            sorgu1 += comboBox2.SelectedValue + ", ";


            if (textBox28.Text != "")
            {
                sorgu1 += textBox28.Text + ", ";
            }
            else
            {
                sorgu1 += "0, ";
            }
            if (textBox29.Text != "")
            {
                sorgu1 += textBox29.Text + ", ";
            }
            else
            {
                sorgu1 += "0, ";
            }

            sorgu1 += comboBox1.SelectedValue + ", ";
            
            if (maskedTextBox1.Text.Length == 6)
            {
                sorgu1 += "'" + "01.01.1900" + "', ";
            }
            else
            {
                sorgu1 += "'" + maskedTextBox1.Text + "', ";
                
            }

                
            sorgu1 += "'" + txtSaglikAciklama.Text + "', ";

            if (txtSigaraAdedi.Text != "")
            {
                sorgu1 += txtSigaraAdedi.Text + ", ";
            }
            else
            {
                sorgu1 += "0, ";
            }
            

            sorgu1 += "'" + txtAlerjiAciklama.Text + "', ";
            sorgu1 += "'" + txtEvcilHayvanAciklama.Text + "', ";
            sorgu1 += "'" + txtTesetturAciklama.Text + "', ";
            sorgu1 += "'" + txtEklemekIstedikleri.Text + "'";



            sorgu1 += ");";
            
            
            
            
            OleDbCommand objKomut2=new OleDbCommand();
            objKomut2.CommandText = sorgu1;
            objKomut2.Connection = con;
        try {
        	 objKomut2.ExecuteNonQuery();
             objKomut2.CommandText = "SELECT @@Identity"; // kaydı yapar yapmaz autoincrement idsini öğrenmenin tek yolu bu, bağlantıyı kapatmadan yapılır. Esas yararlandığım tek kaynak linki: //http://social.msdn.microsoft.com/Forums/en-US/adodotnetdataproviders/thread/82137b56-9dc6-484c-912b-c606464243f7
             int donenIdDegeri = Convert.ToInt32(objKomut2.ExecuteScalar()); // diğer kaynaklar: //http://support.microsoft.com/kb/232144 , bu çok değişik ve incelemeye değer: http://www.mikesdotnetting.com/Article/54/Getting-the-identity-of-the-most-recently-added-recordl
             turkerHRInsanID = donenIdDegeri.ToString();
        	 MessageBox.Show("Yeni Kayıt Başarıyla Yapıldı. ID Numarası: " + _turkerHRInsanID);
             label0.Text = turkerHRInsanID;
		
        } catch (Exception ex) {
        	
            	MessageBox.Show(ex.ToString());
        }
           
            
            con.Close();
            
					}
             
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            meslekler frmMeslekDetay = new meslekler();
            //frmKullaniciDetay.isisInsanID = "3";
            frmMeslekDetay.turkerHRInsanID = turkerHRInsanID;
            frmMeslekDetay.turkerHRIsim = textBox1.Text;
            frmMeslekDetay.turkerHRSoyad = textBox2.Text;
            if (frmMeslekDetay.turkerHRInsanID != "-1")
            {
                frmMeslekDetay.ShowDialog();
                frmMeslekDetay.Dispose();
            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden meslek ekleyemezsiniz!");
            }
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
            
         

            // http://www.ahmetkaymaz.com/2007/04/11/windows-formunu-yonetmekshowdialog-show-metodlari/
      
		}

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            frmPozisyonlarDiger frmMeslekDetay = new frmPozisyonlarDiger();
            //frmKullaniciDetay.isisInsanID = "3";
            frmMeslekDetay.turkerHRInsanID = turkerHRInsanID;
            frmMeslekDetay.turkerHRIsim = textBox1.Text;
            frmMeslekDetay.turkerHRSoyad = textBox2.Text;
            if (frmMeslekDetay.turkerHRInsanID != "-1")
            {
                frmMeslekDetay.ShowDialog();
                frmMeslekDetay.Dispose();
            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden meslekdiğer ekleyemezsiniz!");
            }
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());



            // http://www.ahmetkaymaz.com/2007/04/11/windows-formunu-yonetmekshowdialog-show-metodlari/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            frmDigerHizmetler frmMeslekDetay = new frmDigerHizmetler();
            //frmKullaniciDetay.isisInsanID = "3";
            frmMeslekDetay.turkerHRInsanID = turkerHRInsanID;
            frmMeslekDetay.turkerHRIsim = textBox1.Text;
            frmMeslekDetay.turkerHRSoyad = textBox2.Text;
            if (frmMeslekDetay.turkerHRInsanID != "-1")
            {
                frmMeslekDetay.ShowDialog();
                frmMeslekDetay.Dispose();
            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden meslekdiğer ekleyemezsiniz!");
            }
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());



            // http://www.ahmetkaymaz.com/2007/04/11/windows-formunu-yonetmekshowdialog-show-metodlari/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            frmYabanciDiller frmMeslekDetay = new frmYabanciDiller();
            //frmKullaniciDetay.isisInsanID = "3";
            frmMeslekDetay.turkerHRInsanID = turkerHRInsanID;
            frmMeslekDetay.turkerHRIsim = textBox1.Text;
            frmMeslekDetay.turkerHRSoyad = textBox2.Text;
            if (frmMeslekDetay.turkerHRInsanID != "-1")
            {
                frmMeslekDetay.ShowDialog();
                frmMeslekDetay.Dispose();
            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden Yabancı Dil ekleyemezsiniz!");
            }
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());



            // http://www.ahmetkaymaz.com/2007/04/11/windows-formunu-yonetmekshowdialog-show-metodlari/
        }

        private void button6_Click(object sender, EventArgs e)
        {

            frmReferanslar frmReferans = new frmReferanslar();
            frmReferans.turkerHRInsanID = turkerHRInsanID;
            frmReferans.turkerHRIsim = textBox1.Text;
            frmReferans.turkerHRSoyad = textBox2.Text;
            if (frmReferans.turkerHRInsanID != "-1")
            {
                frmReferans.ShowDialog();
                frmReferans.Dispose();
            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden Referans ekleyemezsiniz!");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmIsTecrubeleri frmIsTecrube = new frmIsTecrubeleri();
            frmIsTecrube.turkerHRInsanID = turkerHRInsanID;
            frmIsTecrube.turkerHRIsim = textBox1.Text;
            frmIsTecrube.turkerHRSoyad = textBox2.Text;
            if (frmIsTecrube.turkerHRInsanID != "-1")
            {
                frmIsTecrube.ShowDialog();
                frmIsTecrube.Dispose();
            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden İş Tecrübesi ekleyemezsiniz!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmKurslarSertifikalar frmKursSertifika = new frmKurslarSertifikalar();
            frmKursSertifika.turkerHRInsanID = turkerHRInsanID;
            frmKursSertifika.turkerHRIsim = textBox1.Text;
            frmKursSertifika.turkerHRSoyad = textBox2.Text;
            if (frmKursSertifika.turkerHRInsanID != "-1")
            {
                frmKursSertifika.ShowDialog();
                frmKursSertifika.Dispose();
            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden Kurslar ve Sertifikalar ekleyemezsiniz!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmEgitimBilgileri frmEgitimBilgi = new frmEgitimBilgileri();
            frmEgitimBilgi.turkerHRInsanID = turkerHRInsanID;
            frmEgitimBilgi.turkerHRIsim = textBox1.Text;
            frmEgitimBilgi.turkerHRSoyad = textBox2.Text;
            if (frmEgitimBilgi.turkerHRInsanID != "-1")
            {
                frmEgitimBilgi.ShowDialog();
                frmEgitimBilgi.Dispose();
            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden Eğitim Bilgileri ekleyemezsiniz!");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //MessageBox.Show("Gün ve Ay 2, Yıl 4 rakamlı girilmelidir, örnek: 25.09.1955");
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {
                Regex dateRegExp = new Regex(@"^(((0?[1-9]|[12]\d|3[01])[\.\-\/](0?[13578]|1[02])[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|((0?[1-9]|[12]\d|30)[\.\-\/](0?[13456789]|1[012])[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|((0?[1-9]|1\d|2[0-8])[\.\-\/]0?2[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|(29[\.\-\/]0?2[\.\-\/]((1[6-9]|[2-9]\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00|[048])))$");
                string girilenTarih = maskedTextBox1.Text;
                Match m = dateRegExp.Match(girilenTarih); //http://stackoverflow.com/questions/1752755/validate-date-textbox

                if (m.Success)
                {
                    //Valid Date, bu regexp 1600 yılından öncesini kabul etmez sonrasını eder, ayrıca 29.02.2012 gibi artık yılları bile anlar!. Çok süper.
                }
                else
                {
                    MessageBox.Show("Sırayla Gün 2 rakamlı, Ay 2 rakamlı, Yıl 4 rakamlı girilmelidir, örnek: 25.09.1955");
                    maskedTextBox1.Focus();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {


            tusKilidi();
            
        }

        void tusKilidi()
        {
            if (button1.Enabled == true)
            {
                button1.Enabled = false;
                button10.Text = "Emniyet Kilidini Aç";
            }
            else
            {
                button1.Enabled = true;
                button10.Text = "Emniyet Kilidini Kapa";
            }

            foreach (Control kontrol in this.Controls)
            {
                // this.controls yazsaydık form öğesindeki kontrol sayısı kadar, 
                // yani alt grup öğelerinin içlerindeki öğelere bakmaz.
                // kaynak: http://bytes.com/topic/c-sharp/answers/870039-checkbox-array-access-through-index
                if (kontrol is TextBox)
                    if (((TextBox)kontrol).ReadOnly == false)
                    {
                        ((TextBox)kontrol).ReadOnly = true;
                        ((TextBox)kontrol).BackColor = Color.LightYellow;
                        ((TextBox)kontrol).ForeColor = Color.Black;
                    }
                    else
                    {
                        ((TextBox)kontrol).ReadOnly = false;
                        ((TextBox)kontrol).BackColor = Color.White;//System.Drawing.SystemColors.Window;
                        ((TextBox)kontrol).ForeColor = Color.Black;
                    }
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
                if (kontrol is MaskedTextBox)
                    if (((MaskedTextBox)kontrol).ReadOnly == false)
                    {
                        ((MaskedTextBox)kontrol).ReadOnly = true;
                        ((MaskedTextBox)kontrol).BackColor = Color.LightYellow;
                        ((MaskedTextBox)kontrol).ForeColor = Color.Black;
                    }
                    else
                    {
                        ((MaskedTextBox)kontrol).ReadOnly = false;
                        ((MaskedTextBox)kontrol).BackColor = Color.White;
                        ((MaskedTextBox)kontrol).ForeColor = Color.Black;
                    }
               
            }
        }

        private void textBox28_Leave(object sender, EventArgs e)
        {
            if (sayiMi(textBox28.Text))
            {
                
            }
            else
            {
                MessageBox.Show("Lütfen sadece rakam girin!");
                textBox28.Focus();
            }
        }



        bool sayiMi(string metin)
        {
            if (button1.Enabled == true)
            {
                string sayikontrol = Regex.Match(metin, "[0-9]+").Value;
                if (sayikontrol == metin)
                {
                    return true;

                    //   MessageBox.Show("bu kelime değil bir sayı " + kelime);
                }
                else
                {
                    return false;
                    
                }
            }
            return true;

        }

        private void textBox29_Leave(object sender, EventArgs e)
        {
            if (sayiMi(textBox29.Text))
            {

            }
            else
            {
                MessageBox.Show("Lütfen sadece rakam girin!");
                textBox29.Focus();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (sayiMi(textBox4.Text))
            {
                if (textBox4.Text.Length == 11 | textBox4.Text.Length == 0)
                {

                }
                else
                {
                    if (button1.Enabled == true)
                    {
                        MessageBox.Show("Lütfen 11 rakam girin!");
                        textBox4.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen sadece rakam girin!");
                textBox4.Focus();
            }

        }

        private void txtSigaraAdedi_Leave(object sender, EventArgs e)
        {
            if (sayiMi(txtSigaraAdedi.Text))
            {

            }
            else
            {
                MessageBox.Show("Lütfen sadece rakam girin!");
                txtSigaraAdedi.Focus();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("http://www.turkerozturk.com/");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmAdaySil frmAdayKaldir = new frmAdaySil();
            frmAdayKaldir.turkerHRInsanID = turkerHRInsanID;
            frmAdayKaldir.turkerHRIsim = textBox1.Text;
            frmAdayKaldir.turkerHRSoyad = textBox2.Text;
            if (frmAdayKaldir.turkerHRInsanID != "-1")
            {
                frmAdayKaldir.ShowDialog();
                frmAdayKaldir.Dispose();

                string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
                OleDbConnection con; con = new OleDbConnection(constr);

                con.Open();
                string sorgu1 = @"SELECT count(*) FROM insanlar WHERE id=" + turkerHRInsanID.ToString() + @";";
                OleDbCommand objKomut = new OleDbCommand();
                objKomut.CommandText = sorgu1;
                objKomut.Connection = con;
                
                string sonuc = objKomut.ExecuteScalar().ToString();
                //MessageBox.Show(turkerHRInsanID.ToString() + " " + sonuc);
                con.Close();
                if (sonuc == "0")
                {
                    this.Dispose(); // çünkü silinmiş bir kayda ait pencerenin kapatılması lazım ki güncel kayıtların bulunduğu ana listeye geri dönülsün.
                }
                else
                {
                    // kullanıcı kaydı silmekten vazgeçti, yapacak birşey yok.
                }

            }
            else
            {
                MessageBox.Show("Yeni kişiyi kaydetmeden silme penceresini açamazsınız!");
            }
        }


	}
}

// http://www.vcskicks.com/data-between-forms.php