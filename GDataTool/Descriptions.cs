using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDataTool
{
    class Descriptions
    {
        private UInt32 offset1;
        private UInt32 offset2;
        private UInt32 offset3;
        private UInt32 offset4;
        private string line1;
        private string line2;
        private string line3;
        private string line4;

        public Descriptions()
        {
        }

        public uint Offset1 { get => offset1; set => offset1 = value; }
        public uint Offset2 { get => offset2; set => offset2 = value; }
        public uint Offset3 { get => offset3; set => offset3 = value; }
        public uint Offset4 { get => offset4; set => offset4 = value; }
        public string Line1 { get => line1; set => line1 = value; }
        public string Line2 { get => line2; set => line2 = value; }
        public string Line3 { get => line3; set => line3 = value; }
        public string Line4 { get => line4; set => line4 = value; }
    }
}
