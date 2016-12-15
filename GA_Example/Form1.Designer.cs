namespace GA_Example
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMoVB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_Path = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtVanBan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSoKyTu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtViTriXuatHien = new System.Windows.Forms.TextBox();
            this.txtLanXuatHien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtXSDotBien = new System.Windows.Forms.TextBox();
            this.txtXSLai = new System.Windows.Forms.TextBox();
            this.txtSoTheHe = new System.Windows.Forms.TextBox();
            this.txtKichThuocQT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtHeSoB = new System.Windows.Forms.TextBox();
            this.txtHeSoA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoVB
            // 
            this.btnMoVB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMoVB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMoVB.Image = ((System.Drawing.Image)(resources.GetObject("btnMoVB.Image")));
            this.btnMoVB.Location = new System.Drawing.Point(522, 27);
            this.btnMoVB.Name = "btnMoVB";
            this.btnMoVB.Size = new System.Drawing.Size(30, 30);
            this.btnMoVB.TabIndex = 50;
            this.btnMoVB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoVB.UseVisualStyleBackColor = false;
            this.btnMoVB.Click += new System.EventHandler(this.btnMoVB_Click);
            // 
            // lb_Path
            // 
            this.lb_Path.AutoSize = true;
            this.lb_Path.Location = new System.Drawing.Point(95, 13);
            this.lb_Path.Name = "lb_Path";
            this.lb_Path.Size = new System.Drawing.Size(0, 13);
            this.lb_Path.TabIndex = 1;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(10, 84);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(501, 20);
            this.txtTim.TabIndex = 2;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(522, 74);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(30, 30);
            this.btnTim.TabIndex = 3;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtVanBan
            // 
            this.txtVanBan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVanBan.Location = new System.Drawing.Point(10, 19);
            this.txtVanBan.Multiline = true;
            this.txtVanBan.Name = "txtVanBan";
            this.txtVanBan.ReadOnly = true;
            this.txtVanBan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVanBan.Size = new System.Drawing.Size(542, 170);
            this.txtVanBan.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDuongDan);
            this.groupBox1.Controls.Add(this.lb_Path);
            this.groupBox1.Controls.Add(this.btnMoVB);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 118);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(10, 37);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(501, 20);
            this.txtDuongDan.TabIndex = 51;
            this.txtDuongDan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDuongDan.TextChanged += new System.EventHandler(this.txtDuongDan_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVanBan);
            this.groupBox2.Location = new System.Drawing.Point(9, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 199);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Văn bản";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Controls.Add(this.txtSoKyTu);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtViTriXuatHien);
            this.groupBox3.Controls.Add(this.txtLanXuatHien);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(9, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 201);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // txtSoKyTu
            // 
            this.txtSoKyTu.Location = new System.Drawing.Point(122, 26);
            this.txtSoKyTu.Name = "txtSoKyTu";
            this.txtSoKyTu.ReadOnly = true;
            this.txtSoKyTu.Size = new System.Drawing.Size(100, 20);
            this.txtSoKyTu.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Số từ của văn bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vị trí xuất hiện";
            // 
            // txtViTriXuatHien
            // 
            this.txtViTriXuatHien.Location = new System.Drawing.Point(122, 66);
            this.txtViTriXuatHien.Multiline = true;
            this.txtViTriXuatHien.Name = "txtViTriXuatHien";
            this.txtViTriXuatHien.ReadOnly = true;
            this.txtViTriXuatHien.Size = new System.Drawing.Size(430, 57);
            this.txtViTriXuatHien.TabIndex = 2;
            // 
            // txtLanXuatHien
            // 
            this.txtLanXuatHien.Location = new System.Drawing.Point(452, 26);
            this.txtLanXuatHien.Name = "txtLanXuatHien";
            this.txtLanXuatHien.ReadOnly = true;
            this.txtLanXuatHien.Size = new System.Drawing.Size(100, 20);
            this.txtLanXuatHien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lần xuất hiện";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtXSDotBien);
            this.groupBox4.Controls.Add(this.txtXSLai);
            this.groupBox4.Controls.Add(this.txtSoTheHe);
            this.groupBox4.Controls.Add(this.txtKichThuocQT);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(589, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 226);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tham số di truyền GA";
            // 
            // txtXSDotBien
            // 
            this.txtXSDotBien.Location = new System.Drawing.Point(135, 182);
            this.txtXSDotBien.Name = "txtXSDotBien";
            this.txtXSDotBien.Size = new System.Drawing.Size(100, 20);
            this.txtXSDotBien.TabIndex = 7;
            // 
            // txtXSLai
            // 
            this.txtXSLai.Location = new System.Drawing.Point(135, 133);
            this.txtXSLai.Name = "txtXSLai";
            this.txtXSLai.Size = new System.Drawing.Size(100, 20);
            this.txtXSLai.TabIndex = 6;
            // 
            // txtSoTheHe
            // 
            this.txtSoTheHe.Location = new System.Drawing.Point(135, 83);
            this.txtSoTheHe.Name = "txtSoTheHe";
            this.txtSoTheHe.Size = new System.Drawing.Size(100, 20);
            this.txtSoTheHe.TabIndex = 5;
            // 
            // txtKichThuocQT
            // 
            this.txtKichThuocQT.Location = new System.Drawing.Point(135, 37);
            this.txtKichThuocQT.Name = "txtKichThuocQT";
            this.txtKichThuocQT.Size = new System.Drawing.Size(100, 20);
            this.txtKichThuocQT.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Xác suất đột biến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Xác suất lai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số thế hệ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kích thước quần thể ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtHeSoB);
            this.groupBox5.Controls.Add(this.txtHeSoA);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(589, 281);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 129);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tham số ưu tiên";
            // 
            // txtHeSoB
            // 
            this.txtHeSoB.Location = new System.Drawing.Point(118, 83);
            this.txtHeSoB.Name = "txtHeSoB";
            this.txtHeSoB.Size = new System.Drawing.Size(117, 20);
            this.txtHeSoB.TabIndex = 3;
            // 
            // txtHeSoA
            // 
            this.txtHeSoA.Location = new System.Drawing.Point(118, 31);
            this.txtHeSoA.Name = "txtHeSoA";
            this.txtHeSoA.Size = new System.Drawing.Size(117, 20);
            this.txtHeSoA.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hệ số b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hệ số a";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(122, 129);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(430, 66);
            this.txtResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 591);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoVB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lb_Path;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtVanBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLanXuatHien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtViTriXuatHien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSoTheHe;
        private System.Windows.Forms.TextBox txtKichThuocQT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXSLai;
        private System.Windows.Forms.TextBox txtXSDotBien;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtHeSoB;
        private System.Windows.Forms.TextBox txtHeSoA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoKyTu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResult;
    }
}

