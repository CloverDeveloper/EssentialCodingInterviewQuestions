using NUnit.Framework;
using StringQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTests.StringQuestions
{
    [TestFixture]
    public class NonRepeatingCharacterTest
    {
        [Test]
        public void Test() 
        {
            NonRepeatingCharacter nonRepeatingCharacter = new NonRepeatingCharacter();

            var str = "aabbcd";

            Assert.AreEqual("c", nonRepeatingCharacter.GetNonRepeatingCharacter(str));

            str = "aabb";

            Assert.AreEqual(null, nonRepeatingCharacter.GetNonRepeatingCharacter(str));

            str = "xxyz";

            Assert.AreEqual("y", nonRepeatingCharacter.GetNonRepeatingCharacter(str));

            str = "abacc";

            Assert.AreEqual("b", nonRepeatingCharacter.GetNonRepeatingCharacter(str));
        }
    }
}
