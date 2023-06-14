namespace WindowsFormsApp2
{
    partial class priority
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(priority));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PRONAME = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BURST = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNumberOfInputs = new System.Windows.Forms.TextBox();
            this.ARRIVAL = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.FCFS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "BURST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "ARRIVAL";
            // 
            // PRONAME
            // 
            this.PRONAME.AutoSize = true;
            this.PRONAME.Location = new System.Drawing.Point(68, 100);
            this.PRONAME.Name = "PRONAME";
            this.PRONAME.Size = new System.Drawing.Size(46, 16);
            this.PRONAME.TabIndex = 18;
            this.PRONAME.Text = "NAME";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(500, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 22);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(500, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 22);
            this.textBox2.TabIndex = 16;
            // 
            // BURST
            // 
            this.BURST.Location = new System.Drawing.Point(158, 210);
            this.BURST.Name = "BURST";
            this.BURST.Size = new System.Drawing.Size(226, 22);
            this.BURST.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 14;
            // 
            // txtNumberOfInputs
            // 
            this.txtNumberOfInputs.Location = new System.Drawing.Point(329, 29);
            this.txtNumberOfInputs.Name = "txtNumberOfInputs";
            this.txtNumberOfInputs.Size = new System.Drawing.Size(226, 22);
            this.txtNumberOfInputs.TabIndex = 13;
            // 
            // ARRIVAL
            // 
            this.ARRIVAL.Location = new System.Drawing.Point(158, 150);
            this.ARRIVAL.Name = "ARRIVAL";
            this.ARRIVAL.Size = new System.Drawing.Size(226, 22);
            this.ARRIVAL.TabIndex = 12;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(158, 95);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(226, 22);
            this.txtInput.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "PRIORITY";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(500, 269);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 22);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 269);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 22);
            this.textBox5.TabIndex = 21;
            // 
            // FCFS
            // 
            this.FCFS.Location = new System.Drawing.Point(318, 367);
            this.FCFS.Name = "FCFS";
            this.FCFS.Size = new System.Drawing.Size(153, 62);
            this.FCFS.TabIndex = 24;
            this.FCFS.Text = "STORE INPUTS";
            this.FCFS.UseVisualStyleBackColor = true;
            this.FCFS.Click += new System.EventHandler(this.FCFS_Click);
            // 
            // priority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(795, 517);
            this.Controls.Add(this.FCFS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PRONAME);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BURST);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNumberOfInputs);
            this.Controls.Add(this.ARRIVAL);
            this.Controls.Add(this.txtInput);
            this.Name = "priority";
            this.Text = "priority";
            this.Load += new System.EventHandler(this.priority_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PRONAME;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox BURST;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNumberOfInputs;
        private System.Windows.Forms.TextBox ARRIVAL;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button FCFS;
    }
}