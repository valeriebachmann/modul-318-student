using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ComboBoxSuchen(string Stationname)
        {
            Transport t = new Transport();

            Stations myStations = t.GetStations(Stationname);

            foreach (Station station in myStations.StationList)
            {
                comboBoxVon.Items.Add(Stationname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Transport t = new Transport();

            //Stations myStations = t.GetStations("Luz");

            
            ////über alle gefundenen Stationen iterieren
            //foreach (Station station in myStations.StationList)
            //{
            //    MessageBox.Show(station.Name);
            //}
        }

        private void comboBoxVon_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBoxSuchen(comboBoxVon.Text);
        }
    }
}
