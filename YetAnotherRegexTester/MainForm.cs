using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace YetAnotherRegexTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (var value in Enum.GetValues(typeof(RegexOptions)))
            {
                regexOptionsComboBox.Items.Add(value);
            }
            regexOptionsComboBox.SelectedItem = RegexOptions.None;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Match();
        }

        private void Match()
        {
            try
            {
                RegexOptions options = RegexOptions.None;
                foreach (var checkBoxItem in regexOptionsComboBox.CheckBoxItems)
                {
                    if (checkBoxItem.Checked)
                        options |= (RegexOptions)Enum.Parse(typeof(RegexOptions), checkBoxItem.Text);
                }

                Regex regex = new Regex(regexTextBox.Text, options);
                MatchCollection matches = regex.Matches(inputDataTextBox.Text);
                string[] groupNames = regex.GetGroupNames();

                matchesTreeView.Nodes.Clear();
                foreach (Match match in matches)
                {
                    TreeNode node = matchesTreeView.Nodes.Add(match.Value);

                    if (groupNames.Length > 1)
                    {
                        for (int index = 1; index < groupNames.Length; index++)
                        {
                            string groupName = groupNames[index];
                            string text = groupName + ": " + match.Groups[groupName].Value;
                            node.Nodes.Add(text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Match();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if (regexTextBox.SelectionStart > 0)
                {
                    regexTextBox.Text = regexTextBox.Text.Insert(regexTextBox.SelectionStart, e.Node.Tag.ToString());
                }
                else
                {
                    regexTextBox.Text += e.Node.Tag;
                }
            }
            else
            {
                e.Node.Expand();
            }
        }
    }
}
