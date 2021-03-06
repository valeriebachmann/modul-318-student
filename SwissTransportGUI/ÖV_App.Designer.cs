﻿namespace SwissTransportGUI
{
    partial class ÖV_App
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖV_App));
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDeparture = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.txtEndStation = new System.Windows.Forms.TextBox();
            this.lstStartStation = new System.Windows.Forms.ListBox();
            this.lstEndStation = new System.Windows.Forms.ListBox();
            this.lstViewTimetable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteTimetable = new System.Windows.Forms.Button();
            this.lstStart = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxStation = new System.Windows.Forms.TextBox();
            this.lstViewDepartureBoard = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewStation = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.pictureBoxTrain = new System.Windows.Forms.PictureBox();
            this.lstStart.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnection.Location = new System.Drawing.Point(754, 304);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(215, 39);
            this.btnSearchConnection.TabIndex = 0;
            this.btnSearchConnection.Text = "Verbindung suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nach";
            // 
            // dateTimeDeparture
            // 
            this.dateTimeDeparture.CustomFormat = "HH:mm";
            this.dateTimeDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDeparture.Location = new System.Drawing.Point(25, 304);
            this.dateTimeDeparture.Name = "dateTimeDeparture";
            this.dateTimeDeparture.ShowUpDown = true;
            this.dateTimeDeparture.Size = new System.Drawing.Size(292, 27);
            this.dateTimeDeparture.TabIndex = 5;
            this.dateTimeDeparture.Value = new System.DateTime(2019, 5, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Abfahrtszeit";
            // 
            // txtStartStation
            // 
            this.txtStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartStation.Location = new System.Drawing.Point(25, 99);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(292, 27);
            this.txtStartStation.TabIndex = 9;
            this.txtStartStation.TextChanged += new System.EventHandler(this.txtStartStation_TextChanged);
            // 
            // txtEndStation
            // 
            this.txtEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndStation.Location = new System.Drawing.Point(379, 99);
            this.txtEndStation.Name = "txtEndStation";
            this.txtEndStation.Size = new System.Drawing.Size(292, 27);
            this.txtEndStation.TabIndex = 10;
            this.txtEndStation.TextChanged += new System.EventHandler(this.txtEndStation_TextChanged);
            // 
            // lstStartStation
            // 
            this.lstStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStartStation.FormattingEnabled = true;
            this.lstStartStation.ItemHeight = 20;
            this.lstStartStation.Location = new System.Drawing.Point(25, 126);
            this.lstStartStation.Name = "lstStartStation";
            this.lstStartStation.Size = new System.Drawing.Size(292, 124);
            this.lstStartStation.TabIndex = 11;
            this.lstStartStation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstStartStation_MouseClick);
            this.lstStartStation.SelectedIndexChanged += new System.EventHandler(this.lstStartStation_SelectedIndexChanged);
            // 
            // lstEndStation
            // 
            this.lstEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEndStation.FormattingEnabled = true;
            this.lstEndStation.ItemHeight = 20;
            this.lstEndStation.Location = new System.Drawing.Point(379, 126);
            this.lstEndStation.Name = "lstEndStation";
            this.lstEndStation.Size = new System.Drawing.Size(292, 124);
            this.lstEndStation.TabIndex = 12;
            this.lstEndStation.SelectedIndexChanged += new System.EventHandler(this.lstEndStation_SelectedIndexChanged);
            // 
            // lstViewTimetable
            // 
            this.lstViewTimetable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstViewTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewTimetable.FullRowSelect = true;
            this.lstViewTimetable.GridLines = true;
            this.lstViewTimetable.Location = new System.Drawing.Point(25, 382);
            this.lstViewTimetable.Name = "lstViewTimetable";
            this.lstViewTimetable.Size = new System.Drawing.Size(944, 345);
            this.lstViewTimetable.TabIndex = 13;
            this.lstViewTimetable.UseCompatibleStateImageBehavior = false;
            this.lstViewTimetable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Abfahrtszeit";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Von";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nach";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gleis";
            this.columnHeader5.Width = 145;
            // 
            // btnDeleteTimetable
            // 
            this.btnDeleteTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTimetable.Location = new System.Drawing.Point(713, 733);
            this.btnDeleteTimetable.Name = "btnDeleteTimetable";
            this.btnDeleteTimetable.Size = new System.Drawing.Size(256, 42);
            this.btnDeleteTimetable.TabIndex = 15;
            this.btnDeleteTimetable.Text = "Fahrplan zurücksetzen";
            this.btnDeleteTimetable.UseVisualStyleBackColor = true;
            this.btnDeleteTimetable.Click += new System.EventHandler(this.btnDeleteTimetable_Click);
            // 
            // lstStart
            // 
            this.lstStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstStart.Controls.Add(this.btnDeleteTimetable);
            this.lstStart.Controls.Add(this.lstViewTimetable);
            this.lstStart.Controls.Add(this.lstEndStation);
            this.lstStart.Controls.Add(this.lstStartStation);
            this.lstStart.Controls.Add(this.txtEndStation);
            this.lstStart.Controls.Add(this.txtStartStation);
            this.lstStart.Controls.Add(this.label4);
            this.lstStart.Controls.Add(this.dateTimeDeparture);
            this.lstStart.Controls.Add(this.label2);
            this.lstStart.Controls.Add(this.label1);
            this.lstStart.Controls.Add(this.btnSearchConnection);
            this.lstStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStart.Location = new System.Drawing.Point(15, 89);
            this.lstStart.Name = "lstStart";
            this.lstStart.Size = new System.Drawing.Size(982, 788);
            this.lstStart.TabIndex = 1;
            this.lstStart.TabStop = false;
            this.lstStart.Text = "Der Online-Fahrplan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Station";
            // 
            // txtBoxStation
            // 
            this.txtBoxStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStation.Location = new System.Drawing.Point(39, 99);
            this.txtBoxStation.Name = "txtBoxStation";
            this.txtBoxStation.Size = new System.Drawing.Size(389, 27);
            this.txtBoxStation.TabIndex = 3;
            this.txtBoxStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxStation_KeyDown);
            // 
            // lstViewDepartureBoard
            // 
            this.lstViewDepartureBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.lstViewDepartureBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewDepartureBoard.GridLines = true;
            this.lstViewDepartureBoard.Location = new System.Drawing.Point(39, 304);
            this.lstViewDepartureBoard.Name = "lstViewDepartureBoard";
            this.lstViewDepartureBoard.Size = new System.Drawing.Size(641, 471);
            this.lstViewDepartureBoard.TabIndex = 5;
            this.lstViewDepartureBoard.UseCompatibleStateImageBehavior = false;
            this.lstViewDepartureBoard.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Abfahrtszeit";
            this.columnHeader6.Width = 157;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nach";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Transportunternehmen";
            this.columnHeader9.Width = 288;
            // 
            // lstViewStation
            // 
            this.lstViewStation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader10});
            this.lstViewStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewStation.FullRowSelect = true;
            this.lstViewStation.Location = new System.Drawing.Point(39, 126);
            this.lstViewStation.MultiSelect = false;
            this.lstViewStation.Name = "lstViewStation";
            this.lstViewStation.Size = new System.Drawing.Size(389, 124);
            this.lstViewStation.TabIndex = 7;
            this.lstViewStation.UseCompatibleStateImageBehavior = false;
            this.lstViewStation.View = System.Windows.Forms.View.Details;
            this.lstViewStation.SelectedIndexChanged += new System.EventHandler(this.lstStation_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Name";
            this.columnHeader10.Width = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lstViewStation);
            this.groupBox2.Controls.Add(this.lstViewDepartureBoard);
            this.groupBox2.Controls.Add(this.txtBoxStation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1014, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 788);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abfahrtstafel";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 34.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(185, 9);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(462, 71);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Swisstransport";
            // 
            // pictureBoxTrain
            // 
            this.pictureBoxTrain.Image = global::SwissTransportGUI.Properties.Resources.icon1;
            this.pictureBoxTrain.Location = new System.Drawing.Point(12, -3);
            this.pictureBoxTrain.Name = "pictureBoxTrain";
            this.pictureBoxTrain.Size = new System.Drawing.Size(167, 102);
            this.pictureBoxTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrain.TabIndex = 5;
            this.pictureBoxTrain.TabStop = false;
            // 
            // ÖV_App
            // 
            this.AcceptButton = this.btnSearchConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1739, 900);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstStart);
            this.Controls.Add(this.pictureBoxTrain);
            this.Controls.Add(this.Label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÖV_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Amazing ÖV App";
            this.lstStart.ResumeLayout(false);
            this.lstStart.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDeparture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.TextBox txtEndStation;
        private System.Windows.Forms.ListBox lstStartStation;
        private System.Windows.Forms.ListBox lstEndStation;
        private System.Windows.Forms.ListView lstViewTimetable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDeleteTimetable;
        private System.Windows.Forms.GroupBox lstStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxStation;
        private System.Windows.Forms.ListView lstViewDepartureBoard;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lstViewStation;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.PictureBox pictureBoxTrain;
    }
}

