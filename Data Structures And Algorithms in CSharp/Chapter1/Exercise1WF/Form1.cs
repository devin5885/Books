using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1WF
{
    using System.Collections;

    public partial class Form1 : Form
    {
        private BindingList<Test> submittedTests = new BindingList<Test>();
        private BindingList<Test> outForChecking = new BindingList<Test>();

        public Form1()
        {
            InitializeComponent();
            dataGridViewSubmitted.DataSource = submittedTests;
            dataGridViewOutTests.DataSource = outForChecking;
        }

        private void btnTurnInTest_Click(object sender, EventArgs e)
        {
            // Error handling.
            if (textBoxTestNumber.Text.Length == 0)
            {
                MessageBox.Show("Invalid Test Number.");
                return;
            }

            // Build test.
            var test = new Test()
                {
                    StudentName = textBoxName.Text,
                    TestNumber = Convert.ToInt32(textBoxTestNumber.Text)
                };

            // Add.
            submittedTests.Add(test);

            // Clear fields.
            textBoxName.Clear();
            textBoxTestNumber.Clear();
        }

        private void btnLookAtTest_Click(object sender, EventArgs e)
        {
            // Error handling.
            if (textBoxTestNumber.Text.Length == 0)
            {
                MessageBox.Show("Invalid Test Number.");
                return;
            }

            // Build test to find.
            var testToFind = new Test()
            {
                StudentName = textBoxName.Text,
                TestNumber = Convert.ToInt32(textBoxTestNumber.Text)
            };

            // Remove.
            var index = submittedTests.IndexOf(testToFind);

            //  Error handling.
            if (index == -1)
            {
                MessageBox.Show("Student name/test name not found.");
                return;
            }

            // Look at test.
            submittedTests.RemoveAt(index);

            // Add to out for checking.
            outForChecking.Add(testToFind);
        }

        private void btnReturnTest_Click(object sender, EventArgs e)
        {
            // Error handling.
            if (textBoxTestNumber.Text.Length == 0)
            {
                MessageBox.Show("Invalid Test Number.");
                return;
            }

            // Build test to find.
            var testToFind = new Test()
            {
                StudentName = textBoxName.Text,
                TestNumber = Convert.ToInt32(textBoxTestNumber.Text)
            };

            // Remove.
            var index = outForChecking.IndexOf(testToFind);

            //  Error handling.
            if (index == -1)
            {
                MessageBox.Show("Student name/test name not found.");
                return;
            }

            // Remove.
            outForChecking.RemoveAt(index);

            // Add.
            submittedTests.Add(testToFind);

            // Clear.
            textBoxName.Clear();
            textBoxTestNumber.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Add all to submitted.
            foreach (var test in outForChecking)
                submittedTests.Add(test);

            // Remove from out for checking.
            outForChecking.Clear();

            // Clear list.
            submittedTests.Clear();

            // Clear.
            textBoxName.Clear();
            textBoxTestNumber.Clear();
        }

        private void textBoxTestNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
