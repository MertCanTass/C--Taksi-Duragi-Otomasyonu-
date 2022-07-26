namespace Taxi
{
    partial class arac
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
            this.btn_soforSil = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_soforGuncelle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_soforEkle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgv_arac = new Guna.UI2.WinForms.Guna2DataGridView();
            this.taxiDataSet1 = new Taxi.taxiDataSet1();
            this.tblaracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_aracTableAdapter = new Taxi.taxiDataSet1TableAdapters.tbl_aracTableAdapter();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txt_aracPlaka = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_aracModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_aracMarka = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblaracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
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
            this.gunaControlBox1.Location = new System.Drawing.Point(885, 12);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 31;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(834, 12);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 32;
            // 
            // btn_soforSil
            // 
            this.btn_soforSil.Animated = true;
            this.btn_soforSil.AutoRoundedCorners = true;
            this.btn_soforSil.BorderRadius = 21;
            this.btn_soforSil.CheckedState.Parent = this.btn_soforSil;
            this.btn_soforSil.CustomImages.Parent = this.btn_soforSil;
            this.btn_soforSil.FillColor = System.Drawing.Color.Maroon;
            this.btn_soforSil.FillColor2 = System.Drawing.Color.IndianRed;
            this.btn_soforSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_soforSil.ForeColor = System.Drawing.Color.White;
            this.btn_soforSil.HoverState.Parent = this.btn_soforSil;
            this.btn_soforSil.Location = new System.Drawing.Point(675, 330);
            this.btn_soforSil.Name = "btn_soforSil";
            this.btn_soforSil.ShadowDecoration.Parent = this.btn_soforSil;
            this.btn_soforSil.Size = new System.Drawing.Size(215, 45);
            this.btn_soforSil.TabIndex = 36;
            this.btn_soforSil.Text = "Sil";
            this.btn_soforSil.Click += new System.EventHandler(this.btn_soforSil_Click);
            // 
            // btn_soforGuncelle
            // 
            this.btn_soforGuncelle.Animated = true;
            this.btn_soforGuncelle.AutoRoundedCorners = true;
            this.btn_soforGuncelle.BorderRadius = 21;
            this.btn_soforGuncelle.CheckedState.Parent = this.btn_soforGuncelle;
            this.btn_soforGuncelle.CustomImages.Parent = this.btn_soforGuncelle;
            this.btn_soforGuncelle.FillColor = System.Drawing.Color.Blue;
            this.btn_soforGuncelle.FillColor2 = System.Drawing.Color.Cyan;
            this.btn_soforGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_soforGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_soforGuncelle.HoverState.Parent = this.btn_soforGuncelle;
            this.btn_soforGuncelle.Location = new System.Drawing.Point(426, 330);
            this.btn_soforGuncelle.Name = "btn_soforGuncelle";
            this.btn_soforGuncelle.ShadowDecoration.Parent = this.btn_soforGuncelle;
            this.btn_soforGuncelle.Size = new System.Drawing.Size(215, 45);
            this.btn_soforGuncelle.TabIndex = 35;
            this.btn_soforGuncelle.Text = "Güncelle";
            this.btn_soforGuncelle.Click += new System.EventHandler(this.btn_soforGuncelle_Click);
            // 
            // btn_soforEkle
            // 
            this.btn_soforEkle.Animated = true;
            this.btn_soforEkle.AutoRoundedCorners = true;
            this.btn_soforEkle.BorderRadius = 21;
            this.btn_soforEkle.CheckedState.Parent = this.btn_soforEkle;
            this.btn_soforEkle.CustomImages.Parent = this.btn_soforEkle;
            this.btn_soforEkle.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_soforEkle.FillColor2 = System.Drawing.Color.YellowGreen;
            this.btn_soforEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_soforEkle.ForeColor = System.Drawing.Color.White;
            this.btn_soforEkle.HoverState.Parent = this.btn_soforEkle;
            this.btn_soforEkle.Location = new System.Drawing.Point(174, 330);
            this.btn_soforEkle.Name = "btn_soforEkle";
            this.btn_soforEkle.ShadowDecoration.Parent = this.btn_soforEkle;
            this.btn_soforEkle.Size = new System.Drawing.Size(215, 45);
            this.btn_soforEkle.TabIndex = 34;
            this.btn_soforEkle.Text = "Ekle";
            this.btn_soforEkle.Click += new System.EventHandler(this.btn_soforEkle_Click);
            // 
            // dgv_arac
            // 
            this.dgv_arac.AllowUserToAddRows = false;
            this.dgv_arac.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_arac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_arac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_arac.BackgroundColor = System.Drawing.Color.White;
            this.dgv_arac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_arac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_arac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_arac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_arac.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_arac.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_arac.EnableHeadersVisualStyles = false;
            this.dgv_arac.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_arac.Location = new System.Drawing.Point(174, 436);
            this.dgv_arac.Name = "dgv_arac";
            this.dgv_arac.ReadOnly = true;
            this.dgv_arac.RowHeadersVisible = false;
            this.dgv_arac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_arac.Size = new System.Drawing.Size(716, 150);
            this.dgv_arac.TabIndex = 37;
            this.dgv_arac.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_arac.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_arac.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_arac.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_arac.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_arac.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_arac.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_arac.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_arac.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_arac.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_arac.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_arac.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_arac.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_arac.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_arac.ThemeStyle.ReadOnly = true;
            this.dgv_arac.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_arac.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_arac.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_arac.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_arac.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_arac.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_arac.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_arac.SelectionChanged += new System.EventHandler(this.dgv_arac_SelectionChanged);
            // 
            // taxiDataSet1
            // 
            this.taxiDataSet1.DataSetName = "taxiDataSet1";
            this.taxiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblaracBindingSource
            // 
            this.tblaracBindingSource.DataMember = "tbl_arac";
            this.tblaracBindingSource.DataSource = this.taxiDataSet1;
            // 
            // tbl_aracTableAdapter
            // 
            this.tbl_aracTableAdapter.ClearBeforeFill = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::Taxi.Properties.Resources.back_24px;
            this.guna2ImageButton1.Location = new System.Drawing.Point(783, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(45, 29);
            this.guna2ImageButton1.TabIndex = 33;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // txt_aracPlaka
            // 
            this.txt_aracPlaka.BorderColor = System.Drawing.Color.White;
            this.txt_aracPlaka.BorderRadius = 8;
            this.txt_aracPlaka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_aracPlaka.DefaultText = "";
            this.txt_aracPlaka.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_aracPlaka.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_aracPlaka.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_aracPlaka.DisabledState.Parent = this.txt_aracPlaka;
            this.txt_aracPlaka.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_aracPlaka.FillColor = System.Drawing.Color.Black;
            this.txt_aracPlaka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_aracPlaka.FocusedState.Parent = this.txt_aracPlaka;
            this.txt_aracPlaka.ForeColor = System.Drawing.Color.White;
            this.txt_aracPlaka.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_aracPlaka.HoverState.Parent = this.txt_aracPlaka;
            this.txt_aracPlaka.IconLeft = global::Taxi.Properties.Resources.taxi_40px;
            this.txt_aracPlaka.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_aracPlaka.Location = new System.Drawing.Point(675, 248);
            this.txt_aracPlaka.Name = "txt_aracPlaka";
            this.txt_aracPlaka.PasswordChar = '\0';
            this.txt_aracPlaka.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_aracPlaka.PlaceholderText = "Araç Plakası";
            this.txt_aracPlaka.SelectedText = "";
            this.txt_aracPlaka.ShadowDecoration.Parent = this.txt_aracPlaka;
            this.txt_aracPlaka.Size = new System.Drawing.Size(215, 39);
            this.txt_aracPlaka.TabIndex = 13;
            // 
            // txt_aracModel
            // 
            this.txt_aracModel.BorderColor = System.Drawing.Color.White;
            this.txt_aracModel.BorderRadius = 8;
            this.txt_aracModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_aracModel.DefaultText = "";
            this.txt_aracModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_aracModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_aracModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_aracModel.DisabledState.Parent = this.txt_aracModel;
            this.txt_aracModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_aracModel.FillColor = System.Drawing.Color.Black;
            this.txt_aracModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_aracModel.FocusedState.Parent = this.txt_aracModel;
            this.txt_aracModel.ForeColor = System.Drawing.Color.White;
            this.txt_aracModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_aracModel.HoverState.Parent = this.txt_aracModel;
            this.txt_aracModel.IconLeft = global::Taxi.Properties.Resources.taxi_40px;
            this.txt_aracModel.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_aracModel.Location = new System.Drawing.Point(427, 248);
            this.txt_aracModel.Name = "txt_aracModel";
            this.txt_aracModel.PasswordChar = '\0';
            this.txt_aracModel.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_aracModel.PlaceholderText = "Araç Model";
            this.txt_aracModel.SelectedText = "";
            this.txt_aracModel.ShadowDecoration.Parent = this.txt_aracModel;
            this.txt_aracModel.Size = new System.Drawing.Size(214, 39);
            this.txt_aracModel.TabIndex = 12;
            // 
            // txt_aracMarka
            // 
            this.txt_aracMarka.BorderColor = System.Drawing.Color.White;
            this.txt_aracMarka.BorderRadius = 8;
            this.txt_aracMarka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_aracMarka.DefaultText = "";
            this.txt_aracMarka.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_aracMarka.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_aracMarka.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_aracMarka.DisabledState.Parent = this.txt_aracMarka;
            this.txt_aracMarka.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_aracMarka.FillColor = System.Drawing.Color.Black;
            this.txt_aracMarka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_aracMarka.FocusedState.Parent = this.txt_aracMarka;
            this.txt_aracMarka.ForeColor = System.Drawing.Color.White;
            this.txt_aracMarka.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_aracMarka.HoverState.Parent = this.txt_aracMarka;
            this.txt_aracMarka.IconLeft = global::Taxi.Properties.Resources.taxi_40px;
            this.txt_aracMarka.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_aracMarka.Location = new System.Drawing.Point(174, 248);
            this.txt_aracMarka.Name = "txt_aracMarka";
            this.txt_aracMarka.PasswordChar = '\0';
            this.txt_aracMarka.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_aracMarka.PlaceholderText = "Araç Markası";
            this.txt_aracMarka.SelectedText = "";
            this.txt_aracMarka.ShadowDecoration.Parent = this.txt_aracMarka;
            this.txt_aracMarka.Size = new System.Drawing.Size(215, 39);
            this.txt_aracMarka.TabIndex = 11;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Taxi.Properties.Resources.taxibg;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-72, -416);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(180, 1404);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(942, 654);
            this.Controls.Add(this.dgv_arac);
            this.Controls.Add(this.btn_soforSil);
            this.Controls.Add(this.btn_soforGuncelle);
            this.Controls.Add(this.btn_soforEkle);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.txt_aracPlaka);
            this.Controls.Add(this.txt_aracModel);
            this.Controls.Add(this.txt_aracMarka);
            this.Controls.Add(this.guna2PictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "arac";
            this.Text = "arac";
            this.Load += new System.EventHandler(this.arac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblaracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_aracMarka;
        private Guna.UI2.WinForms.Guna2TextBox txt_aracPlaka;
        private Guna.UI2.WinForms.Guna2TextBox txt_aracModel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_arac;
        private Guna.UI2.WinForms.Guna2GradientButton btn_soforSil;
        private Guna.UI2.WinForms.Guna2GradientButton btn_soforGuncelle;
        private Guna.UI2.WinForms.Guna2GradientButton btn_soforEkle;
        private taxiDataSet1 taxiDataSet1;
        private System.Windows.Forms.BindingSource tblaracBindingSource;
        private taxiDataSet1TableAdapters.tbl_aracTableAdapter tbl_aracTableAdapter;
    }
}