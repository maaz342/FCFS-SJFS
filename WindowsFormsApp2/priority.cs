using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class priority : Form
    {
        public priority()
        {
            InitializeComponent();
        }

        private void priority_Load(object sender, EventArgs e)
        {

        }

        private void FCFS_Click(object sender, EventArgs e)
        {
            int desiredNumberOfInputs;

            if (!int.TryParse(txtNumberOfInputs.Text, out desiredNumberOfInputs))
            {
                MessageBox.Show("Invalid number of inputs.");
                return;
            }
            // Get the text from the multiline TextBox
            // Get the text from the multiline TextBox
            string inputText = txtInput.Text;
            string arrival = ARRIVAL.Text;
            string bur = BURST.Text;
            string pr = textBox5.Text;

            // Replace space with line break
            string[] lines = inputText.Split(' ');
            string filePath = textBox1.Text;
            if (lines.Length > desiredNumberOfInputs)
            {
                MessageBox.Show("Number of inputs exceeds the limit.");
                return;
            }
            else
            {

                try
                {
                    // Create the file and write the lines of text to it
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (string line in lines)
                        {
                            writer.WriteLine(line);
                        }
                    }

                    // Access the first element of the array
                    string firstElement = lines[0];
                    MessageBox.Show("First element: " + firstElement);


                    MessageBox.Show("File created successfully!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


            string[] arriva = arrival.Split(' ');
            List<int> values = new List<int>();

            for (int i = 0; i < arriva.Length; i++)
            {
                int value;
                if (int.TryParse(arriva[i], out value))
                {
                    values.Add(value);
                }
                else
                {
                    MessageBox.Show("Invalid input at index " + i + ". Please enter valid integer values.");
                    return;
                }
            }

            int[] valuearray = values.ToArray();
            if (valuearray.Length > desiredNumberOfInputs)
            {
                MessageBox.Show("Number of inputs exceeds the limit.");
                return;
            }
            else
            {

                string fileath = textBox2.Text;

                try
                {
                    // Create the file and write the lines of text to it
                    using (StreamWriter writer = new StreamWriter(fileath))
                    {
                        foreach (int line in valuearray)
                        {
                            writer.WriteLine(line);
                        }
                    }

                    // Access the first element of the array
                    int firstElement = valuearray[0];
                    MessageBox.Show("First element: " + firstElement);
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.Message);
                }
            }
            string[] bursat = bur.Split(' ');
            List<int> valuesa = new List<int>();

            for (int i = 0; i < bursat.Length; i++)
            {
                int value;
                if (int.TryParse(bursat[i], out value))
                {
                    valuesa.Add(value);
                }
                else
                {
                    MessageBox.Show("Invalid input at index " + i + ". Please enter valid integer values.");
                    return;
                }
            }


            int[] valuearraya = valuesa.ToArray();
            if (valuearray.Length > desiredNumberOfInputs)
            {
                MessageBox.Show("Number of inputs exceeds the limit.");
                return;
            }
            else
            {
                string filepatha = textBox3.Text;

                try
                {
                    // Create the file and write the lines of text to it
                    using (StreamWriter writer = new StreamWriter(filepatha))
                    {
                        foreach (int line in valuearraya)
                        {
                            writer.WriteLine(line);
                        }
                    }

                    // Access the first element of the array
                    int firstElement = valuearraya[0];
                    MessageBox.Show("First element: " + firstElement);
                }
                catch (Exception eab)
                {
                    MessageBox.Show(eab.Message);
                }

            }
            string[] prio = pr.Split(' ');
            List<int> pri = new List<int>();

            for (int i = 0; i < prio.Length; i++)
            {
                int value;
                if (int.TryParse(prio[i], out value))
                {
                    valuesa.Add(value);
                }
                else
                {
                    MessageBox.Show("Invalid input at index " + i + ". Please enter valid integer values.");
                    return;
                }
            }


            int[] valuearrayp = pri.ToArray();
            if (valuearrayp.Length > desiredNumberOfInputs)
            {
                MessageBox.Show("Number of inputs exceeds the limit.");
                return;
            }
            else
            {
                string filepathp = textBox4.Text;

                try
                {
                    // Create the file and write the lines of text to it
                    using (StreamWriter writer = new StreamWriter(filepathp))
                    {
                        foreach (int line in valuearrayp)
                        {
                            writer.WriteLine(line);
                        }
                    }

                    // Access the first element of the array
                    int firstElement = valuearraya[0];
                    MessageBox.Show("First element: " + firstElement);
                }
                catch (Exception eaab)
                {
                    MessageBox.Show(eaab.Message);
                }

            }

        }
    }
}
