namespace Taxi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btn_girisyap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.pn_kullanıcıGiris = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.benihatırla = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tx_tc = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_kullanıcıKayit = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tx_kyTc = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_kyAdres = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_kyMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_kyTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_kySoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_kayıtol = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tx_kyAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_kySifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pn_kullanıcıGiris.SuspendLayout();
            this.pn_kullanıcıKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Animated = true;
            this.btn_girisyap.AutoRoundedCorners = true;
            this.btn_girisyap.BorderRadius = 21;
            this.btn_girisyap.CheckedState.Parent = this.btn_girisyap;
            this.btn_girisyap.CustomImages.Parent = this.btn_girisyap;
            this.guna2Transition1.SetDecoration(this.btn_girisyap, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_girisyap.FillColor = System.Drawing.Color.Black;
            this.btn_girisyap.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(13)))));
            this.btn_girisyap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisyap.ForeColor = System.Drawing.Color.White;
            this.btn_girisyap.HoverState.Parent = this.btn_girisyap;
            this.btn_girisyap.Location = new System.Drawing.Point(81, 275);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.ShadowDecoration.Parent = this.btn_girisyap;
            this.btn_girisyap.Size = new System.Drawing.Size(215, 45);
            this.btn_girisyap.TabIndex = 8;
            this.btn_girisyap.Text = "Giriş Yap ";
            this.btn_girisyap.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Beni Hatırla ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(51, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kullanıcı Adımı Veya Şifremi Unuttum  ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(111, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kullanıcı Girişi ";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.gunaAnimateWindow1.Interval = 500;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // pn_kullanıcıGiris
            // 
            this.pn_kullanıcıGiris.BackColor = System.Drawing.Color.Transparent;
            this.pn_kullanıcıGiris.Controls.Add(this.benihatırla);
            this.pn_kullanıcıGiris.Controls.Add(this.pn_kullanıcıKayit);
            this.pn_kullanıcıGiris.Controls.Add(this.guna2Button1);
            this.pn_kullanıcıGiris.Controls.Add(this.btn_girisyap);
            this.pn_kullanıcıGiris.Controls.Add(this.tx_tc);
            this.pn_kullanıcıGiris.Controls.Add(this.label1);
            this.pn_kullanıcıGiris.Controls.Add(this.label2);
            this.pn_kullanıcıGiris.Controls.Add(this.label3);
            this.pn_kullanıcıGiris.Controls.Add(this.tx_sifre);
            this.guna2Transition1.SetDecoration(this.pn_kullanıcıGiris, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_kullanıcıGiris.FillColor = System.Drawing.Color.White;
            this.pn_kullanıcıGiris.Location = new System.Drawing.Point(641, 98);
            this.pn_kullanıcıGiris.Name = "pn_kullanıcıGiris";
            this.pn_kullanıcıGiris.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(13)))));
            this.pn_kullanıcıGiris.ShadowDepth = 150;
            this.pn_kullanıcıGiris.ShadowShift = 10;
            this.pn_kullanıcıGiris.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pn_kullanıcıGiris.Size = new System.Drawing.Size(382, 490);
            this.pn_kullanıcıGiris.TabIndex = 14;
            // 
            // benihatırla
            // 
            this.benihatırla.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.benihatırla.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.benihatırla.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.benihatırla.CheckedState.InnerColor = System.Drawing.Color.White;
            this.benihatırla.CheckedState.Parent = this.benihatırla;
            this.guna2Transition1.SetDecoration(this.benihatırla, Guna.UI2.AnimatorNS.DecorationType.None);
            this.benihatırla.Location = new System.Drawing.Point(65, 219);
            this.benihatırla.Name = "benihatırla";
            this.benihatırla.ShadowDecoration.Parent = this.benihatırla;
            this.benihatırla.Size = new System.Drawing.Size(35, 20);
            this.benihatırla.TabIndex = 15;
            this.benihatırla.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.benihatırla.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.benihatırla.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.benihatırla.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.benihatırla.UncheckedState.Parent = this.benihatırla;
            this.benihatırla.CheckedChanged += new System.EventHandler(this.benihatırla_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Taxi.Properties.Resources.arrow_50px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(52, 384);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(272, 60);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Hesap Oluştur";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tx_tc
            // 
            this.tx_tc.BackColor = System.Drawing.Color.White;
            this.tx_tc.BorderRadius = 8;
            this.tx_tc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_tc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_tc.DefaultText = "";
            this.tx_tc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_tc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_tc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_tc.DisabledState.Parent = this.tx_tc;
            this.tx_tc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_tc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_tc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_tc.FocusedState.Parent = this.tx_tc;
            this.tx_tc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_tc.HoverState.Parent = this.tx_tc;
            this.tx_tc.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_tc.Location = new System.Drawing.Point(65, 80);
            this.tx_tc.Name = "tx_tc";
            this.tx_tc.PasswordChar = '\0';
            this.tx_tc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_tc.PlaceholderText = "Kullanıcı Adı ";
            this.tx_tc.SelectedText = "";
            this.tx_tc.ShadowDecoration.Parent = this.tx_tc;
            this.tx_tc.Size = new System.Drawing.Size(246, 42);
            this.tx_tc.TabIndex = 5;
            // 
            // tx_sifre
            // 
            this.tx_sifre.BackColor = System.Drawing.Color.White;
            this.tx_sifre.BorderRadius = 8;
            this.tx_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_sifre, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_sifre.DefaultText = "";
            this.tx_sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_sifre.DisabledState.Parent = this.tx_sifre;
            this.tx_sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_sifre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_sifre.FocusedState.Parent = this.tx_sifre;
            this.tx_sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_sifre.HoverState.Parent = this.tx_sifre;
            this.tx_sifre.IconLeft = global::Taxi.Properties.Resources.password_30px;
            this.tx_sifre.Location = new System.Drawing.Point(65, 146);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '\0';
            this.tx_sifre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_sifre.PlaceholderText = "Şifre";
            this.tx_sifre.SelectedText = "";
            this.tx_sifre.ShadowDecoration.Parent = this.tx_sifre;
            this.tx_sifre.Size = new System.Drawing.Size(246, 42);
            this.tx_sifre.TabIndex = 6;
            this.tx_sifre.UseSystemPasswordChar = true;
            // 
            // pn_kullanıcıKayit
            // 
            this.pn_kullanıcıKayit.BackColor = System.Drawing.Color.Transparent;
            this.pn_kullanıcıKayit.Controls.Add(this.tx_kyTc);
            this.pn_kullanıcıKayit.Controls.Add(this.tx_kyAdres);
            this.pn_kullanıcıKayit.Controls.Add(this.tx_kyMail);
            this.pn_kullanıcıKayit.Controls.Add(this.tx_kyTel);
            this.pn_kullanıcıKayit.Controls.Add(this.tx_kySoyad);
            this.pn_kullanıcıKayit.Controls.Add(this.btn_kayıtol);
            this.pn_kullanıcıKayit.Controls.Add(this.tx_kyAd);
            this.pn_kullanıcıKayit.Controls.Add(this.label5);
            this.pn_kullanıcıKayit.Controls.Add(this.label6);
            this.pn_kullanıcıKayit.Controls.Add(this.tx_kySifre);
            this.guna2Transition1.SetDecoration(this.pn_kullanıcıKayit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_kullanıcıKayit.FillColor = System.Drawing.Color.White;
            this.pn_kullanıcıKayit.Location = new System.Drawing.Point(0, 0);
            this.pn_kullanıcıKayit.Name = "pn_kullanıcıKayit";
            this.pn_kullanıcıKayit.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(13)))));
            this.pn_kullanıcıKayit.ShadowDepth = 150;
            this.pn_kullanıcıKayit.ShadowShift = 10;
            this.pn_kullanıcıKayit.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pn_kullanıcıKayit.Size = new System.Drawing.Size(385, 490);
            this.pn_kullanıcıKayit.TabIndex = 16;
            this.pn_kullanıcıKayit.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_kullanıcıKayit_Paint);
            // 
            // tx_kyTc
            // 
            this.tx_kyTc.BackColor = System.Drawing.Color.White;
            this.tx_kyTc.BorderRadius = 8;
            this.tx_kyTc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_kyTc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_kyTc.DefaultText = "";
            this.tx_kyTc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_kyTc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_kyTc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyTc.DisabledState.Parent = this.tx_kyTc;
            this.tx_kyTc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyTc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_kyTc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyTc.FocusedState.Parent = this.tx_kyTc;
            this.tx_kyTc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyTc.HoverState.Parent = this.tx_kyTc;
            this.tx_kyTc.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_kyTc.Location = new System.Drawing.Point(65, 133);
            this.tx_kyTc.Name = "tx_kyTc";
            this.tx_kyTc.PasswordChar = '\0';
            this.tx_kyTc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_kyTc.PlaceholderText = "Tc No";
            this.tx_kyTc.SelectedText = "";
            this.tx_kyTc.ShadowDecoration.Parent = this.tx_kyTc;
            this.tx_kyTc.Size = new System.Drawing.Size(136, 42);
            this.tx_kyTc.TabIndex = 17;
            // 
            // tx_kyAdres
            // 
            this.tx_kyAdres.BackColor = System.Drawing.Color.White;
            this.tx_kyAdres.BorderRadius = 8;
            this.tx_kyAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_kyAdres, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_kyAdres.DefaultText = "";
            this.tx_kyAdres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_kyAdres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_kyAdres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyAdres.DisabledState.Parent = this.tx_kyAdres;
            this.tx_kyAdres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyAdres.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_kyAdres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyAdres.FocusedState.Parent = this.tx_kyAdres;
            this.tx_kyAdres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyAdres.HoverState.Parent = this.tx_kyAdres;
            this.tx_kyAdres.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_kyAdres.Location = new System.Drawing.Point(65, 181);
            this.tx_kyAdres.Name = "tx_kyAdres";
            this.tx_kyAdres.PasswordChar = '\0';
            this.tx_kyAdres.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_kyAdres.PlaceholderText = "Adres";
            this.tx_kyAdres.SelectedText = "";
            this.tx_kyAdres.ShadowDecoration.Parent = this.tx_kyAdres;
            this.tx_kyAdres.Size = new System.Drawing.Size(278, 42);
            this.tx_kyAdres.TabIndex = 16;
            // 
            // tx_kyMail
            // 
            this.tx_kyMail.BackColor = System.Drawing.Color.White;
            this.tx_kyMail.BorderRadius = 8;
            this.tx_kyMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_kyMail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_kyMail.DefaultText = "";
            this.tx_kyMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_kyMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_kyMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyMail.DisabledState.Parent = this.tx_kyMail;
            this.tx_kyMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_kyMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyMail.FocusedState.Parent = this.tx_kyMail;
            this.tx_kyMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyMail.HoverState.Parent = this.tx_kyMail;
            this.tx_kyMail.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_kyMail.Location = new System.Drawing.Point(65, 229);
            this.tx_kyMail.Name = "tx_kyMail";
            this.tx_kyMail.PasswordChar = '\0';
            this.tx_kyMail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_kyMail.PlaceholderText = "Mail";
            this.tx_kyMail.SelectedText = "";
            this.tx_kyMail.ShadowDecoration.Parent = this.tx_kyMail;
            this.tx_kyMail.Size = new System.Drawing.Size(278, 42);
            this.tx_kyMail.TabIndex = 15;
            // 
            // tx_kyTel
            // 
            this.tx_kyTel.BackColor = System.Drawing.Color.White;
            this.tx_kyTel.BorderRadius = 8;
            this.tx_kyTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_kyTel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_kyTel.DefaultText = "";
            this.tx_kyTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_kyTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_kyTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyTel.DisabledState.Parent = this.tx_kyTel;
            this.tx_kyTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyTel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_kyTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyTel.FocusedState.Parent = this.tx_kyTel;
            this.tx_kyTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyTel.HoverState.Parent = this.tx_kyTel;
            this.tx_kyTel.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_kyTel.Location = new System.Drawing.Point(207, 133);
            this.tx_kyTel.Name = "tx_kyTel";
            this.tx_kyTel.PasswordChar = '\0';
            this.tx_kyTel.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_kyTel.PlaceholderText = "Telefon Numarası";
            this.tx_kyTel.SelectedText = "";
            this.tx_kyTel.ShadowDecoration.Parent = this.tx_kyTel;
            this.tx_kyTel.Size = new System.Drawing.Size(136, 42);
            this.tx_kyTel.TabIndex = 14;
            // 
            // tx_kySoyad
            // 
            this.tx_kySoyad.BackColor = System.Drawing.Color.White;
            this.tx_kySoyad.BorderRadius = 8;
            this.tx_kySoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_kySoyad, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_kySoyad.DefaultText = "";
            this.tx_kySoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_kySoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_kySoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kySoyad.DisabledState.Parent = this.tx_kySoyad;
            this.tx_kySoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kySoyad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_kySoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kySoyad.FocusedState.Parent = this.tx_kySoyad;
            this.tx_kySoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kySoyad.HoverState.Parent = this.tx_kySoyad;
            this.tx_kySoyad.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_kySoyad.Location = new System.Drawing.Point(207, 85);
            this.tx_kySoyad.Name = "tx_kySoyad";
            this.tx_kySoyad.PasswordChar = '\0';
            this.tx_kySoyad.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_kySoyad.PlaceholderText = "Soyad";
            this.tx_kySoyad.SelectedText = "";
            this.tx_kySoyad.ShadowDecoration.Parent = this.tx_kySoyad;
            this.tx_kySoyad.Size = new System.Drawing.Size(136, 42);
            this.tx_kySoyad.TabIndex = 13;
            // 
            // btn_kayıtol
            // 
            this.btn_kayıtol.Animated = true;
            this.btn_kayıtol.AutoRoundedCorners = true;
            this.btn_kayıtol.BorderRadius = 21;
            this.btn_kayıtol.CheckedState.Parent = this.btn_kayıtol;
            this.btn_kayıtol.CustomImages.Parent = this.btn_kayıtol;
            this.guna2Transition1.SetDecoration(this.btn_kayıtol, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_kayıtol.FillColor = System.Drawing.Color.Black;
            this.btn_kayıtol.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(13)))));
            this.btn_kayıtol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıtol.ForeColor = System.Drawing.Color.White;
            this.btn_kayıtol.HoverState.Parent = this.btn_kayıtol;
            this.btn_kayıtol.Location = new System.Drawing.Point(100, 341);
            this.btn_kayıtol.Name = "btn_kayıtol";
            this.btn_kayıtol.ShadowDecoration.Parent = this.btn_kayıtol;
            this.btn_kayıtol.Size = new System.Drawing.Size(215, 45);
            this.btn_kayıtol.TabIndex = 8;
            this.btn_kayıtol.Text = "Kayıt Ol";
            this.btn_kayıtol.Click += new System.EventHandler(this.btn_kayıtol_Click);
            // 
            // tx_kyAd
            // 
            this.tx_kyAd.BackColor = System.Drawing.Color.White;
            this.tx_kyAd.BorderRadius = 8;
            this.tx_kyAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_kyAd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_kyAd.DefaultText = "";
            this.tx_kyAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_kyAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_kyAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyAd.DisabledState.Parent = this.tx_kyAd;
            this.tx_kyAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kyAd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_kyAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyAd.FocusedState.Parent = this.tx_kyAd;
            this.tx_kyAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kyAd.HoverState.Parent = this.tx_kyAd;
            this.tx_kyAd.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_kyAd.Location = new System.Drawing.Point(65, 85);
            this.tx_kyAd.Name = "tx_kyAd";
            this.tx_kyAd.PasswordChar = '\0';
            this.tx_kyAd.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_kyAd.PlaceholderText = "Ad";
            this.tx_kyAd.SelectedText = "";
            this.tx_kyAd.ShadowDecoration.Parent = this.tx_kyAd;
            this.tx_kyAd.Size = new System.Drawing.Size(136, 42);
            this.tx_kyAd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(119, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hesabın Varsa Giriş Yap ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(127, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Kayıt";
            // 
            // tx_kySifre
            // 
            this.tx_kySifre.BackColor = System.Drawing.Color.White;
            this.tx_kySifre.BorderRadius = 8;
            this.tx_kySifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tx_kySifre, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tx_kySifre.DefaultText = "";
            this.tx_kySifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_kySifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_kySifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kySifre.DisabledState.Parent = this.tx_kySifre;
            this.tx_kySifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_kySifre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tx_kySifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kySifre.FocusedState.Parent = this.tx_kySifre;
            this.tx_kySifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_kySifre.HoverState.Parent = this.tx_kySifre;
            this.tx_kySifre.IconLeft = global::Taxi.Properties.Resources.password_30px;
            this.tx_kySifre.Location = new System.Drawing.Point(65, 277);
            this.tx_kySifre.Name = "tx_kySifre";
            this.tx_kySifre.PasswordChar = '\0';
            this.tx_kySifre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tx_kySifre.PlaceholderText = "Şifre";
            this.tx_kySifre.SelectedText = "";
            this.tx_kySifre.ShadowDecoration.Parent = this.tx_kySifre;
            this.tx_kySifre.Size = new System.Drawing.Size(278, 42);
            this.tx_kySifre.TabIndex = 6;
            this.tx_kySifre.UseSystemPasswordChar = true;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.guna2Transition1.SetDecoration(this.gunaControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1075, 12);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 14;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.gunaControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1024, 12);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 15;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // contextMenuStrip1
            // 
            this.guna2Transition1.SetDecoration(this.contextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.Image = global::Taxi.Properties.Resources._3644592;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(154, 98);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(451, 487);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 16;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::Taxi.Properties.Resources.taxibg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-14, -49);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(162, 757);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 756);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.pn_kullanıcıGiris);
            this.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn_kullanıcıGiris.ResumeLayout(false);
            this.pn_kullanıcıGiris.PerformLayout();
            this.pn_kullanıcıKayit.ResumeLayout(false);
            this.pn_kullanıcıKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_girisyap;
        private Guna.UI2.WinForms.Guna2TextBox tx_sifre;
        private Guna.UI2.WinForms.Guna2TextBox tx_tc;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        public Guna.UI2.WinForms.Guna2ShadowPanel pn_kullanıcıGiris;
        private Guna.UI2.WinForms.Guna2ToggleSwitch benihatırla;
        public Guna.UI2.WinForms.Guna2ShadowPanel pn_kullanıcıKayit;
        private Guna.UI2.WinForms.Guna2GradientButton btn_kayıtol;
        private Guna.UI2.WinForms.Guna2TextBox tx_kyAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tx_kySifre;
        private Guna.UI2.WinForms.Guna2TextBox tx_kyTel;
        private Guna.UI2.WinForms.Guna2TextBox tx_kySoyad;
        public Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        public Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tx_kyAdres;
        private Guna.UI2.WinForms.Guna2TextBox tx_kyMail;
        private Guna.UI2.WinForms.Guna2TextBox tx_kyTc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

