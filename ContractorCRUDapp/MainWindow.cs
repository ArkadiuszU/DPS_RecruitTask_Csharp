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
        private  IEnumerable<Contractor> _contractors = new List<Contractor>();
        private IEnumerable<ContractorType> _contractorsType = new List<ContractorType>();
        public MainWindow(ICrudService crudServices)
        {
            _crudService = crudServices;
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
            AddEditWindow form = new AddEditWindow(_crudService, new Contractor(), WindowType.Add , () => { _secectedId = 0; UpdateContractorsList(true); this.edit_button.Enabled = false; this.delete_button.Enabled = false; });
            form.ShowDialog(this);
            
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

            AddEditWindow form = new AddEditWindow(_crudService, _crudService.GetContractorById(_secectedId), WindowType.Edit, () => { _secectedId = 0; UpdateContractorsList(true); this.edit_button.Enabled = false; this.delete_button.Enabled = false; } );
            form.ShowDialog(this);
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateContractorsList(true);
        }

        private void UpdateContractorsList(bool deepUpdate)
        {
            int nextPosition = 5;
            if (deepUpdate)
            {
                _contractors = _crudService.GetAllContractors();
                _contractorsType = _crudService.GetContractorTypes();
            }

            this.table_panel.Controls.Clear();
            foreach (var item in _contractors)
            {
                item.ContractorType = _contractorsType.FirstOrDefault(ct => ct.Id == item.ContractorTypeId);
                ContractorUserControl contractorUC = new ContractorUserControl(item,
                    id =>
                    {
                        this.edit_button.Enabled = true;
                        this.delete_button.Enabled = true;
                        _secectedId = id;
                        UpdateContractorsList(false);
                    })
                {
                    Location = new Point(5, nextPosition),
                    AutoSize = true,
                    BackColor = (_secectedId == item.Id) ? Color.Silver : Color.Gainsboro
                };

                this.table_panel.Controls.Add(contractorUC);
                nextPosition += contractorUC.Height + 10;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            _crudService.DeleteContractorById(_secectedId);
            UpdateContractorsList(true);
            this.edit_button.Enabled = false; this.delete_button.Enabled = false;
        }
    }
}
