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

namespace Drzavna_matura
{
    public partial class Form4 : Form
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
        public List<Ucenik> ucenici = new List<Ucenik>();
        public int index;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader citac = new StreamReader("Ucenici.txt");
            string line;
            while ((line = citac.ReadLine()) != null)
            {
                string[] str = line.Split(',');
                Ucenik uce = new Ucenik(str[0], str[1], str[2], str[3], str[4], str[5], str[6]);
                ucenici.Add(uce);
            }
            StreamReader cita = new StreamReader("Skole.txt");
            while ((line = cita.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                Skola sk = new Skola(temp[0], temp[1]);
                skole.Add(sk);
                comboBox2.Items.Add(temp[0]);
            }
            citac.Close();
            cita.Close();

            Dodaj_Predmete(comboBox5, jedan);
            Dodaj_Predmete(comboBox3, dva);
            Upisi_Ucenika(0);
            index = 0;
        }

        public void Namesti_ComboBox(string naziv, ComboBox com)
        {
            foreach (string str in com.Items)
            {
                if (str == naziv)
                {
                    com.SelectedItem = str;
                }
            }
        }

        public void Upisi_Ucenika(int pozicija)
        {
            Ucenik temp = ucenici[pozicija];
            textBox1.Text = temp.ime;
            textBox2.Text = temp.prezime;
            textBox3.Text = temp.odeljenje;
            Namesti_ComboBox(temp.skola, comboBox2);
            Namesti_ComboBox(temp.prvi, comboBox5);
            Namesti_ComboBox(temp.drugi, comboBox3);
            Namesti_ComboBox(temp.treci, comboBox4);
        }

        public void Dodaj_Predmete(ComboBox com, List<string> lista)
        {
            foreach (string str in lista)
            {
                com.Items.Add(str);
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (ucenici.Count - 1 > index)
            {
                Upisi_Ucenika(index + 1);
                index++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                Upisi_Ucenika(index - 1);
                index--;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Upisi_Ucenika(ucenici.Count - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Upisi_Ucenika(0);
        }

        public void WritetoFile()
        {
            string[] linije = new string[ucenici.Count];
            for (int i = 0; i < ucenici.Count; i++)
            {
                linije[i] = ucenici[i].ToString();
            }
            File.WriteAllLines("Ucenici.txt", linije);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucenici.Remove(ucenici[index]);
            index--;
            Upisi_Ucenika(index);
            WritetoFile(); 
            MessageBox.Show("Успешно сте уклонили ученика.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ucenik refer = ucenici[index];
            Ucenik tek = new Ucenik(textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.SelectedItem.ToString(), comboBox5.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString());
            if (!refer.Equals(tek))
            {
                ucenici[index] = tek;
                WritetoFile();
                MessageBox.Show("Успешно сте изменили ученика.");
            }
            else
            {
                MessageBox.Show("Хвала, у реду је.");
            }
        }
    }
}
