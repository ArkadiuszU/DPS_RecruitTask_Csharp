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
        private ICrudService _crudService;
        
        public MainWindow(ICrudService crudServices)
        {
            _crudService = crudServices;
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

        private void MainWindow_Load(object sender, EventArgs e)
        {

            int nextPosition = 5;
            foreach (var item in _crudService.GetAllContractors())
            {
                ContractorUserControl contractorUC = new ContractorUserControl(item, s => this.title_lb.Text = s)
                {
                    Location = new Point(5, nextPosition),
                    AutoSize = true,
                };

                this.table_panel.Controls.Add(contractorUC);
                nextPosition += contractorUC.Height + 5;
            }
        }
    }
}
