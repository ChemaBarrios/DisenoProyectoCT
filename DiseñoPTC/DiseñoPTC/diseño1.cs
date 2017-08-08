using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DiseñoPTC
{
    public partial class diseño1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public diseño1()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView1.QueryControl += tabbedView1_QueryControl;
        }

        // Assigning a required content for each auto generated Document
        void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {            
           // if (e.Control == null)
               // e.Control = new System.Windows.Forms.Control();
            
        }

        private void diseño1_Load(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.MdiParent = this;
            inicio.Show();
        }
    }
}