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
namespace turkerHR
{
	partial class frmListe
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbCalismaSekli = new System.Windows.Forms.ComboBox();
            this.tblCalismaSekliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.turkerHRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turkerHRveritabaniDataSet2 = new turkerHR.turkerHRveritabaniDataSet2();
            this.tblCalismaSekliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turkerHRDataSet = new turkerHR.isisveritabaniDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDigerHizmetler = new System.Windows.Forms.ComboBox();
            this.tblDigerHizmetlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMeslekGrubuDiger = new System.Windows.Forms.ComboBox();
            this.pozisyonlardigerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkDigerHizmetler = new System.Windows.Forms.CheckBox();
            this.chkMeslekGrubuDiger = new System.Windows.Forms.CheckBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.chkSoyad = new System.Windows.Forms.CheckBox();
            this.chkIsim = new System.Windows.Forms.CheckBox();
            this.chkYasAraligi = new System.Windows.Forms.CheckBox();
            this.chkEgitimDurumu = new System.Windows.Forms.CheckBox();
            this.chkUyruk = new System.Windows.Forms.CheckBox();
            this.chkCalismaSekli = new System.Windows.Forms.CheckBox();
            this.chkUcretAraligiUSD = new System.Windows.Forms.CheckBox();
            this.chkCinsiyet = new System.Windows.Forms.CheckBox();
            this.chkMeslekGrubu = new System.Windows.Forms.CheckBox();
            this.chkUcretAraligiTL = new System.Windows.Forms.CheckBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.tblCinsiyetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbYasAraligi = new System.Windows.Forms.ComboBox();
            this.tblYasAraligiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbUcretAraligiTL = new System.Windows.Forms.ComboBox();
            this.tblucretaraligitlBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbUcretAraligiUSD = new System.Windows.Forms.ComboBox();
            this.tblUcretAraligiUSDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEgitimDurumu = new System.Windows.Forms.ComboBox();
            this.tblEgitimDurumuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMeslekGrubu = new System.Windows.Forms.ComboBox();
            this.pozisyonlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.tblUyrukBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tblCinsiyetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblYasAraligiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblucretaraligitlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUcretAraligiUSDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEgitimDurumuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pozisyonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUyrukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCalismaSekliTableAdapter = new turkerHR.isisveritabaniDataSetTableAdapters.tblCalismaSekliTableAdapter();
            this.tblUyrukTableAdapter = new turkerHR.isisveritabaniDataSetTableAdapters.tblUyrukTableAdapter();
            this.tblEgitimDurumuTableAdapter = new turkerHR.isisveritabaniDataSetTableAdapters.tblEgitimDurumuTableAdapter();
            this.tblYasAraligiTableAdapter = new turkerHR.isisveritabaniDataSetTableAdapters.tblYasAraligiTableAdapter();
            this.tblUcretAraligiUSDTableAdapter = new turkerHR.isisveritabaniDataSetTableAdapters.tblUcretAraligiUSDTableAdapter();
            this.pozisyonlarTableAdapter = new turkerHR.isisveritabaniDataSetTableAdapters.pozisyonlarTableAdapter();
            this.tblCinsiyetTableAdapter = new turkerHR.isisveritabaniDataSetTableAdapters.tblCinsiyetTableAdapter();
            this.tblucretaraligitlBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblucretaraligitlTableAdapter = new turkerHR.isisveritabaniDataSetTableAdapters.tblUcretAraligiTLTableAdapter();
            this.turkerHRveritabaniDataSet1 = new turkerHR.turkerHRveritabaniDataSet1();
            this.tblucretaraligitlTableAdapter1 = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.tblucretaraligitlTableAdapter();
            this.pozisyonlarTableAdapter1 = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.pozisyonlarTableAdapter();
            this.tblCinsiyetTableAdapter1 = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.tblCinsiyetTableAdapter();
            this.tblUcretAraligiUSDTableAdapter1 = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.tblUcretAraligiUSDTableAdapter();
            this.pozisyonlardigerTableAdapter = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.pozisyonlardigerTableAdapter();
            this.tblDigerHizmetlerTableAdapter = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.tblDigerHizmetlerTableAdapter();
            this.tblCalismaSekliTableAdapter1 = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.tblCalismaSekliTableAdapter();
            this.tblUyrukTableAdapter1 = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.tblUyrukTableAdapter();
            this.tblEgitimDurumuTableAdapter1 = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.tblEgitimDurumuTableAdapter();
            this.tblYasAraligiTableAdapter1 = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.tblYasAraligiTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCalismaSekliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRveritabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCalismaSekliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigerHizmetlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozisyonlardigerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCinsiyetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYasAraligiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblucretaraligitlBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUcretAraligiUSDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEgitimDurumuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozisyonlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUyrukBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCinsiyetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYasAraligiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblucretaraligitlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUcretAraligiUSDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEgitimDurumuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozisyonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUyrukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblucretaraligitlBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRveritabaniDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 256);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 287);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Görünümü Tazele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yeni Eleman Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Filtrele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // cmbCalismaSekli
            // 
            this.cmbCalismaSekli.DataSource = this.tblCalismaSekliBindingSource1;
            this.cmbCalismaSekli.DisplayMember = "calismasekli";
            this.cmbCalismaSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalismaSekli.Enabled = false;
            this.cmbCalismaSekli.FormattingEnabled = true;
            this.cmbCalismaSekli.Location = new System.Drawing.Point(419, 53);
            this.cmbCalismaSekli.Name = "cmbCalismaSekli";
            this.cmbCalismaSekli.Size = new System.Drawing.Size(121, 21);
            this.cmbCalismaSekli.TabIndex = 7;
            this.cmbCalismaSekli.ValueMember = "id";
            // 
            // tblCalismaSekliBindingSource1
            // 
            this.tblCalismaSekliBindingSource1.DataMember = "tblCalismaSekli";
            this.tblCalismaSekliBindingSource1.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // turkerHRDataSetBindingSource
            // 
            this.turkerHRDataSetBindingSource.DataSource = this.turkerHRveritabaniDataSet2;
            this.turkerHRDataSetBindingSource.Position = 0;
            // 
            // turkerHRveritabaniDataSet2
            // 
            this.turkerHRveritabaniDataSet2.DataSetName = "turkerHRveritabaniDataSet2";
            this.turkerHRveritabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCalismaSekliBindingSource
            // 
            this.tblCalismaSekliBindingSource.DataMember = "tblCalismaSekli";
            this.tblCalismaSekliBindingSource.DataSource = this.turkerHRDataSet;
            // 
            // turkerHRDataSet
            // 
            this.turkerHRDataSet.DataSetName = "turkerHRDataSet";
            this.turkerHRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDigerHizmetler);
            this.groupBox1.Controls.Add(this.cmbMeslekGrubuDiger);
            this.groupBox1.Controls.Add(this.chkDigerHizmetler);
            this.groupBox1.Controls.Add(this.chkMeslekGrubuDiger);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.chkSoyad);
            this.groupBox1.Controls.Add(this.chkIsim);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.chkYasAraligi);
            this.groupBox1.Controls.Add(this.chkEgitimDurumu);
            this.groupBox1.Controls.Add(this.chkUyruk);
            this.groupBox1.Controls.Add(this.chkCalismaSekli);
            this.groupBox1.Controls.Add(this.chkUcretAraligiUSD);
            this.groupBox1.Controls.Add(this.chkCinsiyet);
            this.groupBox1.Controls.Add(this.chkMeslekGrubu);
            this.groupBox1.Controls.Add(this.chkUcretAraligiTL);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.cmbYasAraligi);
            this.groupBox1.Controls.Add(this.cmbUcretAraligiTL);
            this.groupBox1.Controls.Add(this.cmbUcretAraligiUSD);
            this.groupBox1.Controls.Add(this.cmbEgitimDurumu);
            this.groupBox1.Controls.Add(this.cmbMeslekGrubu);
            this.groupBox1.Controls.Add(this.cmbUyruk);
            this.groupBox1.Controls.Add(this.cmbCalismaSekli);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Kriterleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "count";
            // 
            // cmbDigerHizmetler
            // 
            this.cmbDigerHizmetler.DataSource = this.tblDigerHizmetlerBindingSource;
            this.cmbDigerHizmetler.DisplayMember = "digerhizmetler";
            this.cmbDigerHizmetler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDigerHizmetler.Enabled = false;
            this.cmbDigerHizmetler.FormattingEnabled = true;
            this.cmbDigerHizmetler.Location = new System.Drawing.Point(419, 174);
            this.cmbDigerHizmetler.Name = "cmbDigerHizmetler";
            this.cmbDigerHizmetler.Size = new System.Drawing.Size(121, 21);
            this.cmbDigerHizmetler.TabIndex = 23;
            this.cmbDigerHizmetler.ValueMember = "id";
            this.cmbDigerHizmetler.SelectedIndexChanged += new System.EventHandler(this.cmbDigerHizmetler_SelectedIndexChanged);
            // 
            // tblDigerHizmetlerBindingSource
            // 
            this.tblDigerHizmetlerBindingSource.DataMember = "tblDigerHizmetler";
            this.tblDigerHizmetlerBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // cmbMeslekGrubuDiger
            // 
            this.cmbMeslekGrubuDiger.DataSource = this.pozisyonlardigerBindingSource;
            this.cmbMeslekGrubuDiger.DisplayMember = "meslek";
            this.cmbMeslekGrubuDiger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeslekGrubuDiger.Enabled = false;
            this.cmbMeslekGrubuDiger.FormattingEnabled = true;
            this.cmbMeslekGrubuDiger.Location = new System.Drawing.Point(142, 172);
            this.cmbMeslekGrubuDiger.Name = "cmbMeslekGrubuDiger";
            this.cmbMeslekGrubuDiger.Size = new System.Drawing.Size(121, 21);
            this.cmbMeslekGrubuDiger.TabIndex = 21;
            this.cmbMeslekGrubuDiger.ValueMember = "id";
            // 
            // pozisyonlardigerBindingSource
            // 
            this.pozisyonlardigerBindingSource.DataMember = "pozisyonlardiger";
            this.pozisyonlardigerBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // chkDigerHizmetler
            // 
            this.chkDigerHizmetler.AutoSize = true;
            this.chkDigerHizmetler.Location = new System.Drawing.Point(308, 176);
            this.chkDigerHizmetler.Name = "chkDigerHizmetler";
            this.chkDigerHizmetler.Size = new System.Drawing.Size(97, 17);
            this.chkDigerHizmetler.TabIndex = 22;
            this.chkDigerHizmetler.Text = "Diğer Hizmetler";
            this.chkDigerHizmetler.UseVisualStyleBackColor = true;
            this.chkDigerHizmetler.CheckedChanged += new System.EventHandler(this.chkDigerHizmetler_CheckedChanged);
            // 
            // chkMeslekGrubuDiger
            // 
            this.chkMeslekGrubuDiger.AutoSize = true;
            this.chkMeslekGrubuDiger.Location = new System.Drawing.Point(9, 176);
            this.chkMeslekGrubuDiger.Name = "chkMeslekGrubuDiger";
            this.chkMeslekGrubuDiger.Size = new System.Drawing.Size(120, 17);
            this.chkMeslekGrubuDiger.TabIndex = 20;
            this.chkMeslekGrubuDiger.Text = "Meslek Grubu Diğer";
            this.chkMeslekGrubuDiger.UseVisualStyleBackColor = true;
            this.chkMeslekGrubuDiger.CheckedChanged += new System.EventHandler(this.chkMeslekGrubuDiger_CheckedChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(419, 22);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtIsim
            // 
            this.txtIsim.Enabled = false;
            this.txtIsim.Location = new System.Drawing.Point(141, 23);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(121, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // chkSoyad
            // 
            this.chkSoyad.AutoSize = true;
            this.chkSoyad.Location = new System.Drawing.Point(307, 25);
            this.chkSoyad.Name = "chkSoyad";
            this.chkSoyad.Size = new System.Drawing.Size(56, 17);
            this.chkSoyad.TabIndex = 2;
            this.chkSoyad.Text = "Soyad";
            this.chkSoyad.UseVisualStyleBackColor = true;
            this.chkSoyad.CheckedChanged += new System.EventHandler(this.chkSoyad_CheckedChanged);
            // 
            // chkIsim
            // 
            this.chkIsim.AutoSize = true;
            this.chkIsim.Location = new System.Drawing.Point(9, 26);
            this.chkIsim.Name = "chkIsim";
            this.chkIsim.Size = new System.Drawing.Size(44, 17);
            this.chkIsim.TabIndex = 0;
            this.chkIsim.Text = "İsim";
            this.chkIsim.UseVisualStyleBackColor = true;
            this.chkIsim.CheckedChanged += new System.EventHandler(this.chkIsim_CheckedChanged);
            // 
            // chkYasAraligi
            // 
            this.chkYasAraligi.AutoSize = true;
            this.chkYasAraligi.Location = new System.Drawing.Point(307, 138);
            this.chkYasAraligi.Name = "chkYasAraligi";
            this.chkYasAraligi.Size = new System.Drawing.Size(75, 17);
            this.chkYasAraligi.TabIndex = 18;
            this.chkYasAraligi.Text = "Yaş Aralığı";
            this.chkYasAraligi.UseVisualStyleBackColor = true;
            this.chkYasAraligi.CheckedChanged += new System.EventHandler(this.chkYasAraligi_CheckedChanged);
            // 
            // chkEgitimDurumu
            // 
            this.chkEgitimDurumu.AutoSize = true;
            this.chkEgitimDurumu.Location = new System.Drawing.Point(307, 109);
            this.chkEgitimDurumu.Name = "chkEgitimDurumu";
            this.chkEgitimDurumu.Size = new System.Drawing.Size(94, 17);
            this.chkEgitimDurumu.TabIndex = 14;
            this.chkEgitimDurumu.Text = "Eğitim Durumu";
            this.chkEgitimDurumu.UseVisualStyleBackColor = true;
            this.chkEgitimDurumu.CheckedChanged += new System.EventHandler(this.chkEgitimDurumu_CheckedChanged);
            // 
            // chkUyruk
            // 
            this.chkUyruk.AutoSize = true;
            this.chkUyruk.Location = new System.Drawing.Point(307, 83);
            this.chkUyruk.Name = "chkUyruk";
            this.chkUyruk.Size = new System.Drawing.Size(54, 17);
            this.chkUyruk.TabIndex = 10;
            this.chkUyruk.Text = "Uyruk";
            this.chkUyruk.UseVisualStyleBackColor = true;
            this.chkUyruk.CheckedChanged += new System.EventHandler(this.chkUyruk_CheckedChanged);
            // 
            // chkCalismaSekli
            // 
            this.chkCalismaSekli.AutoSize = true;
            this.chkCalismaSekli.Location = new System.Drawing.Point(307, 57);
            this.chkCalismaSekli.Name = "chkCalismaSekli";
            this.chkCalismaSekli.Size = new System.Drawing.Size(88, 17);
            this.chkCalismaSekli.TabIndex = 6;
            this.chkCalismaSekli.Text = "Çalışma Şekli";
            this.chkCalismaSekli.UseVisualStyleBackColor = true;
            this.chkCalismaSekli.CheckedChanged += new System.EventHandler(this.chkCalismaSekli_CheckedChanged);
            // 
            // chkUcretAraligiUSD
            // 
            this.chkUcretAraligiUSD.AutoSize = true;
            this.chkUcretAraligiUSD.Location = new System.Drawing.Point(9, 138);
            this.chkUcretAraligiUSD.Name = "chkUcretAraligiUSD";
            this.chkUcretAraligiUSD.Size = new System.Drawing.Size(109, 17);
            this.chkUcretAraligiUSD.TabIndex = 16;
            this.chkUcretAraligiUSD.Text = "Ücret Aralığı USD";
            this.chkUcretAraligiUSD.UseVisualStyleBackColor = true;
            this.chkUcretAraligiUSD.CheckedChanged += new System.EventHandler(this.chkUcretAraligiUSD_CheckedChanged);
            // 
            // chkCinsiyet
            // 
            this.chkCinsiyet.AutoSize = true;
            this.chkCinsiyet.Location = new System.Drawing.Point(9, 111);
            this.chkCinsiyet.Name = "chkCinsiyet";
            this.chkCinsiyet.Size = new System.Drawing.Size(62, 17);
            this.chkCinsiyet.TabIndex = 12;
            this.chkCinsiyet.Text = "Cinsiyet";
            this.chkCinsiyet.UseVisualStyleBackColor = true;
            this.chkCinsiyet.CheckedChanged += new System.EventHandler(this.chkCinsiyet_CheckedChanged);
            // 
            // chkMeslekGrubu
            // 
            this.chkMeslekGrubu.AutoSize = true;
            this.chkMeslekGrubu.Location = new System.Drawing.Point(9, 84);
            this.chkMeslekGrubu.Name = "chkMeslekGrubu";
            this.chkMeslekGrubu.Size = new System.Drawing.Size(92, 17);
            this.chkMeslekGrubu.TabIndex = 8;
            this.chkMeslekGrubu.Text = "Meslek Grubu";
            this.chkMeslekGrubu.UseVisualStyleBackColor = true;
            this.chkMeslekGrubu.CheckedChanged += new System.EventHandler(this.chkMeslekGrubu_CheckedChanged);
            // 
            // chkUcretAraligiTL
            // 
            this.chkUcretAraligiTL.AutoSize = true;
            this.chkUcretAraligiTL.Location = new System.Drawing.Point(9, 57);
            this.chkUcretAraligiTL.Name = "chkUcretAraligiTL";
            this.chkUcretAraligiTL.Size = new System.Drawing.Size(99, 17);
            this.chkUcretAraligiTL.TabIndex = 4;
            this.chkUcretAraligiTL.Text = "Ücret Aralığı TL";
            this.chkUcretAraligiTL.UseVisualStyleBackColor = true;
            this.chkUcretAraligiTL.CheckedChanged += new System.EventHandler(this.chkUcretAraligiTL_CheckedChanged);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DataSource = this.tblCinsiyetBindingSource1;
            this.cmbCinsiyet.DisplayMember = "cinsiyet";
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.Enabled = false;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(141, 107);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 13;
            this.cmbCinsiyet.ValueMember = "id";
            // 
            // tblCinsiyetBindingSource1
            // 
            this.tblCinsiyetBindingSource1.DataMember = "tblCinsiyet";
            this.tblCinsiyetBindingSource1.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // cmbYasAraligi
            // 
            this.cmbYasAraligi.DataSource = this.tblYasAraligiBindingSource1;
            this.cmbYasAraligi.DisplayMember = "yasaraligi";
            this.cmbYasAraligi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYasAraligi.Enabled = false;
            this.cmbYasAraligi.FormattingEnabled = true;
            this.cmbYasAraligi.Location = new System.Drawing.Point(419, 134);
            this.cmbYasAraligi.Name = "cmbYasAraligi";
            this.cmbYasAraligi.Size = new System.Drawing.Size(121, 21);
            this.cmbYasAraligi.TabIndex = 19;
            this.cmbYasAraligi.ValueMember = "id";
            // 
            // tblYasAraligiBindingSource1
            // 
            this.tblYasAraligiBindingSource1.DataMember = "tblYasAraligi";
            this.tblYasAraligiBindingSource1.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // cmbUcretAraligiTL
            // 
            this.cmbUcretAraligiTL.DataSource = this.tblucretaraligitlBindingSource2;
            this.cmbUcretAraligiTL.DisplayMember = "ucretaraligi";
            this.cmbUcretAraligiTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUcretAraligiTL.Enabled = false;
            this.cmbUcretAraligiTL.FormattingEnabled = true;
            this.cmbUcretAraligiTL.Location = new System.Drawing.Point(141, 53);
            this.cmbUcretAraligiTL.Name = "cmbUcretAraligiTL";
            this.cmbUcretAraligiTL.Size = new System.Drawing.Size(121, 21);
            this.cmbUcretAraligiTL.TabIndex = 5;
            this.cmbUcretAraligiTL.ValueMember = "id";
            this.cmbUcretAraligiTL.SelectedIndexChanged += new System.EventHandler(this.cmbUcretAraligiTL_SelectedIndexChanged);
            // 
            // tblucretaraligitlBindingSource2
            // 
            this.tblucretaraligitlBindingSource2.DataMember = "tblucretaraligitl";
            this.tblucretaraligitlBindingSource2.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // cmbUcretAraligiUSD
            // 
            this.cmbUcretAraligiUSD.DataSource = this.tblUcretAraligiUSDBindingSource1;
            this.cmbUcretAraligiUSD.DisplayMember = "ucretaraligi";
            this.cmbUcretAraligiUSD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUcretAraligiUSD.Enabled = false;
            this.cmbUcretAraligiUSD.FormattingEnabled = true;
            this.cmbUcretAraligiUSD.Location = new System.Drawing.Point(142, 134);
            this.cmbUcretAraligiUSD.Name = "cmbUcretAraligiUSD";
            this.cmbUcretAraligiUSD.Size = new System.Drawing.Size(120, 21);
            this.cmbUcretAraligiUSD.TabIndex = 17;
            this.cmbUcretAraligiUSD.ValueMember = "id";
            // 
            // tblUcretAraligiUSDBindingSource1
            // 
            this.tblUcretAraligiUSDBindingSource1.DataMember = "tblUcretAraligiUSD";
            this.tblUcretAraligiUSDBindingSource1.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // cmbEgitimDurumu
            // 
            this.cmbEgitimDurumu.DataSource = this.tblEgitimDurumuBindingSource1;
            this.cmbEgitimDurumu.DisplayMember = "egitimdurumu";
            this.cmbEgitimDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEgitimDurumu.Enabled = false;
            this.cmbEgitimDurumu.FormattingEnabled = true;
            this.cmbEgitimDurumu.Location = new System.Drawing.Point(419, 107);
            this.cmbEgitimDurumu.Name = "cmbEgitimDurumu";
            this.cmbEgitimDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbEgitimDurumu.TabIndex = 15;
            this.cmbEgitimDurumu.ValueMember = "id";
            // 
            // tblEgitimDurumuBindingSource1
            // 
            this.tblEgitimDurumuBindingSource1.DataMember = "tblEgitimDurumu";
            this.tblEgitimDurumuBindingSource1.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // cmbMeslekGrubu
            // 
            this.cmbMeslekGrubu.DataSource = this.pozisyonlarBindingSource1;
            this.cmbMeslekGrubu.DisplayMember = "meslek";
            this.cmbMeslekGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeslekGrubu.Enabled = false;
            this.cmbMeslekGrubu.FormattingEnabled = true;
            this.cmbMeslekGrubu.Location = new System.Drawing.Point(141, 80);
            this.cmbMeslekGrubu.Name = "cmbMeslekGrubu";
            this.cmbMeslekGrubu.Size = new System.Drawing.Size(121, 21);
            this.cmbMeslekGrubu.TabIndex = 9;
            this.cmbMeslekGrubu.ValueMember = "id";
            // 
            // pozisyonlarBindingSource1
            // 
            this.pozisyonlarBindingSource1.DataMember = "pozisyonlar";
            this.pozisyonlarBindingSource1.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // cmbUyruk
            // 
            this.cmbUyruk.DataSource = this.tblUyrukBindingSource1;
            this.cmbUyruk.DisplayMember = "uyruk";
            this.cmbUyruk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyruk.Enabled = false;
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Location = new System.Drawing.Point(419, 80);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.Size = new System.Drawing.Size(121, 21);
            this.cmbUyruk.TabIndex = 11;
            this.cmbUyruk.ValueMember = "id";
            // 
            // tblUyrukBindingSource1
            // 
            this.tblUyrukBindingSource1.DataMember = "tblUyruk";
            this.tblUyrukBindingSource1.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 186);
            this.label1.MaximumSize = new System.Drawing.Size(100, 50);
            this.label1.MinimumSize = new System.Drawing.Size(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 50);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sorgu İnceleme";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tblCinsiyetBindingSource
            // 
            this.tblCinsiyetBindingSource.DataMember = "tblCinsiyet";
            this.tblCinsiyetBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // tblYasAraligiBindingSource
            // 
            this.tblYasAraligiBindingSource.DataMember = "tblYasAraligi";
            this.tblYasAraligiBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // tblucretaraligitlBindingSource
            // 
            this.tblucretaraligitlBindingSource.DataMember = "tblucretaraligitl";
            this.tblucretaraligitlBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // tblUcretAraligiUSDBindingSource
            // 
            this.tblUcretAraligiUSDBindingSource.DataMember = "tblUcretAraligiUSD";
            this.tblUcretAraligiUSDBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // tblEgitimDurumuBindingSource
            // 
            this.tblEgitimDurumuBindingSource.DataMember = "tblEgitimDurumu";
            this.tblEgitimDurumuBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // pozisyonlarBindingSource
            // 
            this.pozisyonlarBindingSource.DataMember = "pozisyonlar";
            this.pozisyonlarBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // tblUyrukBindingSource
            // 
            this.tblUyrukBindingSource.DataMember = "tblUyruk";
            this.tblUyrukBindingSource.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // tblCalismaSekliTableAdapter
            // 
            this.tblCalismaSekliTableAdapter.ClearBeforeFill = true;
            // 
            // tblUyrukTableAdapter
            // 
            this.tblUyrukTableAdapter.ClearBeforeFill = true;
            // 
            // tblEgitimDurumuTableAdapter
            // 
            this.tblEgitimDurumuTableAdapter.ClearBeforeFill = true;
            // 
            // tblYasAraligiTableAdapter
            // 
            this.tblYasAraligiTableAdapter.ClearBeforeFill = true;
            // 
            // tblUcretAraligiUSDTableAdapter
            // 
            this.tblUcretAraligiUSDTableAdapter.ClearBeforeFill = true;
            // 
            // pozisyonlarTableAdapter
            // 
            this.pozisyonlarTableAdapter.ClearBeforeFill = true;
            // 
            // tblCinsiyetTableAdapter
            // 
            this.tblCinsiyetTableAdapter.ClearBeforeFill = true;
            // 
            // tblucretaraligitlBindingSource1
            // 
            this.tblucretaraligitlBindingSource1.DataMember = "tblucretaraligitl";
            this.tblucretaraligitlBindingSource1.DataSource = this.turkerHRDataSetBindingSource;
            // 
            // tblucretaraligitlTableAdapter
            // 
            this.tblucretaraligitlTableAdapter.ClearBeforeFill = true;
            // 
            // turkerHRveritabaniDataSet1
            // 
            this.turkerHRveritabaniDataSet1.DataSetName = "turkerHRveritabaniDataSet1";
            this.turkerHRveritabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblucretaraligitlTableAdapter1
            // 
            this.tblucretaraligitlTableAdapter1.ClearBeforeFill = true;
            // 
            // pozisyonlarTableAdapter1
            // 
            this.pozisyonlarTableAdapter1.ClearBeforeFill = true;
            // 
            // tblCinsiyetTableAdapter1
            // 
            this.tblCinsiyetTableAdapter1.ClearBeforeFill = true;
            // 
            // tblUcretAraligiUSDTableAdapter1
            // 
            this.tblUcretAraligiUSDTableAdapter1.ClearBeforeFill = true;
            // 
            // pozisyonlardigerTableAdapter
            // 
            this.pozisyonlardigerTableAdapter.ClearBeforeFill = true;
            // 
            // tblDigerHizmetlerTableAdapter
            // 
            this.tblDigerHizmetlerTableAdapter.ClearBeforeFill = true;
            // 
            // tblCalismaSekliTableAdapter1
            // 
            this.tblCalismaSekliTableAdapter1.ClearBeforeFill = true;
            // 
            // tblUyrukTableAdapter1
            // 
            this.tblUyrukTableAdapter1.ClearBeforeFill = true;
            // 
            // tblEgitimDurumuTableAdapter1
            // 
            this.tblEgitimDurumuTableAdapter1.ClearBeforeFill = true;
            // 
            // tblYasAraligiTableAdapter1
            // 
            this.tblYasAraligiTableAdapter1.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Veritabanı Yedekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Program Hakkında Yardım";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Toplam Sonuç:";
            // 
            // frmListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 543);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmListe";
            this.Text = "Aday Arama Formu";
            this.Load += new System.EventHandler(this.frmListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCalismaSekliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRveritabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCalismaSekliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigerHizmetlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozisyonlardigerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCinsiyetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYasAraligiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblucretaraligitlBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUcretAraligiUSDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEgitimDurumuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozisyonlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUyrukBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCinsiyetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYasAraligiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblucretaraligitlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUcretAraligiUSDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEgitimDurumuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozisyonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUyrukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblucretaraligitlBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRveritabaniDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCalismaSekli;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridView dataGridView1;
        private isisveritabaniDataSet turkerHRDataSet;
        private System.Windows.Forms.BindingSource tblCalismaSekliBindingSource;
        private isisveritabaniDataSetTableAdapters.tblCalismaSekliTableAdapter tblCalismaSekliTableAdapter;
        private System.Windows.Forms.ComboBox cmbYasAraligi;
        private System.Windows.Forms.ComboBox cmbUcretAraligiTL;
        private System.Windows.Forms.ComboBox cmbUcretAraligiUSD;
        private System.Windows.Forms.ComboBox cmbEgitimDurumu;
        private System.Windows.Forms.ComboBox cmbMeslekGrubu;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.BindingSource turkerHRDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblUyrukBindingSource;
        private isisveritabaniDataSetTableAdapters.tblUyrukTableAdapter tblUyrukTableAdapter;
        private System.Windows.Forms.BindingSource tblEgitimDurumuBindingSource;
        private isisveritabaniDataSetTableAdapters.tblEgitimDurumuTableAdapter tblEgitimDurumuTableAdapter;
        private System.Windows.Forms.BindingSource tblYasAraligiBindingSource;
        private isisveritabaniDataSetTableAdapters.tblYasAraligiTableAdapter tblYasAraligiTableAdapter;
        private System.Windows.Forms.BindingSource tblUcretAraligiUSDBindingSource;
        private isisveritabaniDataSetTableAdapters.tblUcretAraligiUSDTableAdapter tblUcretAraligiUSDTableAdapter;
        private System.Windows.Forms.BindingSource pozisyonlarBindingSource;
        private isisveritabaniDataSetTableAdapters.pozisyonlarTableAdapter pozisyonlarTableAdapter;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.BindingSource tblCinsiyetBindingSource;
        private isisveritabaniDataSetTableAdapters.tblCinsiyetTableAdapter tblCinsiyetTableAdapter;
        private System.Windows.Forms.CheckBox chkYasAraligi;
        private System.Windows.Forms.CheckBox chkEgitimDurumu;
        private System.Windows.Forms.CheckBox chkUyruk;
        private System.Windows.Forms.CheckBox chkCalismaSekli;
        private System.Windows.Forms.CheckBox chkUcretAraligiUSD;
        private System.Windows.Forms.CheckBox chkCinsiyet;
        private System.Windows.Forms.CheckBox chkMeslekGrubu;
        private System.Windows.Forms.CheckBox chkUcretAraligiTL;
        private System.Windows.Forms.BindingSource tblucretaraligitlBindingSource1;
        private System.Windows.Forms.BindingSource tblucretaraligitlBindingSource;
        private isisveritabaniDataSetTableAdapters.tblUcretAraligiTLTableAdapter tblucretaraligitlTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.CheckBox chkSoyad;
        private System.Windows.Forms.CheckBox chkIsim;
        private System.Windows.Forms.ComboBox cmbDigerHizmetler;
        private System.Windows.Forms.ComboBox cmbMeslekGrubuDiger;
        private System.Windows.Forms.CheckBox chkDigerHizmetler;
        private System.Windows.Forms.CheckBox chkMeslekGrubuDiger;
        private turkerHRveritabaniDataSet1 turkerHRveritabaniDataSet1;
        private turkerHRveritabaniDataSet2 turkerHRveritabaniDataSet2;
        private System.Windows.Forms.BindingSource tblucretaraligitlBindingSource2;
        private turkerHRveritabaniDataSet2TableAdapters.tblucretaraligitlTableAdapter tblucretaraligitlTableAdapter1;
        private System.Windows.Forms.BindingSource pozisyonlarBindingSource1;
        private turkerHRveritabaniDataSet2TableAdapters.pozisyonlarTableAdapter pozisyonlarTableAdapter1;
        private System.Windows.Forms.BindingSource tblCinsiyetBindingSource1;
        private turkerHRveritabaniDataSet2TableAdapters.tblCinsiyetTableAdapter tblCinsiyetTableAdapter1;
        private System.Windows.Forms.BindingSource tblUcretAraligiUSDBindingSource1;
        private turkerHRveritabaniDataSet2TableAdapters.tblUcretAraligiUSDTableAdapter tblUcretAraligiUSDTableAdapter1;
        private System.Windows.Forms.BindingSource pozisyonlardigerBindingSource;
        private turkerHRveritabaniDataSet2TableAdapters.pozisyonlardigerTableAdapter pozisyonlardigerTableAdapter;
        private System.Windows.Forms.BindingSource tblDigerHizmetlerBindingSource;
        private turkerHRveritabaniDataSet2TableAdapters.tblDigerHizmetlerTableAdapter tblDigerHizmetlerTableAdapter;
        private System.Windows.Forms.BindingSource tblCalismaSekliBindingSource1;
        private turkerHRveritabaniDataSet2TableAdapters.tblCalismaSekliTableAdapter tblCalismaSekliTableAdapter1;
        private System.Windows.Forms.BindingSource tblUyrukBindingSource1;
        private turkerHRveritabaniDataSet2TableAdapters.tblUyrukTableAdapter tblUyrukTableAdapter1;
        private System.Windows.Forms.BindingSource tblEgitimDurumuBindingSource1;
        private turkerHRveritabaniDataSet2TableAdapters.tblEgitimDurumuTableAdapter tblEgitimDurumuTableAdapter1;
        private System.Windows.Forms.BindingSource tblYasAraligiBindingSource1;
        private turkerHRveritabaniDataSet2TableAdapters.tblYasAraligiTableAdapter tblYasAraligiTableAdapter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
	}
}
