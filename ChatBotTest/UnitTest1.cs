using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatBot;
using System;

namespace ChatBotTest
{
    /*
    [TestClass]
    public class ChatBotTest
    {
        [TestMethod]
        [DataRow("k")]
        [DataRow("Hello")]
        [DataRow("How are you?")]
        [DataRow("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
        /*200char"1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890")]
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
        /*200char"1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890")]
        public void Responce_OutPut_ValidEntry(string _output)
        {
            Responce res = new Responce();
            res.Output = _output;
            Assert.Equals(_output, res.Output);
        }

        [TestMethod]
        [DataRow("")]
        public void Responce_Input_NullEntry(string _input)
        {
            Exception ex = null;
            try
            {
                Responce res = new Responce();
                res.Input = _input;
            }
            catch(ArgumentNullException ae)
            {
                ex = ae;
            }
            Assert.IsNotNull(ex);
        }

        [TestMethod]
        [DataRow("")]
        public void Responce_Output_NullEntry(string _output)
        {
            Exception ex = null;
            try
            {
                Responce res = new Responce();
                res.Output = _output;
            }
            catch (ArgumentNullException ae)
            {
                ex = ae;
            }
            Assert.IsNotNull(ex);
        }

        [TestMethod]
        [DataRow("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
        /*201char"12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901")]
        [DataRow("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
        /*300char"1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
                   "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890")]
        public void Responce_Input_LargeEntry(string _input)
        {
            Exception ex = null;
            try
            {
                Responce res = new Responce();
                res.Input = _input;
            }
            catch (ArgumentOutOfRangeException ao)
            {
                ex = ao;
            }
            Assert.IsNotNull(ex);
        }

        [TestMethod]
        [DataRow("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
        /*201char"12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901")]
        [DataRow("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
        /*300char"1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
                   "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890")]
        public void Responce_Output_LargeEntry(string _output)
        {
            Exception ex = null;
            try
            {
                Responce res = new Responce();
                res.Output = _output;
            }
            catch (ArgumentOutOfRangeException ao)
            {
                ex = ao;
            }
            Assert.IsNotNull(ex);
        }
    }
    */
}
