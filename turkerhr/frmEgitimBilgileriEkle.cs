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
using System.Text.RegularExpressions;

namespace turkerHR
{
    public partial class frmEgitimBilgileriEkle : Form
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


        private string _turkerHREgitimBilgiID; //forma parametre alisverisi icin
        public string turkerHREgitimBilgiID
        {
            get { return _turkerHREgitimBilgiID; }
            set { _turkerHREgitimBilgiID = value; }
        } //http://www.vcskicks.com/data-between-forms.php

        OleDbConnection con;
        OleDbCommand objKomut;

        public frmEgitimBilgileriEkle()
        {
            InitializeComponent();
        }

        private void frmEgitimBilgileriEkle_Load(object sender, EventArgs e)
        {
            if (turkerHREgitimBilgiID != "-1")
            {
                tusKilidi();
            }
        label1.Text = "Kullanıcı ID ve İsim Soyad: " + _turkerHRInsanID + " " + _turkerHRIsim + " " + _turkerHRSoyad;
            label2.Text += turkerHREgitimBilgiID;

            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
            con = new OleDbConnection(constr);

            con.Open();

            string sorgu1 = @"SELECT * FROM tblEgitimBilgileri WHERE id=" + turkerHREgitimBilgiID + @";";
            objKomut = new OleDbCommand();
            objKomut.CommandText = sorgu1;
            objKomut.Connection = con;
            OleDbDataReader sonuc;
            sonuc = objKomut.ExecuteReader();

            while (sonuc.Read())
            {
                textBox1.Text = sonuc["okul"].ToString();
                textBox2.Text = sonuc["aciklama"].ToString();
                textBox3.Text = sonuc["baslangictarihi"].ToString();
                textBox4.Text = sonuc["bitistarihi"].ToString();
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Bu kodlar müşterinin isteğiyle iptal edildi.
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "")
            {
                MessageBox.Show("Lütfen tüm kutuları doldurun.");
            }
            else
            {
             * */
                if (turkerHREgitimBilgiID != "-1")
                {

                    con.Open();
                    string sorgu1 = @"UPDATE tblEgitimBilgileri SET";
                    //sorgu1 += " id=" + turkerHREgitimBilgiID + ",";
                    sorgu1 += " idinsanlar=" + turkerHRInsanID + ",";
                    sorgu1 += " okul='" + textBox1.Text + "',";
                    sorgu1 += " aciklama='" + textBox2.Text + "',";
                    sorgu1 += " baslangictarihi='" + textBox3.Text + "',";
                    sorgu1 += " bitistarihi='" + textBox4.Text + "'";
                    sorgu1 += " WHERE id=" + turkerHREgitimBilgiID.ToString() + @";";

                    objKomut = new OleDbCommand();
                    objKomut.CommandText = sorgu1;
                    objKomut.Connection = con;
                    try
                    {
                        objKomut.ExecuteNonQuery();
                        MessageBox.Show("Güncelleme Başarıyla Yapıldı.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    con.Close();
                }
                else // yani yeni kayıt
                {

                    con.Open();


                    string sorgu1 = @"INSERT INTO tblEgitimBilgileri ";
                    sorgu1 += "(";
                    sorgu1 += "idinsanlar, okul, aciklama, baslangictarihi, bitistarihi";
                    sorgu1 += ") VALUES (";
                    // sorgu1 += "VALUES (";
                    // sorgu1 += "NULL, ";
                    sorgu1 += "'" + turkerHRInsanID + "', ";
                    sorgu1 += "'" + textBox1.Text + "', ";
                    sorgu1 += "'" + textBox2.Text + "', ";
                    sorgu1 += "'" + textBox3.Text + "', ";
                    sorgu1 += "'" + textBox4.Text + "'";
                    sorgu1 += ");";

                    OleDbCommand objKomut2 = new OleDbCommand();
                    objKomut2.CommandText = sorgu1;
                    objKomut2.Connection = con;
                    try
                    {
                        objKomut2.ExecuteNonQuery();
                        MessageBox.Show("Yeni Kayıt Başarıyla Yapıldı.");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }


                    con.Close();

                }
                this.Dispose();
            /* Bu kodlar müşterinin isteğiyle iptal edildi.
           }
             * */
       }

       private void textBox3_Leave(object sender, EventArgs e)
       {
           /* Bu kodlar müşterinin isteğiyle iptal edildi, veritabanında tarih alanları text alanlarına dönüştürüldü.
           if (button1.Enabled == true)
           {
               Regex dateRegExp = new Regex(@"^(((0?[1-9]|[12]\d|3[01])[\.\-\/](0?[13578]|1[02])[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|((0?[1-9]|[12]\d|30)[\.\-\/](0?[13456789]|1[012])[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|((0?[1-9]|1\d|2[0-8])[\.\-\/]0?2[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|(29[\.\-\/]0?2[\.\-\/]((1[6-9]|[2-9]\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00|[048])))$");
               string girilenTarih = textBox3.Text;
               Match m = dateRegExp.Match(girilenTarih); //http://stackoverflow.com/questions/1752755/validate-date-textbox

               if (m.Success)
               {
                   //Valid Date, bu regexp 1600 yılından öncesini kabul etmez sonrasını eder, ayrıca 29.02.2012 gibi artık yılları bile anlar!. Çok süper.
               }
               else
               {
                   MessageBox.Show("Sırayla Gün 2 rakamlı, Ay 2 rakamlı, Yıl 4 rakamlı girilmelidir, örnek: 25.09.1955");
                   textBox3.Focus();
               }
           }
            */
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            /* Bu kodlar müşterinin isteğiyle iptal edildi. veritabanında tarih alanları text alanlarına dönüştürüldü.
            if (button1.Enabled == true)
            {
                Regex dateRegExp = new Regex(@"^(((0?[1-9]|[12]\d|3[01])[\.\-\/](0?[13578]|1[02])[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|((0?[1-9]|[12]\d|30)[\.\-\/](0?[13456789]|1[012])[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|((0?[1-9]|1\d|2[0-8])[\.\-\/]0?2[\.\-\/]((1[6-9]|[2-9]\d)?\d{2}|\d))|(29[\.\-\/]0?2[\.\-\/]((1[6-9]|[2-9]\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00|[048])))$");
                string girilenTarih = textBox4.Text;
                Match m = dateRegExp.Match(girilenTarih); //http://stackoverflow.com/questions/1752755/validate-date-textbox

                if (m.Success)
                {
                    //Valid Date, bu regexp 1600 yılından öncesini kabul etmez sonrasını eder, ayrıca 29.02.2012 gibi artık yılları bile anlar!. Çok süper.
                }
                else
                {
                    MessageBox.Show("Sırayla Gün 2 rakamlı, Ay 2 rakamlı, Yıl 4 rakamlı girilmelidir, örnek: 25.09.1955");
                    textBox4.Focus();
                }
            }
             */
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
                        ((TextBox)kontrol).BackColor = Color.White;
                        ((TextBox)kontrol).ForeColor = Color.Black;
                    }

            }
        }
    }
}
