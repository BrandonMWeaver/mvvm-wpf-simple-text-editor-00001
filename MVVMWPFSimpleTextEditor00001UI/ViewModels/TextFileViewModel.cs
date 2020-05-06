using MVVMWPFSimpleTextEditor00001UI.Models;
using MVVMWPFSimpleTextEditor00001UI.ViewModels.Commands;
using System;
using System.Collections.Generic;
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

        public VoidCommand ExitCommand { get; set; }

        public TextFileViewModel()
        {
            this.TextFile = new TextFile();

            this.ExitCommand = new VoidCommand(Exit);
        }

        private void Exit()
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
