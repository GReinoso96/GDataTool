using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDataTool
{
    class StringHelper
    {
        public string ReadUntilNull(BinaryReader stream)
        {
            string str = "";
            char chr;
            while ((int)(chr = stream.ReadChar()) != 0)
                str += chr;
            return str;
        }
        public void WriteAddNull(string input, BinaryWriter bw)
        {
            byte[] bytes = Encoding.GetEncoding("shift_jis").GetBytes(input);
            foreach (byte b in bytes)
            {
                bw.Write(b);
            }
            bw.Write(new byte[] { 0x00 });
        }
    }
}
