using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLobbyTool
{
    class StringHelper
    {
        public string ReadUntilNull(BinaryReader stream)
        {
            string str = "";
            char chr;
            while ((int)(chr = stream.ReadChar()) != 0)
            {
                if (chr != 0x0a)
                {
                    str += chr;
                }
                else
                {
                    str += "\r\n";
                }
            }
            return str;
        }
        public void WriteAddNull(string input, BinaryWriter bw)
        {
            input = input.Replace("\r\n", "\n");
            byte[] bytes = Encoding.GetEncoding("shift_jis").GetBytes(input);
            int charNum = 1;
            foreach (byte b in bytes)
            {
                if (charNum != 23 || b != 0x0A)
                {
                    bw.Write(b);
                }
                else
                {
                    charNum = 0;
                }
                charNum++;
            }
            bw.Write(new byte[] { 0x00 });
        }
    }
}
