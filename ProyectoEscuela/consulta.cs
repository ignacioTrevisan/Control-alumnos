using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEscuela
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
            mostrarAlumnos();
        }
        private void mostrarAlumnos()
        {
            DataTable dt = NegocioAlumnos.buscarinasistencias();
            dataGridView1.DataSource = dt;
            MessageBox.Show("hola");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // verificar si se hizo clic en una celda válida
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null) // verificar si la celda tiene algún valor
                {
                    string nombre = cell.Value.ToString();
                    MessageBox.Show("Hola " + nombre + "!");
                }
            }
        }
    }
}
