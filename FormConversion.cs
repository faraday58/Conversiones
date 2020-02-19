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
            if (txtbFarenheit.Text == "" && txtbKelvin.Text == "")
            {
                if (txtbCentigrados.Text != "")
                {
                    temperatura.Centigrados = float.Parse(txtbCentigrados.Text);
                    temperatura.CentigradosAFarenheit(temperatura.Centigrados);
                    txtbFarenheit.Text = temperatura.Farenheit.ToString();
                    //Comentario
                    temperatura.CentigradosAKelvin(temperatura.Centigrados);
                    txtbKelvin.Text = temperatura.Kelvin.ToString();
                }
            }
            if (txtbCentigrados.Text == "" && txtbKelvin.Text == "")
            {
                if (txtbFarenheit.Text != "")
                {
                    temperatura.Farenheit = float.Parse(txtbFarenheit.Text);
                    temperatura.FarenheitACentigrados(temperatura.Farenheit);
                    txtbCentigrados.Text = temperatura.Centigrados.ToString();
                    //Comentario
                    temperatura.CentigradosAKelvin(temperatura.Centigrados);
                    txtbKelvin.Text = temperatura.Kelvin.ToString();
                }
            }

            if (txtbFarenheit.Text == "" && txtbCentigrados.Text == "")
            {
                if (txtbKelvin.Text != "")
                {
                    temperatura.Kelvin = float.Parse(txtbKelvin.Text);
                    temperatura.KelvinACentigrados(temperatura.Kelvin);
                    txtbCentigrados.Text = temperatura.Centigrados.ToString();
                    //Comentario
                    temperatura.CentigradosAFarenheit(temperatura.Centigrados);
                    txtbFarenheit.Text = temperatura.Farenheit.ToString();
                }
            }

        }

        public void EventoLimpiar(object sender, EventArgs e)
        {
            txtbFarenheit.Text = "";
            txtbCentigrados.Text = "";
            txtbKelvin.Text = "";
        }

    }

}
