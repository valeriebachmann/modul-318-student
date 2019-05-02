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
            lstViewStation.Columns[0].Width = 90;
            lstViewStation.Columns[1].Width = 182;
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

        public void SearchDeparture(string Stationname, ListView listViewName)
        {
            listViewName.Items.Clear();

            Stations myStations = t.GetStations(Stationname);

            foreach (Station station in myStations.StationList)
            {
                ListViewItem item = listViewName.Items.Add(station.Id);
                item.SubItems.Add(station.Name);
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
            SearchDeparture(txtBoxStation.Text, lstViewStation);
        }

        //------------------Auf Beispiele klicken, damit es in der Ortseingabe (Von & Nach) erscheint---------------
        private void lstStartStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStartStation.Text = lstStartStation.SelectedItem.ToString();
            //lstStartStation.Items.Clear();
        }

        private void lstEndStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEndStation.Text = lstEndStation.SelectedItem.ToString();
            //lstEndStation.Items.Clear();
        }

        private void lstStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewStation.SelectedItems != null && lstViewStation.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstViewStation.SelectedItems[0];
                string stationId = selectedItem.Text;
                string stationName = selectedItem.SubItems[1].Text;

                txtBoxStation.Text = stationName;
                txtBoxStation.Tag = stationId;

                lstViewDepartureBoard.Items.Clear();

                StationBoardRoot stationBoard = GetStationBoard(stationName, stationId);
                DisplayDeparture(stationBoard);
            }
        }

        private void lstStartStation_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = txtEndStation;
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
            foreach (StationBoard boardEntry in stationBoard.Entries)
            {
                ListViewItem item = new ListViewItem();
                item.Text = boardEntry.Stop.Departure.ToString();
                item.SubItems.Add(boardEntry.To);
                item.SubItems.Add(boardEntry.Operator);

                lstViewDepartureBoard.Items.Add(item);
            }
        }

        private void btnDeleteTimetable_Click(object sender, EventArgs e)
        {
            lstViewTimetable.Items.Clear();
        }
    }
}
