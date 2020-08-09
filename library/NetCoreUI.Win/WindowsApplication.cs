﻿namespace NetCoreUI.Win
{
    /// <summary>
    /// Provides Windows specific application methods.
    /// </summary>
    public static class WindowsApplication
    {
        /// <summary>
        /// Gets or sets which webview version should be used at most.
        /// </summary>
        public static WebviewType WebviewType { get; set; }

        internal static string ContentServerAddress
        {
            get { return app.ContentServer.HostAddress; }
        }

        private static WinFormsApplication app;

        /// <summary>
        /// Initializes the application.
        /// </summary>
        public static void Init()
        {
            WebviewType = WebviewType.Latest;

            app = new WinFormsApplication();
            Application.Register(app, OperatingSystem.Windows);
        }
    }
}
