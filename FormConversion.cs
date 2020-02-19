using System;


namespace Conversiones
{
    partial class FormConversion
    {
        public FormConversion()
        {
            InitializeComponent();
        }

        public void EventoConversion(object sender, EventArgs e)
        {
            Temperatura temperatura = new Temperatura();

            if( txtbCentigrados.Text != ""    )
            {
                temperatura.Centigrados = float.Parse(txtbCentigrados.Text);
                temperatura.CentigradosAFarenheit(temperatura.Centigrados);
                txtbFarenheit.Text = temperatura.Farenheit.ToString();

                temperatura.CentigradosAKelvin(temperatura.Centigrados);
                txtbKelvin.Text = temperatura.Kelvin.ToString();
            }


        }


    }
}
