namespace BasicsOfInheritance
{
    public partial class Form1 : Form
    {
        List<Drinks> drinksList = new List<Drinks>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }
       

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear();
            var rnd = new Random();
            string[] fruits = { "Апельсин", "Яблоко", "Груша", "Виноград" };

            for (var i=0; i<10; ++i)
            {
                switch(rnd.Next() % 3)
                {
                    case 0:
                        this.drinksList.Add(new Juice { Volume = rnd.Next(1, 3), FruitsUsed = fruits[rnd.Next(fruits.Length)],
                        PresenceOfPulp = rnd.Next() % 2 == 0});
                        break;
                    case 1:
                        this.drinksList.Add(new Soda { Volume = rnd.Next(1, 3), NumberOfBubbles = rnd.Next(100, 5000),
                            view = (SodaView)(rnd.Next() % 2)});
                        break;
                    case 2:
                        this.drinksList.Add(new Alcohol {Volume = rnd.Next(1, 3), Fortress = rnd.Next(5, 100),
                            type = (AlcoholType)(rnd.Next() % 3)});
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int juiceCount = 0;
            int sodaCount = 0;
            int alcoholCount = 0;

            foreach (var drink in this.drinksList)
            {
                if (drink is Juice)
                {
                    juiceCount += 1;
                }
                else if (drink is Soda)
                {

                    sodaCount += 1;

                }
                else if (drink is Alcohol) { 
                
                    alcoholCount += 1;

                }
            }

            txtInfo.Text = "Сок\tГазировка\tАлкоголь";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t\t{2}", juiceCount, sodaCount, alcoholCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.drinksList.Count == 0) {
                txtOut.Text = "Пусто АААААА МОИ ШЕКЕЛИ";
                return;
            }

            var drink = this.drinksList[0];
            this.drinksList.RemoveAt(0);

            txtOut.Text = drink.GetInfo();
            ShowInfo();
        }

        


    }
}
