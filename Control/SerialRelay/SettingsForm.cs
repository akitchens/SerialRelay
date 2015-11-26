// ***********************************************************************
// Assembly         : Serial Relay Controller
// Author           : Andrew Kitchens
// Created          : 11-24-2015
//
// Last Modified By : Andrew Kitchens
// Last Modified On : 11-24-2015
// ***********************************************************************
// <copyright file="SettingsForm.cs" company="AJK Services">
//     Copyright AJK Services © 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace SerialRelay
{
    using System;
    using System.Collections.Generic;
    using System.IO.Ports;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Settings form.
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsForm"/> class.
        /// </summary>
        public SettingsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the SettingsForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Load COM ports.
            foreach (string s in SerialPort.GetPortNames())
            {
                lbAvailableCOMPorts.Items.Add(s);
            }

            // Select default COM port. If not found, select first entry.
            int portIndex = lbAvailableCOMPorts.Items.IndexOf(Properties.Settings.Default.DefaultPort);
            lbAvailableCOMPorts.SelectedIndex = portIndex;

            // Load default settings.
            nudFontSize.Value = (int)Properties.Settings.Default.FontSize;
            int baudRateIndex = cbBaudRates.Items.IndexOf(Properties.Settings.Default.BaudRate.ToString());
            cbBaudRates.SelectedIndex = baudRateIndex;
            tbConfigFile.Text = Properties.Settings.Default.ConfigurationFile;
        }

        /// <summary>
        /// Handles the Click event of the save button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultPort = lbAvailableCOMPorts.SelectedItem.ToString();
            int baudRate = 9600;
            int.TryParse(cbBaudRates.SelectedItem.ToString(), out baudRate);
            Properties.Settings.Default.BaudRate = baudRate;
            Properties.Settings.Default.ConfigurationFile = tbConfigFile.Text;
            Properties.Settings.Default.FontSize = (float)nudFontSize.Value;

            Properties.Settings.Default.Save();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the cancel button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
