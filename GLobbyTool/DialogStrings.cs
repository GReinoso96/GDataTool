using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLobbyTool
{
    class DialogStrings
    {
        private UInt32 unknown;
        private string dialog;
        private bool skip;
        private long stringOffset;

        public DialogStrings(uint unknown)
        {
            this.Unknown = unknown;
        }

        public uint Unknown { get => unknown; set => unknown = value; }
        public string Dialog { get => dialog; set => dialog = value; }
        public bool Skip { get => skip; set => skip = value; }
        public long StringOffset { get => stringOffset; set => stringOffset = value; }
    }
}
