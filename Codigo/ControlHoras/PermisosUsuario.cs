using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
namespace ControlHoras
{
    public partial class PermisosUsuario : Form
    {
        IDatosABMTipos datosabm;
        string UserName;
        public PermisosUsuario()
        {
            InitializeComponent();
            try
            {
                datosabm = DatosABMTipos.getInstance();
                ucPermisosUsuarios1.cargarDatos();
            }
            catch
            {
                throw;
            }
        }

        public PermisosUsuario(string userName)
        {
            InitializeComponent();
            try
            {
                UserName = userName;
                datosabm = DatosABMTipos.getInstance();
                ucPermisosUsuarios1.cargarDatos();
            }
            catch
            {
                throw;
            }
        }

        private void PermisosUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                
                Dictionary<int,List<int>> listaPermisos = datosabm.obtenerPermisosUsuario(UserName);
                ucPermisosUsuarios1.checkItems(listaPermisos);
            }
            catch
            {
                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<int, List<int>> listaPermisos = ucPermisosUsuarios1.obtenerPantallasYControlesSeleccionados();
                datosabm.modificarPermisosUsuario(UserName, listaPermisos);
                MessageBox.Show(this, "Permisos guardados correctamente.", "Permisos", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Error al guardar los permisos.\n"+ex.Message, "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
