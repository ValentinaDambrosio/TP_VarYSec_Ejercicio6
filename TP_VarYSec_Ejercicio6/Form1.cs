using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio6
{
    public partial class fSala : Form
    {
        public fSala()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bOcupacion_Click(object sender, EventArgs e)
        {
            double cupoTotal = Convert.ToInt32(tCapacidad.Text);
            double cupoActual = Convert.ToInt32(tCupoActual.Text);
            double porcentaje = (cupoActual * 100) / cupoTotal;
            MessageBox.Show("Actualmente está la sala ocupada al " + porcentaje + "%");
        }

        private void bSalida_Click(object sender, EventArgs e)
        {
            string sCupo = tCupoActual.Text;
            int cupo = Convert.ToInt32(sCupo);
            cupo--;
            MessageBox.Show("Se retiró una persona, actualmente hay " + cupo + " personas");
        }

        private void bEntrada_Click(object sender, EventArgs e)
        {
            int cupo = Convert.ToInt32(tCupoActual.Text);
            cupo++;
            MessageBox.Show("Ingresó una persona, actualmente hay " + cupo + " personas");
        }
    }
}
