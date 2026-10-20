using System;
using System.Web.UI;

namespace Tarea_caculadora_proga
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bresultado_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(tn1.Text))
                {
                    lresultado.Text = "Por favor, ingrese el primer número.";
                    return;
                }

                double num1 = Convert.ToDouble(tn1.Text);
                double num2 = 0;
                bool tieneNum2 = !string.IsNullOrWhiteSpace(tn2.Text);

                if (tieneNum2)
                {
                    num2 = Convert.ToDouble(tn2.Text);
                }

                double resultado = 0;


                if (chkSuma.Checked)
                {
                    if (!tieneNum2) { lresultado.Text = "Ingrese el segundo número para sumar."; return; }
                    resultado = num1 + num2;
                }
                else if (chkResta.Checked)
                {
                    if (!tieneNum2) { lresultado.Text = "Ingrese el segundo número para restar."; return; }
                    resultado = num1 - num2;
                }
                else if (chkMultiplicacion.Checked)
                {
                    if (!tieneNum2) { lresultado.Text = "Ingrese el segundo número para multiplicar."; return; }
                    resultado = num1 * num2;
                }
                else if (chkDivision.Checked)
                {
                    if (!tieneNum2) { lresultado.Text = "Ingrese el segundo número para dividir."; return; }
                    if (num2 == 0)
                    {
                        lresultado.Text = "Error: No se puede dividir entre cero.";
                        return;
                    }
                    resultado = num1 / num2;
                }
                else if (chkPotencia2.Checked)
                {
                    resultado = Math.Pow(num1, 2); 
                }
                else if (chkExpo.Checked)
                {
                    if (!tieneNum2) { lresultado.Text = "Ingrese el exponente en el segundo campo."; return; }
                    resultado = Math.Pow(num1, num2); 
                }
                else
                {
                    lresultado.Text = "Por favor, seleccione una opción.";
                    return;
                }

                lresultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                lresultado.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }
    }
}