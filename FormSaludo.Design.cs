
using System.Drawing;
using System.Windows.Forms;

namespace FormSaludoG3_2021_2
{
    partial class FormSaludo:Form
    {
        private Label etIntroduceNombre;
        private TextBox txtbNombre;
        private Button btnAceptar;
        private Button btnLimpiar;


        private void IniciarComponentes()
        {
            this.Size = new Size(400,300);
            this.Text = "FormSaludo";
            this.StartPosition = FormStartPosition.CenterScreen;

            //Preparar al atributo del formulario
            etIntroduceNombre = new Label();
            etIntroduceNombre.Text = "Introduce tu nombre";
            //Definiendo la posición del elemento en Point(x,y)
            etIntroduceNombre.Location = new Point(100,100);
            //Definiendo el tamaño del elemento en Size(Largo, ancho)
            etIntroduceNombre.Size = new Size(200, 25);

            //Introducir Texto
            txtbNombre = new TextBox();
            txtbNombre.Location = new Point(100, 150);
            txtbNombre.Size = new Size(225, 25);


            //Agregando un elemento que aparezca en el formulario
            this.Controls.Add(etIntroduceNombre);
            this.Controls.Add(txtbNombre);
        }



    }
}
