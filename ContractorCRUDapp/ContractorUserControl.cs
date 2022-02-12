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
    public partial class ContractorUserControl : UserControl
    {
        private Action<int> _messageTarget;
        private int _contractorId;
        public ContractorUserControl(Contractor contractor, Action<int> messageTarget)
        {
            InitializeComponent();
            this.labelName.Text = contractor.Name;
            this.labelNip.Text = contractor.NipNumber;
            this.labelDetails.Text = contractor.Details;
            //this.labelType.Text = contractor.ContractorType.Type;
            this.labelActive.Text = (contractor.IsActive)? "Aktywny" : "Nieaktywny" ;

            _messageTarget = messageTarget;
            _contractorId = contractor.Id;
        }

  

        private void ContractorUserControl_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void ContractorUserControl_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        private void ContractorUserControl_Click(object sender, EventArgs e)
        {
            _messageTarget(_contractorId);
        }
    }
}
