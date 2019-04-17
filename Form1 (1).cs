using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        LinkedList<Process> processinprog = new LinkedList<Process>();
        LinkedList<Hole> Sortedholes = new LinkedList<Hole>();
        int numOfProcess;
        LinkedList<Hole> holesData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 && holes.RowCount > 1)
            {
                holesData = new LinkedList<Hole>();
                int rownums = holes.RowCount, errors = 0;
                numOfProcess = int.Parse(numericUpDown1.Value.ToString());
                for (int i = 0; i < rownums - 1; i++)
                {
                    if (holes.Rows[i].Cells[1].Value == null || holes.Rows[i].Cells[0].Value == null)
                    {
                        MessageBox.Show("please enter the data of the holes");
                        errors += 1;
                    }
                    else
                    {

                        holesData.AddLast(new Hole(i, int.Parse(holes.Rows[i].Cells[0].Value.ToString()), int.Parse(holes.Rows[i].Cells[1].Value.ToString()), int.Parse(holes.Rows[i].Cells[0].Value.ToString())));
                    }
                }
                if (errors == 0)
                {
                    for (int i = 0; i < numOfProcess; i++)
                    {
                        DataGridViewRow row = (DataGridViewRow)processInput.Rows[i].Clone();
                        row.Cells[0].Value = "P" + i;
                        row.Cells[1].Value = 0;
                        row.Cells[0].ReadOnly = true;
                        row.Cells[1].ReadOnly = false;
                        processInput.Rows.Add(row);
                    }
                    processInput.AllowUserToAddRows = false;
                }
            }
            else if(numericUpDown1.Value == 0)
            {
                MessageBox.Show("Please Add the processes number");
            }
        }
        int flag;
        private void run_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                flag = 0;
                run.Enabled = false;
                processInput.Enabled = false;

                string idofPr_row; int sizeOfPro_row;
                for (int i = 0; i < numOfProcess; i++)
                {
                    idofPr_row = processInput.Rows[i].Cells[0].Value.ToString();
                    sizeOfPro_row = int.Parse(processInput.Rows[i].Cells[1].Value.ToString());
                    processinprog.AddLast(new Process(idofPr_row, sizeOfPro_row));
                }
                //First Fit
                Sortedholes = holesData;
                foreach (Process process in processinprog)
                {
                    foreach (Hole hole in holesData)
                    {
                        if (hole.getSize() >= process.getSize())
                        {
                            process.setAddr(hole.getStartingAddr() + hole.getActSize() - hole.getSize());
                            hole.proceesfits.AddLast(process);
                            hole.setSize(hole.getSize() - process.getSize());
                            break;
                        }
                    }
                }
                Form2 result = new Form2(numOfProcess,processinprog , holesData,Sortedholes,flag);
                result.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                flag = 1;
                run.Enabled = false;
                processInput.Enabled = false;

                string idofPr_row; int sizeOfPro_row;
                for (int i = 0; i < numOfProcess; i++)
                {
                    idofPr_row = processInput.Rows[i].Cells[0].Value.ToString();
                    sizeOfPro_row = int.Parse(processInput.Rows[i].Cells[1].Value.ToString());
                    processinprog.AddLast(new Process(idofPr_row, sizeOfPro_row));
                }
                //Best Fit
                foreach (Process process in processinprog)
                {
                    Sortedholes = new LinkedList<Hole>(holesData.OrderBy(o => o.getSize()).ToList());
                    foreach (Hole hole in Sortedholes)
                    {
                        if (hole.getSize() >= process.getSize())
                        {
                            process.setAddr(hole.getStartingAddr() + hole.getActSize() - hole.getSize());
                            hole.proceesfits.AddLast(process);
                            hole.setSize(hole.getSize() - process.getSize());

                            break;
                        }
                    }
                }
                Form2 result = new Form2(numOfProcess, processinprog, holesData, Sortedholes, flag);
                result.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please enter the method of allocation");
            }
            


        }
    }
}
