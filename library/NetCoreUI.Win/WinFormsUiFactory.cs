﻿using NetCoreUI.Bridge;

namespace NetCoreUI.Win
{
    internal class WinFormsUiFactory : IUiFactory
    {
        public IWindow CreateWindow(WindowConfiguration config, WebviewBridge bridge)
        {
            return new WinFormsWindow(bridge);
        }

        public IStatusIcon CreateStatusIcon(string title)
        {
            return new WinFormsStatusIcon(title);
        }

        public IMessageBox CreateMessageBox()
        {
            return new WinFormsMessageBox();
        }

        public ISaveFileDialog CreateSaveFileDialog()
        {
            return new WinFormsSaveFileDialog();
        }

        public IOpenFileDialog CreateOpenFileDialog()
        {
            return new WinFormsOpenFileDialog();
        }

        public IFolderSelectDialog CreateFolderSelectDialog()
        {
            return new WinFormsFolderSelectDialog();
        }

        public IMenu CreateMenu()
        {
            return new WinFormsMenu();
        }

        public ILabelMenuItem CreateLabelMenu(string label)
        {
            return new WinFormsLabelMenuItem(label);
        }

        public IMenuItem CreateMenuSeparator()
        {
            return new WinFormsSeparatorMenuItem();
        }
    }
}
