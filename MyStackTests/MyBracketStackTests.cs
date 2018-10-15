using MyStack;
using Xunit;

namespace MyStackTests
{
    public class MyBracketStackTests
    {
        [Fact]
        public void Should_CheckBalanceOfParenthesis()
        {
            var myStack = new MyBracketStack();

            var validParenthesisString = myStack.CheckBrackets("( ( ( ) ( ) ) )");
            var invalidParenthesisString = myStack.CheckBrackets("( ) )");

            Assert.True(validParenthesisString);
            Assert.False(invalidParenthesisString);
        }

        [Fact]
        public void Should_CheckBalanceOfParenthesisAndBrackets()
        {
            var myStack = new MyBracketStack();

            var validBracketString = myStack.CheckBrackets2("[ ( ( [ ] ) ) ( ) ]");
            var invalidBracketString = myStack.CheckBrackets2("( [ ) ]");

            Assert.True(validBracketString);
            Assert.False(invalidBracketString);
        }
    }
}