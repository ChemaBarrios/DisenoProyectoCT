using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoPTC
{
    public partial class Conferencista : Form
    {
        public Conferencista()
        {
            InitializeComponent();
        }

        private void radioButtonAConf_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAConf.Checked == true)
            {
                comboBox1.Enabled = false;
                label1.Text = "Seleccion de conferencista para modificar o eliminar ";
                button1.Text = "Añadir conferencista";    
            }
        }

        private void radioButtonMConf_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMConf.Checked == true)
            {
                comboBox1.Enabled = true;
                label1.Text = "Seleccione conferencista a modificar";
                button1.Text = "Modificar datos de conferencista";
            }
        }

        private void radioButtonEConf_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEConf.Checked == true)
            {
                comboBox1.Enabled = true;
                label1.Text = "Seleccione conferencista a eliminar";
                button1.Text = "Eliminar conferencista";
            }
        }
    }
}
