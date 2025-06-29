namespace WorkingHouse_DartMFG
{
    public partial class Form_JohnGray : Form
    {
        private int dialogueState = 0;
        private bool bookGiven = false;
        private Form_Inventory inventory;

        public Form_JohnGray(Form_Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            button3.Visible = false;
            button4.Visible = false;
            StartDialogue();
        }

        private void StartDialogue()
        {
            label1.Text = "Я вас категорически приветствую!";
            button1.Text = "1. Узнать что ему нужно";
            button2.Text = "2. Распросить";
            dialogueState = 1;
        }

        private void CheckForBook()
        {
            if (bookGiven)
            {
                MessageBox.Show("У меня уже есть книга", "Джон Грей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            bool hasBook = false;
            foreach (var item in inventory.listBox1.Items)
            {
                if (item.ToString() == "КНИГА")
                {
                    hasBook = true;
                    break;
                }
            }

            if (hasBook)
            {
                inventory.removeItem("КНИГА");
                inventory.plusOA(500);
                MessageBox.Show("СПАСИБО ЗА КНИГУ, ПРИОЧЕНЬ БЛАГОДАРЕН ВАМ", "Джон Грей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bookGiven = true;
            }
            else
            {
                MessageBox.Show("У вас нет книги", "Джон Грей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (dialogueState)
            {
                case 1:
                    label1.Text = "Вы знаете... До того, как я попал сюда, я много читал. Очень много. Дома - книги, на улице - газеты, даже на работе! Вчитывался в каждую надпись, доску, объявление, инструкцию... А тут... Библиотека закрыта на ремонт уже пятый год, выйти никуда нельзя и книги не продают... Я так соскучился по литературе... \n\nНе моглабы ты достать мне хоть какую-то книжку? Чем толще тем лучше!";
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    button4.Text = "Завершить диалог";
                    break;

                case 2:
                    label1.Text = "Сначла пожар на мануфактуре, который оставил нас без денег... Потом арест родителей, за измену Господину, Царствие Его неизбежно!..\nТак я оказался на улице... \n\nНу и теперь здесь... Тружусь уже долгие 7 лет...";
                    ResetButtons();
                    break;

                case 3:
                    label1.Text = "Ещё какое! Умею читать, писать и считать в уме! Семья мне наняла преподавателя. Расчитывали, что потом я поступлю в университет.\nВыучусь и пойду в министерию...  Там четырёх комнатная квартира...  личный извозчик... серебрянная посуда, вместо цинковоц... танцы... оклад в размере 300 фунтов... Но не срослось...";
                    ResetButtons();
                    break;

                case 4:
                    label1.Text = "Жены у меня не было, детей соответственно тоже... Родители бывшие мануфактурщики, держали столярную лавку в Графстве Олох. Потом она сгорела, спалив ещё пару домов.\nДеньги у нас оставались, но на этаже, где у нас осталась последняя квартира, нашли книгу \"Так Труд\", которая запрещена, ибо является осквернителем Господского Царствия. Вот их и ареставали...";
                    ResetButtons();
                    break;

                case 5:
                    label1.Text = "Вам нет, но образованным людям известно, что даже в тюрьме лучше, чем тут... Там меньше квота труда, бесплатное питание, бесплатная одежда... Бьют только, но боль забывается быстро.\nА тут... Ни выйти на улицу, ни нормального питания, письма от родственников не принимают, посылки забирают себе...  Рабство одним словом!..\n\nНо, возможно это лучше, чем констебьюлянты изобьют тебя до полусмерти за нищенство и оставят в ближайшей канаве. Нищим становится надо тихо... незаметно.\nКак только видишь, что деньги всё, кончаются - собираешь оставшиеся пожитки и уходишь в лес.\nЕсли денег достаточно, можно в трюме грузового судна в Коламбию и Евклат отправится...  там говорят новая жизнь строится, работы много, а работающих нет...\nНо такой выход из положения приходит далеко не всем в голову... Либо позже... ";
                    ResetButtons();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (dialogueState)
            {
                case 1:
                    label1.Text = "Что вы хотите узнать?";
                    button1.Text = "1. Как ты тут оказался?";
                    button2.Text = "2. Ты получил образование?";
                    button3.Visible = true;
                    button3.Text = "3. Что случилось с твоей семьёй?";
                    button4.Visible = true;
                    button4.Text = "4. Что вы думаете о нашем положении?";
                    dialogueState = 2;
                    break;

                case 2:
                    dialogueState = 3;
                    button1_Click(sender, e);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dialogueState == 2)
            {
                dialogueState = 4;
                button1_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dialogueState == 2)
            {
                dialogueState = 5;
                button1_Click(sender, e);
            }
            else if (button4.Text == "Завершить диалог")
            {
                CheckForBook();
            }
            else
            {
                this.Close();
            }
        }

        private void ResetButtons()
        {
            button4.Text = "Продолжить";
            button4.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            dialogueState = 0;
        }
    }
}