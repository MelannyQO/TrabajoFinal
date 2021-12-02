using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeLogica;

namespace CapaDePresentacion
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            //Listar Clientes
            ListarUsuariosEF();
        }

        public UsuarioLogica usuario = new UsuarioLogica();

        #region ADO .NET

        public void ListarUsuarios()
        {
            dataGridViewUsuario.DataSource = usuario.ListarUsuarios();
        }

        private void buttonInsertarUsuario_Click(object sender, EventArgs e)
        {
            var nombre = txtNombres.Text;
            var apellido = txtApellido.Text;
            var tipoDocumento = txtTipoDoc.Text;
            var nDocumento = txtNDoc.Text;
            var fechaNacimiento = txtFecha.Text;
            var genero = txtGenero.Text;
            var correo = txtCorreo.Text;

            var mensaje = usuario.InsertarUsuario(nombre, apellido, tipoDocumento, nDocumento, fechaNacimiento, genero, correo);

            MessageBox.Show(mensaje);
            ListarUsuarios();
        }


        private void buttonActualizarUsuario_Click(object sender, EventArgs e)
        {
            var nombre = txtNombres.Text;
            var apellido = txtApellido.Text;
            var tipoDocumento = txtTipoDoc.Text;
            var nDocumento = txtNDoc.Text;
            var fechaNacimiento = txtFecha.Text;
            var genero = txtGenero.Text;
            var correo = txtCorreo.Text;

            var mensaje = usuario.ActualizarUsuario(nombre, apellido, tipoDocumento, nDocumento, fechaNacimiento, genero, correo);
            MessageBox.Show(mensaje);
            ListarUsuarios();
        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            var nDocumento = txtNDoc.Text;

            var mensaje = usuario.EliminarUsuario(nDocumento);

            MessageBox.Show(mensaje);
            ListarUsuarios();
        }
        #endregion




        #region Entity Framework
        public void ListarUsuariosEF()
        {
            dataGridViewUsuario.DataSource = usuario.ListarUsuariosEF();
        }

        private void buttonInsertarUsuarioEF_Click(object sender, EventArgs e)
        {
            var nombre = txtNombres.Text;
            var apellido = txtApellido.Text;
            var tipoDocumento = txtTipoDoc.Text;
            var nDocumento = txtNDoc.Text;
            var fechaNacimiento = txtFecha.Text;
            var genero = txtGenero.Text;
            var correo = txtCorreo.Text;

            var usuarioInsertado = usuario.InsertarUsuarioEF(nombre, apellido, tipoDocumento, nDocumento, fechaNacimiento, genero, correo);

            var mensaje = string.Empty;

            if (usuarioInsertado)
            {
                MessageBox.Show("Usuario insertado correctamente");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }

            MessageBox.Show(mensaje);
            ListarUsuarios();
        }

        private void buttonActualizarUsuarioEF_Click(object sender, EventArgs e)
        {
            var nombre = txtNombres.Text;
            var apellido = txtApellido.Text;
            var tipoDocumento = txtTipoDoc.Text;
            var nDocumento = txtNDoc.Text;
            var fechaNacimiento = txtFecha.Text;
            var genero = txtGenero.Text;
            var correo = txtCorreo.Text;

            var usuarioActualizado = usuario.ActualizarUsuarioEF(nombre, apellido, tipoDocumento, nDocumento, fechaNacimiento, genero, correo);
            if (usuarioActualizado)
            {
                MessageBox.Show("Usuario actualizado");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }

        }

        private void buttonEliminarUsuarioEF_Click(object sender, EventArgs e)
        {
            var nDocumento = txtNDoc.Text;
            var usuarioEliminado = usuario.EliminarUsuarioEf(nDocumento);
            if (usuarioEliminado)
            {
                MessageBox.Show("Usuario eliminado");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }

        }

        #endregion
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBoxCRUD_SP_Enter(object sender, EventArgs e)
        {

        }


    }

}
