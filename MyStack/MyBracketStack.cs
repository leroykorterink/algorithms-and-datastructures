using System;

namespace MyStack
{
    public class MyBracketStack : MyStack<char>
    {
        public bool CheckBrackets(string brackets)
        {
            foreach (var character in brackets)
            {
                switch (character)
                {
                    case '(':
                        Push(character);
                        break;

                    case ')':
                        var token = Pop();

                        if (!CheckToken(token, character))
                            return false;

                        break;
                }
            }

            return true;
        }

        public bool CheckBrackets2(string brackets)
        {
            foreach (var character in brackets)
            {
                switch (character)
                {
                    case '(':
                    case '[':
                        Push(character);
                        break;

                    case ')':
                    case ']':
                        var token = Pop();

                        if (!CheckToken(token, character))
                            return false;

                        break;
                }
            }

            return true;
        }

        private static bool CheckToken(char token, char character) => (
            token == '(' && character == ')' ||
            token == '[' && character == ']'
        );
    }
}