namespace CHHCHCHCHCHCHCHCHCUCUJUJUJUJUJUJUJ
{
    public partial class MainPage : ContentPage
    {
        int cena = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void kupBilet(object sender, EventArgs e)
        {
            cena += 15;
            Koszyk.Text = $"Cena za wszystkie bilety : {cena} zł";
        }
    }

}
