using System;
using System.Drawing;
using System.Windows.Forms;
namespace Conversiones
{
    partial class FormConversion:Form
    {

        #region Atributos de la clase FormConversión
        private TextBox txtbCentigrados;
        private Label lbCentigrados;
        private TextBox txtbFarenheit;
        private Label lbFarenheit;
        private TextBox txtbKelvin;
        private Label lbKelvin;
        private Button btConvertir;
        #endregion

        public void InitializeComponent()
        {
            #region Instanciando atributos
            txtbCentigrados = new TextBox();
            txtbFarenheit = new TextBox();
            txtbKelvin = new TextBox();
            btConvertir = new Button();
            lbCentigrados = new Label();
            lbFarenheit = new Label();
            lbKelvin = new Label();
            #endregion

            #region Propiedades de aspecto Formulario
            this.Text = "Conversiones";
            this.Size = new Size(225, 400);
            this.Location = new Point(688, 200);
            this.BackColor = Color.SkyBlue;
            #endregion


            //Propiedades del Textbox Centígrados
            txtbCentigrados.Size = new Size(100, 50);
            txtbCentigrados.Location =new  Point(60, 50);

            //Propiedades del Textbox Farenheit
            txtbFarenheit.Size = new Size(100, 50);
            txtbFarenheit.Location = new Point(60, 150);

            //Propiedades del Textbox Kelvin
            txtbKelvin.Size = new Size(100, 50);
            txtbKelvin.Location = new Point(60, 250);

            //Propiedad de Label Centígrados
            lbCentigrados.Text = "°C";
            lbCentigrados.Size = new Size(50, 50);
            lbCentigrados.Location = new Point(165,50);
            //Propiedad de Label Farenheit
            lbFarenheit.Text = "°F";
            lbFarenheit.Size = new Size(50, 50);
            lbFarenheit.Location = new Point(165,150);
            //Propiedad de Label Kelvin
            lbKelvin.Text = "K";
            lbKelvin.Size = new Size(50,50);
            lbKelvin.Location = new Point(165,250);

            btConvertir.Size = new Size(100, 50);
            btConvertir.Location = new Point(60, 275);
            btConvertir.Text = "Convertir";
            btConvertir.Click += new EventHandler(EventoConversion);


            this.Controls.Add(this.txtbCentigrados);
            this.Controls.Add(this.txtbFarenheit);
            this.Controls.Add(this.txtbKelvin);
            this.Controls.Add(this.lbCentigrados);
            this.Controls.Add(this.lbFarenheit);
            this.Controls.Add(this.lbKelvin);
            this.Controls.Add(this.btConvertir);


        }



    }
}
