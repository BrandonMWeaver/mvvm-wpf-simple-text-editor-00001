using Microsoft.Win32;
using MVVMWPFSimpleTextEditor00001UI.Models;
using MVVMWPFSimpleTextEditor00001UI.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMWPFSimpleTextEditor00001UI.ViewModels
{
    class TextFileViewModel : NotificationBase
    {
        private TextFile _textFile;

        public TextFile TextFile
        {
            get { return this._textFile; }
            set
            {
                this._textFile = value;
                this.OnPropertyChanged(nameof(this.TextFile));
            }
        }

        public VoidCommand NewCommand { get; set; }
        public VoidCommand OpenCommand { get; set; }
        public VoidCommand SaveCommand { get; set; }
        public VoidCommand ExitCommand { get; set; }

        public TextFileViewModel()
        {
            this.TextFile = new TextFile();

            this.NewCommand = new VoidCommand(New);
            this.OpenCommand = new VoidCommand(Open);
            this.SaveCommand = new VoidCommand(Save);
            this.ExitCommand = new VoidCommand(Exit);
        }

        private void New()
        {
            this.TextFile = new TextFile();
        }

        private void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text (*.txt)|*.txt"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                this.TextFile = new TextFile
                {
                    Path = openFileDialog.FileName,
                    Text = File.ReadAllText(openFileDialog.FileName)
                };
            }
        }

        private void Save()
        {
            this.TextFile.Save();
        }

        private void Exit()
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
