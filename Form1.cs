using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsTheDiameter

{
    public partial class Form1 : Form
    {
        private List<Circle> circles;
        public Form1()
        {

            InitializeComponent();
            this.circles = List<Circle>();

        }



        private void NewCircle_Click(object sender, EventArgs e)
        private void RedrawCircleCollection()
        {
            CircleCollection.Items.Clear();
            foreach (var circle in this.circles)
            {
                CircleCollection.Items.Add(circle.ToString());
            }
        }

        private void ShowArray_Click(object sender, EventArgs e)
        {
            string msg = "Radius         Diameter\n";
            msg +=       "---------------------------\n";
            foreach (var c in this.circles)
            {
                msg += String.Format("{0}                        {1}\n", c.getRadius(), c.getDiameter());
            }
            MessageBox.Show(msg); 
        }


        private void SetRadius_Click(object sender, EventArgs e)
        {
                double newRadius = Convert.ToDouble(CircleInput.Text);
                var c=circles[CircleCollection.SelectedIndex]; 
                c.setRadius(newRadius);
                this.RedrawCircleCollection();

            }
            catch (System.FormatException)
            {

                MessageBox.Show("Radius format incorrect.");
            }
        }
