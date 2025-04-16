using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EizoKakumeiForFFmpeg
{
    class OutputOptionItem
    {
        public OutputOptionItem(string trackNumber, bool isOutput, string fileName, bool isReCombination)
        {
            this.trackNumber = trackNumber;
            this.isOutput = isOutput;
            this.fileName = fileName;
            this.isReCombination = isReCombination;
        }

        public OutputOptionItem(string trackNumber) 
        {
            this.trackNumber = trackNumber;
            this.isOutput = true;
            this.fileName = "%MOVIENAME%";
            this.isReCombination = false;
        }

        [Description("トラック名")]
        public string trackNumber { get; set; }
        [Description("出力")]
        public bool isOutput { get; set; }
        [Description("出力ファイル名")]
        public string fileName { get; set; }
        [Description("再結合")]
        public bool isReCombination {  get; set; }

        public override string ToString()
        {
            return $"{trackNumber},{isOutput},{fileName},{isReCombination}";
        }
    }
}
