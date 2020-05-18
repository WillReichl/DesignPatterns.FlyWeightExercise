using System;

namespace Coding.Exercise
{
    // https://www.udemy.com/course/design-patterns-csharp-dotnet/learn/quiz/350374#overview
    public class Sentence
    {
        private string text;
        public Sentence(string plainText)
        {
        }

        public WordToken this[int index]
        {
            get
            {
                // todo
            }
        }

        public override string ToString()
        {
            // output formatted text here
        }

        public class WordToken
        {
            public bool Capitalize;
        }
    }
}
