namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.processInput = new System.Windows.Forms.DataGridView();
            this.Process_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.next = new System.Windows.Forms.Button();
            this.holes = new System.Windows.Forms.DataGridView();
            this.hole_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starting_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holes)).BeginInit();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(632, 424);
            this.run.Margin = new System.Windows.Forms.Padding(4);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(100, 28);
            this.run.TabIndex = 13;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(632, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Method of Allocation";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 53);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Best Fit";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "First Fit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // processInput
            // 
            this.processInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process_name,
            this.Process_Size});
            this.processInput.Location = new System.Drawing.Point(632, 39);
            this.processInput.Margin = new System.Windows.Forms.Padding(4);
            this.processInput.Name = "processInput";
            this.processInput.Size = new System.Drawing.Size(329, 201);
            this.processInput.TabIndex = 11;
            // 
            // Process_name
            // 
            this.Process_name.HeaderText = "Process name";
            this.Process_name.Name = "Process_name";
            this.Process_name.ReadOnly = true;
            // 
            // Process_Size
            // 
            this.Process_Size.HeaderText = "Process Size";
            this.Process_Size.Name = "Process_Size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(371, 252);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 10;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(371, 302);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 28);
            this.next.TabIndex = 9;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // holes
            // 
            this.holes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hole_size,
            this.starting_Addr});
            this.holes.Location = new System.Drawing.Point(218, 39);
            this.holes.Margin = new System.Windows.Forms.Padding(4);
            this.holes.Name = "holes";
            this.holes.Size = new System.Drawing.Size(327, 181);
            this.holes.TabIndex = 8;
            // 
            // hole_size
            // 
            this.hole_size.HeaderText = "Hole Size";
            this.hole_size.Name = "hole_size";
            // 
            // starting_Addr
            // 
            this.starting_Addr.HeaderText = "Starting Address";
            this.starting_Addr.Name = "starting_Addr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 490);
            this.Controls.Add(this.run);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.processInput);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.holes);
            this.Name = "Form1";
            this.Text = "Input";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView processInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Size;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.DataGridView holes;
        private System.Windows.Forms.DataGridViewTextBoxColumn hole_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn starting_Addr;
    }
}

