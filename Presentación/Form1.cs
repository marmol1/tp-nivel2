﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            CatalogoNegocio negocio = new CatalogoNegocio();
            dgvArticulos.DataSource = negocio.Listar();
        }
    }
}
