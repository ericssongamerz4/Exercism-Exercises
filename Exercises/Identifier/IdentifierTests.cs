using Xunit;

#region Description
/*
 Add Identifier class with Clean method and tests

Introduces a new static class `Identifier` in the `Squeaky_Clean` namespace, featuring a `Clean` method that processes string identifiers by converting kebab-case to camelCase, replacing spaces with underscores, and omitting control characters, special characters, and Greek lowercase letters. 

Includes unit tests in `IdentifierTests` to validate the `Clean` method's functionality across various scenarios.

 
 */
#endregion

namespace Exercism_Exercises.Exercises.Identifier
{
    public class IdentifierTests
    {
        //1. Replace any spaces encountered with underscores
        [Fact]
        public void CleanSingleLetter()
        {
            Assert.Equal("A", Identifier.Clean("A"));
        }

        [Fact]
        public void CleanCleanString()
        {
            Assert.Equal("àḃç", Identifier.Clean("àḃç"));
        }

        [Fact]
        public void CleanStringWithSpaces()
        {
            Assert.Equal("my___Id", Identifier.Clean("my   Id"));
        }

        //2. Replace control characters with the upper case string "CTRL"
        [Fact]
        public void CleanStringWithControlChar()
        {
            Assert.Equal("myCTRLId", Identifier.Clean("my\0Id"));
        }

        [Fact]
        public void CleanEmptyString()
        {
            Assert.Equal(string.Empty, Identifier.Clean(string.Empty));

        }

        //3. Convert kebab-case to camelCase
        [Fact]
        public void ConvertKebabToCamelCase()
        {
            Assert.Equal("àḂç", Identifier.Clean("à-ḃç"));
        }
        [Fact]
        public void ConvertKebabToCamelCaseAlreadyUpper()
        {
            Assert.Equal("àḂç", Identifier.Clean("à-Ḃç"));

        }

        //4. Omit characters that aren't letters
        [Fact]
        public void CleanStringWithSpecialChars()
        {
            Assert.Equal("MyFinder", Identifier.Clean("My😀😀Finder😀"));
        }

        [Fact]
        public void CleanStringWithNumbers()
        {
            Assert.Equal("MyFinder", Identifier.Clean("1My2Finder3"));
        }

        //5. Omit Greek lower case letters
        [Fact]
        public void OmitLowerCaseGreekLetters()
        {
            Assert.Equal("MyΟFinder", Identifier.Clean("MyΟβιεγτFinder"));
        }

        [Fact]
        public void CombineConversions()
        {
            Assert.Equal("_AbcĐCTRL", Identifier.Clean("9 -abcĐ😀ω\0"));
        }
    }
}
