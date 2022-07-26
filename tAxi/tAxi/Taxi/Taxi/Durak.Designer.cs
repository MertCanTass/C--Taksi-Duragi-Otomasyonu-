namespace Taxi
{
    partial class Durak
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.btn_durakSil = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_durakGuncelle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_durakEkle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgv_durak = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbldurakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSet = new Taxi.taxiDataSet();
            this.tbl_durakTableAdapter = new Taxi.taxiDataSetTableAdapters.tbl_durakTableAdapter();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tx_durakAracSayisi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_durakAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_durakSoforSayisi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_durakAdres = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_durak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldurakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(966, 12);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 18;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(915, 12);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 19;
            // 
            // btn_durakSil
            // 
            this.btn_durakSil.Animated = true;
            this.btn_durakSil.AutoRoundedCorners = true;
            this.btn_durakSil.BorderRadius = 21;
            this.btn_durakSil.CheckedState.Parent = this.btn_durakSil;
            this.btn_durakSil.CustomImages.Parent = this.btn_durakSil;
            this.btn_durakSil.FillColor = System.Drawing.Color.Maroon;
            this.btn_durakSil.FillColor2 = System.Drawing.Color.IndianRed;
            this.btn_durakSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durakSil.ForeColor = System.Drawing.Color.White;
            this.btn_durakSil.HoverState.Parent = this.btn_durakSil;
            this.btn_durakSil.Location = new System.Drawing.Point(718, 391);
            this.btn_durakSil.Name = "btn_durakSil";
            this.btn_durakSil.ShadowDecoration.Parent = this.btn_durakSil;
            this.btn_durakSil.Size = new System.Drawing.Size(175, 45);
            this.btn_durakSil.TabIndex = 28;
            this.btn_durakSil.Text = "Sil";
            this.btn_durakSil.Click += new System.EventHandler(this.btn_durakSil_Click);
            // 
            // btn_durakGuncelle
            // 
            this.btn_durakGuncelle.Animated = true;
            this.btn_durakGuncelle.AutoRoundedCorners = true;
            this.btn_durakGuncelle.BorderRadius = 21;
            this.btn_durakGuncelle.CheckedState.Parent = this.btn_durakGuncelle;
            this.btn_durakGuncelle.CustomImages.Parent = this.btn_durakGuncelle;
            this.btn_durakGuncelle.FillColor = System.Drawing.Color.Blue;
            this.btn_durakGuncelle.FillColor2 = System.Drawing.Color.Cyan;
            this.btn_durakGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durakGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_durakGuncelle.HoverState.Parent = this.btn_durakGuncelle;
            this.btn_durakGuncelle.Location = new System.Drawing.Point(464, 391);
            this.btn_durakGuncelle.Name = "btn_durakGuncelle";
            this.btn_durakGuncelle.ShadowDecoration.Parent = this.btn_durakGuncelle;
            this.btn_durakGuncelle.Size = new System.Drawing.Size(175, 45);
            this.btn_durakGuncelle.TabIndex = 27;
            this.btn_durakGuncelle.Text = "Güncelle";
            this.btn_durakGuncelle.Click += new System.EventHandler(this.btn_durakGuncelle_Click);
            // 
            // btn_durakEkle
            // 
            this.btn_durakEkle.Animated = true;
            this.btn_durakEkle.AutoRoundedCorners = true;
            this.btn_durakEkle.BorderRadius = 21;
            this.btn_durakEkle.CheckedState.Parent = this.btn_durakEkle;
            this.btn_durakEkle.CustomImages.Parent = this.btn_durakEkle;
            this.btn_durakEkle.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_durakEkle.FillColor2 = System.Drawing.Color.YellowGreen;
            this.btn_durakEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durakEkle.ForeColor = System.Drawing.Color.White;
            this.btn_durakEkle.HoverState.Parent = this.btn_durakEkle;
            this.btn_durakEkle.Location = new System.Drawing.Point(215, 391);
            this.btn_durakEkle.Name = "btn_durakEkle";
            this.btn_durakEkle.ShadowDecoration.Parent = this.btn_durakEkle;
            this.btn_durakEkle.Size = new System.Drawing.Size(175, 45);
            this.btn_durakEkle.TabIndex = 26;
            this.btn_durakEkle.Text = "Ekle";
            this.btn_durakEkle.Click += new System.EventHandler(this.btn_durakEkle_Click);
            // 
            // dgv_durak
            // 
            this.dgv_durak.AllowUserToAddRows = false;
            this.dgv_durak.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_durak.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_durak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_durak.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_durak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_durak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_durak.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_durak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_durak.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_durak.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_durak.EnableHeadersVisualStyles = false;
            this.dgv_durak.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_durak.Location = new System.Drawing.Point(215, 212);
            this.dgv_durak.Name = "dgv_durak";
            this.dgv_durak.ReadOnly = true;
            this.dgv_durak.RowHeadersVisible = false;
            this.dgv_durak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_durak.Size = new System.Drawing.Size(678, 150);
            this.dgv_durak.TabIndex = 25;
            this.dgv_durak.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_durak.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_durak.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_durak.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_durak.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_durak.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_durak.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dgv_durak.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_durak.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_durak.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_durak.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_durak.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_durak.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_durak.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_durak.ThemeStyle.ReadOnly = true;
            this.dgv_durak.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_durak.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_durak.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_durak.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_durak.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_durak.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_durak.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_durak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_durak_CellContentClick);
            this.dgv_durak.SelectionChanged += new System.EventHandler(this.dgv_durak_SelectionChanged);
            // 
            // tbldurakBindingSource
            // 
            this.tbldurakBindingSource.DataMember = "tbl_durak";
            this.tbldurakBindingSource.DataSource = this.taxiDataSet;
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "taxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_durakTableAdapter
            // 
            this.tbl_durakTableAdapter.ClearBeforeFill = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::Taxi.Properties.Resources.back_24px;
            this.guna2ImageButton1.Location = new System.Drawing.Point(876, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(33, 29);
            this.guna2ImageButton1.TabIndex = 29;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // tx_durakAracSayisi
            // 
            this.tx_durakAracSayisi.BackColor = System.Drawing.Color.Transparent;
            this.tx_durakAracSayisi.BorderColor = System.Drawing.Color.Black;
            this.tx_durakAracSayisi.BorderRadius = 8;
            this.tx_durakAracSayisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_durakAracSayisi.DefaultText = "";
            this.tx_durakAracSayisi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_durakAracSayisi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_durakAracSayisi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_durakAracSayisi.DisabledState.Parent = this.tx_durakAracSayisi;
            this.tx_durakAracSayisi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_durakAracSayisi.FillColor = System.Drawing.Color.Black;
            this.tx_durakAracSayisi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_durakAracSayisi.FocusedState.Parent = this.tx_durakAracSayisi;
            this.tx_durakAracSayisi.ForeColor = System.Drawing.Color.White;
            this.tx_durakAracSayisi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_durakAracSayisi.HoverState.Parent = this.tx_durakAracSayisi;
            this.tx_durakAracSayisi.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_durakAracSayisi.Location = new System.Drawing.Point(215, 147);
            this.tx_durakAracSayisi.Name = "tx_durakAracSayisi";
            this.tx_durakAracSayisi.PasswordChar = '\0';
            this.tx_durakAracSayisi.PlaceholderForeColor = System.Drawing.Color.White;
            this.tx_durakAracSayisi.PlaceholderText = "Araç Sayısı";
            this.tx_durakAracSayisi.SelectedText = "";
            this.tx_durakAracSayisi.ShadowDecoration.Parent = this.tx_durakAracSayisi;
            this.tx_durakAracSayisi.Size = new System.Drawing.Size(217, 42);
            this.tx_durakAracSayisi.TabIndex = 24;
            // 
            // tx_durakAd
            // 
            this.tx_durakAd.BackColor = System.Drawing.Color.Transparent;
            this.tx_durakAd.BorderColor = System.Drawing.Color.White;
            this.tx_durakAd.BorderRadius = 8;
            this.tx_durakAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_durakAd.DefaultText = "";
            this.tx_durakAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_durakAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_durakAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_durakAd.DisabledState.Parent = this.tx_durakAd;
            this.tx_durakAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_durakAd.FillColor = System.Drawing.Color.Black;
            this.tx_durakAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_durakAd.FocusedState.Parent = this.tx_durakAd;
            this.tx_durakAd.ForeColor = System.Drawing.Color.White;
            this.tx_durakAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_durakAd.HoverState.Parent = this.tx_durakAd;
            this.tx_durakAd.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_durakAd.Location = new System.Drawing.Point(451, 90);
            this.tx_durakAd.Name = "tx_durakAd";
            this.tx_durakAd.PasswordChar = '\0';
            this.tx_durakAd.PlaceholderForeColor = System.Drawing.Color.White;
            this.tx_durakAd.PlaceholderText = "Durak Adı";
            this.tx_durakAd.SelectedText = "";
            this.tx_durakAd.ShadowDecoration.Parent = this.tx_durakAd;
            this.tx_durakAd.Size = new System.Drawing.Size(217, 42);
            this.tx_durakAd.TabIndex = 23;
            // 
            // tx_durakSoforSayisi
            // 
            this.tx_durakSoforSayisi.BackColor = System.Drawing.Color.Transparent;
            this.tx_durakSoforSayisi.BorderColor = System.Drawing.Color.Black;
            this.tx_durakSoforSayisi.BorderRadius = 8;
            this.tx_durakSoforSayisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_durakSoforSayisi.DefaultText = "";
            this.tx_durakSoforSayisi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_durakSoforSayisi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_durakSoforSayisi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_durakSoforSayisi.DisabledState.Parent = this.tx_durakSoforSayisi;
            this.tx_durakSoforSayisi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_durakSoforSayisi.FillColor = System.Drawing.Color.Black;
            this.tx_durakSoforSayisi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_durakSoforSayisi.FocusedState.Parent = this.tx_durakSoforSayisi;
            this.tx_durakSoforSayisi.ForeColor = System.Drawing.Color.White;
            this.tx_durakSoforSayisi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_durakSoforSayisi.HoverState.Parent = this.tx_durakSoforSayisi;
            this.tx_durakSoforSayisi.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_durakSoforSayisi.Location = new System.Drawing.Point(451, 147);
            this.tx_durakSoforSayisi.Name = "tx_durakSoforSayisi";
            this.tx_durakSoforSayisi.PasswordChar = '\0';
            this.tx_durakSoforSayisi.PlaceholderForeColor = System.Drawing.Color.White;
            this.tx_durakSoforSayisi.PlaceholderText = "Şöför Sayısı";
            this.tx_durakSoforSayisi.SelectedText = "";
            this.tx_durakSoforSayisi.ShadowDecoration.Parent = this.tx_durakSoforSayisi;
            this.tx_durakSoforSayisi.Size = new System.Drawing.Size(217, 42);
            this.tx_durakSoforSayisi.TabIndex = 22;
            // 
            // tx_durakAdres
            // 
            this.tx_durakAdres.BackColor = System.Drawing.Color.Transparent;
            this.tx_durakAdres.BorderColor = System.Drawing.Color.Black;
            this.tx_durakAdres.BorderRadius = 8;
            this.tx_durakAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_durakAdres.DefaultText = "";
            this.tx_durakAdres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_durakAdres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_durakAdres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_durakAdres.DisabledState.Parent = this.tx_durakAdres;
            this.tx_durakAdres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_durakAdres.FillColor = System.Drawing.Color.Black;
            this.tx_durakAdres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_durakAdres.FocusedState.Parent = this.tx_durakAdres;
            this.tx_durakAdres.ForeColor = System.Drawing.Color.White;
            this.tx_durakAdres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_durakAdres.HoverState.Parent = this.tx_durakAdres;
            this.tx_durakAdres.IconLeft = global::Taxi.Properties.Resources.user_30px;
            this.tx_durakAdres.Location = new System.Drawing.Point(674, 147);
            this.tx_durakAdres.Name = "tx_durakAdres";
            this.tx_durakAdres.PasswordChar = '\0';
            this.tx_durakAdres.PlaceholderForeColor = System.Drawing.Color.White;
            this.tx_durakAdres.PlaceholderText = "Adres";
            this.tx_durakAdres.SelectedText = "";
            this.tx_durakAdres.ShadowDecoration.Parent = this.tx_durakAdres;
            this.tx_durakAdres.Size = new System.Drawing.Size(217, 42);
            this.tx_durakAdres.TabIndex = 21;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Taxi.Properties.Resources.taxibg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-37, -244);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(180, 944);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 20;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Durak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 570);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btn_durakSil);
            this.Controls.Add(this.btn_durakGuncelle);
            this.Controls.Add(this.btn_durakEkle);
            this.Controls.Add(this.dgv_durak);
            this.Controls.Add(this.tx_durakAracSayisi);
            this.Controls.Add(this.tx_durakAd);
            this.Controls.Add(this.tx_durakSoforSayisi);
            this.Controls.Add(this.tx_durakAdres);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Durak";
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.Durak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_durak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldurakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_durakSil;
        private Guna.UI2.WinForms.Guna2GradientButton btn_durakGuncelle;
        private Guna.UI2.WinForms.Guna2GradientButton btn_durakEkle;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_durak;
        private Guna.UI2.WinForms.Guna2TextBox tx_durakAracSayisi;
        private Guna.UI2.WinForms.Guna2TextBox tx_durakAd;
        private Guna.UI2.WinForms.Guna2TextBox tx_durakSoforSayisi;
        private Guna.UI2.WinForms.Guna2TextBox tx_durakAdres;
        private taxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource tbldurakBindingSource;
        private taxiDataSetTableAdapters.tbl_durakTableAdapter tbl_durakTableAdapter;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}