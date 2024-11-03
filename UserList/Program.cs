// Author: William Owen
// Created: November 3, 2024
// Description: This program is a windows form app that allows the user to type a name
//    in a textbox and add them to a user list When the array gets to 10 elements,
//    pop up a messagebox telling the user that no more names may be entered.
//    Finally the user can click a display button that will show the SORTED
//    list of names in REVERSE alphabetical order.


namespace UserList
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Read names from file
           


            Application.Run(new FormMain());
        }

      
    }
}