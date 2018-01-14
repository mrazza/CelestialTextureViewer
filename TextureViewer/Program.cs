// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="">
// Copyright (C) 2018 Matthew Razza
// </copyright>
// -----------------------------------------------------------------------

namespace TextureViewer
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
