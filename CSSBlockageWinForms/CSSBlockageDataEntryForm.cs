using CSSBlockageLibrary;
using CSSBlockageLibrary.DataAccess;
using CSSBlockageLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSBlockageWinForms
{
    public partial class CSSBlockageDataEntryForm : Form
    {
        public CSSBlockageDataEntryForm()
        {
            InitializeComponent();
        }

        private void CSSBlockageDataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void BlockTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void CSSBlockageServiceRequestLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ServiceRequestValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BlockageTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BlockageSubTypeComboBox.Items.Clear();
            BlockageSubTypeComboBox.Items.AddRange(BlockEntryConfig.SubBlockTypeSelection(BlockageTypeComboBox.Text));
        }

        private void BlockageSubTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                BlockEntryModel model = new BlockEntryModel(ServiceRequestValue.Text, IsItACritSit.Checked, StatusComboBox.Text, BlockageTypeComboBox.Text, BlockageSubTypeComboBox.Text);

                foreach (IDataConnection db in BlockEntryConfig.Connections)
                {
                    db.SaveEntry(model);
                }
            }

            //Clear form after submit
            ServiceRequestValue.Text = "";
            StatusComboBox.Items.Clear();
            BlockageTypeComboBox.Items.Clear();
            BlockageSubTypeComboBox.Items.Clear();
            IsItACritSit.Checked = false;


        }


        private bool Validate()
        {
            bool output = false;
            var servicerequest = ServiceRequestValue;

            if (ServiceRequestValue.TextLength > 0)
            {
                if (ServiceRequestValue.TextLength == 15)
                {
                    output = true;
                }
                
            }

            
            
            if (BlockageSubTypeComboBox.Text.Length > 0)
            {
                output = true;
            }
            if (BlockageSubTypeComboBox.Text.Length > 0)
            {
                output = true;
            }

            return output;
        }

        private void IsItACritSit_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
