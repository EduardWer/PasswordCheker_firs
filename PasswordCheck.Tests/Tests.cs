using System;
using NUnit.Framework;
using PasswordCheck;

namespace PasswordChecker.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Checkpassward_AJLHK_1exepted()
        {
            string passwaord = "AJLHK";
            int score = 1;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        
        [Test]
        public void Checkpassward_asdadas_1exepted()
        {
            string passwaord = "asdadas";
            int score = 1;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        
        [Test]
        public void Checkpassward_123123_1exepted()
        {
            string passwaord = "123123";
            int score = 1;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        [Test]
        public void Checkpassward_SpechChars_1exepted()
        {
            string passwaord = "*&%&#";
            int score = 1;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        
        [Test]
        public void Checkpassward_10chars_0exepted()
        {
            string passwaord = "1010101010";
            int score = 2;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
        
        
        [Test]
        public void Checkpassward_null_0exepted()
        {
            string passwaord = "";
            int score = 0;


            ParolChecker parolChecker = new ParolChecker();
            int action = parolChecker.ChecPassward(passwaord);
            
            Assert.AreEqual(action, score);
        }
    }
}