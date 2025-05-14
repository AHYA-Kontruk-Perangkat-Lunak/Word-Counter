using System;

namespace SimpleWordCounter.Features
{
    public class JumlahKalimat
    {
        private enum State { InText, EndPunctuation }

        public static int CountSentences(string text)
        {
            State currentState = State.InText;
            int sentenceCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                switch (currentState)
                {
                    case State.InText:
                        if (c == '.' || c == '!' || c == '?')
                        {
                            sentenceCount++;
                            currentState = State.EndPunctuation;
                        }
                        break;

                    case State.EndPunctuation:
                        if (!char.IsWhiteSpace(c) && char.IsLetterOrDigit(c))
                        {
                            currentState = State.InText;
                        }
                        break;
                }
            }

            return sentenceCount;
        }
    }
}
