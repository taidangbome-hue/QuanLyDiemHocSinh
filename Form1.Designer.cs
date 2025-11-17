namespace Quản_lý_điểm_học_sinh
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
            this.textBox2_DiemVan = new System.Windows.Forms.TextBox();
            this.textBox3_DiemVan = new System.Windows.Forms.TextBox();
            this.button1_themtths = new System.Windows.Forms.Button();
            this.dataGridView1_danhsach = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_HoTen = new System.Windows.Forms.TextBox();
            this.button1_luu = new System.Windows.Forms.Button();
            this.button2_mobai = new System.Windows.Forms.Button();
            this.button1_xoa = new System.Windows.Forms.Button();
            this.button1_luubai_c2 = new System.Windows.Forms.Button();
            this.button1_mobai_c2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_danhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2_DiemVan
            // 
            this.textBox2_DiemVan.Location = new System.Drawing.Point(227, 46);
            this.textBox2_DiemVan.Name = "textBox2_DiemVan";
            this.textBox2_DiemVan.Size = new System.Drawing.Size(100, 20);
            this.textBox2_DiemVan.TabIndex = 2;
            // 
            // textBox3_DiemVan
            // 
            this.textBox3_DiemVan.Location = new System.Drawing.Point(392, 45);
            this.textBox3_DiemVan.Name = "textBox3_DiemVan";
            this.textBox3_DiemVan.Size = new System.Drawing.Size(100, 20);
            this.textBox3_DiemVan.TabIndex = 3;
            // 
            // button1_themtths
            // 
            this.button1_themtths.Location = new System.Drawing.Point(237, 126);
            this.button1_themtths.Name = "button1_themtths";
            this.button1_themtths.Size = new System.Drawing.Size(75, 23);
            this.button1_themtths.TabIndex = 4;
            this.button1_themtths.Text = "Thêm :";
            this.button1_themtths.UseVisualStyleBackColor = true;
            this.button1_themtths.Click += new System.EventHandler(this.button1_themtths_Click);
            // 
            // dataGridView1_danhsach
            // 
            this.dataGridView1_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_danhsach.Location = new System.Drawing.Point(46, 194);
            this.dataGridView1_danhsach.Name = "dataGridView1_danhsach";
            this.dataGridView1_danhsach.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1_danhsach.TabIndex = 5;
            this.dataGridView1_danhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_danhsach_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ Tên : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điểm Văn : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Điểm Toán : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1_HoTen
            // 
            this.textBox1_HoTen.Location = new System.Drawing.Point(62, 46);
            this.textBox1_HoTen.Name = "textBox1_HoTen";
            this.textBox1_HoTen.Size = new System.Drawing.Size(100, 20);
            this.textBox1_HoTen.TabIndex = 9;
            // 
            // button1_luu
            // 
            this.button1_luu.Location = new System.Drawing.Point(62, 126);
            this.button1_luu.Name = "button1_luu";
            this.button1_luu.Size = new System.Drawing.Size(75, 23);
            this.button1_luu.TabIndex = 10;
            this.button1_luu.Text = "Lưu bài:";
            this.button1_luu.UseVisualStyleBackColor = true;
            this.button1_luu.Click += new System.EventHandler(this.button1_luu_Click);
            // 
            // button2_mobai
            // 
            this.button2_mobai.Location = new System.Drawing.Point(392, 126);
            this.button2_mobai.Name = "button2_mobai";
            this.button2_mobai.Size = new System.Drawing.Size(75, 23);
            this.button2_mobai.TabIndex = 11;
            this.button2_mobai.Text = "Mở bài : ";
            this.button2_mobai.UseVisualStyleBackColor = true;
            this.button2_mobai.Click += new System.EventHandler(this.button2_mobai_Click);
            // 
            // button1_xoa
            // 
            this.button1_xoa.Location = new System.Drawing.Point(547, 126);
            this.button1_xoa.Name = "button1_xoa";
            this.button1_xoa.Size = new System.Drawing.Size(75, 23);
            this.button1_xoa.TabIndex = 12;
            this.button1_xoa.Text = "xóa ";
            this.button1_xoa.UseVisualStyleBackColor = true;
            this.button1_xoa.Click += new System.EventHandler(this.button1_xoa_Click);
            // 
            // button1_luubai_c2
            // 
            this.button1_luubai_c2.Location = new System.Drawing.Point(62, 165);
            this.button1_luubai_c2.Name = "button1_luubai_c2";
            this.button1_luubai_c2.Size = new System.Drawing.Size(75, 23);
            this.button1_luubai_c2.TabIndex = 13;
            this.button1_luubai_c2.Text = "lưu bài";
            this.button1_luubai_c2.UseVisualStyleBackColor = true;
            this.button1_luubai_c2.Click += new System.EventHandler(this.button1_luubai_c2_Click);
            // 
            // button1_mobai_c2
            // 
            this.button1_mobai_c2.Location = new System.Drawing.Point(392, 165);
            this.button1_mobai_c2.Name = "button1_mobai_c2";
            this.button1_mobai_c2.Size = new System.Drawing.Size(75, 23);
            this.button1_mobai_c2.TabIndex = 14;
            this.button1_mobai_c2.Text = "mobai";
            this.button1_mobai_c2.UseVisualStyleBackColor = true;
            this.button1_mobai_c2.Click += new System.EventHandler(this.button1_mobai_c2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 418);
            this.Controls.Add(this.button1_mobai_c2);
            this.Controls.Add(this.button1_luubai_c2);
            this.Controls.Add(this.button1_xoa);
            this.Controls.Add(this.button2_mobai);
            this.Controls.Add(this.button1_luu);
            this.Controls.Add(this.textBox1_HoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_danhsach);
            this.Controls.Add(this.button1_themtths);
            this.Controls.Add(this.textBox3_DiemVan);
            this.Controls.Add(this.textBox2_DiemVan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_danhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2_DiemVan;
        private System.Windows.Forms.TextBox textBox3_DiemVan;
        private System.Windows.Forms.Button button1_themtths;
        private System.Windows.Forms.DataGridView dataGridView1_danhsach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_HoTen;
        private System.Windows.Forms.Button button1_luu;
        private System.Windows.Forms.Button button2_mobai;
        private System.Windows.Forms.Button button1_xoa;
        private System.Windows.Forms.Button button1_luubai_c2;
        private System.Windows.Forms.Button button1_mobai_c2;
    }
}

