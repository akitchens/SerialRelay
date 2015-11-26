// ***********************************************************************
// Assembly         : Serial Relay Controller
// Author           : Andrew Kitchens
// Created          : 11-24-2015
//
// Last Modified By : Andrew
// Last Modified On : 11-24-2015
// ***********************************************************************
// <copyright file="Form1.cs" company="AJK Services">
//     Copyright AJK Services © 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace SerialRelay
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.IO.Ports;
    using System.Linq;
    using System.Windows.Forms;
    using System.Configuration; 

    /// <summary>
    /// Serial relay main form.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Loads the configuration file.
        /// </summary>
        /// <returns>Dictionary of name and command pairs.</returns>
        private static IList<string[]> LoadConfigFile()
        {
            IList<string[]> commands = new List<string []>();

            // Load config file.
            // Check if file exists
            while (!File.Exists(Properties.Settings.Default.ConfigurationFile))
            {
                string message = "Config file not found. Please check settings and try again.";
                string caption = "File Not Found";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    SettingsForm setting = new SettingsForm();
                    setting.ShowDialog();
                    setting.Dispose();
                }
                else
                {
                    Application.Exit();
                    return commands;
                }
            }

            using (var reader = new StreamReader(File.OpenRead(Properties.Settings.Default.ConfigurationFile)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    string[] newCommand = new string[2] { values[0], values[1] };
                    commands.Add(newCommand);
                }
            }

            return commands;
        }

        /// <summary>
        /// Handles the Click event of the SettingsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm setting = new SettingsForm();
            setting.ShowDialog();
            setting.Dispose();
        }

        /// <summary>
        /// Handles the Click event of the quitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the AboutToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox = new About();
            aboutBox.ShowDialog();
            aboutBox.Dispose();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            IList<string []> commands = LoadConfigFile();

            // Create buttons.
            Button commandButton;
            foreach (string [] c in commands)
            {
                commandButton = new Button();
                commandButton.Width = 200;
                commandButton.Height = 50;
                commandButton.Font = new Font("Microsoft Sans Serif", Properties.Settings.Default.FontSize); 
                commandButton.Text = c[0];
                commandButton.Tag = c[1];
                commandButton.Click += new EventHandler(this.CommandButton_Click);           
                
                flpCommands.Controls.Add(commandButton);
            }
        }
                
        /// <summary>
        /// Handles the Click event of the CommandButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CommandButton_Click(object sender, EventArgs e)
        {
            // Send serial command.
            Button btn = sender as Button;
            string cmd = btn.Tag.ToString();

            // Reset back color on all buttons.
            foreach (Button button in flpCommands.Controls.OfType<Button>())
            {
                button.BackColor = default(Color);
            }
                        
            btn.BackColor = Color.Red;

            try
            {
                SerialPort port = new SerialPort(Properties.Settings.Default.DefaultPort, Properties.Settings.Default.BaudRate);
                port.Open();
                port.Write(cmd);
                port.Close();
                port.Dispose();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Error Sending Command";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
