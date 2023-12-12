using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using ENTITIES;
using DESIGNER.Tools;
namespace DESIGNER
{
    public partial class frmPersona : Form
    {
        Personas persona = new Personas();
        Departamentos departamentos = new Departamentos();
        Provincias provincias = new Provincias();
        Distritos distritos = new Distritos();
        DataView dv;

        public frmPersona()
        {
            InitializeComponent();
        }
        private void actualizarperosnas()
        {
            gridpersonas.DataSource = persona.listar();
            gridpersonas.Refresh();
        }
        private void actualizarDepartamentos()
        {
            cboDepartamento.DataSource = departamentos.listar();
            cboDepartamento.Refresh();
            cboDepartamento.DisplayMember = "IdDepartamento		";
            cboDepartamento.ValueMember = "Nombre_Departamento";
            cboDepartamento.Refresh();
        }
       
        private void actualizardistritos()
        {
            
        }
        private void gridpersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            actualizarperosnas();
            actualizarDepartamentos();
            
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboprovincia.DataSource = provincias.listar();
            cboprovincia.Refresh();
            cboprovincia.DisplayMember = "Nombre_Provincia";
            cboprovincia.ValueMember = "IdDepartamento";
            cboprovincia.Refresh();
        }
    }
}
