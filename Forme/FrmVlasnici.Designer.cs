﻿namespace Forme
{
    partial class FrmVlasnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVlasnici));
            this.gridLjubimci = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVlasnici = new System.Windows.Forms.ComboBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZanimanje = new System.Windows.Forms.TextBox();
            this.btnObrisiLjub = new System.Windows.Forms.Button();
            this.btnIzmeniVlasnika = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnSacuvajVlasnika = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLjubimci)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLjubimci
            // 
            this.gridLjubimci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLjubimci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLjubimci.Location = new System.Drawing.Point(7, 26);
            this.gridLjubimci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridLjubimci.Name = "gridLjubimci";
            this.gridLjubimci.ReadOnly = true;
            this.gridLjubimci.RowHeadersWidth = 51;
            this.gridLjubimci.RowTemplate.Height = 24;
            this.gridLjubimci.Size = new System.Drawing.Size(728, 127);
            this.gridLjubimci.TabIndex = 0;
            this.gridLjubimci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLjubimci_CellDoubleClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridLjubimci);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(19, 418);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(745, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ljubimci";
            // 
            // cmbVlasnici
            // 
            this.cmbVlasnici.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVlasnici.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVlasnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbVlasnici.FormattingEnabled = true;
            this.cmbVlasnici.Location = new System.Drawing.Point(19, 47);
            this.cmbVlasnici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVlasnici.Name = "cmbVlasnici";
            this.cmbVlasnici.Size = new System.Drawing.Size(341, 30);
            this.cmbVlasnici.TabIndex = 2;
            this.cmbVlasnici.SelectedIndexChanged += new System.EventHandler(this.cmbVlasnici_SelectedIndexChanged);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(135, 98);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(225, 27);
            this.txtIme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(135, 146);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(225, 27);
            this.txtPrezime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTelefon.Location = new System.Drawing.Point(135, 198);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(225, 27);
            this.txtTelefon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.Location = new System.Drawing.Point(135, 245);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(225, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(15, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Zanimanje";
            // 
            // txtZanimanje
            // 
            this.txtZanimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZanimanje.Location = new System.Drawing.Point(135, 295);
            this.txtZanimanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZanimanje.Name = "txtZanimanje";
            this.txtZanimanje.ReadOnly = true;
            this.txtZanimanje.Size = new System.Drawing.Size(225, 27);
            this.txtZanimanje.TabIndex = 11;
            // 
            // btnObrisiLjub
            // 
            this.btnObrisiLjub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiLjub.Location = new System.Drawing.Point(388, 341);
            this.btnObrisiLjub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiLjub.Name = "btnObrisiLjub";
            this.btnObrisiLjub.Size = new System.Drawing.Size(149, 60);
            this.btnObrisiLjub.TabIndex = 14;
            this.btnObrisiLjub.Text = "Obriši ljubimca";
            this.btnObrisiLjub.UseVisualStyleBackColor = true;
            this.btnObrisiLjub.Visible = false;
            this.btnObrisiLjub.Click += new System.EventHandler(this.btnObrisiLjub_Click);
            // 
            // btnIzmeniVlasnika
            // 
            this.btnIzmeniVlasnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniVlasnika.Location = new System.Drawing.Point(389, 341);
            this.btnIzmeniVlasnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmeniVlasnika.Name = "btnIzmeniVlasnika";
            this.btnIzmeniVlasnika.Size = new System.Drawing.Size(149, 60);
            this.btnIzmeniVlasnika.TabIndex = 15;
            this.btnIzmeniVlasnika.Text = "Izmeni vlasnika";
            this.btnIzmeniVlasnika.UseVisualStyleBackColor = true;
            this.btnIzmeniVlasnika.Click += new System.EventHandler(this.btnIzmeniVlasnika_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNapomena.Location = new System.Drawing.Point(135, 354);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.ReadOnly = true;
            this.txtNapomena.Size = new System.Drawing.Size(225, 47);
            this.txtNapomena.TabIndex = 17;
            // 
            // btnSacuvajVlasnika
            // 
            this.btnSacuvajVlasnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvajVlasnika.Location = new System.Drawing.Point(558, 341);
            this.btnSacuvajVlasnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSacuvajVlasnika.Name = "btnSacuvajVlasnika";
            this.btnSacuvajVlasnika.Size = new System.Drawing.Size(159, 60);
            this.btnSacuvajVlasnika.TabIndex = 19;
            this.btnSacuvajVlasnika.Text = "Sačuvaj vlasnika";
            this.btnSacuvajVlasnika.UseVisualStyleBackColor = true;
            this.btnSacuvajVlasnika.Click += new System.EventHandler(this.btnSacuvajVlasnika_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forme.Properties.Resources.Webp_net_resizeimage__1_;
            this.pictureBox1.Location = new System.Drawing.Point(388, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 272);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVlasnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSacuvajVlasnika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.btnIzmeniVlasnika);
            this.Controls.Add(this.btnObrisiLjub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtZanimanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.cmbVlasnici);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmVlasnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vlasnici";
            this.Load += new System.EventHandler(this.FrmVlasnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLjubimci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLjubimci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbVlasnici;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZanimanje;
        private System.Windows.Forms.Button btnObrisiLjub;
        private System.Windows.Forms.Button btnIzmeniVlasnika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnSacuvajVlasnika;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}