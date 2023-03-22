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
    public partial class frmIsTecrubeleri : Form
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
        public frmIsTecrubeleri()
        {
            InitializeComponent();
        }

        private void frmIsTecrubeleri_Load(object sender, EventArgs e)
        {
            yenile();
        }

        void yenile()
        {
            label1.Text = _turkerHRInsanID.ToString();
            label2.Text = _turkerHRIsim;
            label3.Text = _turkerHRSoyad;
            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + klasoryolu + @"\turkerHRveritabani.mdb;";
            con = new OleDbConnection(constr);

            con.Open();


            string sorgu = @"SELECT * FROM tblIsTecrubeleri WHERE idinsanlar=" + turkerHRInsanID.ToString() + @";";
            objKomut = new OleDbCommand();
            objKomut.CommandText = sorgu;
            objKomut.Connection = con;
            OleDbDataReader sonuc;
            sonuc = objKomut.ExecuteReader();

            BindingSource bindingSource1 = new BindingSource(); // bunu kullanarak normal sql sorgumu datagride bağlayabildim yani dataset ve data adapter kullanmadım zaten pek sevmiyorum alışamadım henüz veritabanından bağımsız olarak datasetlerle çalışmaya.

            bindingSource1.DataSource = sonuc; //http://msdn.microsoft.com/tr-tr/library/system.windows.forms.datagridview.datasource.aspx
            dataGridView1.DataSource = bindingSource1;


            sonuc.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIsTecrubeleriEkle frmIsTecrubeEkle = new frmIsTecrubeleriEkle();
            frmIsTecrubeEkle.turkerHRInsanID = turkerHRInsanID;
            frmIsTecrubeEkle.turkerHRIsim = turkerHRIsim;
            frmIsTecrubeEkle.turkerHRSoyad = turkerHRSoyad;
            frmIsTecrubeEkle.turkerHRIsTecrubeID = "-1";
            frmIsTecrubeEkle.ShowDialog();
            frmIsTecrubeEkle.Dispose();
            yenile();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmIsTecrubeleriEkle frmIsTecrubeEkle = new frmIsTecrubeleriEkle();
            frmIsTecrubeEkle.turkerHRInsanID = turkerHRInsanID;
            frmIsTecrubeEkle.turkerHRIsim = turkerHRIsim;
            frmIsTecrubeEkle.turkerHRSoyad = turkerHRSoyad;
            frmIsTecrubeEkle.turkerHRIsTecrubeID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frmIsTecrubeEkle.ShowDialog();
            frmIsTecrubeEkle.Dispose();
            yenile();

        }

       
    }
}
