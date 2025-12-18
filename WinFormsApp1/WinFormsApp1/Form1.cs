using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        string archivo = "contactos.txt";
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            string contacto = txtNombre.Text + "|" +
                              txtTelefono.Text + "|" +
                              txtDireccion.Text + "|" +
                              txtInstagram.Text + "|" +
                              txtFacebook.Text + "|" +
                              txtLinkedIn.Text;

            File.AppendAllText(archivo, contacto + Environment.NewLine);
            MessageBox.Show("Contacto guardado");

            Limpiar();
            CargarGrid();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivo))
            {
                MessageBox.Show("No hay registros");
                return;
            }

            var lineas = File.ReadAllLines(archivo);
            var contacto = lineas.FirstOrDefault(l => l.StartsWith(txtNombre.Text + "|"));

            if (contacto != null)
            {
                var datos = contacto.Split('|');

                txtNombre.Text = datos[0];
                txtTelefono.Text = datos[1];
                txtDireccion.Text = datos[2];
                txtInstagram.Text = datos[3];
                txtFacebook.Text = datos[4];
                txtLinkedIn.Text = datos[5];
            }
            else
            {
                MessageBox.Show("Contacto no encontrado");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtInstagram.Clear();
            txtFacebook.Clear();
            txtLinkedIn.Clear();
        }

        // ====== DATAGRIDVIEW ======

        void CargarGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Telefono", "Teléfono");
            dataGridView1.Columns.Add("Direccion", "Dirección");
            dataGridView1.Columns.Add("Instagram", "Instagram");
            dataGridView1.Columns.Add("Facebook", "Facebook");
            dataGridView1.Columns.Add("LinkedIn", "LinkedIn");

            if (!File.Exists(archivo)) return;

            var lineas = File.ReadAllLines(archivo);

            foreach (var linea in lineas)
            {
                var datos = linea.Split('|');
                if (datos.Length == 6)
                    dataGridView1.Rows.Add(datos);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtNombre.Text = row.Cells[0].Value.ToString();
            txtTelefono.Text = row.Cells[1].Value.ToString();
            txtDireccion.Text = row.Cells[2].Value.ToString();
            txtInstagram.Text = row.Cells[3].Value.ToString();
            txtFacebook.Text = row.Cells[4].Value.ToString();
            txtLinkedIn.Text = row.Cells[5].Value.ToString();
        }

        private void txtEliminarcontacto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto para eliminar");
                return;
            }

            string nombre = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult r = MessageBox.Show(
                "¿Seguro que desea eliminar este contacto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r != DialogResult.Yes) return;

            if (!File.Exists(archivo)) return;

            var lineas = File.ReadAllLines(archivo).ToList();

            lineas.RemoveAll(l => l.StartsWith(nombre + "|"));

            File.WriteAllLines(archivo, lineas);

            MessageBox.Show("Contacto eliminado");

            Limpiar();
            CargarGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

    



