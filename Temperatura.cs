using System;

namespace Conversiones
{
    class Temperatura
    {

        #region Atributos
        private float centigrados;
        private float farenheit;
        private float kelvin;
        #endregion

        #region Propiedades o encapsulamiento
        public float Centigrados {
            get => centigrados;
            set
            {
                if(-273.15 < value &&  value < 2000   )
                {
                    centigrados = value;
                }
                else
                {
                    centigrados = 0;
                }
                    
            }
        }
        public float Farenheit { 
            get => farenheit;
            set {
                    if(  -459.67 < value && value < 3632    )
                    {
                        farenheit = value;
                    }                    
                    else
                    {
                        farenheit = 32;
                    }
               } 
        }
        public float Kelvin {
            get => kelvin;
            set
            {
                if (0 < value && value <= 2273.15)
                {
                    kelvin = value;
                }
                else
                    kelvin = 0;
                
            }
        }

        #endregion


        #region Métodos de Conversión
        public void CentigradosAFarenheit(float centigrados)
        {
            Centigrados = centigrados;
            Farenheit = 1.8f * Centigrados + 32;

        }

        public void CentigradosAKelvin(float centigrados)
        {
            Centigrados = centigrados;
            Kelvin = Centigrados + 273.15f;
        }

        public void FarenheitACentigrados(float farenheit)
        {
            Centigrados= (farenheit-32)/1.8f;
        }
        public void KelvinACentigrados(float kelvin)
        {
            Centigrados = kelvin-273.15f;
        }


        #endregion


    }
}
