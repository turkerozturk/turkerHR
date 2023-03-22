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
    public partial class frmAdaySil : Form
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

        public frmAdaySil()
        {
            InitializeComponent();
        }

        private void frmAdaySil_Load(object sender, EventArgs e)
        {
           /* if (turkerHRInsanID != "-1")
            {
                tusKilidi();
            }
            * */
            label1.Text = "Kullanıcı ID ve İsim Soyad: " + _turkerHRInsanID + " " + _turkerHRIsim + " " + _turkerHRSoyad;
            label2.Text = "Referans ID: " + turkerHRInsanID;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "evet")
            {
                string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
                con = new OleDbConnection(constr);
                con.Open();
                string sorgu1 = @"DELETE FROM insanlar WHERE id=" + turkerHRInsanID.ToString() + @";";
                objKomut = new OleDbCommand();
                objKomut.CommandText = sorgu1;
                objKomut.Connection = con;
                objKomut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("KAYIT SİLİNDİ: "  +_turkerHRInsanID + " " + _turkerHRIsim + " " + _turkerHRSoyad);
            }
        }
    }
}
