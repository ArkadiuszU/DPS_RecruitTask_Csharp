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
    public enum WindowType { Add, Edit};
    public partial class AddEditWindow : Form
    {
        private ICrudService _crudService;
        private Contractor _contractor;
        private WindowType _windowType;
        private Action _update;
        public AddEditWindow(ICrudService crudServices, Contractor contractor, WindowType windowType, Action update)
        {
            _crudService = crudServices;
            _contractor = contractor;
            _windowType = windowType;
            _update = update;
            InitializeComponent();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            _contractor.Name = this.name_textBox.Text;
            _contractor.NipNumber = this.nipNumber_textBox.Text;
            _contractor.Details = this.details_textBox.Text;
            _contractor.IsActive = this.active_checkBox.Checked;
            _contractor.ContractorTypeId = this.type_comboBox.SelectedIndex + 1 ;


            if (String.IsNullOrEmpty(_contractor.Name) || (_contractor.NipNumber.Length != 10))
            {
                this.error1_lb.Visible = (String.IsNullOrEmpty(_contractor.Name))?true:false;
                this.error2_lb.Visible = (_contractor.NipNumber.Length != 10) ? true : false;


            }
            else
            {
                if (_windowType == WindowType.Add)
                {
                    if (_crudService.AddContractor(_contractor))
                    {
                        this.Close();
                       
                    }
        
                }
                else
                {
                    _crudService.EditContractor(_contractor);
                    this.Close();
                }
            }


            
        }

        private void AddEditWindow_Load(object sender, EventArgs e)
        {
            var collection = _crudService.GetContractorTypes();
            foreach (var item in collection)
            {
                this.type_comboBox.Items.Add(item.Type);
            }
          
            this.name_textBox.Text = _contractor.Name;
            this.nipNumber_textBox.Text = _contractor.NipNumber;
            this.details_textBox.Text = _contractor.Details;
            this.active_checkBox.Checked = _contractor.IsActive;
            this.type_comboBox.SelectedItem = collection.FirstOrDefault(t => t.Id == _contractor.ContractorTypeId).Type;

        }

        private void AddEditWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _update();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            Label error_lb = new Label();

            if (tb == name_textBox)
                error_lb = this.error1_lb;
            else if (tb == nipNumber_textBox)
                error_lb = this.error2_lb;
            else if (tb == details_textBox)
                error_lb = this.error3_lb;


            if ((tb.Text.Length == tb.MaxLength))
            {
                error_lb.Visible = true;
            }
            
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            Label error_lb = new Label();

            if (tb == name_textBox)
                error_lb = this.error1_lb;
            else if (tb == nipNumber_textBox)
                error_lb = this.error2_lb;
            else if (tb == details_textBox)
                error_lb = this.error3_lb;

            if(tb == nipNumber_textBox)
            {
                if (tb.Text.Length != tb.MaxLength)
                {
                    error_lb.Visible = true;
                }
                else
                {
                    error_lb.Visible = false;
                }
            }
            else
            {
                if (tb.Text.Length < tb.MaxLength)
                {
                    error_lb.Visible = false;
                }
            }

            
            
    
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            Label error_lb = new Label();

            if (tb == name_textBox)
                error_lb = this.error1_lb;
            else if (tb == nipNumber_textBox)
                error_lb = this.error2_lb;
            else if (tb == details_textBox)
                error_lb = this.error3_lb;

            if (tb == nipNumber_textBox)
            {
                if (tb.Text.Length == tb.MaxLength)
                {
                    error_lb.Visible = false;
                }
            }
            else
            {
                if (tb.Text.Length <= tb.MaxLength)
                {
                    error_lb.Visible = false;
                }
                else
                {
                    error_lb.Visible = true;
                }
            }

            
            
        }
    }
}
