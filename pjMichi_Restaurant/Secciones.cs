using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjMichi_Restaurant
{
    public partial class Secciones : Form
    {
        public Secciones()
        {
            InitializeComponent();
        }

        private void Secciones_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
                DialogResult r = MessageBox.Show("¿Está seguro de volver a la pagina anterior?", "Regresar",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                    this.Close();
            
        }
    }
}
