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

﻿namespace turkerHR
{
    partial class frmYabanciDiller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.turkerHRveritabaniDataSet2 = new turkerHR.turkerHRveritabaniDataSet2();
            this.seviyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seviyeTableAdapter = new turkerHR.turkerHRveritabaniDataSet2TableAdapters.seviyeTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRveritabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(24, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 391);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yabancı Diller";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(207, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 391);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seviyeler";
            // 
            // turkerHRveritabaniDataSet2
            // 
            this.turkerHRveritabaniDataSet2.DataSetName = "turkerHRveritabaniDataSet2";
            this.turkerHRveritabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seviyeBindingSource
            // 
            this.seviyeBindingSource.DataMember = "seviye";
            this.seviyeBindingSource.DataSource = this.turkerHRveritabaniDataSet2;
            // 
            // seviyeTableAdapter
            // 
            this.seviyeTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dikkat: Seçmediğiniz dillerin seviyeleri, güncelle düğmesine basınca Diğer olurla" +
                "r.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Emniyet Kilidi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmYabanciDiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmYabanciDiller";
            this.Text = "frmYabanciDiller";
            this.Load += new System.EventHandler(this.frmYabanciDiller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turkerHRveritabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private turkerHRveritabaniDataSet2 turkerHRveritabaniDataSet2;
        private System.Windows.Forms.BindingSource seviyeBindingSource;
        private turkerHRveritabaniDataSet2TableAdapters.seviyeTableAdapter seviyeTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}