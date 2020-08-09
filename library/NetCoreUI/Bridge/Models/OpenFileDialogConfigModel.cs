using System.Collections.Generic;

namespace NetCoreUI.Bridge.Models
{
    internal class OpenFileDialogConfigModel
    {
        public string Title { get; set; }
        public string InitialDirectory { get; set; }
        public string FileName { get; set; }
        public IEnumerable<FileFilterModel> FileFilters { get; set; }
        public bool Multiselect { get; set; }
    }
}
