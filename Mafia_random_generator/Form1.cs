using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mafia_random_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listaIgraci = new List<string>();
        List<string> listaIgraciPOM = new List<string>();
        int brMafija = 0, brPolicija = 0, brDoktor = 0, brGragjani = 0;
        int brMafijaPOM = 0, brPolicijaPOM = 0, brDoktorPOM = 0, brGragjaniPOM = 0;
        List<int> listaMafija = new List<int>();
        List<int> listaPolicija = new List<int>();
        List<int> listaDoktori = new List<int>();
        
        int brZaBrisenje = 0;

        HashSet<int> vneseni = new HashSet<int>();

        //za vremeto
        int hh = 0;
        int mm = 0;
        int ss = 0;
        //----------
        int partiiMafija = 0;
        int partiiPravda = 0;

        string akcija = "";


        string porakaPolicija = "";
        string porakaMafija = "";
        string porakaDoktor = "";
        string porakaGrad = "";
        int runda = 1;
        string pomDoktor = "", pomMafija = "";
        bool kraj = false;

        int pomIzglasanM = -1, pomUbienM = -1, pomIzglasanD = -1, pomUbienD = -1, pomIzglasanP = -1, pomUbienP = -1, pomIzglasanG = -1, pomUbienG = -1;
        int indexIzglasanM = -1, indexUbienM = -1, indexIzglasanD = -1, indexUbienD = -1, indexIzglasanP = -1, indexUbienP = -1, indexIzglasanG = -1, indexUbienG = -1;

        bool napolnivPomlista = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            brMafija = Convert.ToInt32(txtBox_mafija.Text);
            brPolicija = Convert.ToInt32(txtBox_policija.Text);
            brDoktor = Convert.ToInt32(txtBox_doktor.Text);
            brGragjani = Convert.ToInt32(txtBox_Gragjanin.Text);

            brMafijaPOM = brMafija;
            brPolicijaPOM = brPolicija;
            brDoktorPOM = brDoktor;
            brGragjaniPOM = brGragjani;

            partiiMafija = Convert.ToInt32(txtBox_BoardMafia.Text);
            partiiPravda = Convert.ToInt32(txtBox_BoardJustice.Text);

            txtBox_IgracNov.Focus();
        }

        private void Btn_IgracNov_Click(object sender, EventArgs e)
        {
            string igracNov = txtBox_IgracNov.Text;
            if(igracNov!="")
            {
                listaIgraci.Add(igracNov);
                AzurirajListaIgraci();
                RaspredeliUlogi();

                lblVkIgraci.Text = listaIgraci.Count.ToString();
            }
            else
            {
                MessageBox.Show("Внеси играч АЛОООО!");
                txtBox_IgracNov.Focus();
            }
            
        }

        private void AzurirajListaIgraci()
        {
            txtBox_Igraci.Text = "";
            int br = 1;
            foreach(string i in listaIgraci)
            {
                txtBox_Igraci.AppendText(br.ToString() + ". " + i + Environment.NewLine);
                br++;
            }
            txtBox_IgracNov.Text = "";
            txtBox_IgracNov.Focus();
        }

        private void TxtBox_mafija_TextChanged(object sender, EventArgs e)
        {
            int number;

            bool success = Int32.TryParse(txtBox_mafija.Text, out number);
            if (success)
            {
                int vkupno = number + brGragjani + brPolicija + brDoktor;
                if (vkupno > listaIgraci.Count)
                {
                    MessageBox.Show("Некако ко многу голема бројка да пиша!");
                    txtBox_mafija.Text = brMafija.ToString();
                }
                else
                {
                    brMafija = number;
                   // brMafijaPOM = brMafija;
                }
            }
            else
            {
                MessageBox.Show("Не се заебавај, внеси број!");
                txtBox_mafija.Text = "";
                txtBox_mafija.Focus();
            }
        }

        private void TxtBox_policija_TextChanged(object sender, EventArgs e)
        {
            int number;

            bool success = Int32.TryParse(txtBox_policija.Text, out number);
            if (success)
            {
                int vkupno = brMafija + brGragjani + number + brDoktor;
                if (vkupno > listaIgraci.Count)
                {
                    MessageBox.Show("Некако ко многу голема бројка да пиша!");
                    txtBox_policija.Text = brPolicija.ToString();
                }
                else
                {
                    brPolicija = number;
                    //brPolicijaPOM = brPolicija;
                }
            }
            else
            {
                MessageBox.Show("Сериозно! Внеси број....");
                txtBox_policija.Text = "";
                txtBox_policija.Focus();
            }
        }

        private void TxtBox_doktor_TextChanged(object sender, EventArgs e)
        {
            int number;

            bool success = Int32.TryParse(txtBox_doktor.Text, out number);
            if (success)
            {
                int vkupno = brMafija + brGragjani + brPolicija + number;
                if (vkupno > listaIgraci.Count)
                {
                    MessageBox.Show("Некако ко многу голема бројка да пиша!");
                    txtBox_doktor.Text = brDoktor.ToString();
                }
                else
                {
                    brDoktor = number;
                    //brDoktorPOM = brDoktor;
                }
            }
            else
            {
                MessageBox.Show("Тешко мина доктореее! Бројче треба да внесиш!");
                txtBox_doktor.Text = "";
                txtBox_doktor.Focus();
            }
        }

        private void TxtBox_IgracNov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_IgracNov.PerformClick();
        }

        private void Btn_Generiraj_Click(object sender, EventArgs e)
        {
            
            
            if (listaIgraci.Count == 0)
            {
                MessageBox.Show("Сериозно?");
                txtBox_IgracNov.Focus();
            }
            else if (listaIgraci.Count == 1)
            {
                MessageBox.Show("За сам можиш и в ум да си играш мафија :)");
                txtBox_IgracNov.Focus();
            }
            else if (listaIgraci.Count == 2)
            {
                MessageBox.Show("Шо да ти изгенерирам бе браат, 2ца сте само!");
                txtBox_IgracNov.Focus();
            }
            else if (listaIgraci.Count == 3)
            {
                MessageBox.Show("Тешко дека 3ца можи да играте :(");
                txtBox_IgracNov.Focus();
            }
            else if (listaIgraci.Count == 4)
            {
                MessageBox.Show("Дај бе најдете уште некој...");
                txtBox_IgracNov.Focus();
            }
            else if (listaIgraci.Count > 4)
            {
                if(brDoktor+brPolicija+brMafija+brGragjani != listaIgraci.Count)
                {
                    MessageBox.Show("Математикава некако не оди...");
                }else
                {
                    if(textBox_runda.Text=="1")
                    {
                        if (!(porakaPolicija != "" || porakaMafija != "" || porakaDoktor != "" ))
                        {

                            brMafijaPOM = brMafija;
                            brPolicijaPOM = brPolicija;
                            brDoktorPOM = brDoktor;
                            brGragjaniPOM = brGragjani;

                            listaDoktori.Clear();
                            listaMafija.Clear();
                            listaPolicija.Clear();
                            vneseni.Clear();
                            lbl_akcija.Text = "";
                            porakaDoktor = "";
                            porakaMafija = "";
                            porakaPolicija = "";
                            pomMafija = "";
                            pomDoktor = "";


                            btn_Justice.Enabled = true;
                            btn_Mafia.Enabled = true;
                            timer1.Stop();
                            hh = 0;
                            mm = 0;
                            ss = 0;
                            lblVreme.Text = "00:00:00";

                            timer1.Start();
                            //trgni gi drugite raboti sto ne trebaaat
                            groupBox2.Visible = false;
                            btn_IgracNov.Visible = false;
                            txtBox_IgracNov.Visible = false;
                            txtBox_Igraci.Visible = false;
                            label5.Visible = false;
                            groupBox_Rundi.Visible = true;
                            if (kraj == true)
                            {
                                txtBox_mafija.Enabled = true;
                                txtBox_policija.Enabled = true;
                                txtBox_doktor.Enabled = true;
                                txtBox_Gragjanin.Enabled = true;
                                kraj = false;
                                if (napolnivPomlista == false)
                                {
                                    napolnivPomlista = true;
                                    foreach (string m in listaIgraci)
                                        listaIgraciPOM.Add(m);
                                }
                            }
                            else
                            {

                                txtBox_mafija.Enabled = false;
                                txtBox_policija.Enabled = false;
                                txtBox_doktor.Enabled = false;
                                txtBox_Gragjanin.Enabled = false;
                                if(napolnivPomlista==false)
                                {
                                    napolnivPomlista = true;
                                    foreach (string m in listaIgraci)
                                        listaIgraciPOM.Add(m);
                                }
                                
                               // kraj = true;
                            }
                            //---------------------------------------

                            int maxBr = listaIgraci.Count;
                            Random r = new Random();

                            //------------------------------------------
                            //1-mafija, 2-gragjanin, 3-doktor, 4-policija
                            List<int> livcinja = new List<int>();
                            //potpisi gi livcinjata
                            for (int i = 0; i < brMafija; i++)
                            {
                                livcinja.Add(1);
                            }
                            for (int i = 0; i < brGragjani; i++)
                            {
                                livcinja.Add(2);
                            }
                            for (int i = 0; i < brDoktor; i++)
                            {
                                livcinja.Add(3);
                            }
                            for (int i = 0; i < brPolicija; i++)
                            {
                                livcinja.Add(4);
                            }
                            //------------------------------------------
                            int brLivcinja = livcinja.Count;
                            int rBr = 0;
                            foreach (string igrac in listaIgraci)
                            {
                                int indexLivce = r.Next(0, brLivcinja);
                                int ulogaLivce = livcinja[indexLivce];
                                //toa so kje se padni go trgame od listata
                                livcinja.RemoveAt(indexLivce);
                                brLivcinja--;

                                if (ulogaLivce == 1)
                                {
                                    //1-MAFIJA
                                    listaMafija.Add(rBr);
                                    vneseni.Add(rBr);
                                }
                                else if (ulogaLivce == 2)
                                {
                                    //2-GRAGJANIN

                                }
                                else if (ulogaLivce == 3)
                                {
                                    //3-DOKTOR
                                    listaDoktori.Add(rBr);
                                    vneseni.Add(rBr);
                                }
                                else if (ulogaLivce == 4)
                                {
                                    //4-POLICIJA
                                    listaPolicija.Add(rBr);
                                    vneseni.Add(rBr);
                                }
                                rBr++;
                            }

                            #region old
                            //int random = GiveMeANumber(maxBr);

                            ////za doktorite
                            //for (int i = 0; i < brDoktor; i++)
                            //{
                            //    //while (proveriDaliGoIma(random))
                            //    //{
                            //    //    random = r.Next(0, maxBr);
                            //    //}
                            //    listaDoktori.Add(random);
                            //    vneseni.Add(random);
                            //    random = GiveMeANumber(maxBr);
                            //}
                            //random = GiveMeANumber(maxBr);
                            ////za policijata
                            //for (int i = 0; i < brPolicija; i++)
                            //{
                            //    //while (proveriDaliGoIma(random))
                            //    //{
                            //    //    random = r.Next(0, maxBr);
                            //    //}
                            //    listaPolicija.Add(random);
                            //    vneseni.Add(random);
                            //    random = GiveMeANumber(maxBr);
                            //}
                            //random = GiveMeANumber(maxBr);
                            ////za mafijasite
                            //for (int i = 0; i < brMafija; i++)
                            //{
                            //    //while (proveriDaliGoIma(random))
                            //    //{
                            //    //    random = r.Next(0, maxBr);
                            //    //}
                            //    listaMafija.Add(random);
                            //    vneseni.Add(random);
                            //    random = GiveMeANumber(maxBr);
                            //}
                            #endregion

                            PrikaziVoOutput();
                        }
                        else
                        {
                            MessageBox.Show("Синее брааат, веќе почна да кликаш акции, не можи пак да генерираш!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Играта е веќе во тек, не можеш да генерираш random!");
                    }
                }
            }
            
        }

        private bool proveriDaliGoIma(int random)
        {
            bool zname = false;
            foreach(int i in listaDoktori)
            {
                if (random == i)
                    zname = true;
            }
            foreach (int i in listaPolicija)
            {
                if (random == i)
                    zname = true;
            }
            foreach (int i in listaMafija)
            {
                if (random == i)
                    zname = true;
            }
            return zname;
        }

        private void RaspredeliUlogi()
        {
            if (listaIgraci.Count < 5)
            {
                brDoktor = 0;
                brMafija = 0;
                brPolicija = 0;
            }
            else if (listaIgraci.Count == 5)
            {
                brDoktor = 1;
                brPolicija = 1;
                brMafija = 1;
            }
            else if (listaIgraci.Count >= 6 && listaIgraci.Count < 8)
            {
                brDoktor = 1;
                brPolicija = 1;
                brMafija = 2;
            }
            else if (listaIgraci.Count >= 8 && listaIgraci.Count < 11)
            {
                brDoktor = 1;
                brPolicija = 2;
                brMafija = 3;
            }
            else if (listaIgraci.Count >= 11)
            {
                decimal brIg = listaIgraci.Count;
                brDoktor = Decimal.ToInt32(Math.Round(brIg * (decimal)0.1));
                brPolicija = Decimal.ToInt32(Math.Round(brIg * (decimal)0.2));
                brMafija = Decimal.ToInt32(Math.Round(brIg * (decimal)0.3));
            }

            brGragjani = listaIgraci.Count - (brDoktor + brMafija + brPolicija);
            //brGragjaniPOM = brGragjani;
            txtBox_doktor.Text = brDoktor.ToString();
            txtBox_mafija.Text = brMafija.ToString();
            txtBox_policija.Text = brPolicija.ToString();
            txtBox_Gragjanin.Text = brGragjani.ToString();
        }

        private void TxtBox_Remove_TextChanged(object sender, EventArgs e)
        {
            int number=0;

            bool success = Int32.TryParse(txtBox_Remove.Text, out number);
            if (success)
            {
                brZaBrisenje = number;
            }
            else
            {
                MessageBox.Show("Не се заебавај, внеси реден број на играч!");
                txtBox_Remove.Text = "";
                txtBox_Remove.Focus();
            }
        }

       

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ////////Digitalen casovnik////////////
            ss++;
            if(ss==60)
            {
                mm++;
                ss = 0;
            }
            if(mm==60)
            {
                hh++;
                mm = 0;
            }

            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
                time += hh;
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
                time += mm;
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
                time += ss;
            lblVreme.Text = time;
            
        }

       

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(groupBox2.Visible==false)
            {
                if (button3.Visible == false)
                {
                    if (txtBox_mafija.Text == "0")
                    {
                        akcija = "";
                        MessageBox.Show("Не знам шо да речам, град без мафија! УТОПИЈА!");
                    }
                    else
                    {
                        akcija = "пукан";
                        lbl_akcija.Text = "Акција: Мафијата пука!";
                    }
                }
                else
                {
                    akcija = "";
                    MessageBox.Show("Народо прво сака да гласа, после че пука мафијата!");
                }
            }else
            {
                akcija = "";
                MessageBox.Show("Ај чекор по чекор, прво си најде некое другарче за играње?");
                txtBox_IgracNov.Focus();
            }
            
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                if (button3.Visible == false)
                {
                    if (txtBox_policija.Text == "0")
                    {
                        akcija = "";
                        MessageBox.Show("Џандарите славно загинаа за градот. Народот сам ќе ги реши мафијашите!");
                    }
                    else
                    {
                        akcija = "проверен";
                        lbl_akcija.Text = "Акција: Полицијата проверува!";
                    }

                }
                else
                {
                    akcija = "";
                    MessageBox.Show("Дај бе гласај прво!");
                }
            }
            else
            {
                akcija = "";
                MessageBox.Show("Брзата кучка слепи кучиња раѓа! Стави прво некој играч.");
                txtBox_IgracNov.Focus();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                if (button3.Visible == false)
                {
                    if (txtBox_doktor.Text == "0")
                    {
                        akcija = "";
                        MessageBox.Show("Нема доктори. И тие што беа заминаа Германија :(!");
                    }
                    else
                    {
                        akcija = "лечен";
                        lbl_akcija.Text = "Акција: Докторот лечи!";
                    }

                }
                else
                {
                    akcija = "";
                    MessageBox.Show("Избори на 1-во место, здравјето на 2-ро!");
                }
            }else
            {
                akcija = "";
                MessageBox.Show("Се прашувам: ако сликичката беше со некој стар дооден доктор, дали прво на него ќе кликнеше?! Внеси играчи!");
                txtBox_IgracNov.Focus();
            }
        }

        private void ListBox_Mafia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (akcija != "")
            {
                int poz = Convert.ToInt32(listBox_Mafia.SelectedIndex.ToString());
                PrikaziVoOutput_soAkcija(akcija, poz, "mafija");

                if (pomIzglasanM > -1 && indexIzglasanM > -1)
                {
                    listaIgraciPOM.RemoveAt(pomIzglasanM);
                    listaMafija.RemoveAt(indexIzglasanM);
                    namaliIndexi(pomIzglasanM);
                    brMafija--;
                    txtBox_mafija.Text = brMafija.ToString();

                    PrikaziVoOutput_naredenDen();

                    pomIzglasanM = -1; pomUbienM = -1; pomIzglasanD = -1; pomUbienD = -1; pomIzglasanP = -1; pomUbienP = -1; pomIzglasanG = -1; pomUbienG = -1;
                    indexIzglasanM = -1; indexUbienM = -1; indexIzglasanD = -1; indexUbienD = -1; indexIzglasanP = -1; indexUbienP = -1; indexIzglasanG = -1; indexUbienG = -1;
                    lbl_akcija.Text = "";

                    //ako nema povekje mafijasi
                    if (txtBox_mafija.Text == "0")
                    {
                        brMafija = brMafijaPOM;
                        brPolicija = brPolicijaPOM;
                        brDoktor = brDoktorPOM;
                        brGragjani = brGragjaniPOM;

                        txtBox_mafija.Text = brMafija.ToString();
                        txtBox_policija.Text = brPolicija.ToString();
                        txtBox_doktor.Text = brDoktor.ToString();
                        txtBox_Gragjanin.Text = brGragjani.ToString();

                        partiiPravda++;
                        txtBox_BoardJustice.Text = partiiPravda.ToString();
                        snimiFile();
                        listaDoktori.Clear();
                        listaMafija.Clear();
                        listaPolicija.Clear();
                        vneseni.Clear();
                        lbl_akcija.Text = "";
                        porakaDoktor = "";
                        porakaMafija = "";
                        porakaPolicija = "";
                        pomMafija = "";
                        pomDoktor = "";
                        textBox_poraki.Text = "";
                        textBox_smrtni.Text = "";
                        textBox_runda.Text = "1";
                        listBox_Citizen.Items.Clear();
                        listBox_Doctor.Items.Clear();
                        listBox_Mafia.Items.Clear();
                        listBox_Police.Items.Clear();
                        button3.Visible = false;
                        runda = 1;
                        timer1.Stop();
                        hh = 0;
                        mm = 0;
                        ss = 0;
                        lblVreme.Text = "00:00:00";

                        timer1.Start();
                        kraj = true;

                        txtBox_mafija.Enabled = true;
                        txtBox_policija.Enabled = true;
                        txtBox_doktor.Enabled = true;
                        txtBox_Gragjanin.Enabled = true;

                        listaIgraciPOM.Clear();
                        //foreach (string m in listaIgraci)
                        //    listaIgraciPOM.Add(m);

                        napolnivPomlista = false;

                        

                        MessageBox.Show("Не останаа мафијаши повеќе, градот победи!");
                        Btn_Generiraj_Click(sender, e);
                    }
                }

            }
            else
            {
                MessageBox.Show("Кликни на некоја сликичка за да одбереш акција (освен Граѓанинот)!");
            }
        }


        private void namaliIndexi(int pogolemOd)
        {
            for (int i = 0; i < listaMafija.Count; i++)
            {
                if(listaMafija[i] > pogolemOd)
                    listaMafija[i] = listaMafija[i] - 1;
            }
            for (int i = 0; i < listaPolicija.Count; i++)
            {
                if (listaPolicija[i] > pogolemOd)
                    listaPolicija[i] = listaPolicija[i] - 1;
            }
            for (int i = 0; i < listaDoktori.Count; i++)
            {
                if (listaDoktori[i] > pogolemOd)
                    listaDoktori[i] = listaDoktori[i] - 1;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int number = 0;

            bool success = Int32.TryParse(txtBox_Remove.Text, out number);
            if (success)
            {
                brZaBrisenje = number;
                if(brZaBrisenje>0 && brZaBrisenje<=listaIgraci.Count)
                {
                    timer1.Stop();
                    hh = 0;mm = 0;
                    ss = 0;
                    lblVreme.Text = "00:00:00";

                    AzurirajListaIgraci();
                    RaspredeliUlogi();
                    //txtBox_OutputDoktori.Text = "";
                    //txtBox_OutputGragjanin.Text = "";
                    //txtBox_outputMafija.Text = "";
                    //txtBox_OutputPolicija.Text = "";
                    listBox_Doctor.Items.Clear();
                    listBox_Citizen.Items.Clear();
                    listBox_Mafia.Items.Clear();
                    listBox_Police.Items.Clear();

                    //izbrisi
                    listaIgraci.RemoveAt(brZaBrisenje - 1);
                    AzurirajListaIgraci();
                    RaspredeliUlogi();

                    
                }
                else
                {
                    MessageBox.Show("Пијан да не си? Дај види убо шо внесуваш!");
                    txtBox_Remove.Text = "";
                    txtBox_Remove.Focus();
                }
            }
            else
            {
                MessageBox.Show("Не се заебавај, внеси реден број на играч!");
                txtBox_Remove.Text = "";
                txtBox_Remove.Focus();
            }
        }

        private void ListBox_Police_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (akcija != "")
            {
                int poz = Convert.ToInt32(listBox_Police.SelectedIndex.ToString());
                PrikaziVoOutput_soAkcija(akcija, poz, "policija");
                if (pomIzglasanP > -1 && indexIzglasanP > -1)
                {
                    listaIgraciPOM.RemoveAt(pomIzglasanP);
                    listaPolicija.RemoveAt(indexIzglasanP);
                    namaliIndexi(pomIzglasanP);
                    brPolicija--;
                    txtBox_policija.Text = brPolicija.ToString();

                    PrikaziVoOutput_naredenDen();
                    pomIzglasanM = -1; pomUbienM = -1; pomIzglasanD = -1; pomUbienD = -1; pomIzglasanP = -1; pomUbienP = -1; pomIzglasanG = -1; pomUbienG = -1;
                    indexIzglasanM = -1; indexUbienM = -1; indexIzglasanD = -1; indexUbienD = -1; indexIzglasanP = -1; indexUbienP = -1; indexIzglasanG = -1; indexUbienG = -1;
                    lbl_akcija.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Кликни на некоја сликичка за да одбереш акција (освен Граѓанинот)!");
            }
        }

        private void ListBox_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (akcija != "")
            {
                int poz = Convert.ToInt32(listBox_Doctor.SelectedIndex.ToString());
                PrikaziVoOutput_soAkcija(akcija, poz, "doktor");
                if (pomIzglasanD > -1 && indexIzglasanD > -1)
                {
                    listaIgraciPOM.RemoveAt(pomIzglasanD);
                    listaDoktori.RemoveAt(indexIzglasanD);
                    namaliIndexi(pomIzglasanD);
                    brDoktor--;
                    txtBox_doktor.Text = brDoktor.ToString();

                    PrikaziVoOutput_naredenDen();
                    pomIzglasanM = -1; pomUbienM = -1; pomIzglasanD = -1; pomUbienD = -1; pomIzglasanP = -1; pomUbienP = -1; pomIzglasanG = -1; pomUbienG = -1;
                    indexIzglasanM = -1; indexUbienM = -1; indexIzglasanD = -1; indexUbienD = -1; indexIzglasanP = -1; indexUbienP = -1; indexIzglasanG = -1; indexUbienG = -1;
                    lbl_akcija.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Кликни на некоја сликичка за да одбереш акција (освен Граѓанинот)!");
            }
        }

        private void ListBox_Citizen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (akcija != "")
            {
                int poz = Convert.ToInt32(listBox_Citizen.SelectedIndex.ToString());
                PrikaziVoOutput_soAkcija(akcija, poz, "gragjanin");
                if (pomIzglasanG > -1 && indexIzglasanG > -1) 
                {
                    listaIgraciPOM.RemoveAt(pomIzglasanG);
                    //listaMafija.RemoveAt(indexIzglasanM);
                    namaliIndexi(pomIzglasanG);
                    brGragjani--;
                    txtBox_Gragjanin.Text = brGragjani.ToString();

                    PrikaziVoOutput_naredenDen();
                    pomIzglasanM = -1; pomUbienM = -1; pomIzglasanD = -1; pomUbienD = -1; pomIzglasanP = -1; pomUbienP = -1; pomIzglasanG = -1; pomUbienG = -1;
                    indexIzglasanM = -1; indexUbienM = -1; indexIzglasanD = -1; indexUbienD = -1; indexIzglasanP = -1; indexUbienP = -1; indexIzglasanG = -1; indexUbienG = -1;
                    lbl_akcija.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Кликни на некоја сликичка за да одбереш акција (освен Граѓанинот)!");
            }
        }

        private void Btn_Mafia_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Мафијата победи!!! Дали си сигурен дека сакаш да ја завршиш партијата", "!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

               

                brMafija = brMafijaPOM;
                brPolicija = brPolicijaPOM;
                brDoktor = brDoktorPOM;
                brGragjani = brGragjaniPOM;

                txtBox_mafija.Text = brMafija.ToString();
                txtBox_policija.Text = brPolicija.ToString();
                txtBox_doktor.Text = brDoktor.ToString();
                txtBox_Gragjanin.Text = brGragjani.ToString();

                partiiMafija++;
                txtBox_BoardMafia.Text = partiiMafija.ToString();

                snimiFile();

                listaDoktori.Clear();
                listaMafija.Clear();
                listaPolicija.Clear();
                vneseni.Clear();
                lbl_akcija.Text = "";
                porakaDoktor = "";
                porakaMafija = "";
                porakaPolicija = "";
                pomMafija = "";
                pomDoktor = "";
                textBox_poraki.Text = "";
                textBox_smrtni.Text = "";
                textBox_runda.Text = "1";
                listBox_Citizen.Items.Clear();
                listBox_Doctor.Items.Clear();
                listBox_Mafia.Items.Clear();
                listBox_Police.Items.Clear();
                runda = 1;
                button3.Visible = false;
                timer1.Stop();
                hh = 0;
                mm = 0;
                ss = 0;
                lblVreme.Text = "00:00:00";

                timer1.Start();
                kraj = true;

                txtBox_mafija.Enabled = true;
                txtBox_policija.Enabled = true;
                txtBox_doktor.Enabled = true;
                txtBox_Gragjanin.Enabled = true;

                listaIgraciPOM.Clear();
                //foreach (string m in listaIgraci)
                //    listaIgraciPOM.Add(m);

                napolnivPomlista = false;

                Btn_Generiraj_Click(sender, e);

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Btn_Justice_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Градот победи!!! Дали си сигурен дека сакаш да ја завршиш партијата", "!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                brMafija = brMafijaPOM;
                brPolicija = brPolicijaPOM;
                brDoktor = brDoktorPOM;
                brGragjani = brGragjaniPOM;

                txtBox_mafija.Text = brMafija.ToString();
                txtBox_policija.Text = brPolicija.ToString();
                txtBox_doktor.Text = brDoktor.ToString();
                txtBox_Gragjanin.Text = brGragjani.ToString();

                partiiPravda++;
                txtBox_BoardJustice.Text = partiiPravda.ToString();

                snimiFile();

                listaDoktori.Clear();
                listaMafija.Clear();
                listaPolicija.Clear();
                vneseni.Clear();
                lbl_akcija.Text = "";
                porakaDoktor = "";
                porakaMafija = "";
                porakaPolicija = "";
                pomMafija = "";
                pomDoktor = "";
                textBox_poraki.Text = "";
                textBox_smrtni.Text = "";
                textBox_runda.Text = "1";
                listBox_Citizen.Items.Clear();
                listBox_Doctor.Items.Clear();
                listBox_Mafia.Items.Clear();
                listBox_Police.Items.Clear();
                button3.Visible = false;
                runda = 1;
                timer1.Stop();
                hh = 0;
                mm = 0;
                ss = 0;
                lblVreme.Text = "00:00:00";

                timer1.Start();
                kraj = true;

                txtBox_mafija.Enabled = true;
                txtBox_policija.Enabled = true;
                txtBox_doktor.Enabled = true;
                txtBox_Gragjanin.Enabled = true;

                listaIgraciPOM.Clear();
                //foreach (string m in listaIgraci)
                //    listaIgraciPOM.Add(m);

                napolnivPomlista = false;
                Btn_Generiraj_Click(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            akcija = "изгласан";
            lbl_akcija.Text = "Акција: Овците гласаат (само тие +18)!";
        }

        private void TxtBox_Gragjanin_TextChanged(object sender, EventArgs e)
        {
            int number;

            bool success = Int32.TryParse(txtBox_Gragjanin.Text, out number);
            if (success)
            {
                int vkupno = brMafija + number + brPolicija + brDoktor;
                if (vkupno > listaIgraci.Count)
                {
                    MessageBox.Show("Некако ко многу голема бројка да пиша!");
                    txtBox_Gragjanin.Text = brGragjani.ToString();
                }
                else
                {
                    brGragjani = number;
                }
            }
            else
            {
                MessageBox.Show("Абееее, бројчееее!");
                txtBox_Gragjanin.Text = "";
                txtBox_Gragjanin.Focus();
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                if (txtBox_Gragjanin.Text == "0")
                {
                    MessageBox.Show("Ни криви ни должни, го кркаа. Али ајде, градот да ни е жив и здрав!");
                }
                else
                {
                    lbl_akcija.Text = "Акција: Граѓанинот, хммммм... вегетира?!";
                }
            }else
            {
                akcija = "";
                MessageBox.Show("Не го задевај!!! Гледаш колку безгрижно си гледа турски серии. Тукууу, внеси играчи.");
                txtBox_IgracNov.Focus();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if((porakaPolicija!="" || txtBox_policija.Text == "0") && porakaMafija!="" && (porakaDoktor!="" || txtBox_doktor.Text=="0"))
            {
                bool ubien = false;

                runda++;
                textBox_runda.Text = runda.ToString();

                //VESTI
                //----------------
                textBox_poraki.Text = "Вести од претходната вечер:" + Environment.NewLine;
                textBox_poraki.Text += "---------------------------" + Environment.NewLine;
                textBox_poraki.Text += porakaPolicija + Environment.NewLine +
                    porakaMafija + Environment.NewLine;// +
                    //porakaDoktor + Environment.NewLine;

                if (pomDoktor != pomMafija)
                {
                    textBox_poraki.Text += "И покрај крајните напори на докторот, животот го загуби " + pomMafija + "." + Environment.NewLine ;
                    textBox_smrtni.Text += pomMafija + ";" + Environment.NewLine;
                    ubien = true;
                }
                else
                    textBox_poraki.Text += "Докторот успешно го спаси пациентот " + pomMafija + Environment.NewLine;
                //----------------

                lbl_akcija.Text = "";
                porakaDoktor = "";
                porakaMafija = "";
                porakaPolicija = "";
                pomMafija = "";
                pomDoktor = "";
                lbl_akcija.Text = "";
                akcija = "";
                button3.Visible = true;



                if (ubien == true)
                {
                    ubien = false;
                    if (pomUbienM > -1 && indexUbienM > -1)
                    {
                        listaIgraciPOM.RemoveAt(pomUbienM);
                        listaMafija.RemoveAt(indexUbienM);
                        namaliIndexi(pomUbienM);
                        brMafija--;
                        txtBox_mafija.Text = brMafija.ToString();

                        //PrikaziVoOutput_naredenDen();

                        pomIzglasanM = -1; pomUbienM = -1; pomIzglasanD = -1; pomUbienD = -1; pomIzglasanP = -1; pomUbienP = -1; pomIzglasanG = -1; pomUbienG = -1;
                        indexIzglasanM = -1; indexUbienM = -1; indexIzglasanD = -1; indexUbienD = -1; indexIzglasanP = -1; indexUbienP = -1; indexIzglasanG = -1; indexUbienG = -1;

                    }

                    if (pomUbienP > -1 && indexUbienP > -1)
                    {
                        listaIgraciPOM.RemoveAt(pomUbienP);
                        listaPolicija.RemoveAt(indexUbienP);
                        namaliIndexi(pomUbienP);
                        brPolicija--;
                        txtBox_policija.Text = brPolicija.ToString();

                        //PrikaziVoOutput_naredenDen();
                        pomIzglasanM = -1; pomUbienM = -1; pomIzglasanD = -1; pomUbienD = -1; pomIzglasanP = -1; pomUbienP = -1; pomIzglasanG = -1; pomUbienG = -1;
                        indexIzglasanM = -1; indexUbienM = -1; indexIzglasanD = -1; indexUbienD = -1; indexIzglasanP = -1; indexUbienP = -1; indexIzglasanG = -1; indexUbienG = -1;

                    }

                    if (pomUbienD > -1 && indexUbienD > -1)
                    {
                        listaIgraciPOM.RemoveAt(pomUbienD);
                        listaDoktori.RemoveAt(indexUbienD);
                        namaliIndexi(pomUbienD);
                        brDoktor--;
                        txtBox_doktor.Text = brDoktor.ToString();

                        //PrikaziVoOutput_naredenDen();
                        pomIzglasanM = -1; pomUbienM = -1; pomIzglasanD = -1; pomUbienD = -1; pomIzglasanP = -1; pomUbienP = -1; pomIzglasanG = -1; pomUbienG = -1;
                        indexIzglasanM = -1; indexUbienM = -1; indexIzglasanD = -1; indexUbienD = -1; indexIzglasanP = -1; indexUbienP = -1; indexIzglasanG = -1; indexUbienG = -1;

                    }
                    if (pomUbienG > -1 && indexUbienG > -1)
                    {
                        listaIgraciPOM.RemoveAt(pomUbienG);
                        //listaMafija.RemoveAt(indexIzglasanM);
                        namaliIndexi(pomUbienG);
                        brGragjani--;
                        txtBox_Gragjanin.Text = brGragjani.ToString();

                        //PrikaziVoOutput_naredenDen();
                        pomIzglasanM = -1; pomUbienM = -1; pomIzglasanD = -1; pomUbienD = -1; pomIzglasanP = -1; pomUbienP = -1; pomIzglasanG = -1; pomUbienG = -1;
                        indexIzglasanM = -1; indexUbienM = -1; indexIzglasanD = -1; indexUbienD = -1; indexIzglasanP = -1; indexUbienP = -1; indexIzglasanG = -1; indexUbienG = -1;

                    }

                }

                // PrikaziVoOutput();
                PrikaziVoOutput_naredenDen();
                if (runda>1)
                {
                    txtBox_mafija.Enabled = false;
                    txtBox_policija.Enabled = false;
                    txtBox_doktor.Enabled = false;
                    txtBox_Gragjanin.Enabled = false;

                    button3.Visible = true;

                    kraj = false;

                    

                }

                if(txtBox_mafija.Text=="0")
                {
                    brMafija = brMafijaPOM;
                    brPolicija = brPolicijaPOM;
                    brDoktor = brDoktorPOM;
                    brGragjani = brGragjaniPOM;

                    txtBox_mafija.Text = brMafija.ToString();
                    txtBox_policija.Text = brPolicija.ToString();
                    txtBox_doktor.Text = brDoktor.ToString();
                    txtBox_Gragjanin.Text = brGragjani.ToString();

                    partiiPravda++;
                    txtBox_BoardJustice.Text = partiiPravda.ToString();
                    snimiFile();
                    listaDoktori.Clear();
                    listaMafija.Clear();
                    listaPolicija.Clear();
                    vneseni.Clear();
                    lbl_akcija.Text = "";
                    porakaDoktor = "";
                    porakaMafija = "";
                    porakaPolicija = "";
                    pomMafija = "";
                    pomDoktor = "";
                    textBox_poraki.Text = "";
                    textBox_smrtni.Text = "";
                    textBox_runda.Text = "1";
                    listBox_Citizen.Items.Clear();
                    listBox_Doctor.Items.Clear();
                    listBox_Mafia.Items.Clear();
                    listBox_Police.Items.Clear();
                    button3.Visible = false;
                    runda = 1;
                    timer1.Stop();
                    hh = 0;
                    mm = 0;
                    ss = 0;
                    lblVreme.Text = "00:00:00";

                    timer1.Start();
                    kraj = true;

                    txtBox_mafija.Enabled = true;
                    txtBox_policija.Enabled = true;
                    txtBox_doktor.Enabled = true;
                    txtBox_Gragjanin.Enabled = true;

                    listaIgraciPOM.Clear();
                    //foreach (string m in listaIgraci)
                    //    listaIgraciPOM.Add(m);

                    napolnivPomlista = false;

                    

                    MessageBox.Show("Не останаа мафијаши повеќе, градот победи!");

                    Btn_Generiraj_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Мора да ги одредите сите акции од улогите! Кликаш на сликче па после на некој од играчите.");
            }
        }

        private void PrikaziVoOutput()
        {
            //txtBox_outputMafija.Text = "";
            listBox_Mafia.Items.Clear();
            foreach(int i in listaMafija)
            {
                //txtBox_outputMafija.Text += "М: " + listaIgraci[i] + Environment.NewLine;
                listBox_Mafia.Items.Add(listaIgraci[i]);
            }
            //txtBox_outputMafija.Text += Environment.NewLine;

            //txtBox_OutputPolicija.Text = "";
            listBox_Police.Items.Clear(); ;
            foreach (int i in listaPolicija)
            {
                //txtBox_OutputPolicija.Text += "П: " + listaIgraci[i] + Environment.NewLine;
                listBox_Police.Items.Add(listaIgraci[i]);
            }
            //txtBox_OutputPolicija.Text += Environment.NewLine;

            //txtBox_OutputDoktori.Text = "";
            listBox_Doctor.Items.Clear();
            foreach (int i in listaDoktori)
            {
                //txtBox_OutputDoktori.Text += "Д: " + listaIgraci[i] + Environment.NewLine;
                listBox_Doctor.Items.Add(listaIgraci[i]);
            }
            //txtBox_OutputDoktori.Text += Environment.NewLine;

            //txtBox_OutputGragjanin.Text = "";
            listBox_Citizen.Items.Clear();
            int pom = 0;
            foreach (string s in listaIgraci)
            {
                if(!proveriDaliGoIma(pom))
                {
                    //txtBox_OutputGragjanin.Text += "Г: " + s + Environment.NewLine;
                    listBox_Citizen.Items.Add(s);
                }
                pom++;
            }
            //txtBox_OutputGragjanin.Text += Environment.NewLine;
        }

        private void PrikaziVoOutput_naredenDen()
        {
            //txtBox_outputMafija.Text = "";
            listBox_Mafia.Items.Clear();
            foreach (int i in listaMafija)
            {
                //txtBox_outputMafija.Text += "М: " + listaIgraci[i] + Environment.NewLine;
                listBox_Mafia.Items.Add(listaIgraciPOM[i]);
            }
            //txtBox_outputMafija.Text += Environment.NewLine;

            //txtBox_OutputPolicija.Text = "";
            listBox_Police.Items.Clear(); ;
            foreach (int i in listaPolicija)
            {
                //txtBox_OutputPolicija.Text += "П: " + listaIgraci[i] + Environment.NewLine;
                listBox_Police.Items.Add(listaIgraciPOM[i]);
            }
            //txtBox_OutputPolicija.Text += Environment.NewLine;

            //txtBox_OutputDoktori.Text = "";
            listBox_Doctor.Items.Clear();
            foreach (int i in listaDoktori)
            {
                //txtBox_OutputDoktori.Text += "Д: " + listaIgraci[i] + Environment.NewLine;
                listBox_Doctor.Items.Add(listaIgraciPOM[i]);
            }
            //txtBox_OutputDoktori.Text += Environment.NewLine;

            //txtBox_OutputGragjanin.Text = "";
            listBox_Citizen.Items.Clear();
            int pom = 0;
            foreach (string s in listaIgraciPOM)
            {
                if (!proveriDaliGoIma(pom))
                {
                    //txtBox_OutputGragjanin.Text += "Г: " + s + Environment.NewLine;
                    listBox_Citizen.Items.Add(s);
                }
                pom++;
            }
            //txtBox_OutputGragjanin.Text += Environment.NewLine;
        }


        private void PrikaziVoOutput_soAkcija(string akcija,int poz, string uloga)
        {
            int brPomMafija = 0;
            //txtBox_outputMafija.Text = "";
            listBox_Mafia.Items.Clear();
            int br = 0;
            foreach (int i in listaMafija)
            {
                //txtBox_outputMafija.Text += "М: " + listaIgraciPOM[i] + Environment.NewLine;
                if (uloga=="mafija" && br == poz)
                {
                    
                    if (akcija == "проверен")
                    {
                        porakaPolicija = "Полицијата успешно ја заврши работата и го откри мафијашот " + listaIgraciPOM[i] + ".";
                        listBox_Mafia.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                    }
                    if (akcija == "пукан")
                    {
                        porakaMafija = "Жална вест, беше пукано во " + listaIgraciPOM[i] + ".";
                        listBox_Mafia.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                        pomMafija = listaIgraciPOM[i];
                        brPomMafija = i;
                        indexUbienM = br;
                        pomUbienM = i;
                    }
                    if (akcija == "лечен")
                    {
                        porakaDoktor = "Докторот го лекуваше " + listaIgraciPOM[i] + ".";
                        listBox_Mafia.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                        pomDoktor = listaIgraciPOM[i];
                    }
                    if (akcija == "изгласан")
                    {
                        porakaGrad = listaIgraciPOM[i];
                        DialogResult dialogResult = MessageBox.Show("Дали си сигурен дека сакаш да го изгласаш другарчето?", "!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            textBox_smrtni.Text += porakaGrad + ";" + Environment.NewLine;
                            //listBox_Mafia.Items.RemoveAt(br);
                            
                            pomIzglasanM = i;
                            indexIzglasanM = br;
                            button3.Visible = false;

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            listBox_Mafia.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                            //do something else
                        }
                    }
                }
                else
                {
                    listBox_Mafia.Items.Add(listaIgraciPOM[i]);
                }
                br++;
            }
           
            //txtBox_outputMafija.Text += Environment.NewLine;
            br = 0;
            //txtBox_OutputPolicija.Text = "";
            listBox_Police.Items.Clear(); 
            foreach (int i in listaPolicija)
            {
                //txtBox_OutputPolicija.Text += "П: " + listaIgraciPOM[i] + Environment.NewLine;
                if (uloga=="policija" && br==poz)
                {
                    
                    if (akcija == "проверен")
                    {
                        porakaPolicija = "Полицијата џабе го потроши времето проверувајќи го " + listaIgraciPOM[i] + ".";
                        listBox_Police.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                    }
                    if (akcija == "пукан")
                    {
                        porakaMafija = "Жална вест, беше пукано во " + listaIgraciPOM[i] + ".";
                        pomMafija = listaIgraciPOM[i];
                        listBox_Police.Items.Add(listaIgraciPOM[i] + "<=" + akcija);

                        indexUbienP = br;
                        pomUbienP = i;
                    }
                    if (akcija == "лечен")
                    {
                        porakaDoktor = "Докторот го лекуваше " + listaIgraciPOM[i] + ".";
                        listBox_Police.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                        pomDoktor = listaIgraciPOM[i];
                    }
                    if (akcija == "изгласан")
                    {
                        porakaGrad = listaIgraciPOM[i];
                        DialogResult dialogResult = MessageBox.Show("Дали си сигурен дека сакаш да го изгласаш другарчето?", "!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //textBox_smrtni.Text += porakaGrad + ";" + Environment.NewLine;
                            textBox_smrtni.Text += porakaGrad + ";" + Environment.NewLine;
                          

                            pomIzglasanP = i;
                            indexIzglasanP = br;
                            button3.Visible = false;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                            listBox_Police.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                        }
                    }
                }
                else
                {
                    listBox_Police.Items.Add(listaIgraciPOM[i]);
                }
                br++;
            }
            //txtBox_OutputPolicija.Text += Environment.NewLine;
            br = 0;
            //txtBox_OutputDoktori.Text = "";
            listBox_Doctor.Items.Clear();
            foreach (int i in listaDoktori)
            {
                //txtBox_OutputDoktori.Text += "Д: " + listaIgraciPOM[i] + Environment.NewLine;
                if (uloga == "doktor" && br == poz)
                {
                    
                    if (akcija == "проверен")
                    {
                        porakaPolicija = "Полицијата џабе го потроши времето проверувајќи го " + listaIgraciPOM[i] + ".";
                        listBox_Doctor.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                    }
                    if (akcija == "пукан")
                    {
                        porakaMafija = "Жална вест, беше пукано во " + listaIgraciPOM[i] + ".";
                        listBox_Doctor.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                        pomMafija = listaIgraciPOM[i];
                      
                        indexUbienD = br;
                        pomUbienD = i;
                    }
                    if (akcija == "лечен")
                    {
                        porakaDoktor = "Докторот го лекуваше " + listaIgraciPOM[i] + ".";
                        listBox_Doctor.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                        pomDoktor = listaIgraciPOM[i];
                    }
                    if (akcija == "изгласан")
                    {
                        porakaGrad = listaIgraciPOM[i];
                        DialogResult dialogResult = MessageBox.Show("Дали си сигурен дека сакаш да го изгласаш другарчето?", "!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            textBox_smrtni.Text += porakaGrad + ";" + Environment.NewLine;


                            pomIzglasanD = i;
                            indexIzglasanD = br;
                            button3.Visible = false;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                            listBox_Doctor.Items.Add(listaIgraciPOM[i] + "<=" + akcija);
                        }
                    }
                }
                else
                {
                    listBox_Doctor.Items.Add(listaIgraciPOM[i]);
                }
                br++;
            }
            br = 0;
            //txtBox_OutputDoktori.Text += Environment.NewLine;

            //txtBox_OutputGragjanin.Text = "";
            listBox_Citizen.Items.Clear();
            int pom = 0;
            foreach (string s in listaIgraciPOM)
            {
                if (!proveriDaliGoIma(pom))
                {
                    //txtBox_OutputGragjanin.Text += "Г: " + s + Environment.NewLine;
                    if(uloga=="gragjanin" && br == poz)
                    {
                       
                        if (akcija == "проверен")
                        {
                            porakaPolicija = "Полицијата џабе го потроши времето проверувајќи го " + s + ".";
                            listBox_Citizen.Items.Add(s + "<=" + akcija);
                        }
                        if (akcija == "пукан")
                        {
                            porakaMafija = "Жална вест, беше пукано во " + s + ".";
                            listBox_Citizen.Items.Add(s + "<=" + akcija);
                            pomMafija = s;
                            indexUbienG = br;
                            pomUbienG = pom;
                        }
                        if (akcija == "лечен")
                        {
                            porakaDoktor = "Докторот го лекуваше " + s + ".";
                            listBox_Citizen.Items.Add(s + "<=" + akcija);
                            pomDoktor = s;
                        }
                        if (akcija == "изгласан")
                        {
                            porakaGrad = s;
                            DialogResult dialogResult = MessageBox.Show("Дали си сигурен дека сакаш да го изгласаш другарчето?", "!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                textBox_smrtni.Text += porakaGrad + ";" + Environment.NewLine;


                                pomIzglasanG = pom;
                                indexIzglasanG = br;
                                button3.Visible = false;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //do something else
                                listBox_Citizen.Items.Add(s + "<=" + akcija);
                            }
                        }
                    }
                    else
                    {
                        listBox_Citizen.Items.Add(s);
                    }
                    
                    br++;
                }
                pom++;
            }

            //listaMafija.RemoveAt(brPomMafija);
           // brMafija--;

            //txtBox_OutputGragjanin.Text += Environment.NewLine;
        }

        private int GiveMeANumber(int max)
        {
            //var exclude = new HashSet<int>() { 5, 7, 17, 23 };
            var range = Enumerable.Range(0, max).Where(i => !vneseni.Contains(i));

            var rand = new System.Random();
            int index = rand.Next(0, max - vneseni.Count);
            return range.ElementAt(index);
        }


        //f-ja za snimanje na file
        private void snimiFile()
        {
            using (StreamWriter writer = new StreamWriter("logs\\Rezultati_"+DateTime.Now.Day.ToString()+"_"+DateTime.Now.Month.ToString()+"_"+DateTime.Now.Year.ToString()+".txt",true))
            {
                writer.WriteLine();
                writer.WriteLine(">>> "+DateTime.Now.ToString());
                writer.WriteLine("============================================");
                writer.WriteLine(">>> В Р Е М Е   Н А   И Г Р А Њ Е:  " + lblVreme.Text + " <<<");
                writer.WriteLine(">>> ПОМИНАТИ ДЕНОВИ: " + textBox_runda.Text + " <<<");
                writer.WriteLine(">>> Р Е З У Л Т А Т:     мафија " + txtBox_BoardMafia.Text + " - " +txtBox_BoardJustice.Text+ " градот <<<");
                writer.WriteLine("____________________________________________");
                writer.WriteLine(">>> И Г Р А Ч И:  "+listaIgraci.Count.ToString()+" <<<");
                writer.WriteLine("    мафија: " + brMafijaPOM.ToString() + ", полиција: "+brPolicijaPOM.ToString()+", доктори: "+brDoktorPOM.ToString()+", граѓани: "+brGragjaniPOM.ToString());
                
                int br = 0;
                foreach(string s in listaIgraci)
                {
                    writer.WriteLine(br+". "+s);
                    br++;
                }
                writer.WriteLine("____________________________________________");
                writer.WriteLine();

                writer.WriteLine(">>>  М Е Ѓ У     Ж И В И Т Е     С Е <<<");
                writer.WriteLine("    МАФИЈА: ");
                br = 0;
                foreach(string s in listBox_Mafia.Items)
                {
                    writer.WriteLine(br + ". " + s.ToString());
                    br++;
                }
                writer.WriteLine("____________________________________________");
                writer.WriteLine("    ПОЛИЦИЈА: ");
                br = 0;
                foreach (string s in listBox_Police.Items)
                {
                    writer.WriteLine(br + ". " + s.ToString());
                    br++;
                }
                writer.WriteLine("____________________________________________");
                writer.WriteLine("    ДОКТОРИ: ");
                br = 0;
                foreach (string s in listBox_Doctor.Items)
                {
                    writer.WriteLine(br + ". " + s.ToString());
                    br++;
                }
                writer.WriteLine("____________________________________________");
                writer.WriteLine("    ГРАЃАНИ: ");
                br = 0;
                foreach (string s in listBox_Citizen.Items)
                {
                    writer.WriteLine(br + ". " + s.ToString());
                    br++;
                }
                writer.WriteLine("____________________________________________");
                writer.WriteLine("    СЛАВНО ЗАГИНАТИ / ИЗБРКАНИ: ");
                writer.WriteLine(textBox_smrtni.Text);
                writer.WriteLine("============================================");
            }
        }

    }
}
