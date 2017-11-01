using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenOverlay___EasyReader
{
    public partial class FormSettings : Form
    {
        public Form1 frmReference;
        bool cancelExit = true;

        public FormSettings()
        {
            InitializeComponent();
        }

        public void setColour()
        {
            frmReference.updateBackgroundColour(hScrollAlpha.Value, hScroll_R.Value, hScroll_G.Value, hScroll_B.Value);
        }

        private void hScrollMaster(object sender, ScrollEventArgs e)
        {
            setColour();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancelExit = false;
            Application.Exit();
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = cancelExit;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            setupPresets();
        }

        void setupPresets()
        {
            string[] colourList = new string[] { "-- Select Colour --", "Default Colour", "Blackness", "Mellow Yellow", "Blues", "Orange ya an orange"};

            comboBox1.Items.AddRange(colourList);
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1: //Default
                case 2: //Blackness
                      hScroll_R.Value = 1;
                      hScroll_G.Value = 1;
                      hScroll_B.Value = 1;
                    break;
                case 3: //Yellow
                      hScroll_R.Value = 255;
                      hScroll_G.Value = 242;
                      hScroll_B.Value = 1;
                    break;
                case 4: //Blues
                      hScroll_R.Value = 27;
                      hScroll_G.Value = 9;
                      hScroll_B.Value = 247;
                    break;
                case 5: //Orange
                      hScroll_R.Value = 255;
                      hScroll_G.Value = 127;
                      hScroll_B.Value = 39;
                    break;
            }

            if (comboBox1.SelectedIndex > 0) setColour();
            
        }
    }
}
