using MVVMWPFSimpleTextEditor00001UI.Models;
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

        public TextFileViewModel()
        {
            this.TextFile = new TextFile();
        }
    }
}
