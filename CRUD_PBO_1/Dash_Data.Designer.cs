namespace CRUD_PBO_1
{
    partial class Dash_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash_Data));
            label5 = new Label();
            dataGridView1 = new DataGridView();
            btnedit = new Button();
            btnhapus = new Button();
            btnkembali = new Button();
            btnkeluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Montserrat ExtraBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(397, 39);
            label5.TabIndex = 13;
            label5.Text = "Dashboard Perpustakaan";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(746, 217);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.DarkBlue;
            btnedit.Font = new Font("Montserrat", 7F, FontStyle.Bold);
            btnedit.ForeColor = SystemColors.ControlLightLight;
            btnedit.Location = new Point(532, 318);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(112, 39);
            btnedit.TabIndex = 15;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btnhapus
            // 
            btnhapus.BackColor = Color.Firebrick;
            btnhapus.Font = new Font("Montserrat", 7F, FontStyle.Bold);
            btnhapus.ForeColor = SystemColors.ControlLightLight;
            btnhapus.Location = new Point(662, 318);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(112, 39);
            btnhapus.TabIndex = 16;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = false;
            btnhapus.Click += btnhapus_Click;
            // 
            // btnkembali
            // 
            btnkembali.Font = new Font("Montserrat Medium", 8F, FontStyle.Bold);
            btnkembali.Location = new Point(28, 394);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(112, 34);
            btnkembali.TabIndex = 17;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // btnkeluar
            // 
            btnkeluar.Font = new Font("Montserrat Medium", 8F, FontStyle.Bold);
            btnkeluar.Location = new Point(662, 394);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(112, 34);
            btnkeluar.TabIndex = 18;
            btnkeluar.Text = "Keluar";
            btnkeluar.UseVisualStyleBackColor = true;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // Dash_Data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnkeluar);
            Controls.Add(btnkembali);
            Controls.Add(btnhapus);
            Controls.Add(btnedit);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            DoubleBuffered = true;
            Name = "Dash_Data";
            Text = "Dash_Data";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dataGridView1;
        private Button btnedit;
        private Button btnhapus;
        private Button btnkembali;
        private Button btnkeluar;
    }
}