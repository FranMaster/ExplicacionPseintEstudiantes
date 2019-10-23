using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJEMPLO
{
    public partial class Form1 : Form
    {
        List<Alumno> BaulAlumnos = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Alumno alumnoN = new Alumno();
            alumnoN.Dni = int.Parse(TxtDni.Text);
            alumnoN.Nombre = TxtNombre.Text;
            alumnoN.Apellido = TxtApellido.Text;
            BaulAlumnos.Add(alumnoN);
            ListaAlumnosVisual.DataSource = null;
            ListaAlumnosVisual.DataSource = BaulAlumnos;
        }

        private void BtnEliminarPrimero_Click(object sender, EventArgs e)
        {
            BaulAlumnos.RemoveAt(0);
            ListaAlumnosVisual.DataSource = null;
            ListaAlumnosVisual.DataSource = BaulAlumnos;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BaulAlumnos.RemoveAt(BaulAlumnos.Count-1);
            ListaAlumnosVisual.DataSource = null;
            ListaAlumnosVisual.DataSource = BaulAlumnos;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BaulAlumnos.Count; i++)
            {
                if (BaulAlumnos[i].Dni==int.Parse(TxtSearch.Text))
                {
                    TxtNombre.Text = BaulAlumnos[i].Nombre;
                    TxtApellido.Text = BaulAlumnos[i].Apellido;
                    TxtDni.Text = BaulAlumnos[i].Dni.ToString();
                }
            }
        }

        private void BtnEliminarUnico_Click(object sender, EventArgs e)
        {
            int position = -1;
            for (int i = 0; i < BaulAlumnos.Count; i++)
            {
                if (BaulAlumnos[i].Dni == int.Parse(TxtSearch.Text))
                {
                    position = i;
                }
            }
            if (position>-1)
            {
                BaulAlumnos.RemoveAt(position);
            }
            ListaAlumnosVisual.DataSource = null;
            ListaAlumnosVisual.DataSource = BaulAlumnos;
        }
    }
}
