using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueStackOverflow
{
    public partial class Form1 : Form
    {
        SportsCar theCar;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            theCar.SpeedIncr = Int32.Parse(textBox2.Text);

            if (theCar.Accelerate(theCar.Brand == "Mercedes"))
            {
                theCar.Accelerate(true);
            }
            else { theCar.Accelerate(); }
            updateUI();
            
        }

        
        theCar.SpeedLimit += TheCar_SpeedLimit;
        //theCar.SpeedLimit += TheCar_SpeedLimit;
        private void TheCar_SpeedLimit(object sender, EventArgs e)
        {
            MessageBox.Show("Speed limit attempted");
        }

        private void updateUI()
        {
            txtMaxSPeed.Text = theCar.Speed.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            theCar = new SportsCar(comboBox1.Text);
            txtMaxSPeed.Text = theCar.MaxSpeed.ToString();
            lblstatus.Text = theCar.Status.ToString();
        }


    }
}
