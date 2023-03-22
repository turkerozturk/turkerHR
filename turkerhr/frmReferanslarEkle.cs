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
using System.Data.OleDb;
using System.IO;

namespace turkerHR
{
    public partial class frmReferanslarEkle : Form
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


        private string _turkerHRReferansID; //forma parametre alisverisi icin
        public string turkerHRReferansID
        {
            get { return _turkerHRReferansID; }
            set { _turkerHRReferansID = value; }
        } //http://www.vcskicks.com/data-between-forms.php

        OleDbConnection con;
        OleDbCommand objKomut;

        public frmReferanslarEkle()
        {
            InitializeComponent();
        }

        private void frmReferanslarEkle_Load(object sender, EventArgs e)
        {
            if (turkerHRReferansID != "-1")
            {
                tusKilidi();
            }
            label1.Text = "Kullanıcı ID ve İsim Soyad: " + _turkerHRInsanID + " " + _turkerHRIsim + " " + _turkerHRSoyad;
            label2.Text = "Referans ID: " + _turkerHRReferansID;

            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
            con = new OleDbConnection(constr);

            con.Open();

            //string sorgu1 = @"SELECT * FROM insanlar WHERE isim='ali';";
            string sorgu1 = @"SELECT * FROM tblReferanslar WHERE id=" + turkerHRReferansID.ToString() + @";";
            objKomut = new OleDbCommand();
            objKomut.CommandText = sorgu1;
            objKomut.Connection = con;
            OleDbDataReader sonuc;
            sonuc = objKomut.ExecuteReader();

            while (sonuc.Read())
            {
                textBox1.Text = sonuc["kurum"].ToString();                
                textBox2.Text = sonuc["kisi"].ToString();
                textBox3.Text = sonuc["unvan"].ToString();
                textBox4.Text = sonuc["telefon1"].ToString();
                textBox5.Text = sonuc["telefon2"].ToString();
                textBox6.Text = sonuc["email"].ToString();
                textBox7.Text = sonuc["webadresi"].ToString();
            }

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (turkerHRReferansID != "-1")
            {
                
                con.Open();
                string sorgu1 = @"UPDATE tblReferanslar SET";
                //sorgu1 += " id=" + turkerHRReferansID + ",";
                sorgu1 += " idinsanlar=" + turkerHRInsanID + ",";
                sorgu1 += " kurum='" + textBox1.Text + "',";
                sorgu1 += " kisi='" + textBox2.Text + "',";
                sorgu1 += " unvan='" + textBox3.Text + "',";
                sorgu1 += " telefon1='" + textBox4.Text + "',";
                sorgu1 += " telefon2='" + textBox5.Text + "',";
                sorgu1 += " email='" + textBox6.Text + "',";
                sorgu1 += " webadresi='" + textBox7.Text + "'";
                sorgu1 += " WHERE id=" + turkerHRReferansID.ToString() + @";";

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


                string sorgu1 = @"INSERT INTO tblReferanslar ";
                sorgu1 += "(";
                sorgu1 += "idinsanlar, kurum, kisi, unvan, telefon1, telefon2, email, webadresi";
                sorgu1 += ") VALUES (";
                // sorgu1 += "VALUES (";
                // sorgu1 += "NULL, ";
                sorgu1 += "'" + turkerHRInsanID + "', ";
                sorgu1 += "'" + textBox1.Text + "', ";
                sorgu1 += "'" + textBox2.Text + "', ";
                sorgu1 += "'" + textBox3.Text + "', ";
                sorgu1 += "'" + textBox4.Text + "', ";
                sorgu1 += "'" + textBox5.Text + "', ";
                sorgu1 += "'" + textBox6.Text + "', ";
                sorgu1 += "'" + textBox7.Text + "'";                
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
