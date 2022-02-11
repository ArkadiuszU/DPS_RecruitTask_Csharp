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
        private Action<string> _messageTarget;
        public ContractorUserControl(Contractor ob, Action<string> messageTarget)
        {
            InitializeComponent();
            this.label1.Text = ob.Name;
            _messageTarget = messageTarget;
        }

  

        private void ContractorUserControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.Cursor = Cursors.Hand;
        }

        private void ContractorUserControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            this.Cursor = Cursors.Default;
        }


        private void ContractorUserControl_Click(object sender, EventArgs e)
        {
            _messageTarget("a");
        }
    }
}
