using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_and_Potfolio1
{ 
    public partial class options_Form : Form
    {
        
        public options_Form()
        {
            InitializeComponent();
        }

        public int milliseconds
        {
            get { return (int)time_updown.Value; }
            set { time_updown.Value = value; }
        }
        public int width
        {
            get { return (int)width_updown.Value; }
            set { width_updown.Value = value; }
        }
        public int height
        {
            get { return (int)Height_updown.Value; }
            set { Height_updown.Value = value; }
        }
        public Color Cell_color
        {
            
            get
            {
                Color color = Color.White;

                if (yellow_radioButton.Checked)
                     color = Color.Yellow;

                if (green_radioButton.Checked)
                    color = Color.Green;

                if (Gold_radioButton.Checked)
                    color = Color.Gold;

                if (nondefault_radioButton.Checked)
                    color = cell_color_btn.BackColor;

                return color;
            }
            set
            {
                if (value == Color.Yellow)
                {
                    yellow_radioButton.Checked = true;
                }
                else if (value == Color.Green)
                {
                    green_radioButton.Checked = true;
                }
                else if (value == Color.Gold)
                {
                    Gold_radioButton.Checked = true;
                }
                else
                    nondefault_radioButton.Checked = true;
                    
            }
        }
        public Color grid_color
        {
            get
            {
                Color C = Color.White;
                if (red_radioButton.Checked)
                    C = Color.Red;
                if (Cyan_radioButton.Checked)
                    C = Color.Cyan;
                if (Silver_radioButton.Checked)
                    C = Color.Silver;
                if (nondefault_radioButton1.Checked)
                    C = grid_color_btn.BackColor;

                return C;
            }
            set
            {
                if (value == Color.Red)
                    red_radioButton.Checked = true;
                else if (value == Color.Cyan)
                    Cyan_radioButton.Checked = true;
                else if (value == Color.Silver)
                    Silver_radioButton.Checked = true;
                else
                    nondefault_radioButton1.Checked = true;
            }
        }
        /*proberty that returns a boolean to see if the tordial or the finite 
         radio button is checked*/

        //toroidal
        public bool grid_tor
        {
            get
            {
                if (toroidal_rbtn.Checked)
                    return true;
                else
                    return false;
            }
            set
            {
                if (value == true)
                    toroidal_rbtn.Checked = true;
            }
        }
        //Finite
        public bool grid_Fin
        {
            get
            {
                if (Finite_rbtn.Checked)
                    return true;
                else
                    return false;
            }
            set
            {
                if (value == true)
                    Finite_rbtn.Checked = true;
            }
        }

        private void nondefault_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (nondefault_radioButton.Checked == true)
                cell_color_btn.Enabled = true;
            else
                cell_color_btn.Enabled = false;
        }

        private void cell_color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog Cdlg = new ColorDialog();
            Cdlg.Color = cell_color_btn.BackColor;
            if(Cdlg.ShowDialog() == DialogResult.OK)
            {
                cell_color_btn.BackColor = Cdlg.Color;
            }
        }
   

        private void nondefault_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (nondefault_radioButton1.Checked == true)
                grid_color_btn.Enabled = true;
            else
                grid_color_btn.Enabled = false;
        }

        private void grid_color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog Cdlg = new ColorDialog();
            Cdlg.Color = grid_color_btn.BackColor;
            if (Cdlg.ShowDialog() == DialogResult.OK)
            {
                grid_color_btn.BackColor = Cdlg.Color;
            }
        }
    }
}
