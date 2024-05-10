using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab7
{
    public partial class View: Form
    {
        private ControllerTrain controller;

        public View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddTrain(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                controller.DisplayTrains();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void DisplayTrainList(string trainList)
        {
            try
            {
                label4.Text = trainList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void test(ControllerTrain cont)
        {
            controller = cont;
        }
    }
}
