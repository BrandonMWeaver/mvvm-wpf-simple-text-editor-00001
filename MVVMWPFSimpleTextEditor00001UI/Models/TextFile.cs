using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMWPFSimpleTextEditor00001UI.Models
{
    class TextFile
    {
        public string Path { get; set; }
        public string Text { get; set; }

        public void Save()
        {
            if (this.Path != null)
                File.WriteAllText(this.Path, this.Text);
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text (*.txt)|*.txt"
                };
                if (saveFileDialog.ShowDialog() == true)
                {
                    this.Path = saveFileDialog.FileName;
                    File.WriteAllText(saveFileDialog.FileName, this.Text);
                }
            }
        }
    }
}
