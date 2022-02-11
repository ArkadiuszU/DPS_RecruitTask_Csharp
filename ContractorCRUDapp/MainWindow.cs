using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractorCRUDapp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddEditWindow form = new AddEditWindow();
            form.ShowDialog(this);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            AddEditWindow form = new AddEditWindow();
            form.ShowDialog(this);
        }
    }
}
