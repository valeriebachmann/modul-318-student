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
    public partial class ÖV_App : Form
    {
        Transport t = new Transport();
        public ÖV_App()
        {
            InitializeComponent();

            this.ActiveControl = txtStartStation;
            lstViewStation.Columns[0].Width = 90;
            lstViewStation.Columns[1].Width = 182;
            pictureBoxTrain.Padding = new Padding(0);
            this.dateTimeDeparture.Value = DateTime.Now;
        }
        private void SearchStations(string stationname, ListBox listBoxName)
        {
            listBoxName.Items.Clear();
            Stations myStations = t.GetStations(stationname);
            try
            {
                foreach (Station station in myStations.StationList)
                {
                    listBoxName.Items.Add(station.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SearchDeparture(string stationname, ListView listViewName)
        {
            listViewName.Items.Clear();
            Stations myStations = t.GetStations(stationname);
            foreach (Station station in myStations.StationList)
            {
                ListViewItem item = listViewName.Items.Add(station.Id);
                item.SubItems.Add(station.Name);
            }
        }
        private void txtStartStation_TextChanged(object sender, EventArgs e)
        {
            SearchStations(txtStartStation.Text, lstStartStation);
        }
        private void txtEndStation_TextChanged(object sender, EventArgs e)
        {
            SearchStations(txtEndStation.Text, lstEndStation);
        }
        private void txtBoxStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBoxStation.Text.Length > 1)
                SearchDeparture(txtBoxStation.Text, lstViewStation);
        }
        private void lstStartStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStartStation.Text = lstStartStation.SelectedItem.ToString();
        }
        private void lstEndStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEndStation.Text = lstEndStation.SelectedItem.ToString();
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
        private Connections SearchConnections(string startStation, string endStation, string time)
        {
            Connections connections = t.GetConnections(startStation, endStation, time);
            return connections;
        }
        private StationBoardRoot GetStationBoard(string station, string id)
        {
            StationBoardRoot stationboard = t.GetStationBoard(station, id);
            return stationboard;
        }
        private void DisplayConnections(Connections connections)
        {
            try
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
            catch(NullReferenceException)
            {
                MessageBox.Show("Diese Station/en wurde/n nicht gefunden.");
            }
        }
        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            if(lstViewTimetable.Items.Count > 0)
            {
                lstViewTimetable.Items.Clear();
            }
            if (string.IsNullOrEmpty(txtStartStation.Text) && string.IsNullOrEmpty(txtEndStation.Text))
            {
                MessageBox.Show("Bitte geben Sie die Anfahrts- und Ankunftsstation ein!");
            }
            if (string.IsNullOrEmpty(txtStartStation.Text) && !string.IsNullOrEmpty(txtEndStation.Text))
            {
                MessageBox.Show("Bitte geben Sie eine Anfahrtsstation ein!");
            }
            if (!string.IsNullOrEmpty(txtStartStation.Text) && string.IsNullOrEmpty(txtEndStation.Text))
            {
                MessageBox.Show("Bitte geben Sie eine Ankunftsstation ein!");
            }

            string time = dateTimeDeparture.Value.ToString("HH:mm");
            Connections connections = SearchConnections(txtStartStation.Text, txtEndStation.Text, time);
            DisplayConnections(connections);
        }
        private void DisplayDeparture(StationBoardRoot stationBoard)
        {
            try
            {
                if (stationBoard == null)
                {
                    MessageBox.Show("Für diese Station gibt es keine Abfahrtstafel (keine ÖV-Haltestelle).", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                foreach (StationBoard boardEntry in stationBoard.Entries)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = boardEntry.Stop.Departure.ToString();
                    item.SubItems.Add(boardEntry.To);
                    item.SubItems.Add(boardEntry.Operator);

                    lstViewDepartureBoard.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }
        private void btnDeleteTimetable_Click(object sender, EventArgs e)
        {
            lstViewTimetable.Items.Clear();
        }
    }
}
