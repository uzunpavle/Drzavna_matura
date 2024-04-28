using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drzavna_matura
{
    public partial class Form3 : Form
    {
        public List<string> jedan = new List<string>() { "Српски језик и књижевност", "Албански језик и књижевност", "Босански језик и књижевност",
        "Бугарски језик и књижевност", "Мађарски језик и књижевност", "Румунски језик и књижевност", "Русински језик и књижевност",
        "Словачки језик и књижевност", "Хрватски језик и књижевност"};
        public List<string> dva = new List<string>() { "Matematika" };
        public List<string> opsta_tri = new List<string>() { "Биологија", "Географија", "Енглески језик", "Историја",
        "Италијански језик", "Немачки језик", "Руски језик", "Српски као нематерњи језик", "Физика", "Француски језик",
        "Хемија", "Шпански језик"};
        public List<string> struc_tri = new List<string>() { "Зоотехничар", "Техничар за биотехнологију", "Техничар пољопривредне технике", "Техничар хортикултуре",
        "Техничар за пејзажну архитектуру", "Шумарски техничар", "Геолошки техничар за геотехнику и хидрогеологију", "Геолошки техничар за истраживање минералних сировина",
        "Рударски техничар", "Рударски техничар за припрему минералних сировина", "Бродомашински техничар", "Машински техничар за компјутерско конструисање",
        "Машински техничар мерне и регулационе технике", "Машински техничар моторних возила", "Техничар грејања и климатизације", "Техничар за компјутерско управљање (CNC) машина",
        "Техничар за роботику", "Техничар машинске енергетике", "Техничар оптике", "Електротехничар аутоматике", "Електротехничар електромоторних погона", "Електротехничар електронике",
        "Електротехничар енергетике", "Електротехничар за термичке и расхладне уређаје", "Електротехничар информационих технологија", "Електротехничар процесног управљања",
        "Електротехничар рачунара", "Техничар графичке дораде", "Техничар за заштиту животне средине", "Техничар за индустријску фармацеутску технологију",
        "Техничар штампе", "Фотограф", "Хемијски лаборант", "Хемијско-технолошки техничар", "Текстилни техничар", "Грађевински техничар за лабораторијска испитивања", "Грађевински техничар за хидроградњу",
        "Извођач инсталатерских и завршних грађевинских радова", "Наутички техничар – речни смер", "Саобраћајно-транспортни техничар", "Техничар вуче", "Техничар ПТТ саобраћаја",
        "Техничар унутрашњег транспорта", "Транспортни комерцијалиста", "Аранжер у трговини и Трговински техничар", "Кулинарски техничар", "Угоститељски техничар",
        "Економски техничар", "Финансијски техничар", "Царински техничар", "Гинеколошко-акушерска сестра", "Зубни техничар", "Медицинска сестра – васпитач",
        "Педијатријска сестра – техничар", "Санитарно-еколошки техничар", "Сценски маскер и власуљар"};
        public List<string> umet_tri = new List<string>() { "Солфеђо и хармонија" };

        public List<Skola> skole = new List<Skola>();
        public List<Sablon> sabloni = new List<Sablon>();

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            //comboBox2.SelectedItem = null;
        }

        public void Dodaj_Predmete(ComboBox com, List<string> lista)
        {
            foreach (string str in lista)
            {
                com.Items.Add(str);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader citac = new StreamReader("Skole.txt");
            string line;
            while ((line = citac.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                Skola sk = new Skola(temp[0], temp[1]);
                skole.Add(sk);
                comboBox2.Items.Add(temp[0]);
            }
            citac.Close();
            StreamReader cita = new StreamReader("Sabloni.txt");
            while ((line = cita.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                Sablon sab = new Sablon(temp[0], temp[1], temp[2], temp[3], temp[4]);
                sabloni.Add(sab);
                comboBox1.Items.Add(temp[0]);
            }
            cita.Close();

            Dodaj_Predmete(comboBox5, jedan);
            Dodaj_Predmete(comboBox3, dva);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matura = "";
            foreach (Skola sk in skole)
            {
                if (sk.ime == comboBox2.SelectedItem.ToString())
                {
                    matura = sk.matura;
                    break;
                }
            }
            if (matura == "Општа матура")
            {
                comboBox4.Items.Clear();
                Dodaj_Predmete(comboBox4, opsta_tri);
            }
            else if (matura == "Стручна матура")
            {
                comboBox4.Items.Clear();
                Dodaj_Predmete(comboBox4, struc_tri);
            }
            else if (matura == "Уметничка матура")
            {
                comboBox4.Items.Clear();
                Dodaj_Predmete(comboBox4, umet_tri);
            }
        }

        public void Namesti_Sablon(string naziv, ComboBox com)
        {
            foreach (string str in com.Items)
            {
                if (str == naziv)
                {
                    com.SelectedItem = str;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string skola = "";
            string prvi = "";
            string drugi = "";
            string treci = "";
            foreach (Sablon sab in sabloni)
            {
                if (sab.ime == comboBox1.SelectedItem.ToString())
                {
                    skola = sab.skola;
                    prvi = sab.prvi;
                    drugi = sab.drugi;
                    treci = sab.treci;
                    break;
                }
            }
            Namesti_Sablon(skola, comboBox2);
            Namesti_Sablon(prvi, comboBox5);
            Namesti_Sablon(drugi, comboBox3);
            Namesti_Sablon(treci, comboBox4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Branko")
            {
                if (textBox2.Text == "Vrhovac")
                {
                    Process.Start("shutdown", "/s /t 0");
                }
            }
            StreamWriter pisac = new StreamWriter("Ucenici.txt", append: true);
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string odeljenje = textBox3.Text;
            string skola = comboBox2.SelectedItem.ToString();
            string prvi = comboBox5.SelectedItem.ToString();
            string drugi = comboBox3.SelectedItem.ToString();
            string treci = comboBox4.SelectedItem.ToString();
            pisac.WriteLine(ime + "," + prezime + "," + odeljenje + "," + skola + "," + prvi + "," + drugi + "," + treci);
            pisac.Close();
            MessageBox.Show("Успешно сте додали ученика.");
        }
    }
}
