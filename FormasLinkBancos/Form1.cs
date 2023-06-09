using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasLinkBancos
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            listarDataGridView.DataSource = new AlunoDAO().Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarDataGridView.DataSource = new AlunoDAO().Listar2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listarDataGridView.DataSource = new AlunoDAO().Listar3();
        }
    }
    }

