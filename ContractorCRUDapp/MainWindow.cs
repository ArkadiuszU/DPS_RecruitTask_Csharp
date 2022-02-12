using ContractorCRUDapp.Entities;
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
        private int _secectedId;
        
        public MainWindow(ICrudService crudServices)
        {
            _crudService = crudServices;
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
            AddEditWindow form = new AddEditWindow(_crudService, new Contractor(), WindowType.Add , () => { _secectedId = 0; UpdateContractorsList(); this.edit_button.Enabled = false; this.delete_button.Enabled = false; });
            form.ShowDialog(this);
            
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

            AddEditWindow form = new AddEditWindow(_crudService, _crudService.GetContractorById(_secectedId), WindowType.Edit, () => { _secectedId = 0; UpdateContractorsList(); this.edit_button.Enabled = false; this.delete_button.Enabled = false; } );
            form.ShowDialog(this);
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateContractorsList();
        }

        private void UpdateContractorsList()
        {
            this.table_panel.Controls.Clear();
            int nextPosition = 5;
            foreach (var item in _crudService.GetAllContractors())
            {
                ContractorUserControl contractorUC = new ContractorUserControl(item,
                    id =>
                    {
                        this.edit_button.Enabled = true;
                        this.delete_button.Enabled = true;
                        _secectedId = id;
                        UpdateContractorsList();
                    })
                {
                    Location = new Point(5, nextPosition),
                    AutoSize = true,
                    BackColor = (_secectedId == item.Id) ? Color.Red : Color.Silver
            };

                this.table_panel.Controls.Add(contractorUC);
                nextPosition += contractorUC.Height + 5;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            _crudService.DeleteContractorById(_secectedId);
            UpdateContractorsList();
        }
    }
}
