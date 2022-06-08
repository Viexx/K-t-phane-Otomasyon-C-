
namespace KutuphaneOtomasyon
{
    partial class UyeSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeSayfasi));
            this.btn_kitaparauye = new System.Windows.Forms.Button();
            this.btn_yenileuye = new System.Windows.Forms.Button();
            this.txt_kitaparauyeID = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tür = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basımyılı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kitaparauye
            // 
            this.btn_kitaparauye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitaparauye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitaparauye.ImageIndex = 4;
            this.btn_kitaparauye.ImageList = this.ımageList1;
            this.btn_kitaparauye.Location = new System.Drawing.Point(197, 12);
            this.btn_kitaparauye.Name = "btn_kitaparauye";
            this.btn_kitaparauye.Size = new System.Drawing.Size(110, 39);
            this.btn_kitaparauye.TabIndex = 0;
            this.btn_kitaparauye.Text = "     ARA";
            this.btn_kitaparauye.UseVisualStyleBackColor = true;
            this.btn_kitaparauye.Click += new System.EventHandler(this.btn_kitaparauye_Click);
            // 
            // btn_yenileuye
            // 
            this.btn_yenileuye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenileuye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yenileuye.ImageIndex = 5;
            this.btn_yenileuye.ImageList = this.ımageList1;
            this.btn_yenileuye.Location = new System.Drawing.Point(444, 12);
            this.btn_yenileuye.Name = "btn_yenileuye";
            this.btn_yenileuye.Size = new System.Drawing.Size(161, 40);
            this.btn_yenileuye.TabIndex = 2;
            this.btn_yenileuye.Text = "     YENİLE";
            this.btn_yenileuye.UseVisualStyleBackColor = true;
            this.btn_yenileuye.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_kitaparauyeID
            // 
            this.txt_kitaparauyeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitaparauyeID.Location = new System.Drawing.Point(323, 12);
            this.txt_kitaparauyeID.Multiline = true;
            this.txt_kitaparauyeID.Name = "txt_kitaparauyeID";
            this.txt_kitaparauyeID.Size = new System.Drawing.Size(115, 39);
            this.txt_kitaparauyeID.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "clear.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "refresh.png");
            this.ımageList1.Images.SetKeyName(4, "search.png");
            this.ımageList1.Images.SetKeyName(5, "refresh-person.png");
            this.ımageList1.Images.SetKeyName(6, "kutuphane.png");
            this.ımageList1.Images.SetKeyName(7, "uye-ara.png");
            this.ımageList1.Images.SetKeyName(8, "quit.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KutuphaneOtomasyon.Properties.Resources.kutuphane;
            this.pictureBox1.Location = new System.Drawing.Point(734, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cıkıs.ImageIndex = 8;
            this.btn_cıkıs.ImageList = this.ımageList1;
            this.btn_cıkıs.Location = new System.Drawing.Point(250, 382);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(278, 41);
            this.btn_cıkıs.TabIndex = 3;
            this.btn_cıkıs.Text = "ÇIKIŞ YAP";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdil,
            this.yayınevi,
            this.tür,
            this.adet,
            this.sayfasayisi,
            this.basımyılı});
            this.dataGridView1.Location = new System.Drawing.Point(49, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(679, 286);
            this.dataGridView1.TabIndex = 7;
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KitapID";
            this.kitapid.Name = "kitapid";
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "Kitapİsim";
            this.kitapisim.Name = "kitapisim";
            // 
            // kitapyazar
            // 
            this.kitapyazar.HeaderText = "KitapYazar";
            this.kitapyazar.Name = "kitapyazar";
            // 
            // kitapdil
            // 
            this.kitapdil.HeaderText = "KitapDil";
            this.kitapdil.Name = "kitapdil";
            // 
            // yayınevi
            // 
            this.yayınevi.HeaderText = "YayınEvi";
            this.yayınevi.Name = "yayınevi";
            // 
            // tür
            // 
            this.tür.HeaderText = "Tür";
            this.tür.Name = "tür";
            // 
            // adet
            // 
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.HeaderText = "SayfaSayısı";
            this.sayfasayisi.Name = "sayfasayisi";
            // 
            // basımyılı
            // 
            this.basımyılı.HeaderText = "BasımYılı";
            this.basımyılı.Name = "basımyılı";
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_kitaparauyeID);
            this.Controls.Add(this.btn_yenileuye);
            this.Controls.Add(this.btn_kitaparauye);
            this.Name = "UyeSayfasi";
            this.Text = "UyeSayfasi";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitaparauye;
        private System.Windows.Forms.Button btn_yenileuye;
        private System.Windows.Forms.TextBox txt_kitaparauyeID;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cıkıs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdil;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tür;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basımyılı;
    }
}