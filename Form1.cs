using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SistemasUsuarios
{
    public partial class Form1 : Form
    {
        private readonly Conexion_base_datos db =
            new Conexion_base_datos();
        private string usuarioOriginal = "";
        private string claveOriginal = "";
        private string nombreOriginal = "";
        private string direccionOriginal = "";
        private string telefonoOriginal = "";
        private const string tabla =
            "dbo.Usuarios_Usss039026";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                DataSet ds = db.crearDs();
                dgvUsuarios.DataSource = ds.Tables["usuarios"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;

            if (usuario.Length < 6 || usuario.Length > 16)
            {
                MessageBox.Show(
                    "El usuario debe tener entre 6 y 16 caracteres.");
                return false;
            }

            if (!clave.Any(char.IsLetter) ||
                !clave.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "La clave debe contener letras y números.");
                return false;
            }

            if (clave != txtConfirmarClave.Text)
            {
                MessageBox.Show("Las claves no coinciden.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Completa todos los campos.");
                return false;
            }

            if (txtTelefono.Text.Trim().Length > 9)
            {
                MessageBox.Show(
                    "El teléfono no puede superar 9 caracteres.");
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarClave.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                string sqlExiste = $@"
            SELECT COUNT(*) FROM {tabla}
            WHERE usuario = @usuario";

                SqlParameter[] parametrosExiste =
                {
            new SqlParameter("@usuario", txtUsuario.Text.Trim())
        };

                using (SqlConnection cn = new SqlConnection(
                    @"Server=FREDY\SQLEXPRESS04;Database=SistemaUsuariosDB;Trusted_Connection=True;TrustServerCertificate=True;"))
                using (SqlCommand cmd = new SqlCommand(sqlExiste, cn))
                {
                    cmd.Parameters.AddRange(parametrosExiste);
                    cn.Open();

                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Ese usuario ya existe. Elegí otro.");
                        return;
                    }
                }

                string sql = $@"
            INSERT INTO {tabla}
            (usuario, clave, nombre, [dirección], [teléfono])
            VALUES (@usuario, @clave, @nombre, @direccion, @telefono)";

                SqlParameter[] p =
                {
            new SqlParameter("@usuario", txtUsuario.Text.Trim()),
            new SqlParameter("@clave", txtClave.Text),
            new SqlParameter("@nombre", txtNombre.Text.Trim()),
            new SqlParameter("@direccion", txtDireccion.Text.Trim()),
            new SqlParameter("@telefono", txtTelefono.Text.Trim())
        };

                db.mantenimiento_usuarios_Usss039026(sql, p);
                CargarUsuarios();
                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarClave.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Selecciona un usuario y completa todos los campos.");
                return;
            }

            if (!ValidarCampos()) return;

            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("Selecciona un usuario de la tabla.");
                return;
            }
            if (txtUsuario.Text.Trim() == usuarioOriginal &&
    txtClave.Text == claveOriginal &&
    txtNombre.Text.Trim() == nombreOriginal &&
    txtDireccion.Text.Trim() == direccionOriginal &&
    txtTelefono.Text.Trim() == telefonoOriginal)
            {
                MessageBox.Show("Selecciona un campo a modificar.");
                return;
            }
            string sqlExiste = $@"
    SELECT COUNT(*) FROM {tabla}
    WHERE usuario = @usuario
    AND idUsuario <> @id";

            SqlParameter[] parametrosExiste =
            {
    new SqlParameter("@usuario", txtUsuario.Text.Trim()),
    new SqlParameter("@id", id)
};

            using (SqlConnection cn = new SqlConnection(
                @"Server=FREDY\SQLEXPRESS04;Database=SistemaUsuariosDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            using (SqlCommand cmd = new SqlCommand(sqlExiste, cn))
            {
                cmd.Parameters.AddRange(parametrosExiste);
                cn.Open();

                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show(
                        "Ese nombre de usuario ya pertenece a otro registro. Elegí otro.");
                    return;
                }
            }
            try
            {
                string sql = $@"UPDATE {tabla}
            SET usuario=@usuario, clave=@clave,
                nombre=@nombre, [dirección]=@direccion,
                [teléfono]=@telefono
            WHERE idUsuario=@id";

                SqlParameter[] p =
                {
            new SqlParameter("@usuario", txtUsuario.Text.Trim()),
            new SqlParameter("@clave", txtClave.Text),
            new SqlParameter("@nombre", txtNombre.Text.Trim()),
            new SqlParameter("@direccion", txtDireccion.Text.Trim()),
            new SqlParameter("@telefono", txtTelefono.Text.Trim()),
            new SqlParameter("@id", id)
        };

                int filas = db.mantenimiento_usuarios_Usss039026(sql, p);

                if (filas > 0)
                {
                    CargarUsuarios();
                    MessageBox.Show("Usuario modificado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            if (MessageBox.Show(
                "¿Eliminar este usuario?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string sql = $"DELETE FROM {tabla} WHERE idUsuario=@id";

                SqlParameter[] p =
                {
                    new SqlParameter("@id", id)
                };

                db.mantenimiento_usuarios_Usss039026(sql, p);

                CargarUsuarios();
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void MostrarUsuario()
        {
            if (dgvUsuarios.CurrentRow == null ||
                dgvUsuarios.CurrentRow.IsNewRow)
                return;

            DataGridViewRow fila = dgvUsuarios.CurrentRow;

            txtIdUsuario.Text =
                Convert.ToString(fila.Cells["idUsuario"].Value);

            txtUsuario.Text =
                Convert.ToString(fila.Cells["usuario"].Value);

            txtClave.Text =
                Convert.ToString(fila.Cells["clave"].Value);

            txtConfirmarClave.Text = txtClave.Text;

            txtNombre.Text =
                Convert.ToString(fila.Cells["nombre"].Value);

            txtDireccion.Text =
                Convert.ToString(fila.Cells["dirección"].Value);

            txtTelefono.Text =
                Convert.ToString(fila.Cells["teléfono"].Value);

            usuarioOriginal = txtUsuario.Text;
            claveOriginal = txtClave.Text;
            nombreOriginal = txtNombre.Text;
            direccionOriginal = txtDireccion.Text;
            telefonoOriginal = txtTelefono.Text;
        }

        private void dgvUsuarios_SelectionChanged(
            object sender, EventArgs e)
        {
            MostrarUsuario();
        }

        private void dgvUsuarios_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            MostrarUsuario();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                dgvUsuarios.ClearSelection();
                dgvUsuarios.CurrentCell = dgvUsuarios.Rows[0].Cells[0];
                MostrarUsuario();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            int i = dgvUsuarios.CurrentRow.Index;

            if (i > 0)
            {
                dgvUsuarios.CurrentCell = dgvUsuarios.Rows[i - 1].Cells[0];
                MostrarUsuario();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            int i = dgvUsuarios.CurrentRow.Index;
            int total = dgvUsuarios.Rows
                .Cast<DataGridViewRow>()
                .Count(fila => !fila.IsNewRow);

            if (i < total - 1)
            {
                dgvUsuarios.CurrentCell = dgvUsuarios.Rows[i + 1].Cells[0];
                MostrarUsuario();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            int total = dgvUsuarios.Rows
                .Cast<DataGridViewRow>()
                .Count(fila => !fila.IsNewRow);

            if (total > 0)
            {
                dgvUsuarios.CurrentCell = dgvUsuarios.Rows[total - 1].Cells[0];
                MostrarUsuario();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

            dgvUsuarios.ClearSelection();
        }
    }
}