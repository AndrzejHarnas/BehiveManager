using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            workerJobComboBox.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
            workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" });
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z żądłami" });
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek", "Utrzymywanie ula", "Patrol z żądłami" });


            queen = new Queen(workers); 
                
        }


             private Queen queen;



            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerJobComboBox.Text, (int)shiftNumericUpDown.Value) == false)
            {
                MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania" + workerJobComboBox.Text + " Królowa pszczółek mówi...");
            }
            else
                MessageBox.Show("Zadanie " + workerJobComboBox.Text + "Będzie ukończone za " + shiftNumericUpDown.Value + "zmiany, Królowa pszczółek mówi...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportTextBox.Text = queen.workTheNextShift();
        }

    }
    
}
