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
            this.ActiveControl = txtStartStation;
        }
        public void SearchStations(string Stationname, ListBox listBoxName)
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
            SearchStations(txtStartStation.Text, lstStartStation);
        }

        private void txtEndStation_TextChanged(object sender, EventArgs e)
        {
            SearchStations(txtEndStation.Text, lstEndStation);
        }

        private void txtBoxStation_TextChanged(object sender, EventArgs e)
        {
            SearchStations(txtBoxStation.Text, lstBoxStation);
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

        //------------------------------------AUSGABE (Methode)------------------------------------------------
        
        private Connections SearchConnections(string StartStation, string EndStation)
        {
            Connections connections = t.GetConnections(StartStation, EndStation);
            return connections;
        }

        private StationBoardRoot GetStationBoard(string Station, string Id)
        {
            StationBoardRoot stationboard = t.GetStationBoard(Station, Id);
            return stationboard;
        }

        //private Station GetStation()
        //{
        //    Station station = t.GetStations();
        //    return null;
        //}

        //--------------------------------------Verbindung Ausgabe----------------------------------
        private void DisplayConnections(Connections connections)
        {
            foreach (Connection c in connections.ConnectionList)
            {
                ListViewItem item = new ListViewItem();
                DateTime departure = Convert.ToDateTime(c.From.Departure);
                item.Text = departure.Date.ToString("dd.MM.yyyy");
                item.SubItems.Add(departure.TimeOfDay.ToString());
                item.SubItems.Add(c.From.Station.Name);
                item.SubItems.Add(c.To.Station.Name);
                item.SubItems.Add(c.From.Platform);

                lstViewTimetable.Items.Add(item);
            }
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            Connections connections = SearchConnections(txtStartStation.Text, txtEndStation.Text);
            DisplayConnections(connections);
        }

        //--------------------------------------------Abfahrtstafel Ausgabe--------------------------------------
        private void DisplayDeparture(StationBoardRoot stationBoard)
        {
            foreach (StationBoard c in stationBoard.Entries)
            {
                ListViewItem item = new ListViewItem();
            //    DateTime departure = Convert.ToDateTime(c.From.Departure);
            //    item.SubItems.Add(departure.TimeOfDay.ToString());
           //     item.SubItems.Add(c.To.Station.Name);
            //    item.SubItems.Add(c.From.Platform);

                lstViewDepartureBoard.Items.Add(item);
            }
        }
        private void btnSearchDeparture_Click(object sender, EventArgs e)
        {
           // StationBoardRoot stationBoard = GetStationBoard(txtBoxStation.Text, stationBoard.Station.Id);
           // DisplayDeparture(stationBoard);
        }

        private void btnDeleteTimetable_Click(object sender, EventArgs e)
        {
            lstViewTimetable.Items.Clear();
        }
        private void btnDeleteDepartureBoard_Click(object sender, EventArgs e)
        {
            lstViewDepartureBoard.Items.Clear();
        }
        
    }
}
