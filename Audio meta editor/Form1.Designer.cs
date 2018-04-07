namespace MP3_meta_editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Putanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInputs = new System.Windows.Forms.BindingSource(this.components);
            this.btnOtvori = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtDuzina = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRbr = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Godina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtContr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOutputs = new System.Windows.Forms.BindingSource(this.components);
            this.txtArtistOut = new System.Windows.Forms.TextBox();
            this.txtTitleOut = new System.Windows.Forms.TextBox();
            this.txtAlbumOut = new System.Windows.Forms.TextBox();
            this.txtDuzinaOut = new System.Windows.Forms.TextBox();
            this.txtYearOut = new System.Windows.Forms.TextBox();
            this.txtRbrOut = new System.Windows.Forms.TextBox();
            this.txtGenreOut = new System.Windows.Forms.TextBox();
            this.txtContrOut = new System.Windows.Forms.TextBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkArtist = new System.Windows.Forms.LinkLabel();
            this.cbAlbumi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkAlbum = new System.Windows.Forms.LinkLabel();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linkKategorija = new System.Windows.Forms.LinkLabel();
            this.cbPotKat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkPotKat = new System.Windows.Forms.LinkLabel();
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnGodina = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnArtistSve = new System.Windows.Forms.Button();
            this.btnAlbumSve = new System.Windows.Forms.Button();
            this.btnGodinaSve = new System.Windows.Forms.Button();
            this.btnGenreSve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKorigovati = new System.Windows.Forms.Button();
            this.ckNazivi = new System.Windows.Forms.CheckBox();
            this.ckAlbum = new System.Windows.Forms.CheckBox();
            this.ckArtist = new System.Windows.Forms.CheckBox();
            this.rbSva = new System.Windows.Forms.RadioButton();
            this.rbSamoPocetna = new System.Windows.Forms.RadioButton();
            this.rbPrvoVeliko = new System.Windows.Forms.RadioButton();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIzvrsiti = new System.Windows.Forms.Button();
            this.cbVerzije = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSablon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutputs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.AllowUserToResizeColumns = false;
            this.dgvInput.AllowUserToResizeRows = false;
            this.dgvInput.AutoGenerateColumns = false;
            this.dgvInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.IdInput,
            this.Putanja});
            this.dgvInput.DataSource = this.bsInputs;
            this.dgvInput.Location = new System.Drawing.Point(12, 34);
            this.dgvInput.MultiSelect = false;
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.ReadOnly = true;
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInput.Size = new System.Drawing.Size(284, 281);
            this.dgvInput.TabIndex = 0;
            this.dgvInput.SelectionChanged += new System.EventHandler(this.dgvInput_SelectionChanged);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // IdInput
            // 
            this.IdInput.DataPropertyName = "IdInput";
            this.IdInput.HeaderText = "IdInput";
            this.IdInput.Name = "IdInput";
            this.IdInput.ReadOnly = true;
            this.IdInput.Visible = false;
            this.IdInput.Width = 65;
            // 
            // Putanja
            // 
            this.Putanja.DataPropertyName = "Putanja";
            this.Putanja.HeaderText = "Putanja";
            this.Putanja.Name = "Putanja";
            this.Putanja.ReadOnly = true;
            this.Putanja.Visible = false;
            this.Putanja.Width = 68;
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(12, 321);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(115, 26);
            this.btnOtvori.TabIndex = 1;
            this.btnOtvori.Text = "Učitaj album";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(302, 90);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(132, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(302, 51);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.ReadOnly = true;
            this.txtArtist.Size = new System.Drawing.Size(132, 20);
            this.txtArtist.TabIndex = 3;
            // 
            // txtDuzina
            // 
            this.txtDuzina.Location = new System.Drawing.Point(302, 168);
            this.txtDuzina.Name = "txtDuzina";
            this.txtDuzina.ReadOnly = true;
            this.txtDuzina.Size = new System.Drawing.Size(132, 20);
            this.txtDuzina.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(302, 207);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(132, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtRbr
            // 
            this.txtRbr.Location = new System.Drawing.Point(302, 246);
            this.txtRbr.Name = "txtRbr";
            this.txtRbr.ReadOnly = true;
            this.txtRbr.Size = new System.Drawing.Size(132, 20);
            this.txtRbr.TabIndex = 6;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(302, 129);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(132, 20);
            this.txtAlbum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Artist";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(299, 74);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 9;
            this.Title.Text = "Title";
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Location = new System.Drawing.Point(299, 113);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(36, 13);
            this.Album.TabIndex = 10;
            this.Album.Text = "Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Trajanje";
            // 
            // Godina
            // 
            this.Godina.AutoSize = true;
            this.Godina.Location = new System.Drawing.Point(299, 191);
            this.Godina.Name = "Godina";
            this.Godina.Size = new System.Drawing.Size(41, 13);
            this.Godina.TabIndex = 12;
            this.Godina.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Žanr";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(302, 285);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(132, 20);
            this.txtGenre.TabIndex = 15;
            // 
            // txtContr
            // 
            this.txtContr.Location = new System.Drawing.Point(302, 327);
            this.txtContr.Name = "txtContr";
            this.txtContr.ReadOnly = true;
            this.txtContr.Size = new System.Drawing.Size(132, 20);
            this.txtContr.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Contributing Artist";
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeColumns = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.AutoGenerateColumns = false;
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NazivOut,
            this.Artist,
            this.AlbumName,
            this.Genre,
            this.Year});
            this.dgvOutput.DataSource = this.bsOutputs;
            this.dgvOutput.Location = new System.Drawing.Point(652, 34);
            this.dgvOutput.MultiSelect = false;
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(284, 281);
            this.dgvOutput.TabIndex = 18;
            this.dgvOutput.SelectionChanged += new System.EventHandler(this.dgvOutput_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NazivOut
            // 
            this.NazivOut.DataPropertyName = "Naziv";
            this.NazivOut.HeaderText = "Naziv";
            this.NazivOut.Name = "NazivOut";
            this.NazivOut.ReadOnly = true;
            this.NazivOut.Width = 59;
            // 
            // Artist
            // 
            this.Artist.DataPropertyName = "Artist";
            this.Artist.HeaderText = "Artist";
            this.Artist.MinimumWidth = 10;
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            this.Artist.Width = 55;
            // 
            // AlbumName
            // 
            this.AlbumName.DataPropertyName = "AlbumName";
            this.AlbumName.HeaderText = "Album";
            this.AlbumName.MinimumWidth = 10;
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.ReadOnly = true;
            this.AlbumName.Width = 61;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Žanr";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 54;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Godina";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 66;
            // 
            // txtArtistOut
            // 
            this.txtArtistOut.Location = new System.Drawing.Point(461, 51);
            this.txtArtistOut.Name = "txtArtistOut";
            this.txtArtistOut.Size = new System.Drawing.Size(132, 20);
            this.txtArtistOut.TabIndex = 19;
            // 
            // txtTitleOut
            // 
            this.txtTitleOut.Location = new System.Drawing.Point(461, 90);
            this.txtTitleOut.Name = "txtTitleOut";
            this.txtTitleOut.Size = new System.Drawing.Size(132, 20);
            this.txtTitleOut.TabIndex = 20;
            // 
            // txtAlbumOut
            // 
            this.txtAlbumOut.Location = new System.Drawing.Point(461, 129);
            this.txtAlbumOut.Name = "txtAlbumOut";
            this.txtAlbumOut.Size = new System.Drawing.Size(132, 20);
            this.txtAlbumOut.TabIndex = 21;
            // 
            // txtDuzinaOut
            // 
            this.txtDuzinaOut.Location = new System.Drawing.Point(461, 168);
            this.txtDuzinaOut.Name = "txtDuzinaOut";
            this.txtDuzinaOut.Size = new System.Drawing.Size(132, 20);
            this.txtDuzinaOut.TabIndex = 22;
            // 
            // txtYearOut
            // 
            this.txtYearOut.Location = new System.Drawing.Point(461, 207);
            this.txtYearOut.Name = "txtYearOut";
            this.txtYearOut.Size = new System.Drawing.Size(132, 20);
            this.txtYearOut.TabIndex = 23;
            // 
            // txtRbrOut
            // 
            this.txtRbrOut.Location = new System.Drawing.Point(461, 246);
            this.txtRbrOut.Name = "txtRbrOut";
            this.txtRbrOut.Size = new System.Drawing.Size(132, 20);
            this.txtRbrOut.TabIndex = 24;
            // 
            // txtGenreOut
            // 
            this.txtGenreOut.Location = new System.Drawing.Point(461, 285);
            this.txtGenreOut.Name = "txtGenreOut";
            this.txtGenreOut.Size = new System.Drawing.Size(132, 20);
            this.txtGenreOut.TabIndex = 25;
            // 
            // txtContrOut
            // 
            this.txtContrOut.Location = new System.Drawing.Point(461, 327);
            this.txtContrOut.Name = "txtContrOut";
            this.txtContrOut.Size = new System.Drawing.Size(132, 20);
            this.txtContrOut.TabIndex = 26;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(1013, 32);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(153, 20);
            this.txtPretraga.TabIndex = 27;
            this.txtPretraga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPretraga_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Pretraga";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(1083, 58);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 29;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // cbArtist
            // 
            this.cbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(1013, 87);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(153, 21);
            this.cbArtist.TabIndex = 30;
            this.cbArtist.SelectionChangeCommitted += new System.EventHandler(this.cbArtist_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(977, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Artist";
            // 
            // linkArtist
            // 
            this.linkArtist.AutoSize = true;
            this.linkArtist.Location = new System.Drawing.Point(1172, 95);
            this.linkArtist.Name = "linkArtist";
            this.linkArtist.Size = new System.Drawing.Size(23, 13);
            this.linkArtist.TabIndex = 32;
            this.linkArtist.TabStop = true;
            this.linkArtist.Text = "link";
            this.linkArtist.Visible = false;
            this.linkArtist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkArtist_LinkClicked);
            // 
            // cbAlbumi
            // 
            this.cbAlbumi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlbumi.FormattingEnabled = true;
            this.cbAlbumi.Location = new System.Drawing.Point(1013, 167);
            this.cbAlbumi.Name = "cbAlbumi";
            this.cbAlbumi.Size = new System.Drawing.Size(153, 21);
            this.cbAlbumi.TabIndex = 33;
            this.cbAlbumi.SelectionChangeCommitted += new System.EventHandler(this.cbAlbumi_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(971, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Album";
            // 
            // linkAlbum
            // 
            this.linkAlbum.AutoSize = true;
            this.linkAlbum.Location = new System.Drawing.Point(1172, 175);
            this.linkAlbum.Name = "linkAlbum";
            this.linkAlbum.Size = new System.Drawing.Size(23, 13);
            this.linkAlbum.TabIndex = 35;
            this.linkAlbum.TabStop = true;
            this.linkAlbum.Text = "link";
            this.linkAlbum.Visible = false;
            this.linkAlbum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbum_LinkClicked);
            // 
            // cbKategorija
            // 
            this.cbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(1013, 113);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(153, 21);
            this.cbKategorija.TabIndex = 36;
            this.cbKategorija.SelectionChangeCommitted += new System.EventHandler(this.cbKategorija_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(953, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Kategorija";
            // 
            // linkKategorija
            // 
            this.linkKategorija.AutoSize = true;
            this.linkKategorija.Location = new System.Drawing.Point(1172, 121);
            this.linkKategorija.Name = "linkKategorija";
            this.linkKategorija.Size = new System.Drawing.Size(23, 13);
            this.linkKategorija.TabIndex = 38;
            this.linkKategorija.TabStop = true;
            this.linkKategorija.Text = "link";
            this.linkKategorija.Visible = false;
            this.linkKategorija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKategorija_LinkClicked);
            // 
            // cbPotKat
            // 
            this.cbPotKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPotKat.FormattingEnabled = true;
            this.cbPotKat.Location = new System.Drawing.Point(1013, 140);
            this.cbPotKat.Name = "cbPotKat";
            this.cbPotKat.Size = new System.Drawing.Size(153, 21);
            this.cbPotKat.TabIndex = 39;
            this.cbPotKat.SelectionChangeCommitted += new System.EventHandler(this.cbPotKat_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(938, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Potkategorija";
            // 
            // linkPotKat
            // 
            this.linkPotKat.AutoSize = true;
            this.linkPotKat.Location = new System.Drawing.Point(1172, 148);
            this.linkPotKat.Name = "linkPotKat";
            this.linkPotKat.Size = new System.Drawing.Size(23, 13);
            this.linkPotKat.TabIndex = 41;
            this.linkPotKat.TabStop = true;
            this.linkPotKat.Text = "link";
            this.linkPotKat.Visible = false;
            this.linkPotKat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPotKat_LinkClicked);
            // 
            // btnArtist
            // 
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnArtist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArtist.Location = new System.Drawing.Point(600, 51);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(20, 20);
            this.btnArtist.TabIndex = 42;
            this.btnArtist.Text = "<";
            this.btnArtist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTitle.Location = new System.Drawing.Point(600, 90);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(20, 20);
            this.btnTitle.TabIndex = 43;
            this.btnTitle.Text = "<";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlbum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlbum.Location = new System.Drawing.Point(600, 129);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(20, 20);
            this.btnAlbum.TabIndex = 44;
            this.btnAlbum.Text = "<";
            this.btnAlbum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnGodina
            // 
            this.btnGodina.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGodina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGodina.Location = new System.Drawing.Point(600, 207);
            this.btnGodina.Name = "btnGodina";
            this.btnGodina.Size = new System.Drawing.Size(20, 20);
            this.btnGodina.TabIndex = 45;
            this.btnGodina.Text = "<";
            this.btnGodina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGodina.UseVisualStyleBackColor = true;
            this.btnGodina.Click += new System.EventHandler(this.btnGodina_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenre.Location = new System.Drawing.Point(600, 285);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(20, 20);
            this.btnGenre.TabIndex = 46;
            this.btnGenre.Text = "<";
            this.btnGenre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnArtistSve
            // 
            this.btnArtistSve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnArtistSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnArtistSve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArtistSve.Location = new System.Drawing.Point(626, 51);
            this.btnArtistSve.Name = "btnArtistSve";
            this.btnArtistSve.Size = new System.Drawing.Size(20, 20);
            this.btnArtistSve.TabIndex = 47;
            this.btnArtistSve.Text = "S";
            this.btnArtistSve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArtistSve.UseVisualStyleBackColor = true;
            this.btnArtistSve.Click += new System.EventHandler(this.btnArtistSve_Click);
            // 
            // btnAlbumSve
            // 
            this.btnAlbumSve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlbumSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlbumSve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlbumSve.Location = new System.Drawing.Point(626, 129);
            this.btnAlbumSve.Name = "btnAlbumSve";
            this.btnAlbumSve.Size = new System.Drawing.Size(20, 20);
            this.btnAlbumSve.TabIndex = 49;
            this.btnAlbumSve.Text = "S";
            this.btnAlbumSve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlbumSve.UseVisualStyleBackColor = true;
            this.btnAlbumSve.Click += new System.EventHandler(this.btnAlbumSve_Click);
            // 
            // btnGodinaSve
            // 
            this.btnGodinaSve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGodinaSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGodinaSve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGodinaSve.Location = new System.Drawing.Point(626, 207);
            this.btnGodinaSve.Name = "btnGodinaSve";
            this.btnGodinaSve.Size = new System.Drawing.Size(20, 20);
            this.btnGodinaSve.TabIndex = 50;
            this.btnGodinaSve.Text = "S";
            this.btnGodinaSve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGodinaSve.UseVisualStyleBackColor = true;
            this.btnGodinaSve.Click += new System.EventHandler(this.btnGodinaSve_Click);
            // 
            // btnGenreSve
            // 
            this.btnGenreSve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenreSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenreSve.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenreSve.Location = new System.Drawing.Point(626, 285);
            this.btnGenreSve.Name = "btnGenreSve";
            this.btnGenreSve.Size = new System.Drawing.Size(20, 20);
            this.btnGenreSve.TabIndex = 51;
            this.btnGenreSve.Text = "S";
            this.btnGenreSve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenreSve.UseVisualStyleBackColor = true;
            this.btnGenreSve.Click += new System.EventHandler(this.btnGenreSve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKorigovati);
            this.groupBox1.Controls.Add(this.ckNazivi);
            this.groupBox1.Controls.Add(this.ckAlbum);
            this.groupBox1.Controls.Add(this.ckArtist);
            this.groupBox1.Controls.Add(this.rbSva);
            this.groupBox1.Controls.Add(this.rbSamoPocetna);
            this.groupBox1.Controls.Add(this.rbPrvoVeliko);
            this.groupBox1.Location = new System.Drawing.Point(652, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 101);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korigovanje pravopisa";
            // 
            // btnKorigovati
            // 
            this.btnKorigovati.Location = new System.Drawing.Point(197, 21);
            this.btnKorigovati.Name = "btnKorigovati";
            this.btnKorigovati.Size = new System.Drawing.Size(75, 63);
            this.btnKorigovati.TabIndex = 6;
            this.btnKorigovati.Text = "Korigovati";
            this.btnKorigovati.UseVisualStyleBackColor = true;
            this.btnKorigovati.Click += new System.EventHandler(this.btnKorigovati_Click);
            // 
            // ckNazivi
            // 
            this.ckNazivi.AutoSize = true;
            this.ckNazivi.Location = new System.Drawing.Point(136, 21);
            this.ckNazivi.Name = "ckNazivi";
            this.ckNazivi.Size = new System.Drawing.Size(55, 17);
            this.ckNazivi.TabIndex = 5;
            this.ckNazivi.Text = "Nazivi";
            this.ckNazivi.UseVisualStyleBackColor = true;
            // 
            // ckAlbum
            // 
            this.ckAlbum.AutoSize = true;
            this.ckAlbum.Location = new System.Drawing.Point(136, 67);
            this.ckAlbum.Name = "ckAlbum";
            this.ckAlbum.Size = new System.Drawing.Size(55, 17);
            this.ckAlbum.TabIndex = 4;
            this.ckAlbum.Text = "Album";
            this.ckAlbum.UseVisualStyleBackColor = true;
            // 
            // ckArtist
            // 
            this.ckArtist.AutoSize = true;
            this.ckArtist.Location = new System.Drawing.Point(136, 44);
            this.ckArtist.Name = "ckArtist";
            this.ckArtist.Size = new System.Drawing.Size(49, 17);
            this.ckArtist.TabIndex = 3;
            this.ckArtist.Text = "Artist";
            this.ckArtist.UseVisualStyleBackColor = true;
            // 
            // rbSva
            // 
            this.rbSva.AutoSize = true;
            this.rbSva.Location = new System.Drawing.Point(7, 66);
            this.rbSva.Name = "rbSva";
            this.rbSva.Size = new System.Drawing.Size(84, 17);
            this.rbSva.TabIndex = 2;
            this.rbSva.Text = "SVA SLOVA";
            this.rbSva.UseVisualStyleBackColor = true;
            this.rbSva.Click += new System.EventHandler(this.rbSva_Click);
            // 
            // rbSamoPocetna
            // 
            this.rbSamoPocetna.AutoSize = true;
            this.rbSamoPocetna.Location = new System.Drawing.Point(7, 43);
            this.rbSamoPocetna.Name = "rbSamoPocetna";
            this.rbSamoPocetna.Size = new System.Drawing.Size(125, 17);
            this.rbSamoPocetna.TabIndex = 1;
            this.rbSamoPocetna.Text = "Samo Početna Slova";
            this.rbSamoPocetna.UseVisualStyleBackColor = true;
            this.rbSamoPocetna.Click += new System.EventHandler(this.rbSamoPocetna_Click);
            // 
            // rbPrvoVeliko
            // 
            this.rbPrvoVeliko.AutoSize = true;
            this.rbPrvoVeliko.Checked = true;
            this.rbPrvoVeliko.Location = new System.Drawing.Point(7, 20);
            this.rbPrvoVeliko.Name = "rbPrvoVeliko";
            this.rbPrvoVeliko.Size = new System.Drawing.Size(123, 17);
            this.rbPrvoVeliko.TabIndex = 0;
            this.rbPrvoVeliko.TabStop = true;
            this.rbPrvoVeliko.Text = "Samo 1. veliko slovo";
            this.rbPrvoVeliko.UseVisualStyleBackColor = true;
            this.rbPrvoVeliko.Click += new System.EventHandler(this.rbPrvoVeliko_Click);
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(1012, 221);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(153, 153);
            this.picCover.TabIndex = 53;
            this.picCover.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(971, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Cover";
            // 
            // btnIzvrsiti
            // 
            this.btnIzvrsiti.Location = new System.Drawing.Point(1011, 387);
            this.btnIzvrsiti.Name = "btnIzvrsiti";
            this.btnIzvrsiti.Size = new System.Drawing.Size(154, 35);
            this.btnIzvrsiti.TabIndex = 55;
            this.btnIzvrsiti.Text = "Izvrši promjenu tagova";
            this.btnIzvrsiti.UseVisualStyleBackColor = true;
            this.btnIzvrsiti.Click += new System.EventHandler(this.btnIzvrsiti_Click);
            // 
            // cbVerzije
            // 
            this.cbVerzije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVerzije.FormattingEnabled = true;
            this.cbVerzije.Location = new System.Drawing.Point(1013, 194);
            this.cbVerzije.Name = "cbVerzije";
            this.cbVerzije.Size = new System.Drawing.Size(42, 21);
            this.cbVerzije.TabIndex = 56;
            this.cbVerzije.SelectionChangeCommitted += new System.EventHandler(this.cbVerzije_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(971, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Verzija";
            // 
            // btnSablon
            // 
            this.btnSablon.Location = new System.Drawing.Point(652, 5);
            this.btnSablon.Name = "btnSablon";
            this.btnSablon.Size = new System.Drawing.Size(284, 23);
            this.btnSablon.TabIndex = 58;
            this.btnSablon.Text = "Ubaci prazan šablon";
            this.btnSablon.UseVisualStyleBackColor = true;
            this.btnSablon.Click += new System.EventHandler(this.btnSablon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 449);
            this.Controls.Add(this.btnSablon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbVerzije);
            this.Controls.Add(this.btnIzvrsiti);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenreSve);
            this.Controls.Add(this.btnGodinaSve);
            this.Controls.Add(this.btnAlbumSve);
            this.Controls.Add(this.btnArtistSve);
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.btnGodina);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnArtist);
            this.Controls.Add(this.linkPotKat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbPotKat);
            this.Controls.Add(this.linkKategorija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.linkAlbum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAlbumi);
            this.Controls.Add(this.linkArtist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.txtContrOut);
            this.Controls.Add(this.txtGenreOut);
            this.Controls.Add(this.txtRbrOut);
            this.Controls.Add(this.txtYearOut);
            this.Controls.Add(this.txtDuzinaOut);
            this.Controls.Add(this.txtAlbumOut);
            this.Controls.Add(this.txtTitleOut);
            this.Controls.Add(this.txtArtistOut);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContr);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Godina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtRbr);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDuzina);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.dgvInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio meta editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutputs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.BindingSource bsInputs;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtDuzina;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRbr;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Godina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtContr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.TextBox txtArtistOut;
        private System.Windows.Forms.TextBox txtTitleOut;
        private System.Windows.Forms.TextBox txtAlbumOut;
        private System.Windows.Forms.TextBox txtDuzinaOut;
        private System.Windows.Forms.TextBox txtYearOut;
        private System.Windows.Forms.TextBox txtRbrOut;
        private System.Windows.Forms.TextBox txtGenreOut;
        private System.Windows.Forms.TextBox txtContrOut;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkArtist;
        private System.Windows.Forms.ComboBox cbAlbumi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkAlbum;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkKategorija;
        private System.Windows.Forms.ComboBox cbPotKat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkPotKat;
        private System.Windows.Forms.BindingSource bsOutputs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnGodina;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnArtistSve;
        private System.Windows.Forms.Button btnAlbumSve;
        private System.Windows.Forms.Button btnGodinaSve;
        private System.Windows.Forms.Button btnGenreSve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKorigovati;
        private System.Windows.Forms.CheckBox ckNazivi;
        private System.Windows.Forms.CheckBox ckAlbum;
        private System.Windows.Forms.CheckBox ckArtist;
        private System.Windows.Forms.RadioButton rbSva;
        private System.Windows.Forms.RadioButton rbSamoPocetna;
        private System.Windows.Forms.RadioButton rbPrvoVeliko;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIzvrsiti;
        private System.Windows.Forms.ComboBox cbVerzije;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Putanja;
        private System.Windows.Forms.Button btnSablon;
    }
}

