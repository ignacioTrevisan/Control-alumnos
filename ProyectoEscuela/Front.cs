using EntidadPermiso;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoEscuela
{
    public partial class Front : Form
    {
        string cargo = "";
        public Front()
        {
            InitializeComponent();
             
        }

        private void btn_nuevoAlumno_Click(object sender, EventArgs e)
        {
            if (cargo == "profesor")
            {
                NuevoAlumno formulario = new NuevoAlumno();
                formulario.ShowDialog();
            }
            else 
            {
                MessageBox.Show("No posee permisos para acceder a este area ");
            }
        }

        private void btn_asistencias_Click(object sender, EventArgs e)
        {
            if (cargo == "profesor")
            {
                TomarAsistencia formulario = new TomarAsistencia();
                formulario.ShowDialog();
            }
            else 
            {
                MessageBox.Show("No posee permisos para acceder a este area ");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Permisos p = new Permisos();
            p.dni = Convert.ToDouble(txt_user.Text);
            p.pass = txt_pass.Text;
            buscarcargo(p);
            cargo = p.Desc;
        }
        public void buscarcargo(Permisos p)
        {

            int idEmp = NegocioAlumnos.buscarCargo(p);
            if (p.Desc == "profesor")
            {
                MessageBox.Show("Usted ha iniciado como " + p.Desc);
            }
            else
            { 
                MessageBox.Show("No se ha encontrado registro de un cargo con el dni " + p.dni+ "o la contraseña es incorrecta");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            consulta f = new consulta();
            f.ShowDialog();
        }
    }
}
