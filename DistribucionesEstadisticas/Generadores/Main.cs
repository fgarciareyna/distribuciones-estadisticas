using System;
using System.Windows.Forms;

namespace Generadores
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_pro_Click(object sender, EventArgs e)
        {
            Tp1 generador = new Tp1();
            generador.Show();
        }
    }
}
