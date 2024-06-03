namespace Calificaciones4838081
{
    ///<Summary>
    ///<Createddate>29/05/2024</createddate>
    ///<company></company>
    ///<lastmodificationdate>02/06/2024</lastmodificationdate>
    ///<lastmodificationdescription>
    ///
    ///</lastmodificationdescription>
    ///<lastmodifierautor>Jasson Navarro</lastmodifierautor>
    ///</Summary>
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }



        #region evento button
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text)
                && !string.IsNullOrEmpty(entry3.Text) && !string.IsNullOrEmpty(entry4.Text) && !string.IsNullOrEmpty(entry5.Text)) 
            { 
            double promedio,promedio1,promedio2,promedio3,promedio4,promedio5;
            promedio1 = Convert.ToDouble(entry1.Text);
            promedio2 = Convert.ToDouble(entry2.Text);
            promedio3 = Convert.ToDouble(entry3.Text);
            promedio4 = Convert.ToDouble(entry4.Text);
            promedio5 = Convert.ToDouble(entry5.Text);
            promedio = promedio1 + promedio2 + promedio3 + promedio4 + promedio5 / 5;
            entry6.Text = promedio.ToString();
            }
            else
            {
                DisplayAlert("Error","Introduce los 5 promedios", "ok");
            }
        }
        #endregion
    }

}
