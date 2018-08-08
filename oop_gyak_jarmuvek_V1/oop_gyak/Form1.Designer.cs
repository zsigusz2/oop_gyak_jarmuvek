namespace oop_gyak
{
    partial class frm_jarmuvek
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
            this.bt_exit = new System.Windows.Forms.Button();
            this.gp_kategoriak = new System.Windows.Forms.GroupBox();
            this.rb_szgk = new System.Windows.Forms.RadioButton();
            this.rb_tdk = new System.Windows.Forms.RadioButton();
            this.rb_mkp = new System.Windows.Forms.RadioButton();
            this.la_text1 = new System.Windows.Forms.Label();
            this.la_text2 = new System.Windows.Forms.Label();
            this.gp_szgk = new System.Windows.Forms.GroupBox();
            this.rb_nincs = new System.Windows.Forms.RadioButton();
            this.rb_van = new System.Windows.Forms.RadioButton();
            this.nud_szszsz = new System.Windows.Forms.NumericUpDown();
            this.nud_ccm = new System.Windows.Forms.NumericUpDown();
            this.nud_gye = new System.Windows.Forms.NumericUpDown();
            this.nud_ot = new System.Windows.Forms.NumericUpDown();
            this.nud_st = new System.Windows.Forms.NumericUpDown();
            this.tb_marka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.la_text3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_ajtok = new System.Windows.Forms.NumericUpDown();
            this.bt_feltolt = new System.Windows.Forms.Button();
            this.bt_kiir = new System.Windows.Forms.Button();
            this.gp_kategoriak.SuspendLayout();
            this.gp_szgk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_szszsz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ccm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ajtok)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(521, 415);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(68, 23);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "Kilépés";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // gp_kategoriak
            // 
            this.gp_kategoriak.Controls.Add(this.rb_mkp);
            this.gp_kategoriak.Controls.Add(this.rb_tdk);
            this.gp_kategoriak.Controls.Add(this.rb_szgk);
            this.gp_kategoriak.Location = new System.Drawing.Point(12, 12);
            this.gp_kategoriak.Name = "gp_kategoriak";
            this.gp_kategoriak.Size = new System.Drawing.Size(156, 111);
            this.gp_kategoriak.TabIndex = 1;
            this.gp_kategoriak.TabStop = false;
            this.gp_kategoriak.Text = "Kategóriák";
            // 
            // rb_szgk
            // 
            this.rb_szgk.AutoSize = true;
            this.rb_szgk.Location = new System.Drawing.Point(6, 19);
            this.rb_szgk.Name = "rb_szgk";
            this.rb_szgk.Size = new System.Drawing.Size(107, 17);
            this.rb_szgk.TabIndex = 1;
            this.rb_szgk.TabStop = true;
            this.rb_szgk.Text = "Személygépkocsi";
            this.rb_szgk.UseVisualStyleBackColor = true;
            this.rb_szgk.CheckedChanged += new System.EventHandler(this.rb_szgk_CheckedChanged);
            // 
            // rb_tdk
            // 
            this.rb_tdk.AutoSize = true;
            this.rb_tdk.Location = new System.Drawing.Point(6, 52);
            this.rb_tdk.Name = "rb_tdk";
            this.rb_tdk.Size = new System.Drawing.Size(96, 17);
            this.rb_tdk.TabIndex = 2;
            this.rb_tdk.TabStop = true;
            this.rb_tdk.Text = "Tehergépkocsi";
            this.rb_tdk.UseVisualStyleBackColor = true;
            this.rb_tdk.CheckedChanged += new System.EventHandler(this.rb_szgk_CheckedChanged);
            // 
            // rb_mkp
            // 
            this.rb_mkp.AutoSize = true;
            this.rb_mkp.Location = new System.Drawing.Point(6, 84);
            this.rb_mkp.Name = "rb_mkp";
            this.rb_mkp.Size = new System.Drawing.Size(94, 17);
            this.rb_mkp.TabIndex = 3;
            this.rb_mkp.TabStop = true;
            this.rb_mkp.Text = "Motorkerékpár";
            this.rb_mkp.UseVisualStyleBackColor = true;
            this.rb_mkp.CheckedChanged += new System.EventHandler(this.rb_szgk_CheckedChanged);
            // 
            // la_text1
            // 
            this.la_text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_text1.Location = new System.Drawing.Point(174, 21);
            this.la_text1.Name = "la_text1";
            this.la_text1.Size = new System.Drawing.Size(92, 23);
            this.la_text1.TabIndex = 2;
            this.la_text1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // la_text2
            // 
            this.la_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_text2.Location = new System.Drawing.Point(272, 21);
            this.la_text2.Name = "la_text2";
            this.la_text2.Size = new System.Drawing.Size(151, 23);
            this.la_text2.TabIndex = 3;
            this.la_text2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gp_szgk
            // 
            this.gp_szgk.Controls.Add(this.bt_kiir);
            this.gp_szgk.Controls.Add(this.bt_feltolt);
            this.gp_szgk.Controls.Add(this.nud_ajtok);
            this.gp_szgk.Controls.Add(this.label7);
            this.gp_szgk.Controls.Add(this.rb_nincs);
            this.gp_szgk.Controls.Add(this.rb_van);
            this.gp_szgk.Controls.Add(this.nud_szszsz);
            this.gp_szgk.Controls.Add(this.nud_ccm);
            this.gp_szgk.Controls.Add(this.nud_gye);
            this.gp_szgk.Controls.Add(this.nud_ot);
            this.gp_szgk.Controls.Add(this.nud_st);
            this.gp_szgk.Controls.Add(this.tb_marka);
            this.gp_szgk.Controls.Add(this.label6);
            this.gp_szgk.Controls.Add(this.label5);
            this.gp_szgk.Controls.Add(this.label4);
            this.gp_szgk.Controls.Add(this.label3);
            this.gp_szgk.Controls.Add(this.label2);
            this.gp_szgk.Controls.Add(this.label1);
            this.gp_szgk.Controls.Add(this.la_text3);
            this.gp_szgk.Location = new System.Drawing.Point(178, 47);
            this.gp_szgk.Name = "gp_szgk";
            this.gp_szgk.Size = new System.Drawing.Size(411, 353);
            this.gp_szgk.TabIndex = 5;
            this.gp_szgk.TabStop = false;
            this.gp_szgk.Text = "Személygépkocsi";
            this.gp_szgk.Visible = false;
            // 
            // rb_nincs
            // 
            this.rb_nincs.AutoSize = true;
            this.rb_nincs.Location = new System.Drawing.Point(287, 127);
            this.rb_nincs.Name = "rb_nincs";
            this.rb_nincs.Size = new System.Drawing.Size(52, 17);
            this.rb_nincs.TabIndex = 29;
            this.rb_nincs.Text = "Nincs";
            this.rb_nincs.UseVisualStyleBackColor = true;
            // 
            // rb_van
            // 
            this.rb_van.AutoSize = true;
            this.rb_van.Checked = true;
            this.rb_van.Location = new System.Drawing.Point(231, 127);
            this.rb_van.Name = "rb_van";
            this.rb_van.Size = new System.Drawing.Size(44, 17);
            this.rb_van.TabIndex = 28;
            this.rb_van.TabStop = true;
            this.rb_van.Text = "Van";
            this.rb_van.UseVisualStyleBackColor = true;
            // 
            // nud_szszsz
            // 
            this.nud_szszsz.Location = new System.Drawing.Point(231, 206);
            this.nud_szszsz.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_szszsz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_szszsz.Name = "nud_szszsz";
            this.nud_szszsz.Size = new System.Drawing.Size(100, 20);
            this.nud_szszsz.TabIndex = 27;
            this.nud_szszsz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_ccm
            // 
            this.nud_ccm.Location = new System.Drawing.Point(231, 166);
            this.nud_ccm.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_ccm.Name = "nud_ccm";
            this.nud_ccm.Size = new System.Drawing.Size(100, 20);
            this.nud_ccm.TabIndex = 26;
            // 
            // nud_gye
            // 
            this.nud_gye.Location = new System.Drawing.Point(231, 90);
            this.nud_gye.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nud_gye.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nud_gye.Name = "nud_gye";
            this.nud_gye.Size = new System.Drawing.Size(100, 20);
            this.nud_gye.TabIndex = 25;
            this.nud_gye.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nud_ot
            // 
            this.nud_ot.Location = new System.Drawing.Point(231, 53);
            this.nud_ot.Maximum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.nud_ot.Name = "nud_ot";
            this.nud_ot.Size = new System.Drawing.Size(100, 20);
            this.nud_ot.TabIndex = 24;
            // 
            // nud_st
            // 
            this.nud_st.Location = new System.Drawing.Point(231, 19);
            this.nud_st.Maximum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.nud_st.Name = "nud_st";
            this.nud_st.Size = new System.Drawing.Size(100, 20);
            this.nud_st.TabIndex = 23;
            // 
            // tb_marka
            // 
            this.tb_marka.AccessibleDescription = "Opel";
            this.tb_marka.Location = new System.Drawing.Point(231, 247);
            this.tb_marka.Name = "tb_marka";
            this.tb_marka.Size = new System.Drawing.Size(100, 20);
            this.tb_marka.TabIndex = 22;
            this.tb_marka.Tag = "";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Márka:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Szállítható személyek száma:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ccm3:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Érvényes forgalmi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gyártás éve:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Össztömeg:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // la_text3
            // 
            this.la_text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_text3.Location = new System.Drawing.Point(3, 16);
            this.la_text3.Name = "la_text3";
            this.la_text3.Size = new System.Drawing.Size(126, 23);
            this.la_text3.TabIndex = 15;
            this.la_text3.Text = "Salyát tömeg:";
            this.la_text3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ajtók száma:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nud_ajtok
            // 
            this.nud_ajtok.Location = new System.Drawing.Point(231, 281);
            this.nud_ajtok.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_ajtok.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_ajtok.Name = "nud_ajtok";
            this.nud_ajtok.Size = new System.Drawing.Size(100, 20);
            this.nud_ajtok.TabIndex = 31;
            this.nud_ajtok.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // bt_feltolt
            // 
            this.bt_feltolt.Location = new System.Drawing.Point(6, 315);
            this.bt_feltolt.Name = "bt_feltolt";
            this.bt_feltolt.Size = new System.Drawing.Size(101, 23);
            this.bt_feltolt.TabIndex = 32;
            this.bt_feltolt.Text = "Autó létrehozása";
            this.bt_feltolt.UseVisualStyleBackColor = true;
            this.bt_feltolt.Click += new System.EventHandler(this.bt_feltolt_Click);
            // 
            // bt_kiir
            // 
            this.bt_kiir.Enabled = false;
            this.bt_kiir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_kiir.Location = new System.Drawing.Point(113, 315);
            this.bt_kiir.Name = "bt_kiir";
            this.bt_kiir.Size = new System.Drawing.Size(162, 23);
            this.bt_kiir.TabIndex = 33;
            this.bt_kiir.Text = "Autó adatainak kiírása fileba";
            this.bt_kiir.UseVisualStyleBackColor = true;
            this.bt_kiir.Click += new System.EventHandler(this.bt_kiir_Click);
            // 
            // frm_jarmuvek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.gp_szgk);
            this.Controls.Add(this.la_text2);
            this.Controls.Add(this.la_text1);
            this.Controls.Add(this.gp_kategoriak);
            this.Controls.Add(this.bt_exit);
            this.Name = "frm_jarmuvek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Járműcsoportok";
            this.gp_kategoriak.ResumeLayout(false);
            this.gp_kategoriak.PerformLayout();
            this.gp_szgk.ResumeLayout(false);
            this.gp_szgk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_szszsz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ccm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ajtok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.GroupBox gp_kategoriak;
        private System.Windows.Forms.RadioButton rb_mkp;
        private System.Windows.Forms.RadioButton rb_tdk;
        private System.Windows.Forms.RadioButton rb_szgk;
        private System.Windows.Forms.Label la_text1;
        private System.Windows.Forms.Label la_text2;
        private System.Windows.Forms.GroupBox gp_szgk;
        private System.Windows.Forms.RadioButton rb_nincs;
        private System.Windows.Forms.RadioButton rb_van;
        private System.Windows.Forms.NumericUpDown nud_szszsz;
        private System.Windows.Forms.NumericUpDown nud_ccm;
        private System.Windows.Forms.NumericUpDown nud_gye;
        private System.Windows.Forms.NumericUpDown nud_ot;
        private System.Windows.Forms.NumericUpDown nud_st;
        private System.Windows.Forms.TextBox tb_marka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label la_text3;
        private System.Windows.Forms.NumericUpDown nud_ajtok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_feltolt;
        private System.Windows.Forms.Button bt_kiir;
    }
}

