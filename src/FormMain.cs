using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EAObfuscation
{
    internal partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            listBoxTarget.Items.Clear();
            foreach(string categoryDescription in Rules.RuleCategoryDescriptions)
            {
                listBoxTarget.Items.Add(categoryDescription);
            }

            changeCheckStatus(true);
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Enterprise Architect Project(*.eap;*.eapx)|*.eap;*.eapx";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            textBoxFile.Text = ofd.FileName;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            List<bool> target = new List<bool>();
            for (int i = 0; i < listBoxTarget.Items.Count; i++)
            {
                target.Add(listBoxTarget.GetItemChecked(i));
            }

            Obfuscation obfuscation = new Obfuscation(textBoxFile.Text);
            if (!obfuscation.Execute(target))
            {
                buttonRun.Enabled = true;
                return;
            }

            Close();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            changeCheckStatus(true);
        }

        private void buttonNone_Click(object sender, EventArgs e)
        {
            changeCheckStatus(false);
        }

        private void changeCheckStatus(bool status)
        {
            for (int i = 0; i < listBoxTarget.Items.Count; i++)
            {
                listBoxTarget.SetItemChecked(i, status);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
