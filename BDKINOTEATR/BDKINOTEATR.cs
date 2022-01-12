using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BDKINOTEATR
{
    public partial class BDKINOTEATR : Form
    {
        SqlDataAdapter adapter = null;
        string connString = $@"Data Source=DESKTOP-08SJV26\SQLEXPRESS;Initial Catalog = bdkinoteatr;Integrated Security=SSPI;";
        public BDKINOTEATR()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                int i = 0;
                SqlCommand command = new SqlCommand("SELECT name FROM sys.objects WHERE type in ('U', 'V') AND name != 'Avtorizaciya' AND name != 'Roli' AND name != 'sysdiagrams'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        i = i++;
                        toolStripButton2.Items.Add(reader.GetString(i));
                    }
                }
                reader.Close();
                connection.Close();
            }
        }

        private void BDKINOTEATR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {

            string tablename = toolStripButton2.Text;

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-08SJV26\SQLEXPRESS;Initial Catalog = bdkinoteatr;Integrated Security=SSPI;");

            connection.Open();

            if (tablename == "Choice Table")
            {
                MessageBox.Show("Выберите таблицу из списка или \n\rвведите название вручную.", "Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                adapter = new SqlDataAdapter($"SELECT * FROM {tablename}", connection);
                DataTable dt = new DataTable($"{tablename}");
                adapter.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                connection.Close();
                ZhanrAdd.Parent = null;
                ZhanrDel.Parent = null;
                ZhanrRed.Parent = null;
                FilmsAdd.Parent = null;
                FilmsDel.Parent = null;
                FilmsRed.Parent = null;
                ZalAdd.Parent = null;
                ZalDel.Parent = null;
                ZalRed.Parent = null;
                SeansAdd.Parent = null;
                SeansDel.Parent = null;
                SeansRed.Parent = null;
                KatBilAdd.Parent = null;
                KatBilDel.Parent = null;
                KatBilRed.Parent = null;
                DoljnAdd.Parent = null;
                DoljnDel.Parent = null;
                DoljnRed.Parent = null;
                SotAdd.Parent = null;
                SotDel.Parent = null;
                SotRed.Parent = null;
                MestoAdd.Parent = null;
                MestoDel.Parent = null;
                MestoRed.Parent = null;
                BiletAdd.Parent = null;
                BiletDel.Parent = null;
                BiletRed.Parent = null;
                ChekAdd.Parent = null;
                ChekDel.Parent = null;
                ChekRed.Parent = null;
                BiletChekAdd.Parent = null;
                BiletChekDel.Parent = null;
                BiletChekRed.Parent = null;
                StranaAdd.Parent = null;
                StranaDel.Parent = null;
                StranaRed.Parent = null;
            }

            if (tablename == "Zhanr")
            {
                ZhanrAdd.Parent = tabControl1;
                ZhanrDel.Parent = tabControl1;
                ZhanrRed.Parent = tabControl1;
            }
            else if (tablename == "Film")
            {
                FilmsAdd.Parent = tabControl1;
                FilmsDel.Parent = tabControl1;
                FilmsRed.Parent = tabControl1;
            }
            else if (tablename == "Zal")
            {
                ZalAdd.Parent = tabControl1;
                ZalDel.Parent = tabControl1;
                ZalRed.Parent = tabControl1;
            }
            else if (tablename == "Seans")
            {
                SeansAdd.Parent = tabControl1;
                SeansDel.Parent = tabControl1;
                SeansRed.Parent = tabControl1;
            }
            else if (tablename == "KategoriyaBileta")
            {
                KatBilAdd.Parent = tabControl1;
                KatBilDel.Parent = tabControl1;
                KatBilRed.Parent = tabControl1;
            }
            else if (tablename == "Doljnost")
            {
                DoljnAdd.Parent = tabControl1;
                DoljnDel.Parent = tabControl1;
                DoljnRed.Parent = tabControl1;
            }
            else if (tablename == "Sotrydnik")
            {
                SotAdd.Parent = tabControl1;
                SotDel.Parent = tabControl1;
                SotRed.Parent = tabControl1;
            }
            else if (tablename == "Mesto")
            {
                MestoAdd.Parent = tabControl1;
                MestoDel.Parent = tabControl1;
                MestoRed.Parent = tabControl1;
            }
            else if (tablename == "Bilet")
            {
                BiletAdd.Parent = tabControl1;
                BiletDel.Parent = tabControl1;
                BiletRed.Parent = tabControl1;
            }
            else if (tablename == "Chek")
            {
                ChekAdd.Parent = tabControl1;
                ChekDel.Parent = tabControl1;
                ChekRed.Parent = tabControl1;
            }
            else if (tablename == "Bilet_Chek")
            {
                BiletChekAdd.Parent = tabControl1;
                BiletChekDel.Parent = tabControl1;
                BiletChekRed.Parent = tabControl1;
            }
            else if (tablename == "Strana")
            {
                StranaAdd.Parent = tabControl1;
                StranaDel.Parent = tabControl1;
                StranaRed.Parent = tabControl1;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void BDKINOTEATR_Load(object sender, EventArgs e)
        {
            ZhanrAdd.Parent = null;
            ZhanrDel.Parent = null;
            ZhanrRed.Parent = null;
            FilmsAdd.Parent = null;
            FilmsDel.Parent = null;
            FilmsRed.Parent = null;
            ZalAdd.Parent = null;
            ZalDel.Parent = null;
            ZalRed.Parent = null;
            SeansAdd.Parent = null;
            SeansDel.Parent = null;
            SeansRed.Parent = null;
            KatBilAdd.Parent = null;
            KatBilDel.Parent = null;
            KatBilRed.Parent = null;
            DoljnAdd.Parent = null;
            DoljnDel.Parent = null;
            DoljnRed.Parent = null;
            SotAdd.Parent = null;
            SotDel.Parent = null;
            SotRed.Parent = null;
            MestoAdd.Parent = null;
            MestoDel.Parent = null;
            MestoRed.Parent = null;
            BiletAdd.Parent = null;
            BiletDel.Parent = null;
            BiletRed.Parent = null;
            ChekAdd.Parent = null;
            ChekDel.Parent = null;
            ChekRed.Parent = null;
            BiletChekAdd.Parent = null;
            BiletChekDel.Parent = null;
            BiletChekRed.Parent = null;
            StranaAdd.Parent = null;
            StranaDel.Parent = null;
            StranaRed.Parent = null;
        }

        private void ZhanrAddBut_Click(object sender, EventArgs e)
        {
            string id = IdZhanra.Text;
            string zhanr = Zhanr.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Zhanr VALUES ('{id}', '{zhanr}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdZhanra.Text = "";
            Zhanr.Text = "";
        }

        private void ZhanrDelBut_Click(object sender, EventArgs e)
        {
            string id = IdZhanrDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Zhanr where IDZhanra = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdZhanrDel.Text = "";
        }

        private void ZhanrRedBut_Click(object sender, EventArgs e)
        {
            string id = IdZhanrRed.Text;
            string zhanr = ZhanrUpd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Zhanr set Zhanr = '{zhanr}' where IDZhanra = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdZhanrRed.Text = "";
            ZhanrUpd.Text = "";
        }

        private void FilmsAddBut_Click(object sender, EventArgs e)
        {
            string id = IdFilma.Text;
            string nazv = NazvanFilm.Text;
            string vozreyt = VozReyt.Text;
            string dlit = Dliteln.Text;
            string stran = IdStrana.Text;
            string zhanr = IdZhanrFilm.Text;
            string nachprok = NachProk.Text;
            string konprok = KonProk.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Film(IDFilma, Nazvanie, VozrastnoyReyting, Dlitelnost, IDStrana, IDZhanra, NachaloProkata, KonecProkata) VALUES('{id}', '{nazv}', '{vozreyt}', '{dlit}', '{stran}', '{zhanr}', '{nachprok}', '{konprok}'))", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdFilma.Text = "";
            NazvanFilm.Text = "";
            VozReyt.Text = "";
            Dliteln.Text = "";
            IdStrana.Text = "";
            IdZhanrFilm.Text = "";
            NachProk.Text = "";
            KonProk.Text = "";
        }

        private void FilmsDelBut_Click(object sender, EventArgs e)
        {
            string id = IdFilmDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Film where IDFilma = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdFilmDel.Text = "";
        }

        private void FilmsRedBut_Click(object sender, EventArgs e)
        {
            string id = IdFilma.Text;
            string nazv = NazvanFilm.Text;
            string vozreyt = VozReyt.Text;
            string dlit = Dliteln.Text;
            string stran = IdStrana.Text;
            string zhanr = IdZhanrFilm.Text;
            string nachprok = NachProk.Text;
            string konprok = KonProk.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Film set Nazvanie = {nazv}, VozrastnoyReyting = {vozreyt}, Dlitelnost = {dlit}, IDStrana = {stran}, IDZhanra = {zhanr}, NachaloProkata = {nachprok}, KonecProkata = {konprok} where IDFilma = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdFilma.Text = "";
            NazvanFilm.Text = "";
            VozReyt.Text = "";
            Dliteln.Text = "";
            IdStrana.Text = "";
            IdZhanrFilm.Text = "";
            NachProk.Text = "";
            KonProk.Text = "";
        }

        private void ZalAddBut_Click(object sender, EventArgs e)
        {
            string nazv = NazvZala.Text;
            string kolmest = KolvMest.Text;
            string kolryad = KolvRyad.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Zal(Nazvanie, KolichestvoMest, KolichestvoRyadov) VALUES ('{nazv}', '{kolmest}', '{kolryad}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            NazvZala.Text = "";
            KolvMest.Text = "";
            KolvRyad.Text = "";
        }

        private void ZalDelBut_Click(object sender, EventArgs e)
        {
            string id = IdZalDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Zal where IDZala = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdZalDel.Text = "";
        }

        private void ZalRedBut_Click(object sender, EventArgs e)
        {
            string id = IdZalRed.Text;
            string nazv = NazvZalRed.Text;
            string kolvmest = KolvMestRed.Text;
            string kolvryad = KolvRyadRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Zal set Nazvanie = '{nazv}', KolichestvoMest = '{kolvmest}', KolichestvoRyadov = '{kolvryad}' where IDZala = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdZalRed.Text = "";
            NazvZalRed.Text = "";
            KolvMestRed.Text = "";
            KolvRyadRed.Text = "";
        }
        private void SeansAddBut_Click(object sender, EventArgs e)
        {
            string idfilm = IdFilmSeansAdd.Text;
            string idzal = IdZalSeansAdd.Text;
            string data = DataPokazaSeansAdd.Text;
            string vremya = VremyaSeansAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Seans(IDFilma, IDZala, DataPokaza, Vremya) VALUES ('{idfilm}', '{idzal}', '{data}', '{vremya}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdFilmSeansAdd.Text = "";
            IdZalSeansAdd.Text = "";
            DataPokazaSeansAdd.Text = "";
            VremyaSeansAdd.Text = "";
        }
        private void SeansDelBut_Click(object sender, EventArgs e)
        {
            string id = IdSeansDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Seans where IDSeansa = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdSeansDel.Text = "";
        }
        private void SeansRedBut_Click(object sender, EventArgs e)
        {
            string id = IdSeansRed.Text;
            string idfilm = IdFilmSeansRed.Text;
            string idzal = IdZalSeansRed.Text;
            string data = DataSeansRed.Text;
            string vremya = VremyaSeansRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Seans set IDFilma = '{idfilm}', IDZala = '{idzal}', DataPokaza = '{data}', Vremya = '{vremya}' where IDSeansa = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdSeansRed.Text = "";
            IdFilmSeansRed.Text = "";
            IdZalSeansRed.Text = "";
            DataSeansRed.Text = "";
            VremyaSeansRed.Text = "";
        }

        private void KatBilAddBut_Click(object sender, EventArgs e)
        {
            string id = IdKatAdd.Text;
            string nazv = NazvKatAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT KategoriyaBileta VALUES ('{id}', '{nazv}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdKatAdd.Text = "";
            NazvKatAdd.Text = "";
        }
        private void IdKatDelBut_Click(object sender, EventArgs e)
        {
            string id = IdKatDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from KategoriyaBileta where IDKategorii = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdKatDel.Text = "";
        }
        private void IdKatRedBut_Click(object sender, EventArgs e)
        {
            string id = IdKatRed.Text;
            string nazv = NazvKatRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update KategoriyaBileta set NazvanieKategorii = '{nazv}' where IDKategorii = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdKatRed.Text = "";
            NazvKatRed.Text = "";
        }
        private void DoljnostAddBut_Click(object sender, EventArgs e)
        {
            string id = IdDoljnAdd.Text;
            string nazv = NazvDoljAdd.Text;
            string zarplata = ZarplDoljAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Doljnost VALUES ('{id}', '{nazv}', '{zarplata}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdDoljnAdd.Text = "";
            NazvDoljAdd.Text = "";
            ZarplDoljAdd.Text = "";
        }
        private void IdDoljnDelBut_Click(object sender, EventArgs e)
        {
            string id = IdDoljDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Doljnost where IDDoljnost = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdDoljDel.Text = "";
        }
        private void IdDoljRedBut_Click(object sender, EventArgs e)
        {
            string id = IdDoljRed.Text;
            string nazv = NazvDoljRed.Text;
            string zarplata = ZarplDoljRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Doljnost set Nazvanie = '{nazv}', Zarplata = {zarplata} where IDDoljnost = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdDoljRed.Text = "";
            NazvDoljRed.Text = "";
            ZarplDoljRed.Text = "";
        }
        private void SotAddBut_Click(object sender, EventArgs e)
        {
            string fio = FioSotAdd.Text;
            string iddolj = IdDoljSotAdd.Text;
            string telephon = TelephonSotAdd.Text;
            string email = EMailSotAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Sotrydnik(FIO, IDDoljnost, Telephon, EMail) VALUES ('{fio}', '{iddolj}', '{telephon}', '{email}'))", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            FioSotAdd.Text = "";
            IdDoljSotAdd.Text = "";
            TelephonSotAdd.Text = "";
            EMailSotAdd.Text = "";
        }
        private void SotDelBut_Click(object sender, EventArgs e)
        {
            string id = IdSotDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Sotrydnik where IDSotrydnika = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdSotDel.Text = "";
        }
        private void SotRedBut_Click(object sender, EventArgs e)
        {
            string id = IdSotRed.Text;
            string fio = FioSotRed.Text;
            string iddolj = IdDoljSotRed.Text;
            string telephon = TelephonSotRed.Text;
            string email = EmailSotRed.Text;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Sotrydnik set FIO = '{fio}', IDDoljnost = {iddolj}, Telephon = '{telephon}', EMail = '{email}' where IDSotrydnika = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdSotRed.Text = "";
            FioSotRed.Text = "";
            IdDoljSotRed.Text = "";
            TelephonSotRed.Text = "";
            EmailSotRed.Text = "";
        }
        private void MestoAddBut_Click(object sender, EventArgs e)
        {
            string ryad = RyadMestoAdd.Text;
            string mesto = MestoMestoAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Mesto (Ryad, Mesto) VALUES ('{ryad}', '{mesto}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            RyadMestoAdd.Text = "";
            MestoMestoAdd.Text = "";
        }
        private void IdMestoDelBut_Click(object sender, EventArgs e)
        {
            string id = IdMestoDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Mesto where IDMesta = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdMestoDel.Text = "";
        }
        private void MestoRedBut_Click(object sender, EventArgs e)
        {
            string id = IdMestoRed.Text;
            string ryad = IdRyadMestoRed.Text;
            string mesto = IdMestoMestoRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Mesto set Ryad = '{ryad}', Mesto = {mesto} where IDMesta = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdMestoRed.Text = "";
            IdRyadMestoRed.Text = "";
            IdMestoMestoRed.Text = "";
        }
        private void BiletAddBut_Click(object sender, EventArgs e)
        {
            string idseansa = IdSeansBiletAdd.Text;
            string idmesta = IdMestaBiletAdd.Text;
            string idkat = IdKategoriiBiletAdd.Text;
            string cena = CenaBiletaBiletAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Bilet(IDSeansa, IDMesta, IDKategorii, CenaBileta) VALUES ('{idseansa}', '{idmesta}', '{idkat}', '{cena}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdSeansBiletAdd.Text = "";
            IdMestaBiletAdd.Text = "";
            IdKategoriiBiletAdd.Text = "";
            CenaBiletaBiletAdd.Text = "";
        }
        private void IdBiletDelBut_Click(object sender, EventArgs e)
        {
            string id = IdBiletDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Bilet where IDBileta = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdBiletDel.Text = "";
        }
        private void BiletRedBut_Click(object sender, EventArgs e)
        {
            string id = IdBiletRed.Text;
            string idseans = IdSeansaBiletRed.Text;
            string idmesto = IdMestaBiletRed.Text;
            string idkat = IdKatbiletRed.Text;
            string cena = CenaBiletRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Bilet set IDSeans = '{idseans}', IDMesta = {idmesto}, IDKategorii = '{idkat}', CenaBileta = '{cena}' where IDMesta = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdBiletRed.Text = "";
            IdSeansaBiletRed.Text = "";
            IdMestaBiletRed.Text = "";
            IdKatbiletRed.Text = "";
            CenaBiletRed.Text = "";
        }
        private void ChekAddBut_Click(object sender, EventArgs e)
        {
            string idsot = IdSotChekAdd.Text;
            string data = DataVremyaChekadd.Text;
            string cena = CenaChekAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Chek(IDSotrydnika, Data_Vremya, Cena) VALUES ('{idsot}', '{data}', '{cena}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdSotChekAdd.Text = "";
            DataVremyaChekadd.Text = "";
            CenaChekAdd.Text = "";
        }
        private void ChekDelBut_Click(object sender, EventArgs e)
        {
            string id = IdChekDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Chek where IDCheka = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdChekDel.Text = "";
        }
        private void ChekRedBut_Click(object sender, EventArgs e)
        {
            string idchek = IdChekRed.Text;
            string idsot = IdSotChekRed.Text;
            string data = DataChekRed.Text;
            string cena = CenaChekRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Chek set IDSotrydnika = '{idsot}', Data_Vremya = {data}, Cena = '{cena}' where IDCheka = {idchek}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdChekRed.Text = "";
            IdSotChekRed.Text = "";
            DataChekRed.Text = "";
            CenaChekRed.Text = "";
        }
        private void BilChekAddBut_Click(object sender, EventArgs e)
        {
            string chek = IdChekaBilChekAdd.Text;
            string bilet = IdBiletbilChekAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Bilet_Chek(IDCheka, IDBileta) VALUES ('{chek}', '{bilet}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdChekaBilChekAdd.Text = "";
            IdBiletbilChekAdd.Text = "";
        }
        private void DilChekDelBut_Click(object sender, EventArgs e)
        {
            string idcheka = IdChekBilChekDel.Text;
            string idbileta = IdBilBilChekDel.Text;
            if (idbileta != "")
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand($"delete from Bilet_Chek where IDCheka = {idcheka} AND IDBileta = {idbileta}", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    connection.Close();
                }
                LoadData();
                IdChekBilChekDel.Text = "";
                IdBilBilChekDel.Text = "";
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand($"delete from Bilet_Chek where IDCheka = {idcheka}", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    connection.Close();
                }
                LoadData();
            }
            
        }
        private void BilChekRedBut_Click(object sender, EventArgs e)
        {
            string chektake = IdChekTakeRed.Text;
            string biltake = IdBilTakeRed.Text;
            string chektook = IdChekTookRed.Text;
            string biltook = IdBilTookRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Bilet_Chek set IDCheka = '{chektook}', IDBileta = {biltook} where IDCheka = {chektake} AND IDBileta = '{biltake}'", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdChekTakeRed.Text = "";
            IdBilTakeRed.Text = "";
            IdChekTookRed.Text = "";
            IdBilTookRed.Text = "";
        }
        private void StranaAddBut_Click(object sender, EventArgs e)
        {
            string id = IdStraniAdd.Text;
            string strana = StrAdd.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"INSERT Strana VALUES ('{id}', '{strana}')", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdStraniAdd.Text = "";
            StrAdd.Text = "";
        }
        private void IdStrDelBut_Click(object sender, EventArgs e)
        {
            string id = IdStrDel.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"delete from Strana where IDStrani = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdStrDel.Text = "";
        }
        private void StrRedBut_Click(object sender, EventArgs e)
        {
            string id = IdStrRed.Text;
            string str = StrRed.Text;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand($"update Strana set Strana = '{str}' where IDStrani = {id}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            LoadData();
            IdStrRed.Text = "";
            StrRed.Text = "";
        }
    }
}