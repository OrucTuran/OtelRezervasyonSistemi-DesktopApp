
namespace OtelYeniProje.Formlar.Admin
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.TxtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit9 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.BtnKapat);
            this.groupControl4.Controls.Add(this.BtnGiris);
            this.groupControl4.Controls.Add(this.TxtSifre);
            this.groupControl4.Controls.Add(this.TxtKullaniciAdi);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.pictureEdit3);
            this.groupControl4.Controls.Add(this.pictureEdit9);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(381, 159);
            this.groupControl4.TabIndex = 18;
            this.groupControl4.Text = "groupControl4";
            // 
            // BtnKapat
            // 
            this.BtnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.Location = new System.Drawing.Point(9, 98);
            this.BtnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(120, 51);
            this.BtnKapat.TabIndex = 92;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGiris.ImageOptions.SvgImage")));
            this.BtnGiris.Location = new System.Drawing.Point(136, 98);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(239, 51);
            this.BtnGiris.TabIndex = 91;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.EditValue = "Sifrenizi Giriniz";
            this.TxtSifre.Location = new System.Drawing.Point(136, 62);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Properties.UseSystemPasswordChar = true;
            this.TxtSifre.Size = new System.Drawing.Size(239, 22);
            this.TxtSifre.TabIndex = 1;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.EditValue = "Kullanici Adinizi Giriniz";
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(136, 28);
            this.TxtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(239, 22);
            this.TxtKullaniciAdi.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 66);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 16);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Şifre:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(38, 31);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 16);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Kullanıcı Adı:";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(9, 61);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(25, 25);
            this.pictureEdit3.TabIndex = 15;
            // 
            // pictureEdit9
            // 
            this.pictureEdit9.EditValue = ((object)(resources.GetObject("pictureEdit9.EditValue")));
            this.pictureEdit9.Location = new System.Drawing.Point(9, 26);
            this.pictureEdit9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit9.Name = "pictureEdit9";
            this.pictureEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit9.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit9.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit9.Size = new System.Drawing.Size(25, 25);
            this.pictureEdit9.TabIndex = 90;
            // 
            // FrmAdminGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnKapat;
            this.ClientSize = new System.Drawing.Size(381, 159);
            this.Controls.Add(this.groupControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminGiris";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit9;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
    }
}