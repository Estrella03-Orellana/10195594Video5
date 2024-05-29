namespace _10195594Video5
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  El evento clicked del botón lo que realiza es que cambia el texto que estába por otro dentro del botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Presioname de nuevo";
        }
    }

}
