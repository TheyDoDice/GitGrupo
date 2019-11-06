using System;
using System.Windows.Forms;

namespace SWComboFK
{
    public partial class SWComboFK : System.Windows.Forms.ComboBox
    {
        private string _ControlID;

        public string ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }

        public SWComboFK()
        {
            this.SuspendLayout();
            // 
            // SWComboFK
            // 
            this.SelectedValueChanged += new System.EventHandler(this.PassaValor);
            this.ResumeLayout(false);
        }

        private void PassaValor(object sender, EventArgs e)
        { 
            Form myForm = this.FindForm();

            foreach (Control ctr in myForm.Controls)
            {
                if (ctr.GetType()==typeof(GroupBox))
                {
                    foreach (Control ctr1 in ctr.Controls)
                    {
                        if (ctr1.Name == _ControlID)
                        {
                            ctr1.Text = this.SelectedIndex.ToString();
                        }
                    }
                }
                else if (ctr.Name == _ControlID)
                {
                    ctr.Text = this.SelectedIndex.ToString();
                }
            }
        }
    }
}
