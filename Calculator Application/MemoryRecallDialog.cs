using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator_Application
{
    public partial class MemoryRecallDialog : Form
    {
        public string SelectedVariable { get; private set; } = "";

        public MemoryRecallDialog(Dictionary<string, double> memory)
        {
            InitializeComponent();
            
            // Populate listbox with variable names and values
            foreach (var kvp in memory.OrderBy(x => x.Key))
            {
                lstVariables.Items.Add($"{kvp.Key} = {kvp.Value}");
            }
            
            if (lstVariables.Items.Count > 0)
            {
                lstVariables.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstVariables.SelectedItem != null)
            {
                string? selected = lstVariables.SelectedItem.ToString();
                if (selected != null)
                {
                    int equalsIndex = selected.IndexOf(" = ");
                    if (equalsIndex > 0)
                    {
                        SelectedVariable = selected.Substring(0, equalsIndex);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lstVariables_DoubleClick(object sender, EventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void lstVariables_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }
    }
}

