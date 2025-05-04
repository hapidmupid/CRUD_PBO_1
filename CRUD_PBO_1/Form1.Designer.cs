namespace CRUD_PBO_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tb_penerbit = new TextBox();
            tb_judul = new TextBox();
            tb_tahun = new TextBox();
            tb_kategori = new TextBox();
            btnsimpan = new Button();
            btnlihat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnreset = new Button();
            SuspendLayout();
            // 
            // tb_penerbit
            // 
            tb_penerbit.BorderStyle = BorderStyle.None;
            tb_penerbit.Cursor = Cursors.IBeam;
            tb_penerbit.Font = new Font("Montserrat", 8F);
            tb_penerbit.ForeColor = SystemColors.Desktop;
            tb_penerbit.Location = new Point(268, 107);
            tb_penerbit.Name = "tb_penerbit";
            tb_penerbit.Size = new Size(480, 20);
            tb_penerbit.TabIndex = 0;
            // 
            // tb_judul
            // 
            tb_judul.BorderStyle = BorderStyle.None;
            tb_judul.Cursor = Cursors.IBeam;
            tb_judul.Font = new Font("Montserrat", 8F);
            tb_judul.ForeColor = SystemColors.Desktop;
            tb_judul.Location = new Point(269, 50);
            tb_judul.Name = "tb_judul";
            tb_judul.Size = new Size(480, 20);
            tb_judul.TabIndex = 1;
            // 
            // tb_tahun
            // 
            tb_tahun.BorderStyle = BorderStyle.None;
            tb_tahun.Cursor = Cursors.IBeam;
            tb_tahun.Font = new Font("Montserrat", 8F);
            tb_tahun.ForeColor = SystemColors.Desktop;
            tb_tahun.Location = new Point(269, 164);
            tb_tahun.Name = "tb_tahun";
            tb_tahun.Size = new Size(480, 20);
            tb_tahun.TabIndex = 2;
            // 
            // tb_kategori
            // 
            tb_kategori.BorderStyle = BorderStyle.None;
            tb_kategori.Cursor = Cursors.IBeam;
            tb_kategori.Font = new Font("Montserrat", 8F);
            tb_kategori.ForeColor = SystemColors.Desktop;
            tb_kategori.Location = new Point(269, 220);
            tb_kategori.Name = "tb_kategori";
            tb_kategori.Size = new Size(480, 20);
            tb_kategori.TabIndex = 3;
            // 
            // btnsimpan
            // 
            btnsimpan.BackColor = Color.ForestGreen;
            btnsimpan.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold);
            btnsimpan.ForeColor = SystemColors.ControlLightLight;
            btnsimpan.Location = new Point(660, 274);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(108, 37);
            btnsimpan.TabIndex = 4;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = false;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnlihat
            // 
            btnlihat.BackColor = Color.MidnightBlue;
            btnlihat.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold);
            btnlihat.ForeColor = SystemColors.ControlLightLight;
            btnlihat.Location = new Point(659, 440);
            btnlihat.Name = "btnlihat";
            btnlihat.Size = new Size(120, 39);
            btnlihat.TabIndex = 7;
            btnlihat.Text = "Lihat Data";
            btnlihat.UseVisualStyleBackColor = false;
            btnlihat.Click += btnlihat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat Medium", 7F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(267, 81);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 8;
            label1.Text = "Penerbit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Montserrat Medium", 7F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(268, 24);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "Judul Buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat Medium", 7F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(268, 137);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 10;
            label3.Text = "Tahun Penerbit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat Medium", 7F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(268, 194);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 11;
            label4.Text = "Kategori";
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.Firebrick;
            btnreset.Font = new Font("Montserrat SemiBold", 7F, FontStyle.Bold);
            btnreset.ForeColor = SystemColors.Control;
            btnreset.Location = new Point(552, 274);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(102, 37);
            btnreset.TabIndex = 13;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(801, 493);
            Controls.Add(btnreset);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnlihat);
            Controls.Add(btnsimpan);
            Controls.Add(tb_kategori);
            Controls.Add(tb_tahun);
            Controls.Add(tb_judul);
            Controls.Add(tb_penerbit);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_penerbit;
        private TextBox tb_judul;
        private TextBox tb_tahun;
        private TextBox tb_kategori;
        private Button btnsimpan;
        private Button btnlihat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnreset;
    }
}
