using CSSBlockageLibrary;
using CSSBlockageLibrary.DataAccess;
using CSSBlockageLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ServiceRequestValue_TextChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex == 0)
            {
                IsItACritSit.Checked = true;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BlockageTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex == -1)
            {
                BlockageSubTypeComboBox.Items.Clear();
            }
            else
            {
                BlockageSubTypeComboBox.Items.Clear();
                BlockageSubTypeComboBox.Items.AddRange(BlockEntryConfig.SubBlockTypeSelection(BlockageTypeComboBox.Text));
            }

        }

        private void BlockageSubTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                  
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                BlockEntryModel model = new BlockEntryModel(ServiceRequestValue.Text, IsItACritSit.Checked, StatusComboBox.Text, BlockageTypeComboBox.Text, BlockageSubTypeComboBox.Text, CommentBox.Text);

                foreach (IDataConnection db in BlockEntryConfig.Connections)
                {
                    try
                    {
                        db.SaveEntry(model);

                        submitStatusLabel.ForeColor = System.Drawing.Color.Green;
                        submitStatusLabel.Text = "Submission Completed";

                    }
                    //catch(Exception)
                    //{
                    //    submitStatusLabel.ForeColor = System.Drawing.Color.Red;
                    //    submitStatusLabel.Text = "Error: Submission Failure";
                    //}
                    finally
                    {
                        submitStatusLabel.ForeColor = System.Drawing.Color.Black;
                        submitStatusLabel.Text = "Submission Completed";
                    }
                }
            }
            else
            {
                submitStatusLabel.ForeColor = System.Drawing.Color.Red;
                submitStatusLabel.Text = "Error: Validation Failure";
            }

            //Clear form after submit
            

            //if (IsItACritSit.Checked == true)
            //{
            //    submitStatusLabel.ForeColor = System.Drawing.Color.Green;
            //    submitStatusLabel.Text = "Submission Completed";
            //}
            //else
            //{
            //    submitStatusLabel.ForeColor = System.Drawing.Color.Red;
            //    submitStatusLabel.Text = "Error";
            //}

            ServiceRequestValue.Text = "";
            StatusComboBox.SelectedIndex = -1;
            BlockageSubTypeComboBox.Items.Clear();
            BlockageTypeComboBox.SelectedIndex = -1;
            IsItACritSit.Checked = false;
        }


        private new bool Validate()
        {
            bool output = false;

            if (ServiceRequestValue.TextLength > 0)
            {
                if (ServiceRequestValue.TextLength == 15)
                {
                    output = true;
                }

            }

            return output;
        }

        private void IsItACritSit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ServiceRequestValue.Text = "";
            StatusComboBox.SelectedIndex = -1;
            BlockageSubTypeComboBox.Items.Clear();
            BlockageTypeComboBox.SelectedIndex = -1;
            IsItACritSit.Checked = false;

            submitStatusLabel.ForeColor = System.Drawing.Color.Black;
            submitStatusLabel.Text = "Form Cleared";


        }

        private void CommentBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
