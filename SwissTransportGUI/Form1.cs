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
        Transport t = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        public void txtBoxStationSuchen(string Stationname, ListBox listBoxName)
        {
            listBoxName.Items.Clear();
            
            Stations myStations = t.GetStations(Stationname);

            foreach (Station station in myStations.StationList)
            {
                listBoxName.Items.Add(station.Name);
            }
        }

        //-------------------Ortseingabe (Von & Nach) mit Beispiele ausgeben------------------------------
        private void txtStartStation_TextChanged(object sender, EventArgs e)
        {
                txtBoxStationSuchen(txtStartStation.Text, lstStartStation);
        }

        private void txtEndStation_TextChanged(object sender, EventArgs e)
        {
            txtBoxStationSuchen(txtEndStation.Text, lstEndStation);
        }

        private void txtBoxStation_TextChanged(object sender, EventArgs e)
        {
            txtBoxStationSuchen(txtBoxStation.Text, lstBoxStation);
        }

        //------------------Auf Beispiele klicken, damit es in der Ortseingabe (Von & Nach) erscheint---------------
        private void lstStartStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStartStation.Text = lstStartStation.SelectedItem.ToString();
            lstStartStation.Items.Clear();
        }

        private void lstEndStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEndStation.Text = lstEndStation.SelectedItem.ToString();
            lstEndStation.Items.Clear();
        }

        private void lstBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxStation.Text = lstBoxStation.SelectedItem.ToString();
            lstBoxStation.Items.Clear();
        }

        //------------------------------------Fahrplanausgabe------------------------------------------------
        private void FahrplanAusgeben(ListView lstView)
        {
            Connections fahrplan = t.GetConnections(txtStartStation.Text, txtEndStation.Text);
            foreach (Connection f in fahrplan.ConnectionList)
            {
                try
                {
                   

                    lstView.Items.Add("f.dateTimePicker");
                    lstView.Items.Add(f.From.Station.Name);
                    lstView.Items.Add(f.To.Station.Name);
                }
                catch
                {
                    MessageBox.Show("Keine Verbindung zwischen den Stationen gefunden");
                }
            }
        }
        
        private void buttonVerbindungSuchen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStartStation.Text) || string.IsNullOrWhiteSpace(txtEndStation.Text))
                return;

            FahrplanAusgeben(lstViewFahrplan);


            ListViewItem i = new ListViewItem(txtStartStation.Text);
            i.SubItems.Add(txtEndStation.Text);
            lstViewFahrplan.Items.Add(i);
        }
    }
}
