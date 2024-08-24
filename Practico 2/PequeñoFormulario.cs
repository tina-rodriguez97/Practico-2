using System.Text.RegularExpressions;

namespace Practico_2
{
    public partial class PequeñoFormulario : Form
    {
        public PequeñoFormulario()
        {
            InitializeComponent();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string errores = "";
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();

            // Verificar si todos los campos están completos
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido))
            {
                errores += "Debe completar todos los campos.\n";
            }
            else
            {
                // Validar DNI
                if (!Regex.IsMatch(txtDNI.Text, @"^\d+$"))
                {
                    errores += "El campo DNI solo permite números.\n";
                }

                // Validar Nombre
                if (!Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
                {
                    errores += "El campo Nombre solo permite letras.\n";
                }

                // Validar Apellido
                if (!Regex.IsMatch(apellido, @"^[a-zA-Z\s]+$"))
                {
                    errores += "El campo Apellido solo permite letras.\n";
                }
            }

            // Actualizar el label "modificar" con los campos que se han completado
            lblModificar.Text = string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(apellido)
                ? "modificar"
                : $"{nombre} {apellido}".Trim();

            // Mostrar los errores si existen
            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Si hay errores, no continuar con la inserción
            }

            // Mostrar la ventana de confirmación
            DialogResult result = MessageBox.Show(
                "¿Seguro que desea insertar un nuevo cliente?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1); // Button1 pone el foco en "Sí"

            // Si el usuario selecciona "Sí"
            if (result == DialogResult.Yes)
            {
                string nombreCompleto = $"{nombre} {apellido}".Trim();

                // Mostrar el mensaje de que el cliente se insertó correctamente
                MessageBox.Show(
                    $"El cliente '{nombreCompleto}' se insertó correctamente.",
                    "Cliente Insertado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = $"{txtNombre.Text} {txtApellido.Text}";

            // Mostrar la ventana de confirmación para eliminar
            DialogResult result = MessageBox.Show(
                $"Está a punto de eliminar al cliente: {nombreCompleto}",
                "Confirmación de Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); // Button2 pone el foco en "No"

            // Si el usuario selecciona "Sí"
            if (result == DialogResult.Yes)
            {
                // Mostrar el mensaje de que el cliente se eliminó correctamente
                MessageBox.Show(
                    $"El cliente '{nombreCompleto}' se eliminó correctamente.",
                    "Cliente Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }  
    }
}
