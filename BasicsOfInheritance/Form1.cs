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
            for (var i=0; i<10; ++i)
            {
                switch(rnd.Next() % 3)
                {
                    case 0:
                        this.drinksList.Add(new Juice {
                            Volume = rnd.Next() % 6
                        });
                        break;
                    case 1:
                        this.drinksList.Add(new Soda {
                            Volume = rnd.Next() % 6
                        });
                        break;
                    case 2:
                        this.drinksList.Add(new Alcohol {
                            Volume = rnd.Next() % 6
                        });
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

            txtInfo.Text = "Ñîê\tÃàçèðîâêà\tÀëêàãîëü";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", juiceCount, sodaCount, alcoholCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.drinksList.Count == 0) {
                txtOut.Text = "Ïóñòî ÀÀÀÀÀÀ ÌÎÈ ØÅÊÅËÈ";
                return;
            }

            var drink = this.drinksList[0];
            this.drinksList.RemoveAt(0);

            txtOut.Text = drink.GetInfo();
            ShowInfo();
        }

        


    }
}
