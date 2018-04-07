using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;
using System.Drawing.Imaging;

namespace MP3_meta_editor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private static string artUrl = "";
        private static string katUrl = "";
        private static string potKatUrl = "";
        private static string kategorija = "";
        private static string potkategorija = "";
        private static string albumUrl = "";
        private static string albumStr = "";
        private static string artistStr = "";
        private static string imgUrl = "";
        List<Inputs> list = new List<Inputs>();
        static Dictionary<string, string> artistList = new Dictionary<string, string>();

        static List<Kategorije> Kategorije = new List<Kategorije>();
        static List<Album> Albumi = new List<Album>();
        static List<Pjesma> SpisakPjesama = new List<Pjesma>();

        static Dictionary<int, string> dict = new Dictionary<int, string>();

        private void btnOtvori_Click(object sender, EventArgs e)
        {

            try
            {
                int id = 0;
                FolderBrowserDialog fd = new FolderBrowserDialog();

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    dgvInput.Rows.Clear();

                    list = Directory.GetFiles(fd.SelectedPath)
                                        .Select(s => new Inputs
                                        {
                                            IdInput = id++,
                                            Naziv = Path.GetFileNameWithoutExtension(s),
                                            Putanja = s,
                                            Ekstenzija = Path.GetExtension(s).ToLower()
                                        }).Where(s => s.Ekstenzija != ".jpg" && s.Ekstenzija != ".jpeg" && s.Ekstenzija != ".gif" && s.Ekstenzija != ".bmp" && s.Ekstenzija != ".svg" && s.Ekstenzija != ".png")
                                            .ToList();

                    var ekstenzije = TagLib.SupportedMimeType.AllExtensions.ToList();
                    var listEkstenzije = list.Select(x => x.Ekstenzija.Substring(1)).ToList();

                    //ono što sam se mučio sat i po samo zbog tačke isped .mp3 :)))
                    //var item = listEkstenzije.Where(c => !string.IsNullOrEmpty(c)).GroupBy(a => a).OrderByDescending(b => b.Key[0].ToString()).First().Key;
                    //if (ekstenzije.Any(a => a.Contains(item.Substring(1).ToLower())))


                    if (listEkstenzije.Intersect(ekstenzije).Any())
                    {
                        //bsInputs.DataSource = list.Where(s => ekstenzije.Contains(s.Ekstenzija.Substring(1)));
                        bsInputs.DataSource = list; //.Where(s => s.Ekstenzija != ".jpg" && s.Ekstenzija != ".jpeg" && s.Ekstenzija != ".gif" && s.Ekstenzija != ".bmp" && s.Ekstenzija != ".svg" && s.Ekstenzija != ".png");

                        dgvInput.DataSource = bsInputs;

                        dgvInput.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        int? indexIn = null;
        private void dgvInput_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (dgvInput.RowCount > 0)
                {

                    if (dgvOutput.RowCount > 0 && indexIn != dgvInput.CurrentCell.RowIndex && dgvInput.CurrentCell.RowIndex < dgvOutput.RowCount)
                    {
                        if (indexIn != null)
                        {
                            dgvOutput.Rows[indexIn.GetValueOrDefault()].Selected = false;
                        }


                        indexIn = dgvInput.CurrentRow.Index;

                        dgvOutput.Rows[dgvInput.CurrentCell.RowIndex].Selected = true;

                        dgvOutput.CurrentCell = dgvOutput.Rows[dgvInput.CurrentCell.RowIndex].Cells[1];

                        TagTextovi();

                    }

                    TagLibFajl(dgvInput.CurrentCell.RowIndex);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        void TagLibFajl(int id)
        {
            TagLib.File file = TagLib.File.Create(list.Where(s => s.IdInput == id).Select(s => s.Putanja).FirstOrDefault());

            txtArtist.Text = file.Tag.FirstAlbumArtist;
            txtTitle.Text = file.Tag.Title;
            txtAlbum.Text = file.Tag.Album;
            txtDuzina.Text = file.Properties.Duration.ToString(@"mm\:ss");
            txtYear.Text = file.Tag.Year.ToString();
            txtRbr.Text = file.Tag.Track.ToString();
            txtGenre.Text = file.Tag.FirstGenre;
            txtContr.Text = file.Tag.JoinedAlbumArtists;


            string str1 = file.Tag.FirstPerformer;
            string str2 = file.Tag.JoinedPerformers;
        }


        public static async Task StartCrawler(string text)
        {

            try
            {

                string url = string.Format("https://www.discogs.com/search/?q={0}&type=artist", text);
                var httpCli = new HttpClient();
                var html = await httpCli.GetStringAsync(url);

                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                var divs = htmlDoc.DocumentNode.SelectNodes("//div[@id='search_results']/div");

                artistList.Clear();

                foreach (var item in divs)
                {

                    artistList.Add(
                        item.Descendants("h4").FirstOrDefault().InnerText,
                        item.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }




        public static async Task StartKategorijeCrawler()
        {

            try
            {
                string url = string.Format("https://www.discogs.com{0}", artUrl);
                var httpCli = new HttpClient();
                var html = await httpCli.GetStringAsync(url);

                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                var divs = htmlDoc.DocumentNode.SelectNodes("//div[@id='discography_wrapper']/div[1]/ul[@class='facets_nav']");

                //testne variable
                //var liste = divs.Descendants("li").Select(a => a.Element("h3")).OfType<HtmlNode>().Select(a => a.Element("a").LastChild.InnerText.Replace(" ", String.Empty).Replace("\n", String.Empty)).ToList();
                //var pot = divs.Descendants("li").Select(a => a.Element("a")).OfType<HtmlNode>().Select(a => a.Element("span")).OfType<HtmlNode>().Select(y => y.NextSibling.InnerText.Replace(" ", String.Empty).Replace("\n", String.Empty)).ToList();

                var nodeLista = divs.Descendants("li").ToList();
                string katUrl = "";
                Kategorije.Clear();
                foreach (var i in nodeLista)
                {

                    if (i.FirstChild.NextSibling.Name == "h3")
                    {
                        kategorija = i.FirstChild.NextSibling.FirstChild.NextSibling.LastChild.InnerText.Replace(" ", String.Empty).Replace("\n", String.Empty);
                        katUrl = i.FirstChild.NextSibling.FirstChild.NextSibling.GetAttributeValue("href", string.Empty);
                    }

                    if (i.FirstChild.NextSibling.Name == "a" && i.FirstChild.NextSibling.FirstChild.NextSibling != null)
                    {
                        Kategorije.Add(new Kategorije()
                        {
                            Kategorija = kategorija,
                            KategorijaUrl = katUrl,
                            PotKat = new Potkategorije()
                            {
                                GlavnaKategorija = kategorija,
                                Potkategorija = i.FirstChild.NextSibling.FirstChild.NextSibling?.NextSibling.InnerText.Replace(" ", String.Empty).Replace("\n", String.Empty).Replace("&", "-"),
                                PotkategorijaUrl = i.FirstChild.NextSibling.GetAttributeValue("href", string.Empty)
                            },

                        });

                    }

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        public static async Task StartAlbumCrawler()
        {
            try
            {
                string url = string.Format("https://www.discogs.com{0}?sort=year%2Casc&limit=500&subtype={1}&filter_anv=0&type={2}&page=1", artUrl, potkategorija, kategorija);
                var httpCli = new HttpClient();
                var html = await httpCli.GetStringAsync(url);

                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                //var divs = htmlDoc.DocumentNode.SelectNodes("//*[@id='artist']");
                Albumi.Clear();


                var nodeLista = htmlDoc.DocumentNode.SelectNodes("//td[@class='title']/a");

                foreach (var i in nodeLista)
                {
                    Albumi.Add(new Album
                    {
                        Artist = artistStr,
                        AlbumUrl = i.GetAttributeValue("href", string.Empty),
                        Naziv = i.InnerText.Replace("&#39;", "'").Replace("&#34;", "\""),
                        Kategorija = kategorija,
                        Potkategorija = potkategorija
                    });

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        public static async Task StartTracksCrawler(bool master)
        {
            try
            {

                string url = string.Format("https://www.discogs.com{0}", albumUrl);
                var httpCli = new HttpClient();
                var html = await httpCli.GetStringAsync(url);

                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                var divs = htmlDoc.DocumentNode.SelectNodes("//table[@class='playlist']//tr[contains(@class,'tracklist_track track')]//td[contains(@class,'track tracklist_track_title ')]").ToList();
                //var genre = htmlDoc.DocumentNode.SelectSingleNode("//div[@itemprop='genre']/a").InnerText;

                var genre = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='head'][contains(text(),'Genre:')]").NextSibling.NextSibling.InnerText.Replace("\n", string.Empty).Trim(); //.NextSibling.FirstChild.InnerText;

                int brojverzija = 0;
                var godina = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='head'][contains(text(),'Released:') or contains(text(),'Year:') ]").NextSibling.NextSibling.InnerText.Replace("\n", string.Empty).Trim().ToString();
              

                imgUrl = htmlDoc.DocumentNode.SelectSingleNode("//span[@class='thumbnail_center']").FirstChild.NextSibling.GetAttributeValue("src", string.Empty);

                SpisakPjesama.Clear();

                uint id = 0;
                foreach (var i in divs)
                {
                    SpisakPjesama.Add(new Pjesma
                    {
                        Id = id++,
                        Album = albumStr,
                        Artist = artistStr,
                        NazivPjesme = i.Descendants("span").Where(a => a.Attributes["class"].Value.Contains("tracklist_track_title")).FirstOrDefault().InnerText.Replace("&#39;", "'").Replace("&#34;", "\"").Trim(), //.FirstChild.NextSibling.InnerText.Replace(" &#39;", "'").Replace("&#34;", "\"").Trim(),
                        Genre = genre,
                        Godina = godina

                    });

                }

                if (master)
                {

                    List<HtmlNode> verzije = new List<HtmlNode>();

                    if (htmlDoc.DocumentNode.SelectNodes("//table[@id='versions']//tr") != null)
                    {
                        verzije = htmlDoc.DocumentNode.SelectNodes("//table[@id='versions']//tr").Descendants("td").Where(a => a.Attributes["class"].Value.Contains("title")).ToList();
                        brojverzija = verzije.Count();
                    }


                    if (brojverzija > 0)
                    {
                        
                        int ver = 1;
                        dict.Clear();
                        dict.Add(0, "");

                        foreach (var i in verzije)
                        {
                            dict.Add(ver, i.FirstChild.NextSibling.GetAttributeValue("href", ""));
                            ver++;
                        }

                        Albumi.Where(x => x.Naziv == albumStr).Select(x => { x.BrojVerzija = brojverzija; x.VerzijeUrl = dict; return x; }).FirstOrDefault().ToList();
                    }
                }     


                    Albumi.Where(x => x.Naziv == albumStr).Select(x => { x.Genre = genre; x.Godina = godina; x.ImageUrl = imgUrl; x.Pjesme = SpisakPjesama; return x; }).FirstOrDefault().ToList();
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }


        string pretraga = "";
        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            
            if (txtPretraga.Text != pretraga)
            {
                pretraga = txtPretraga.Text;
                ClearTextTags();

                await Pretraga();
            }

        }



        private async void txtPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPretraga.Text != pretraga)
            {
                e.SuppressKeyPress = true;
                ClearTextTags();
                pretraga = txtPretraga.Text;

                await Pretraga();
            }
        }


        private async Task Pretraga()
        {

            try
            {
                string pretraga = txtPretraga.Text.Replace(" ", "+");

                cbArtist.DataSource = null;
                cbArtist.Items.Clear();
                linkArtist.Visible = false;

                cbKategorija.DataSource = null;
                cbKategorija.Items.Clear();
                linkKategorija.Visible = false;

                cbPotKat.DataSource = null;
                cbPotKat.Items.Clear();
                linkPotKat.Visible = false;

                cbAlbumi.DataSource = null;
                cbAlbumi.Items.Clear();
                linkAlbum.Visible = false;

                cbVerzije.DataSource = null;
                cbVerzije.Items.Clear();

                ClearTextTags();
                dgvOutput.DataSource = null;
                dgvOutput.Rows.Clear();

                await StartCrawler(pretraga);
                cbArtist.DataSource = new BindingSource(artistList, "");
                cbArtist.DisplayMember = "Key";
                cbArtist.ValueMember = "Value";
                artUrl = cbArtist.SelectedValue.ToString();
                artistStr = cbArtist.Text;
                linkArtist.Visible = true;

                
                await StartKategorijeCrawler();
                cbKategorija.DataSource = new BindingSource(Kategorije.Select(x => new { x.Kategorija, x.KategorijaUrl }).Distinct().ToList(), "");
                cbKategorija.DisplayMember = "Kategorija";
                cbKategorija.ValueMember = "KategorijaUrl";
                kategorija = cbKategorija.Text; //kategorija odabrana
                katUrl = cbKategorija.SelectedValue.ToString();
                linkKategorija.Visible = true;
              
                cbPotKat.DataSource = new BindingSource(Kategorije.Where(x => x.Kategorija == cbKategorija.Text).Select(x => new { x.PotKat.Potkategorija, x.PotKat.PotkategorijaUrl }).Distinct().ToList(), "");
                cbPotKat.DisplayMember = "Potkategorija";
                cbPotKat.ValueMember = "PotkategorijaUrl";
                potkategorija = cbPotKat.Text; //potkategorija odabrana
                potKatUrl = cbPotKat.SelectedValue.ToString();
                linkPotKat.Visible = true;
                
                await StartAlbumCrawler();
                cbAlbumi.DataSource = new BindingSource(Albumi, "");
                cbAlbumi.DisplayMember = "Naziv";
                cbAlbumi.ValueMember = "AlbumUrl";
                albumStr = cbAlbumi.Text; //kategorija odabrana
                albumUrl = cbAlbumi.SelectedValue.ToString();
                linkAlbum.Visible = true;


                await StartTracksCrawler(true);

                cbVerzije.DataSource = new BindingSource(Albumi.Where(x => x.Naziv == albumStr).Select(x => x.VerzijeUrl).FirstOrDefault(), null);
                if (cbVerzije.Items.Count != 0)
                {
                    cbVerzije.DisplayMember = "Key";
                    cbVerzije.ValueMember = "Value";
                }


                imgUrl = Albumi.Where(x => x.Naziv == albumStr).Select(x => x.ImageUrl).FirstOrDefault();
                Cover(imgUrl);

                PopuniOutput();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void linkArtist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = string.Format("https://www.discogs.com{0}", artUrl);
            ProcessStartInfo sInfo = new ProcessStartInfo(url);
            Process.Start(sInfo);
        }

        private void linkKategorija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = string.Format("https://www.discogs.com{0}", katUrl);
            ProcessStartInfo sInfo = new ProcessStartInfo(url);
            Process.Start(sInfo);
        }


        private void linkPotKat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = string.Format("https://www.discogs.com{0}", potKatUrl);
            ProcessStartInfo sInfo = new ProcessStartInfo(url);
            Process.Start(sInfo);
        }

        private void linkAlbum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = string.Format("https://www.discogs.com{0}", albumUrl);
            ProcessStartInfo sInfo = new ProcessStartInfo(url);
            Process.Start(sInfo);
        }

        private async void cbArtist_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cbArtist.ValueMember != "")
            {
                artUrl = cbArtist.SelectedValue.ToString();
                artistStr = cbArtist.Text;

                try
                {

                    cbKategorija.DataSource = null;
                    cbKategorija.Items.Clear();
                    linkKategorija.Visible = false;
                    cbPotKat.DataSource = null;
                    cbPotKat.Items.Clear();
                    linkPotKat.Visible = false;
                    cbAlbumi.DataSource = null;
                    cbAlbumi.Items.Clear();
                    linkAlbum.Visible = false;

                    cbVerzije.DataSource = null;
                    cbVerzije.Items.Clear();

                    ClearTextTags();
                    dgvOutput.DataSource = null;
                    dgvOutput.Rows.Clear();


                    await StartKategorijeCrawler();
                    cbKategorija.DataSource = new BindingSource(Kategorije.Select(x => new { x.Kategorija, x.KategorijaUrl }).Distinct().ToList(), "");
                    cbKategorija.DisplayMember = "Kategorija";
                    cbKategorija.ValueMember = "KategorijaUrl";
                    kategorija = cbKategorija.Text; //kategorija odabrana
                    katUrl = cbKategorija.SelectedValue.ToString();
                    linkKategorija.Visible = true;

                    cbPotKat.DataSource = new BindingSource(Kategorije.Where(x => x.Kategorija == cbKategorija.Text).Select(x => new { x.PotKat.Potkategorija, x.PotKat.PotkategorijaUrl }).Distinct().ToList(), "");
                    cbPotKat.DisplayMember = "Potkategorija";
                    cbPotKat.ValueMember = "PotkategorijaUrl";
                    potkategorija = cbPotKat.Text; //potkategorija odabrana
                    potKatUrl = cbPotKat.SelectedValue.ToString();
                    linkPotKat.Visible = true;

                    await StartAlbumCrawler();
                    cbAlbumi.DataSource = new BindingSource(Albumi, "");
                    cbAlbumi.DisplayMember = "Naziv";
                    cbAlbumi.ValueMember = "AlbumUrl";
                    albumStr = cbAlbumi.Text; //kategorija odabrana
                    albumUrl = cbAlbumi.SelectedValue.ToString();
                    linkAlbum.Visible = true;

                    await StartTracksCrawler(true);

                    cbVerzije.DataSource = new BindingSource(Albumi.Where(x => x.Naziv == albumStr).Select(x => x.VerzijeUrl).FirstOrDefault(), "");
                    if (cbVerzije.Items.Count != 0)
                    {
                        cbVerzije.DisplayMember = "Key";
                        cbVerzije.ValueMember = "Value";
                    }


                    imgUrl = Albumi.Where(x => x.Naziv == albumStr).Select(x => x.ImageUrl).FirstOrDefault();
                    Cover(imgUrl);

                    PopuniOutput();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private async void cbKategorija_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbKategorija.ValueMember != "")
            {
                katUrl = cbKategorija.SelectedValue.ToString();
                kategorija = cbKategorija.Text; //kategorija odabrana
                cbPotKat.DataSource = null;
                cbPotKat.Items.Clear();
                linkPotKat.Visible = false;
                cbAlbumi.DataSource = null;
                cbAlbumi.Items.Clear();
                linkAlbum.Visible = false;

                cbVerzije.DataSource = null;
                cbVerzije.Items.Clear();

                ClearTextTags();
                dgvOutput.DataSource = null;
                dgvOutput.Rows.Clear();

                cbPotKat.DataSource = new BindingSource(Kategorije.Where(x => x.Kategorija == cbKategorija.Text).Select(x => new { x.PotKat.Potkategorija, x.PotKat.PotkategorijaUrl }).Distinct().ToList(), "");
                cbPotKat.DisplayMember = "Potkategorija";
                cbPotKat.ValueMember = "PotkategorijaUrl";
                potkategorija = cbPotKat.Text; //potkategorija odabrana
                potKatUrl = cbPotKat.SelectedValue.ToString();
                linkPotKat.Visible = true;

                await StartAlbumCrawler();
                cbAlbumi.DataSource = new BindingSource(Albumi, "");
                cbAlbumi.DisplayMember = "Naziv";
                cbAlbumi.ValueMember = "AlbumUrl";
                albumStr = cbAlbumi.Text; //kategorija odabrana
                albumUrl = cbAlbumi.SelectedValue.ToString();
                linkAlbum.Visible = true;

                await StartTracksCrawler(true);

                cbVerzije.DataSource = new BindingSource(Albumi.Where(x => x.Naziv == albumStr).Select(x => x.VerzijeUrl).FirstOrDefault(), "");
                if (cbVerzije.Items.Count != 0)
                {
                    cbVerzije.DisplayMember = "Key";
                    cbVerzije.ValueMember = "Value";
                }


                PopuniOutput();
            }
        }

        private async void cbPotKat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbPotKat.ValueMember != "")
            {
                potkategorija = cbPotKat.Text;
                potKatUrl = cbPotKat.SelectedValue.ToString();
                cbAlbumi.DataSource = null;
                cbAlbumi.Items.Clear();
                linkAlbum.Visible = false;

                cbVerzije.DataSource = null;
                cbVerzije.Items.Clear();

                dgvOutput.DataSource = null;
                dgvOutput.Rows.Clear();
                ClearTextTags();

                await StartAlbumCrawler();
                cbAlbumi.DataSource = new BindingSource(Albumi, "");
                cbAlbumi.DisplayMember = "Naziv";
                cbAlbumi.ValueMember = "AlbumUrl";
                albumStr = cbAlbumi.Text; //kategorija odabrana
                albumUrl = cbAlbumi.SelectedValue.ToString();
                linkAlbum.Visible = true;

                await StartTracksCrawler(true);

                cbVerzije.DataSource = new BindingSource(Albumi.Where(x => x.Naziv == albumStr).Select(x => x.VerzijeUrl).FirstOrDefault(), "");
                if (cbVerzije.Items.Count != 0)
                {
                    cbVerzije.DisplayMember = "Key";
                    cbVerzije.ValueMember = "Value";
                }


                imgUrl = Albumi.Where(x => x.Naziv == albumStr).Select(x => x.ImageUrl).FirstOrDefault();
                Cover(imgUrl);

                PopuniOutput();
            }
        }

        private async void cbAlbumi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbAlbumi.ValueMember != "")
            {
                albumStr = cbAlbumi.Text;
                albumUrl = cbAlbumi.SelectedValue.ToString();

                cbVerzije.DataSource = null;
                cbVerzije.Items.Clear();

                dgvOutput.DataSource = null;
                dgvOutput.Rows.Clear();
                ClearTextTags();

                await StartTracksCrawler(true);
                
                cbVerzije.DataSource = new BindingSource(Albumi.Where(x => x.Naziv == albumStr).Select(x => x.VerzijeUrl).FirstOrDefault(), "");
                if (cbVerzije.Items.Count != 0)
                {
                    cbVerzije.DisplayMember = "Key";
                    cbVerzije.ValueMember = "Value";
                }


                imgUrl = Albumi.Where(x => x.Naziv == albumStr).Select(x => x.ImageUrl).FirstOrDefault();
                Cover(imgUrl);
                PopuniOutput();
            }
        }


        private async void cbVerzije_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvOutput.DataSource = null;
            dgvOutput.Rows.Clear();
            ClearTextTags();

            albumUrl = cbVerzije.SelectedValue.ToString();
            linkAlbum.Visible = false;

            await StartTracksCrawler(false);

            //cbVerzije.DataSource = new BindingSource(Albumi.Where(x => x.Naziv == albumStr).Select(x => x.VerzijeUrl).FirstOrDefault(), "");
            //cbVerzije.DisplayMember = "Key";
            ////cbVerzije.ValueMember = "Value";            
            linkAlbum.Visible = true;
            imgUrl = Albumi.Where(x => x.Naziv == albumStr).Select(x => x.ImageUrl).FirstOrDefault();
            Cover(imgUrl);
            PopuniOutput();
        }


        void PopuniOutput()
        {

            try
            {
                if (SpisakPjesama.Count > 0)
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Naziv", typeof(string));
                    dt.Columns.Add("Artist", typeof(string));
                    dt.Columns.Add("AlbumName", typeof(string));
                    dt.Columns.Add("Genre", typeof(string));
                    dt.Columns.Add("Year", typeof(string));

                    DataRow dr = null;

                    foreach (var pjesma in SpisakPjesama)
                    {
                        dr = dt.NewRow();
                        dr["Id"] = pjesma.Id;
                        dr["Naziv"] = pjesma.NazivPjesme;
                        dr["Artist"] = pjesma.Artist;
                        dr["AlbumName"] = pjesma.Album;
                        dr["Genre"] = pjesma.Genre;
                        dr["Year"] = pjesma.Godina;
                        dt.Rows.Add(dr);
                    }

                    dgvOutput.AutoGenerateColumns = false;
                    dgvOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvOutput.DataSource = dt;
                    dgvOutput.Refresh();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        int? indexOut = null;
        private void dgvOutput_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (dgvOutput.RowCount > 0)
                {

                    if (dgvInput.RowCount > 0 && indexOut != dgvOutput.CurrentRow.Index && dgvOutput.CurrentCell.RowIndex < dgvInput.RowCount)
                    {

                        if (indexOut != null)
                        {
                            dgvInput.Rows[indexOut.GetValueOrDefault()].Selected = false;
                        }

                        indexOut = dgvOutput.CurrentRow.Index;

                        dgvInput.Rows[dgvOutput.CurrentCell.RowIndex].Selected = true;

                        TagLibFajl(indexOut.GetValueOrDefault());
                    }

                    TagTextovi();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void ClearTextTags()
        {
            txtArtistOut.Text = "";
            txtTitleOut.Text = "";
            txtAlbumOut.Text = "";
            txtDuzinaOut.Text = "";
            txtYearOut.Text = "";
            txtRbrOut.Text = "";
            txtGenreOut.Text = "";
            txtContrOut.Text = "";

            picCover.Image = null;
        }


        void TagTextovi()
        {

            txtArtistOut.Text = dgvOutput.CurrentRow.Cells["Artist"].Value.ToString();
            txtTitleOut.Text = dgvOutput.CurrentRow.Cells["NazivOut"].Value.ToString();
            txtAlbumOut.Text = dgvOutput.CurrentRow.Cells["AlbumName"].Value.ToString();
            txtDuzinaOut.Text = txtDuzina.Text;
            txtYearOut.Text = dgvOutput.CurrentRow.Cells["Year"].Value.ToString();
            txtRbrOut.Text = ((int)(dgvOutput.CurrentRow.Cells["Id"].Value) + 1).ToString();
            txtGenreOut.Text = dgvOutput.CurrentRow.Cells["Genre"].Value.ToString();
            txtContrOut.Text = dgvOutput.CurrentRow.Cells["Artist"].Value.ToString();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtArtistOut.Text))
            {
                SpisakPjesama.Where(x => x.Id == ((int)(dgvOutput.CurrentRow.Cells["Id"].Value))).Select(x => { x.Artist = txtArtistOut.Text; return x; }).FirstOrDefault().ToList();
                PopuniOutput();
            }
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTitleOut.Text))
            {
                SpisakPjesama.Where(x => x.Id == ((int)(dgvOutput.CurrentRow.Cells["Id"].Value))).Select(x => { x.NazivPjesme = txtTitleOut.Text; return x; }).FirstOrDefault().ToList();
                PopuniOutput();
            }
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAlbumOut.Text))
            {
                SpisakPjesama.Where(x => x.Id == ((int)(dgvOutput.CurrentRow.Cells["Id"].Value))).Select(x => { x.Album = txtAlbumOut.Text; return x; }).FirstOrDefault().ToList();
                PopuniOutput();
            }
        }

        private void btnGodina_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtYearOut.Text))
            {
                SpisakPjesama.Where(x => x.Id == ((int)(dgvOutput.CurrentRow.Cells["Id"].Value))).Select(x => { x.Godina = txtYearOut.Text; return x; }).FirstOrDefault().ToList();
                PopuniOutput();
            }
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGenreOut.Text))
            {
                SpisakPjesama.Where(x => x.Id == ((int)(dgvOutput.CurrentRow.Cells["Id"].Value))).Select(x => { x.Genre = txtGenreOut.Text; return x; }).FirstOrDefault().ToList();
                PopuniOutput();
            }
        }

        private void btnArtistSve_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtArtistOut.Text))
            {
                SpisakPjesama.Select(x => { x.Artist = txtArtistOut.Text; return x; }).ToList();
                PopuniOutput();
            }
        }

        private void btnAlbumSve_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAlbumOut.Text))
            {
                SpisakPjesama.Select(x => { x.Album = txtAlbumOut.Text; return x; }).ToList();
                PopuniOutput();
            }
        }

        private void btnGodinaSve_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtYearOut.Text))
            {
                SpisakPjesama.Select(x => { x.Godina = txtYearOut.Text; return x; }).ToList();
                PopuniOutput();
            }
        }

        private void btnGenreSve_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGenreOut.Text))
            {
                SpisakPjesama.Select(x => { x.Genre = txtGenreOut.Text; return x; }).ToList();
                PopuniOutput();
            }
        }

        private void btnKorigovati_Click(object sender, EventArgs e)
        {
            if (dgvOutput.RowCount > 0)
            {

                if (rbPrvoVeliko.Checked)
                {
                    KorigovanjePravopisa();
                }
                else if (!rbSamoPocetna.Checked)
                {
                    KorigovanjePravopisa();
                }
                else   //!rbSva.Checked
                {
                    KorigovanjePravopisa();
                }
            }
        }


        void KorigovanjePravopisa()
        {
            StringBuilder strBuild;

            if (ckNazivi.Checked)
            {

                if (rbPrvoVeliko.Checked)
                {
                    string naziv;

                    foreach (var str in SpisakPjesama)
                    {
                        strBuild = new StringBuilder(str.NazivPjesme.ToLower());
                        strBuild[0] = str.NazivPjesme.ToUpper()[0];
                        naziv = strBuild.ToString();
                        SpisakPjesama.Where(x => x.NazivPjesme == str.NazivPjesme).Select(x => { x.NazivPjesme = naziv; return x; }).FirstOrDefault().ToList();
                    }

                    PopuniOutput();
                }
                else if (rbSamoPocetna.Checked)
                {
                    foreach (var str in SpisakPjesama)
                    {
                        string[] nazivi = str.NazivPjesme.Split(' ');
                        string naziv;
                        List<string> listStr = new List<string>();

                        foreach (var n in nazivi)
                        {
                            string nz;
                            
                            strBuild = new StringBuilder(n.ToLower());
                            strBuild[0] = n.ToUpper()[0];
                            nz = strBuild.ToString();
                            listStr.Add(nz);
                            
                        }

                        naziv = string.Join(" ", listStr);
                        SpisakPjesama.Where(x => x.NazivPjesme == str.NazivPjesme).Select(x => { x.NazivPjesme = naziv; return x; }).FirstOrDefault().ToList();

                        PopuniOutput();
                    }

                }
                else   //!rbSva.Checked
                {
                    foreach (var str in SpisakPjesama)
                    {
                        SpisakPjesama.Where(x => x.NazivPjesme == str.NazivPjesme).Select(x => { x.NazivPjesme = str.NazivPjesme.ToUpper(); return x; }).FirstOrDefault().ToList();
                    }

                    PopuniOutput();
                }
            }

            if (ckAlbum.Checked)
            {
                if (rbPrvoVeliko.Checked)
                {
                    string naziv;

                    foreach (var str in SpisakPjesama)
                    {
                        strBuild = new StringBuilder(str.Album.ToLower());
                        strBuild[0] = str.Album.ToUpper()[0];
                        naziv = strBuild.ToString();
                        SpisakPjesama.Where(x => x.Album == str.Album).Select(x => { x.Album = naziv; return x; }).FirstOrDefault().ToList();
                    }

                    PopuniOutput();
                }
                else if (rbSamoPocetna.Checked)
                {
                    foreach (var str in SpisakPjesama)
                    {
                        string[] nazivi = str.Album.Split(' ');
                        string naziv;
                        List<string> listStr = new List<string>();

                        foreach (var n in nazivi)
                        {
                            string nz;

                            strBuild = new StringBuilder(n.ToLower());
                            strBuild[0] = n.ToUpper()[0];
                            nz = strBuild.ToString();
                            listStr.Add(nz);

                        }

                        naziv = string.Join(" ", listStr);
                        SpisakPjesama.Where(x => x.Album == str.Album).Select(x => { x.Album = naziv; return x; }).FirstOrDefault().ToList();

                        PopuniOutput();
                    }

                }
                else   //!rbSva.Checked
                {
                    foreach (var str in SpisakPjesama)
                    {
                        SpisakPjesama.Where(x => x.Album == str.Album).Select(x => { x.Album = str.Album.ToUpper(); return x; }).FirstOrDefault().ToList();
                    }

                    PopuniOutput();
                }
            }
            if(ckArtist.Checked)
            {
                if (rbPrvoVeliko.Checked)
                {
                    string naziv;

                    foreach (var str in SpisakPjesama)
                    {
                        strBuild = new StringBuilder(str.Artist.ToLower());
                        strBuild[0] = str.Artist.ToUpper()[0];
                        naziv = strBuild.ToString();
                        SpisakPjesama.Where(x => x.Artist == str.Artist).Select(x => { x.Artist = naziv; return x; }).FirstOrDefault().ToList();
                    }

                    PopuniOutput();
                }
                else if (rbSamoPocetna.Checked)
                {
                    foreach (var str in SpisakPjesama)
                    {
                        string[] nazivi = str.Artist.Split(' ');
                        string naziv;
                        List<string> listStr = new List<string>();

                        foreach (var n in nazivi)
                        {
                            string nz;

                            strBuild = new StringBuilder(n.ToLower());
                            strBuild[0] = n.ToUpper()[0];
                            nz = strBuild.ToString();
                            listStr.Add(nz);

                        }

                        naziv = string.Join(" ", listStr);
                        SpisakPjesama.Where(x => x.Artist == str.Artist).Select(x => { x.Artist = naziv; return x; }).FirstOrDefault().ToList();

                        PopuniOutput();
                    }

                }
                else   //!rbSva.Checked
                {
                    foreach (var str in SpisakPjesama)
                    {
                        SpisakPjesama.Where(x => x.Artist == str.Artist).Select(x => { x.Artist = str.Artist.ToUpper(); return x; }).FirstOrDefault().ToList();
                    }

                    PopuniOutput();
                }
            }
        }




        private void rbPrvoVeliko_Click(object sender, EventArgs e)
        {
            if (!rbPrvoVeliko.Checked)
            {
                rbPrvoVeliko.Checked = true;
                rbSamoPocetna.Checked = false;
                rbSva.Checked = false;
            }
        }

        private void rbSamoPocetna_Click(object sender, EventArgs e)
        {
            if (!rbSamoPocetna.Checked)
            {
                rbSamoPocetna.Checked = true;
                rbPrvoVeliko.Checked = false;
                rbSva.Checked = false;
            }
        }

        private void rbSva_Click(object sender, EventArgs e)
        {
            if (!rbSva.Checked)
            {
                rbSva.Checked = true;
                rbSamoPocetna.Checked = false;
                rbPrvoVeliko.Checked = false;
            }
        }


        string path = "";
        void Cover(string url)
        {
          

            try
            {
                var invalidChars = Path.GetInvalidFileNameChars();

                string albumNewStr = new string(albumStr.Where(x => !invalidChars.Contains(x)).ToArray());
                path = $"{Application.StartupPath}\\{albumNewStr}.jpg";


                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    byte[] data = webClient.DownloadData(url);

                    using (MemoryStream mem = new MemoryStream(data))
                    {

                        using (var myImg = Image.FromStream(mem))
                        {
                            myImg.Save(path, ImageFormat.Jpeg);
                        }

                        mem.Close();
                    }

                }

                picCover.ImageLocation = path;
                picCover.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }           
        }

        private void btnIzvrsiti_Click(object sender, EventArgs e)
        {
            bool godOk = false;

            try
            {
                uint num;
                foreach(var god in SpisakPjesama)
                {
                    if(!uint.TryParse(god.Godina, out num))
                    {
                        godOk = false;
                        break;
                    } else
                    {
                        godOk = true;
                    }
                }
                
                if (godOk)
                {
                    foreach (var i in list)
                    {
                        
                        FileInfo fileInfo = new FileInfo(i.Putanja);
                        fileInfo.IsReadOnly = false;

                        var file = TagLib.File.Create(i.Putanja);
                        file.Tag.Title = SpisakPjesama.Where(x => x.Id == i.IdInput).Select(x => x.NazivPjesme).FirstOrDefault();
                        file.Tag.Album = SpisakPjesama.Where(x => x.Id == i.IdInput).Select(x => x.Album).FirstOrDefault();
                        file.Tag.Year = Convert.ToUInt32(SpisakPjesama.Where(x => x.Id == i.IdInput).Select(x => x.Godina).FirstOrDefault());
                        file.Tag.Track = SpisakPjesama.Where(x => x.Id == i.IdInput).Select(x => (x.Id + 1)).FirstOrDefault();
                        file.Tag.AlbumArtists = new string[] { $"{SpisakPjesama.Where(x => x.Id == i.IdInput).Select(x => x.Artist).FirstOrDefault()}" };
                        file.Tag.Composers = new string[] { $"{SpisakPjesama.Where(x => x.Id == i.IdInput).Select(x => x.Artist).FirstOrDefault()}" };
                        file.Tag.Genres = new string[] { $"{SpisakPjesama.Where(x => x.Id == i.IdInput).Select(x => x.Genre).FirstOrDefault()}" };
                        file.Tag.Performers = new string[] { $"{SpisakPjesama.Where(x => x.Id == i.IdInput).Select(x => x.Artist).FirstOrDefault()}" };

                        TagLib.Picture pic = new TagLib.Picture
                        {
                            Type = TagLib.PictureType.FrontCover,
                            Description = "Cover",
                            MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg,                          

                        };

                        pic.Data = TagLib.ByteVector.FromPath(path);
                        file.Tag.Pictures = new TagLib.IPicture[] { pic };
                        file.Save();
                    }

                    MessageBox.Show("Promjena uspješno izvršena.");

                } else
                {
                    MessageBox.Show("Godina albuma mora biti validna. (numerički pozitivan broj)\n");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }    
        }
        
        void PretaziPoAlbumu()
        {

        }

        public static int clanovi = 0;
        private void btnSablon_Click(object sender, EventArgs e)
        {
            
            uint id = 0;
            Sablon frmSablon = new Sablon();            
            frmSablon.ShowDialog();
            
            if(clanovi > 0)
            {

                for (int i = clanovi; i > 0; i--)
                {
                    SpisakPjesama.Add(new Pjesma
                    {
                        Id = id++,
                        Album = "",
                        Artist = "",
                        NazivPjesme = "",
                        Genre = "",
                        Godina = ""

                    });
                }

                PopuniOutput();              
            }
        }
    }
}
