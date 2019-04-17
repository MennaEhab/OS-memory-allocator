namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.the_result = new System.Windows.Forms.DataGridView();
            this.Hole_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.the_result)).BeginInit();
            this.SuspendLayout();
            // 
            // the_result
            // 
            this.the_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.the_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hole_name,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Process_Addr});
            this.the_result.Location = new System.Drawing.Point(2, 13);
            this.the_result.Margin = new System.Windows.Forms.Padding(4);
            this.the_result.Name = "the_result";
            this.the_result.ReadOnly = true;
            this.the_result.Size = new System.Drawing.Size(797, 297);
            this.the_result.TabIndex = 4;
            // 
            // Hole_name
            // 
            this.Hole_name.HeaderText = "Hole name";
            this.Hole_name.Name = "Hole_name";
            this.Hole_name.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Process number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Process Size";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Process_Addr
            // 
            this.Process_Addr.HeaderText = "Process starting Add";
            this.Process_Addr.Name = "Process_Addr";
            this.Process_Addr.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "allocate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.the_result);
            this.Name = "Form2";
            this.Text = "output";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.the_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView the_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hole_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Addr;
        private System.Windows.Forms.Button button1;
    }
}