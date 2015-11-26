// ***********************************************************************
// Assembly         : Serial Relay Controller
// Author           : Andrew Kitchens
// Created          : 11-24-2015
//
// Last Modified By : Andrew Kitchens
// Last Modified On : 11-24-2015
// ***********************************************************************
// <copyright file="Program.cs" company="AJK Services">
//     Copyright AJK Services © 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace SerialRelay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Serial sender program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
