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
    public partial class Form2 : Form
    {
        int flag1;
        LinkedList<Process> processinprogD = new LinkedList<Process>();
        Dictionary<Process, Hole> saveproces = new Dictionary<Process, Hole>();
        public int numOfProcesses;
        LinkedList<Hole> dataOfHoless = new LinkedList<Hole>();
        LinkedList<Hole> SortedholesD = new LinkedList<Hole>();
        public LinkedListNode<Process> y;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int numOfProcs, LinkedList<Process> processinprogg, LinkedList<Hole> dataOfHoles, LinkedList<Hole> Sortedholess, int flag)//0=first,1=best
        {
            InitializeComponent();
            processinprogD = processinprogg;
            dataOfHoless = dataOfHoles;
            numOfProcesses = numOfProcs;
            SortedholesD = Sortedholess;
            y = processinprogD.First;



           /* int ii = 0;
            foreach (Hole hole in dataOfHoless)
            {
                if (hole.proceesfits == null)
                {
                    DataGridViewRow row = (DataGridViewRow)the_result.Rows[ii].Clone();
                    row.Cells[0].Value = "hole" + hole.getID();
                    row.Cells[1].Value = 0;
                    row.Cells[2].Value = 0;
                    row.Cells[3].Value = 0;
                    row.ReadOnly = true;
                    the_result.Rows.Add(row);
                    ii++;
                }
                else
                {
                    foreach (Process procs in hole.proceesfits)
                    {


                        DataGridViewRow row = (DataGridViewRow)the_result.Rows[ii].Clone();
                        row.Cells[0].Value = "hole" + hole.getID();
                        row.Cells[1].Value = procs.getID();
                        row.Cells[2].Value = procs.getSize();
                        row.Cells[3].Value = procs.getAddr();

                        row.ReadOnly = true;
                        the_result.Rows.Add(row);
                    }
                }
            }
            */
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public int ii, counter=1;
        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Hole holeinsort in SortedholesD)
            {
                if (holeinsort.proceesfits.Find(y.Value) != null)
                {
                    saveproces.Add(y.Value, holeinsort);
                    break;
                }
            }
            if (counter >= processinprogD.Count)
                button1.Enabled = false;
            else
            {
                y = y.Next;
                counter++;
            }
            the_result.Rows.Clear();
             ii = 0;



            foreach (Hole hole in dataOfHoless)
            {
                if (saveproces.FirstOrDefault(o => o.Value == hole).Key == null)
                {
                    DataGridViewRow row = (DataGridViewRow)the_result.Rows[ii].Clone();
                    row.Cells[0].Value = "hole" + hole.getID();
                    row.Cells[1].Value = 0;
                    row.Cells[2].Value = 0;
                    row.Cells[3].Value = 0;
                    row.ReadOnly = true;
                    the_result.Rows.Add(row);
                    ii++;
                }
                
                    foreach (Process procs in saveproces.Keys)
                    {
                        if (saveproces[procs]==hole)
                        {
                        DataGridViewRow row = (DataGridViewRow)the_result.Rows[ii].Clone();
                        row.Cells[0].Value = "hole" + hole.getID();
                        row.Cells[1].Value = procs.getID();
                        row.Cells[2].Value = procs.getSize();
                        row.Cells[3].Value = procs.getAddr();

                        row.ReadOnly = true;
                        the_result.Rows.Add(row);
                        ii++;

                    }
                    }
                }
            


        }
    }
}
