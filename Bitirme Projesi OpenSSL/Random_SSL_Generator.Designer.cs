namespace Bitirme_Projesi_OpenSSL
{
    partial class Random_SSL_Generator
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
            this.validity = new System.Windows.Forms.Label();
            this.clear_all = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.keys = new System.Windows.Forms.GroupBox();
            this.one_key = new System.Windows.Forms.Button();
            this.priv_key = new System.Windows.Forms.Label();
            this.two_key = new System.Windows.Forms.Button();
            this.private_key = new System.Windows.Forms.TextBox();
            this.country_shorts = new System.Windows.Forms.ComboBox();
            this.x = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.country_t = new System.Windows.Forms.ComboBox();
            this.details = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.web_adress_t = new System.Windows.Forms.TextBox();
            this.organization_t = new System.Windows.Forms.TextBox();
            this.organization_unit_t = new System.Windows.Forms.TextBox();
            this.district_t = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.Label();
            this.city_t = new System.Windows.Forms.TextBox();
            this.name_t = new System.Windows.Forms.TextBox();
            this.web_adress = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.district = new System.Windows.Forms.Label();
            this.country_ll = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mail = new System.Windows.Forms.Label();
            this.mail_t = new System.Windows.Forms.TextBox();
            this.contry_s_l = new System.Windows.Forms.Label();
            this.yil_l = new System.Windows.Forms.Label();
            this.validity_t = new System.Windows.Forms.ComboBox();
            this.gun_l = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.hata = new System.Windows.Forms.Label();
            this.keys.SuspendLayout();
            this.SuspendLayout();
            // 
            // validity
            // 
            this.validity.AutoSize = true;
            this.validity.Location = new System.Drawing.Point(94, 160);
            this.validity.Name = "validity";
            this.validity.Size = new System.Drawing.Size(102, 16);
            this.validity.TabIndex = 46;
            this.validity.Text = "Geçerlilik süresi";
            // 
            // clear_all
            // 
            this.clear_all.AutoSize = true;
            this.clear_all.Location = new System.Drawing.Point(572, 362);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(116, 26);
            this.clear_all.TabIndex = 37;
            this.clear_all.Text = "Tümünü temizle";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(14, 407);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 26);
            this.cancel.TabIndex = 42;
            this.cancel.Text = "İptal";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // keys
            // 
            this.keys.Controls.Add(this.error);
            this.keys.Controls.Add(this.one_key);
            this.keys.Controls.Add(this.priv_key);
            this.keys.Controls.Add(this.two_key);
            this.keys.Controls.Add(this.private_key);
            this.keys.Location = new System.Drawing.Point(88, 270);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(478, 122);
            this.keys.TabIndex = 10;
            this.keys.TabStop = false;
            this.keys.Text = "Anahtar türü";
            // 
            // one_key
            // 
            this.one_key.AutoSize = true;
            this.one_key.Location = new System.Drawing.Point(186, -2);
            this.one_key.Name = "one_key";
            this.one_key.Size = new System.Drawing.Size(75, 26);
            this.one_key.TabIndex = 11;
            this.one_key.Text = "1024";
            this.one_key.UseVisualStyleBackColor = true;
            this.one_key.Click += new System.EventHandler(this.one_key_Click);
            // 
            // priv_key
            // 
            this.priv_key.AutoSize = true;
            this.priv_key.Location = new System.Drawing.Point(23, 37);
            this.priv_key.Name = "priv_key";
            this.priv_key.Size = new System.Drawing.Size(56, 16);
            this.priv_key.TabIndex = 22;
            this.priv_key.Text = "Anahtar:";
            // 
            // two_key
            // 
            this.two_key.AutoSize = true;
            this.two_key.Location = new System.Drawing.Point(286, -2);
            this.two_key.Name = "two_key";
            this.two_key.Size = new System.Drawing.Size(75, 26);
            this.two_key.TabIndex = 12;
            this.two_key.Text = "2048";
            this.two_key.UseVisualStyleBackColor = true;
            this.two_key.Click += new System.EventHandler(this.two_key_Click);
            // 
            // private_key
            // 
            this.private_key.Location = new System.Drawing.Point(147, 33);
            this.private_key.Name = "private_key";
            this.private_key.Size = new System.Drawing.Size(177, 22);
            this.private_key.TabIndex = 13;
            // 
            // country_shorts
            // 
            this.country_shorts.FormattingEnabled = true;
            this.country_shorts.Items.AddRange(new object[] {
            "AF",
            "AX",
            "DE",
            "US",
            "UM",
            "AS",
            "AD",
            "AO",
            "AI",
            "AQ",
            "AG",
            "AR",
            "AL",
            "AW",
            "AU",
            "AT",
            "AZ",
            "BS",
            "BH",
            "BD",
            "BB",
            "EH",
            "BY",
            "BE",
            "BZ",
            "BJ",
            "BM",
            "AE",
            "UK",
            "BO",
            "BA",
            "BW",
            "BV",
            "BR",
            "BN",
            "BG",
            "BF",
            "BI",
            "BT",
            "GB",
            "CV",
            "KY",
            "GI",
            "DZ",
            "DJ",
            "CC",
            "CK",
            "TD",
            "CZ",
            "CN",
            "DK",
            "TP",
            "DO",
            "DM",
            "EC",
            "GQ",
            "SV",
            "ID",
            "ER",
            "AM",
            "EE",
            "ET",
            "FK",
            "FO",
            "MA",
            "FJ",
            "CI",
            "PH",
            "PS",
            "FI",
            "FR",
            "FX",
            "GF",
            "TF",
            "PF",
            "GA",
            "GM",
            "GH",
            "GN",
            "GW",
            "TG",
            "GD",
            "GL",
            "GP",
            "GU",
            "GT",
            "GY",
            "ZA",
            "GS",
            "KR",
            "GE",
            "HT",
            "HM",
            "HR",
            "IN",
            "NL",
            "AN",
            "HN",
            "HK",
            "IQ",
            "IO",
            "IR",
            "IE",
            "ES",
            "IL",
            "GD",
            "CH",
            "IT",
            "IS",
            "JM",
            "JP",
            "KH",
            "CM",
            "CA",
            "QA",
            "KZ",
            "KE",
            "CY",
            "KG",
            "KI",
            "CO",
            "KM",
            "CG",
            "CD",
            "KP",
            "CR",
            "KW",
            "MP",
            "CU",
            "LA",
            "LS",
            "LV",
            "LR",
            "LY",
            "LI",
            "LT",
            "LB",
            "LU",
            "MO",
            "HU",
            "MG",
            "MK",
            "MW",
            "MV",
            "MY",
            "ML",
            "MT",
            "MH",
            "MQ",
            "MU",
            "YT",
            "MX",
            "EG",
            "FM",
            "MN",
            "MD",
            "MC",
            "MS",
            "MR",
            "MZ",
            "MM",
            "NA",
            "NR",
            "NP",
            "NE",
            "NG",
            "NI",
            "NU",
            "CX",
            "NF",
            "NO",
            "CF",
            "UZ",
            "PK",
            "PW",
            "PA",
            "PG",
            "PY",
            "PE",
            "PN",
            "PL",
            "PT",
            "PR",
            "RE",
            "RO",
            "RW",
            "RU",
            "SH",
            "KN",
            "LC",
            "PM",
            "VC",
            "WS",
            "SM",
            "ST",
            "SN",
            "SC",
            "CS",
            "SL",
            "SG",
            "SK",
            "SI",
            "SB",
            "SO",
            "LK",
            "SU",
            "SD",
            "SR",
            "SY",
            "SA",
            "SJ",
            "SZ",
            "CL",
            "TJ",
            "TZ",
            "TH",
            "TW",
            "TP",
            "TK",
            "TO",
            "TT",
            "TN",
            "TC",
            "TV",
            "TR",
            "TM",
            "UG",
            "UA",
            "OM",
            "UY",
            "JO",
            "VU",
            "VA",
            "VE",
            "VN",
            "VG",
            "VI",
            "WF",
            "YE",
            "NC",
            "NZ",
            "YU",
            "GR",
            "ZR",
            "ZM",
            "ZW"});
            this.country_shorts.Location = new System.Drawing.Point(517, 76);
            this.country_shorts.Name = "country_shorts";
            this.country_shorts.Size = new System.Drawing.Size(121, 24);
            this.country_shorts.TabIndex = 3;
            this.country_shorts.SelectedIndexChanged += new System.EventHandler(this.country_shorts_SelectedIndexChanged);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.ForeColor = System.Drawing.Color.Red;
            this.x.Location = new System.Drawing.Point(502, 186);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(220, 16);
            this.x.TabIndex = 44;
            this.x.Text = "(Eğer yoksa web sitesi adı yazınız...)";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(95, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(31, 16);
            this.name.TabIndex = 43;
            this.name.Text = "İsim";
            // 
            // country_t
            // 
            this.country_t.FormattingEnabled = true;
            this.country_t.Items.AddRange(new object[] {
            "Afganistan",
            "Aland Adaları",
            "Almanya",
            "Amerika Birleşik Devletleri",
            "ABD Küçük Dış Adaları",
            "Amerikan Samoası",
            "Andorra",
            "Angora",
            "Anguilla",
            "Antarktika",
            "Antigua ve Barbuda",
            "Arjantin",
            "Arnavutluk",
            "Aruba",
            "Avustralya",
            "Avusturya",
            "Azerbeycan",
            "Bahamalar",
            "Bahreyn",
            "Bangladeş",
            "Barbados",
            "Batı Sahra",
            "Belarus",
            "Belçika",
            "Belize",
            "Benin",
            "Bermuda",
            "Birleşik Arap Emirlikleri",
            "Birleşik Krallık",
            "Bolivya",
            "Bosna Hersek",
            "Botsvana",
            "Bouvet Adası",
            "Brezilya",
            "Brunei Sultanlığı",
            "Bulgaristan",
            "Burkina Faso",
            "Burundi",
            "Butan",
            "Büyük Britanya (İngiltere)",
            "Cape Verde",
            "Cayman Adaları",
            "Cebelitarık",
            "Cezayir",
            "Cibuti",
            "Cocos (Keeling) Adaları",
            "Cook Adaları",
            "Çad",
            "Çek Cumhuriyeti",
            "Çin",
            "Danimarka",
            "Doğu Timor",
            "Dominik Cumhuriyeti",
            "Dominika",
            "Ekvador",
            "Ekvator Ginesi",
            "El Salvador",
            "Endonezya",
            "Eritre",
            "Ermenistan",
            "Estonya",
            "Etiyopya",
            "Falkland Adaları (Malvinas)",
            "Faroe Adaları",
            "Fas",
            "Fiji",
            "Fildişi Sahili (Fildişi Sahili)",
            "Filipinler",
            "Filistin Bölgesi",
            "Finlandiya",
            "Fransa",
            "Fransa, Büyükşehir",
            "Fransız Guyanası",
            "Fransız Güney Toprakları",
            "Fransız Polinezyası",
            "Gabon",
            "Gambiya",
            "Gana",
            "Gine",
            "Gine-Bissau",
            "Gitmek",
            "Grenada",
            "Grönland",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guyana",
            "Güney Afrika",
            "Güney Georgia & G.Sandwich Adaları",
            "Güney Kore",
            "Gürcistan",
            "Haiti",
            "Heard ve McDonald Adaları",
            "Hırvatistan (Hrvatska)",
            "Hindistan",
            "Hollanda",
            "Hollanda Antilleri",
            "Honduras",
            "Hong Kong",
            "Irak",
            "İngiliz Hint Okyanusu Bölgesi",
            "İran",
            "İrlanda",
            "ispanya",
            "İsrail",
            "İsveç",
            "İsviçre",
            "İtalya",
            "İzlanda",
            "Jamaika",
            "Japonya",
            "Kamboçya",
            "Kamerun",
            "Kanada",
            "Katar",
            "Kazakistan",
            "Kenya",
            "Kıbrıs",
            "Kırgızistan",
            "Kiribati",
            "Kolombiya",
            "Komorlar",
            "Kongo",
            "Kongo Demokratik Cumhuriyeti",
            "Kore (Kuzey)",
            "Kosta Rika",
            "Kuveyt",
            "Kuzey Mariana Adaları",
            "Küba",
            "Laos",
            "Lesotho",
            "Letonya",
            "Liberya",
            "Libya",
            "Lihtenştayn",
            "Litvanya",
            "Lübnan",
            "Lüksemburg",
            "Macao",
            "Macaristan",
            "Madagaskar",
            "Makedonya",
            "Malawi",
            "Maldivler",
            "Malezya",
            "Mali",
            "Malta",
            "Marşal Adaları",
            "Martinik",
            "Mauritius",
            "Mayotte",
            "Meksika",
            "Mısır",
            "Mikronezya Federe Devletleri",
            "Moğolistan",
            "Moldova",
            "Monako",
            "Montserrat",
            "Moritanya",
            "Mozambik",
            "Myanmar",
            "Namibya",
            "Nauru",
            "Nepal",
            "Nijer",
            "Nijerya",
            "Nikaragua",
            "Niue",
            "Noel Adası",
            "Norfolk Adası",
            "Norveç",
            "Orta Afrika Cumhuriyeti",
            "Özbekistan",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua Yeni Gine",
            "Paraguay",
            "Peru",
            "Pitcairn",
            "Polonya",
            "Portekiz",
            "Porto Riko",
            "Réunion Ada Devleti",
            "Romanya",
            "Ruanda",
            "Rusya Federasyonu",
            "Saint Helena",
            "Saint Kitts ve Nevis",
            "Saint Lucia",
            "Saint Pierre ve Miquelon",
            "Saint Vincent ve Grenadinler",
            "Samoa",
            "San Marino",
            "Sao Tome ve Principe",
            "Senegal",
            "Seyşeller",
            "Sırbistan ve Karadağ",
            "Sierra Leone",
            "Singapur",
            "Slovakya",
            "Slovenya",
            "Solomon Adaları",
            "Somali",
            "Sri Lanka",
            "SSCB (eski)",
            "Sudan",
            "Surinam",
            "Suriye",
            "Suudi Arabistan",
            "Svalbard ve Jan Mayen",
            "Svaziland",
            "Şili",
            "Tacikistan",
            "Tanzanya",
            "Tayland",
            "Tayvan",
            "Timor-Leste",
            "Tokelau",
            "Tonga",
            "Trinidad ve Tobago",
            "Tunus",
            "Turks ve Caicos Adaları",
            "Tuvalu",
            "Türkiye",
            "Türkmenistan",
            "Uganda",
            "Ukrayna",
            "Umman",
            "Uruguay",
            "Ürdün",
            "Vanuatu",
            "Vatikan Şehir Devleti",
            "Venezuela",
            "Vietnam",
            "Virgin Adaları (İngiliz)",
            "Virjin Adaları (ABD)",
            "Wallis ve Futuna",
            "Yemen",
            "Yeni Kaledonya",
            "Yeni Zelanda (Aotearoa)",
            "Yugoslavya (eski)",
            "Yunanistan",
            "Zaire (eski)",
            "Zambiya",
            "Zimbabve"});
            this.country_t.Location = new System.Drawing.Point(236, 74);
            this.country_t.Name = "country_t";
            this.country_t.Size = new System.Drawing.Size(261, 24);
            this.country_t.TabIndex = 2;
            this.country_t.SelectedIndexChanged += new System.EventHandler(this.country_t_SelectedIndexChanged);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Location = new System.Drawing.Point(94, 214);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(37, 16);
            this.details.TabIndex = 41;
            this.details.Text = "Birim";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(94, 186);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(41, 16);
            this.company.TabIndex = 38;
            this.company.Text = "Şirket";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(95, 104);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(13, 16);
            this.city.TabIndex = 35;
            this.city.Text = "İl";
            // 
            // web_adress_t
            // 
            this.web_adress_t.Location = new System.Drawing.Point(236, 46);
            this.web_adress_t.Name = "web_adress_t";
            this.web_adress_t.Size = new System.Drawing.Size(261, 22);
            this.web_adress_t.TabIndex = 1;
            // 
            // organization_t
            // 
            this.organization_t.Location = new System.Drawing.Point(235, 186);
            this.organization_t.Name = "organization_t";
            this.organization_t.Size = new System.Drawing.Size(261, 22);
            this.organization_t.TabIndex = 7;
            // 
            // organization_unit_t
            // 
            this.organization_unit_t.Location = new System.Drawing.Point(235, 214);
            this.organization_unit_t.Name = "organization_unit_t";
            this.organization_unit_t.Size = new System.Drawing.Size(261, 22);
            this.organization_unit_t.TabIndex = 8;
            // 
            // district_t
            // 
            this.district_t.Location = new System.Drawing.Point(236, 130);
            this.district_t.Name = "district_t";
            this.district_t.Size = new System.Drawing.Size(261, 22);
            this.district_t.TabIndex = 5;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(95, 76);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(35, 16);
            this.country.TabIndex = 30;
            this.country.Text = "Ülke";
            // 
            // city_t
            // 
            this.city_t.Location = new System.Drawing.Point(236, 102);
            this.city_t.Name = "city_t";
            this.city_t.Size = new System.Drawing.Size(261, 22);
            this.city_t.TabIndex = 4;
            // 
            // name_t
            // 
            this.name_t.Location = new System.Drawing.Point(236, 18);
            this.name_t.Name = "name_t";
            this.name_t.Size = new System.Drawing.Size(261, 22);
            this.name_t.TabIndex = 0;
            this.name_t.TextChanged += new System.EventHandler(this.name_t_TextChanged);
            // 
            // web_adress
            // 
            this.web_adress.AutoSize = true;
            this.web_adress.Location = new System.Drawing.Point(95, 48);
            this.web_adress.Name = "web_adress";
            this.web_adress.Size = new System.Drawing.Size(84, 16);
            this.web_adress.TabIndex = 25;
            this.web_adress.Text = "Web adress:";
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.Location = new System.Drawing.Point(711, 407);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 26);
            this.OK.TabIndex = 39;
            this.OK.Text = "Oluştur";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // district
            // 
            this.district.AutoSize = true;
            this.district.Location = new System.Drawing.Point(95, 132);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(28, 16);
            this.district.TabIndex = 36;
            this.district.Text = "İlçe";
            // 
            // country_ll
            // 
            this.country_ll.AutoSize = true;
            this.country_ll.Location = new System.Drawing.Point(611, 46);
            this.country_ll.Name = "country_ll";
            this.country_ll.Size = new System.Drawing.Size(44, 16);
            this.country_ll.TabIndex = 48;
            this.country_ll.Text = "label1";
            this.country_ll.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(95, 242);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(32, 16);
            this.mail.TabIndex = 50;
            this.mail.Text = "Mail";
            // 
            // mail_t
            // 
            this.mail_t.Location = new System.Drawing.Point(236, 242);
            this.mail_t.Name = "mail_t";
            this.mail_t.Size = new System.Drawing.Size(261, 22);
            this.mail_t.TabIndex = 9;
            // 
            // contry_s_l
            // 
            this.contry_s_l.AutoSize = true;
            this.contry_s_l.Location = new System.Drawing.Point(514, 48);
            this.contry_s_l.Name = "contry_s_l";
            this.contry_s_l.Size = new System.Drawing.Size(44, 16);
            this.contry_s_l.TabIndex = 51;
            this.contry_s_l.Text = "label2";
            this.contry_s_l.Visible = false;
            // 
            // yil_l
            // 
            this.yil_l.AutoSize = true;
            this.yil_l.Location = new System.Drawing.Point(514, 160);
            this.yil_l.Name = "yil_l";
            this.yil_l.Size = new System.Drawing.Size(44, 16);
            this.yil_l.TabIndex = 52;
            this.yil_l.Text = "label3";
            this.yil_l.Visible = false;
            // 
            // validity_t
            // 
            this.validity_t.FormattingEnabled = true;
            this.validity_t.Items.AddRange(new object[] {
            "1 Yıl",
            "2 Yıl",
            "3 Yıl",
            "4 Yıl",
            "5 Yıl"});
            this.validity_t.Location = new System.Drawing.Point(235, 157);
            this.validity_t.Name = "validity_t";
            this.validity_t.Size = new System.Drawing.Size(262, 24);
            this.validity_t.TabIndex = 6;
            this.validity_t.SelectedIndexChanged += new System.EventHandler(this.validity_t_SelectedIndexChanged);
            // 
            // gun_l
            // 
            this.gun_l.AutoSize = true;
            this.gun_l.Location = new System.Drawing.Point(584, 160);
            this.gun_l.Name = "gun_l";
            this.gun_l.Size = new System.Drawing.Size(44, 16);
            this.gun_l.TabIndex = 54;
            this.gun_l.Text = "label4";
            this.gun_l.Visible = false;
            this.gun_l.Click += new System.EventHandler(this.label4_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(342, 37);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 16);
            this.error.TabIndex = 55;
            // 
            // hata
            // 
            this.hata.AutoSize = true;
            this.hata.Location = new System.Drawing.Point(305, 417);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(0, 16);
            this.hata.TabIndex = 55;
            // 
            // Random_SSL_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hata);
            this.Controls.Add(this.gun_l);
            this.Controls.Add(this.validity_t);
            this.Controls.Add(this.yil_l);
            this.Controls.Add(this.contry_s_l);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.mail_t);
            this.Controls.Add(this.country_ll);
            this.Controls.Add(this.validity);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.keys);
            this.Controls.Add(this.country_shorts);
            this.Controls.Add(this.x);
            this.Controls.Add(this.name);
            this.Controls.Add(this.country_t);
            this.Controls.Add(this.details);
            this.Controls.Add(this.company);
            this.Controls.Add(this.city);
            this.Controls.Add(this.web_adress_t);
            this.Controls.Add(this.organization_t);
            this.Controls.Add(this.organization_unit_t);
            this.Controls.Add(this.district_t);
            this.Controls.Add(this.country);
            this.Controls.Add(this.city_t);
            this.Controls.Add(this.name_t);
            this.Controls.Add(this.web_adress);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.district);
            this.Name = "Random_SSL_Generator";
            this.Text = "SSL";
            this.keys.ResumeLayout(false);
            this.keys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button clear_all;
        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.GroupBox keys;
        public System.Windows.Forms.Button one_key;
        public System.Windows.Forms.Label priv_key;
        public System.Windows.Forms.Button two_key;
        public System.Windows.Forms.TextBox private_key;
        public System.Windows.Forms.Label x;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.ComboBox country_t;
        public System.Windows.Forms.Label details;
        public System.Windows.Forms.Label company;
        public System.Windows.Forms.Label city;
        public System.Windows.Forms.TextBox web_adress_t;
        public System.Windows.Forms.TextBox organization_t;
        public System.Windows.Forms.TextBox organization_unit_t;
        public System.Windows.Forms.TextBox district_t;
        public System.Windows.Forms.Label country;
        public System.Windows.Forms.TextBox city_t;
        public System.Windows.Forms.TextBox name_t;
        public System.Windows.Forms.Label web_adress;
        public System.Windows.Forms.Button OK;
        public System.Windows.Forms.Label district;
        public System.Windows.Forms.Label validity;
        public System.Windows.Forms.ComboBox country_shorts;
        public System.Windows.Forms.Label country_ll;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Label mail;
        public System.Windows.Forms.TextBox mail_t;
        private System.Windows.Forms.Label contry_s_l;
        private System.Windows.Forms.Label yil_l;
        private System.Windows.Forms.ComboBox validity_t;
        private System.Windows.Forms.Label gun_l;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label hata;
    }
}

