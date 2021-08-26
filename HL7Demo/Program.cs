using HL7.Dotnetcore;
using System;

namespace HL7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string hl7_str = @"MSH|^~\&|VOXELCLOUD|CENTER1|LIMAGE|CENTER|20210826102604.0525||ACK^T02^ACK|377101|P|2.5
MSA|AR|377101|No appropriate destination could be found to which this message could be routed";
            Message message = new Message(hl7_str);
            bool f = message.ParseMessage();
            string s = message.GetValue("MSH.9");
            bool fff = message.SetValue("MSH.9", "ACK");
            string ss = message.GetValue("MSH.9");
            //SetValue之后需要SerializeMessage一下
            string strUpdatedMsg = message.SerializeMessage(false);
            Console.WriteLine(message.HL7Message);
            Console.ReadLine();
        }
    }
}
