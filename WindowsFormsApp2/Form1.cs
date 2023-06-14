using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public TextBox tb2;
        public string[] lines;
        public string filePath;
        public string[] arriva;
        public int[] valuearray;
        public int[] valuearraya;
        public int[] c;
        public int[] b;
        public int[] a;
       public int desiredNumberOfInputs;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        private void PerformFCFS()
        {
            int desiredNumberOfInputs;

            if (!int.TryParse(txtNumberOfInputs.Text, out desiredNumberOfInputs))
            {
                MessageBox.Show("Invalid number of inputs.");
                return;
            }

            // Get the text from the multiline TextBox
            string inputText = txtInput.Text;
            string arrivaltext = ARRIVAL.Text;
            string bur = BURST.Text;

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

            string[] arriva = arrivaltext.Split(' ');
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

            dataGridView1.Columns.Add("Process", "Process");
            dataGridView1.Columns.Add("Arrival", "Arrival");
            dataGridView1.Columns.Add("Burst", "Burst");
            dataGridView1.Columns.Add("Completion", "Completion");
            dataGridView1.Columns.Add("Waiting", "Waiting");
            dataGridView1.Columns.Add("Turnaround", "Turnaround");

            // Combine the arrival, burst, and process arrays into a single array of tuples
            (int process, int arrivaltext, int burst)[] processes = valuearray
      .Select((value, index) => (process: index + 1, arrivaltext: value, burst: valuearraya[index]))
      .ToArray();
            // Sort the processes based on their arrival times
            Array.Sort(processes, (a, b) => a.arrivaltext.CompareTo(b.arrivaltext));

            int n = processes.Length;  // Number of processes
            int[] completionTime = new int[n];
            int[] waitingTime = new int[n];
            int[] turnaroundTime = new int[n];
            int totalWaitingTime = 0;
            int totalTurnaroundTime = 0;

            // Populate the DataGridView with the sorted process data
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add(processes[i].process, processes[i].arrivaltext, processes[i].burst);
            }

            // Calculate completion time, waiting time, and turnaround time for each process
            completionTime[0] = processes[0].arrivaltext + processes[0].burst;

            for (int i = 1; i < n; i++)
            {
                completionTime[i] = Math.Max(processes[i].arrivaltext, completionTime[i - 1]) + processes[i].burst;
            }

            for (int i = 0; i < n; i++)
            {
                waitingTime[i] = completionTime[i] - processes[i].arrivaltext - processes[i].burst;
                totalWaitingTime += waitingTime[i];
            }

            for (int i = 0; i < n; i++)
            {
                turnaroundTime[i] = completionTime[i] - processes[i].arrivaltext;
                totalTurnaroundTime += turnaroundTime[i];
            }

            // Display the completion time, waiting time, and turnaround time in the DataGridView
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells["Completion"].Value = completionTime[i];
                dataGridView1.Rows[i].Cells["Waiting"].Value = waitingTime[i];
                dataGridView1.Rows[i].Cells["Turnaround"].Value = turnaroundTime[i];
            }
        }
        private void PerformSJFS()
        {
            int desiredNumberOfInputs;

            if (!int.TryParse(txtNumberOfInputs.Text, out desiredNumberOfInputs))
            {
                MessageBox.Show("Invalid number of inputs.");
                return;
            }

            // Get the text from the multiline TextBox
            string inputText = txtInput.Text;
            string arrival = ARRIVAL.Text;
            string bur = BURST.Text;

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

            dataGridView1.Columns.Add("Process", "Process");
            dataGridView1.Columns.Add("Arrival", "Arrival");
            dataGridView1.Columns.Add("Burst", "Burst");
            dataGridView1.Columns.Add("Completion", "Completion");
            dataGridView1.Columns.Add("Waiting", "Waiting");
            dataGridView1.Columns.Add("Turnaround", "Turnaround");

            // Combine the burst, arrival, and process arrays into a single array of tuples
            (int process, int arrival, int burst)[] processes = valuearray
                .Select((value, index) => (process: index + 1, arrival: value , burst: valuearraya[index]))
                .ToArray();

            // Sort the processes based on their burst times in ascending order
            Array.Sort(processes, (a, b) => a.burst.CompareTo(b.burst));

            int n = processes.Length;  // Number of processes
            int[] completionTime = new int[n];
            int[] waitingTime = new int[n];
            int[] turnaroundTime = new int[n];
            int totalWaitingTime = 0;
            int totalTurnaroundTime = 0;

            // Populate the DataGridView with the sorted process data
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add(processes[i].process, processes[i].arrival, processes[i].burst);
            }

            // Calculate completion time, waiting time, and turnaround time for each process
            completionTime[0] = processes[0].burst;

            for (int i = 1; i < n; i++)
            {
                completionTime[i] = Math.Max(processes[i].arrival, completionTime[i - 1]) + processes[i].burst;
            }

            for (int i = 0; i < n; i++)
            {
                waitingTime[i] = completionTime[i] - processes[i].arrival - processes[i].burst;
                totalWaitingTime += waitingTime[i];
            }

            for (int i = 0; i < n; i++)
            {
                turnaroundTime[i] = completionTime[i] - processes[i].arrival;
                totalTurnaroundTime += turnaroundTime[i];
            }

            // Display the completion time, waiting time, and turnaround time in the DataGridView
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells["Completion"].Value = completionTime[i];
                dataGridView1.Rows[i].Cells["Waiting"].Value = waitingTime[i];
                dataGridView1.Rows[i].Cells["Turnaround"].Value = turnaroundTime[i];
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FCFS_Click(object sender, EventArgs e)
    
        {
           



           

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void FCFS_Click_1(object sender, EventArgs e)
        {
            PerformFCFS();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformSJFS();
        }
    }
}


