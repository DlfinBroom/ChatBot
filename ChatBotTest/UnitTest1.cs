using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatBot;

namespace ChatBotTest
{
    [TestClass]
    public class ChatBotTest
    {
        [TestMethod]
        [DataRow("k")]
        [DataRow("Hello")]
        [DataRow("How are you?")]
        [DataRow("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
        /*200char*/"1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890")]
        public void Responce_Input_ValidEntry(string _input)
        {
            Responce res = new Responce();
            res.Input = _input;
            Assert.Equals(_input, res.Input);
        }

        [TestMethod]
        [DataRow("k")]
        [DataRow("Hello")]
        [DataRow("How are you?")]
        [DataRow("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
        /*200char*/"1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890")]
        public void Responce_OutPut_ValidEntry(string _output)
        {
            Responce res = new Responce();
            res.Output = _output;
            Assert.Equals(_output, res.Output);
        }
    }
}
