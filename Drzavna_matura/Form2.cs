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
    
    public partial class Form2 : Form
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
        /*
        public List<string> poljop_tri = new List<string>() { "Зоотехничар", "Техничар за биотехнологију", "Техничар пољопривредне технике", "Техничар хортикултуре" };
        public List<string> suma_tri = new List<string>() { "Техничар за пејзажну архитектуру", "Шумарски техничар" };
        public List<string> geol_tri = new List<string>() { "Геолошки техничар за геотехнику и хидрогеологију", "Геолошки техничар за истраживање минералних сировина",
        "Рударски техничар", "Рударски техничар за припрему минералних сировина"};
        public List<string> masina_tri = new List<string>() { "Бродомашински техничар", "Машински техничар за компјутерско конструисање",
        "Машински техничар мерне и регулационе технике", "Машински техничар моторних возила", "Техничар грејања и климатизације", "Техничар за компјутерско управљање (CNC) машина",
        "Техничар за роботику", "Техничар машинске енергетике", "Техничар оптике"};
        public List<string> elek_tri = new List<string>() { "Електротехничар аутоматике", "Електротехничар електромоторних погона", "Електротехничар електронике",
        "Електротехничар енергетике", "Електротехничар за термичке и расхладне уређаје", "Електротехничар информационих технологија", "Електротехничар процесног управљања",
        "Електротехничар рачунара"};
        public List<string> hem_tri = new List<string>() { "Техничар графичке дораде", "Техничар за заштиту животне средине", "Техничар за индустријску фармацеутску технологију",
        "Техничар штампе", "Фотограф", "Хемијски лаборант", "Хемијско-технолошки техничар"};
        public List<string> teks_tri = new List<string>() { "Текстилни техничар" };
        public List<string> geod_tri = new List<string>() { "Грађевински техничар за лабораторијска испитивања", "Грађевински техничар за хидроградњу",
        "Извођач инсталатерских и завршних грађевинских радова"};
        public List<string> saob_tri = new List<string>() { "Наутички техничар – речни смер", "Саобраћајно-транспортни техничар", "Техничар вуче", "Техничар ПТТ саобраћаја",
        "Техничар унутрашњег транспорта", "Транспортни комерцијалиста"};
        public List<string> trg_tri = new List<string>() { "Аранжер у трговини и Трговински техничар", "Кулинарски техничар", "Угоститељски техничар" };
        public List<string> ekon_tri = new List<string>() { "Економски техничар", "Финансијски техничар", "Царински техничар" };
        public List<string> zdrav_tri = new List<string>() { "Гинеколошко-акушерска сестра", "Зубни техничар", "Медицинска сестра – васпитач",
        "Педијатријска сестра – техничар", "Санитарно-еколошки техничар"};
        public List<string> lic_tri = new List<string>() { "Сценски маскер и власуљар" };*/
        public List<string> umet_tri = new List<string>() { "Солфеђо и хармонија" };

        public List<Skola> skole = new List<Skola>();

        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader citac = new StreamReader("Skole.txt");
            string line;
            while ((line = citac.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                Skola sk = new Skola(temp[0], temp[1]);
                skole.Add(sk);
                comboBox5.Items.Add(temp[0]);
            }
            citac.Close();

            Dodaj_Predmete(comboBox2, jedan);
            Dodaj_Predmete(comboBox3, dva);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string skola = textBox1.Text;
            string matura = comboBox1.SelectedItem.ToString();
            const string putanja = "Skole.txt";
            StreamWriter pisac = new StreamWriter(putanja, append:true);
            pisac.WriteLine(skola + "," + matura);
            pisac.Close();

            Skola tren = new Skola(skola, matura);
            skole.Add(tren);

            Dodaj_Skole();
            MessageBox.Show("Успешно сте додали нову школу.");
        }

        public void Dodaj_Skole()
        {
            comboBox5.Items.Add(skole.Last().ime);
        }

        public void Dodaj_Predmete(ComboBox com, List<string> lista)
        {
            foreach (string str in lista)
            {
                com.Items.Add(str);
            }
        }

        private void comboBox5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matura = "";
            foreach (Skola sk in skole)
            {
                if (sk.ime == comboBox5.SelectedItem.ToString())
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            StreamWriter pisac = new StreamWriter("Sabloni.txt", append: true);
            string ime = textBox2.Text;
            string skola = comboBox5.SelectedItem.ToString();
            string prvi = comboBox2.SelectedItem.ToString();
            string drugi = comboBox3.SelectedItem.ToString();
            string treci = comboBox4.SelectedItem.ToString();
            pisac.WriteLine(ime + "," + skola + "," + prvi + "," + drugi + "," + treci);
            pisac.Close();
            MessageBox.Show("Успешно сте додали нови шаблон.");
        }
    }
}
