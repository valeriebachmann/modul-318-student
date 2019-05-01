﻿namespace SwissTransportGUI
{
    partial class Form1
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
            this.buttonVerbindungSuchen = new System.Windows.Forms.Button();
            this.lstStart = new System.Windows.Forms.GroupBox();
            this.lstViewFahrplan = new System.Windows.Forms.ListView();
            this.lstEndStation = new System.Windows.Forms.ListBox();
            this.lstStartStation = new System.Windows.Forms.ListBox();
            this.txtEndStation = new System.Windows.Forms.TextBox();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.textBoxZeit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAbfahrtstafel = new System.Windows.Forms.ListBox();
            this.lstBoxStation = new System.Windows.Forms.ListBox();
            this.txtBoxStation = new System.Windows.Forms.TextBox();
            this.buttonStationSuchen = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstStart.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVerbindungSuchen
            // 
            this.buttonVerbindungSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerbindungSuchen.Location = new System.Drawing.Point(715, 308);
            this.buttonVerbindungSuchen.Name = "buttonVerbindungSuchen";
            this.buttonVerbindungSuchen.Size = new System.Drawing.Size(215, 39);
            this.buttonVerbindungSuchen.TabIndex = 0;
            this.buttonVerbindungSuchen.Text = "Verbindung suchen";
            this.buttonVerbindungSuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungSuchen.Click += new System.EventHandler(this.buttonVerbindungSuchen_Click);
            // 
            // lstStart
            // 
            this.lstStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStart.Controls.Add(this.lstViewFahrplan);
            this.lstStart.Controls.Add(this.lstEndStation);
            this.lstStart.Controls.Add(this.lstStartStation);
            this.lstStart.Controls.Add(this.txtEndStation);
            this.lstStart.Controls.Add(this.txtStartStation);
            this.lstStart.Controls.Add(this.textBoxZeit);
            this.lstStart.Controls.Add(this.label4);
            this.lstStart.Controls.Add(this.label3);
            this.lstStart.Controls.Add(this.dateTimePicker);
            this.lstStart.Controls.Add(this.label2);
            this.lstStart.Controls.Add(this.label1);
            this.lstStart.Controls.Add(this.buttonVerbindungSuchen);
            this.lstStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStart.Location = new System.Drawing.Point(35, 12);
            this.lstStart.Name = "lstStart";
            this.lstStart.Size = new System.Drawing.Size(964, 749);
            this.lstStart.TabIndex = 1;
            this.lstStart.TabStop = false;
            this.lstStart.Text = "Der Online-Fahrplan";
            // 
            // lstViewFahrplan
            // 
            this.lstViewFahrplan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstViewFahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewFahrplan.Location = new System.Drawing.Point(25, 382);
            this.lstViewFahrplan.Name = "lstViewFahrplan";
            this.lstViewFahrplan.Size = new System.Drawing.Size(905, 345);
            this.lstViewFahrplan.TabIndex = 13;
            this.lstViewFahrplan.UseCompatibleStateImageBehavior = false;
            this.lstViewFahrplan.View = System.Windows.Forms.View.Details;
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
            // lstStartStation
            // 
            this.lstStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStartStation.FormattingEnabled = true;
            this.lstStartStation.ItemHeight = 20;
            this.lstStartStation.Location = new System.Drawing.Point(25, 126);
            this.lstStartStation.Name = "lstStartStation";
            this.lstStartStation.Size = new System.Drawing.Size(292, 124);
            this.lstStartStation.TabIndex = 11;
            this.lstStartStation.SelectedIndexChanged += new System.EventHandler(this.lstStartStation_SelectedIndexChanged);
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
            // txtStartStation
            // 
            this.txtStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartStation.Location = new System.Drawing.Point(25, 99);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(292, 27);
            this.txtStartStation.TabIndex = 9;
            this.txtStartStation.TextChanged += new System.EventHandler(this.txtStartStation_TextChanged);
            // 
            // textBoxZeit
            // 
            this.textBoxZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZeit.Location = new System.Drawing.Point(379, 316);
            this.textBoxZeit.Name = "textBoxZeit";
            this.textBoxZeit.Size = new System.Drawing.Size(120, 27);
            this.textBoxZeit.TabIndex = 8;
            this.textBoxZeit.Text = "z.B. 13:30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(25, 314);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(292, 27);
            this.dateTimePicker.TabIndex = 5;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstAbfahrtstafel);
            this.groupBox2.Controls.Add(this.lstBoxStation);
            this.groupBox2.Controls.Add(this.txtBoxStation);
            this.groupBox2.Controls.Add(this.buttonStationSuchen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1036, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 749);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abfahrtstafel";
            // 
            // lstAbfahrtstafel
            // 
            this.lstAbfahrtstafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAbfahrtstafel.FormattingEnabled = true;
            this.lstAbfahrtstafel.ItemHeight = 25;
            this.lstAbfahrtstafel.Location = new System.Drawing.Point(41, 273);
            this.lstAbfahrtstafel.Name = "lstAbfahrtstafel";
            this.lstAbfahrtstafel.Size = new System.Drawing.Size(543, 454);
            this.lstAbfahrtstafel.TabIndex = 5;
            // 
            // lstBoxStation
            // 
            this.lstBoxStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxStation.FormattingEnabled = true;
            this.lstBoxStation.ItemHeight = 20;
            this.lstBoxStation.Location = new System.Drawing.Point(39, 126);
            this.lstBoxStation.Name = "lstBoxStation";
            this.lstBoxStation.Size = new System.Drawing.Size(292, 124);
            this.lstBoxStation.TabIndex = 4;
            this.lstBoxStation.SelectedIndexChanged += new System.EventHandler(this.lstBoxStation_SelectedIndexChanged);
            // 
            // txtBoxStation
            // 
            this.txtBoxStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStation.Location = new System.Drawing.Point(39, 99);
            this.txtBoxStation.Name = "txtBoxStation";
            this.txtBoxStation.Size = new System.Drawing.Size(292, 27);
            this.txtBoxStation.TabIndex = 3;
            this.txtBoxStation.TextChanged += new System.EventHandler(this.txtBoxStation_TextChanged);
            // 
            // buttonStationSuchen
            // 
            this.buttonStationSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStationSuchen.Location = new System.Drawing.Point(362, 99);
            this.buttonStationSuchen.Name = "buttonStationSuchen";
            this.buttonStationSuchen.Size = new System.Drawing.Size(223, 34);
            this.buttonStationSuchen.TabIndex = 2;
            this.buttonStationSuchen.Text = "Station suchen";
            this.buttonStationSuchen.UseVisualStyleBackColor = true;
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
            this.columnHeader3.Width = 239;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nach";
            this.columnHeader4.Width = 221;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gleis";
            this.columnHeader5.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 773);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.lstStart.ResumeLayout(false);
            this.lstStart.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVerbindungSuchen;
        private System.Windows.Forms.GroupBox lstStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZeit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStationSuchen;
        private System.Windows.Forms.ListBox lstEndStation;
        private System.Windows.Forms.ListBox lstStartStation;
        private System.Windows.Forms.TextBox txtEndStation;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.ListBox lstBoxStation;
        private System.Windows.Forms.TextBox txtBoxStation;
        private System.Windows.Forms.ListBox lstAbfahrtstafel;
        private System.Windows.Forms.ListView lstViewFahrplan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

