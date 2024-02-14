using System.Collections.Generic;

namespace FAQ_app.Store
{
    public class DataStore
    {
        public static List<FAQmodel> FAQList { get; private set; }

        static DataStore()
        {
            InitializeFAQList();
        }

        private static void InitializeFAQList()
        {
            FAQList = new List<FAQmodel>
            {
                // C# FAQs
                new FAQmodel
                {
                    Question = "What is C#?",
                    Answer = "C# is a programming language developed by Microsoft.",
                    Topic = "C#",
                    Category = "General"
                },
                new FAQmodel
                {
                    Question = "How to declare a variable in C#?",
                    Answer = "You can declare a variable using the 'var' keyword, like 'var myVar = 10;'",
                    Topic = "C#",
                    Category = "General"
                },
                new FAQmodel
                {
                    Question = "Who is the creator of C#?",
                    Answer = "C# was created by Anders Hejlsberg at Microsoft.",
                    Topic = "C#",
                    Category = "History"
                },
                new FAQmodel
                {
                    Question = "When was C# first introduced?",
                    Answer = "C# was first introduced with the release of Visual Studio.NET in 2000.",
                    Topic = "C#",
                    Category = "History"
                },

                // Bootstrap FAQs
                new FAQmodel
                {
                    Question = "What is Bootstrap?",
                    Answer = "Bootstrap is a popular open-source front-end framework for building responsive and mobile-first websites.",
                    Topic = "Bootstrap",
                    Category = "General"
                },
                new FAQmodel
                {
                    Question = "How to include Bootstrap in a web project?",
                    Answer = "You can include Bootstrap in your project by adding the Bootstrap CSS and JavaScript files to your HTML document or by using a CDN (Content Delivery Network).",
                    Topic = "Bootstrap",
                    Category = "General"
                },
                new FAQmodel
                {
                    Question = "Who developed Bootstrap?",
                    Answer = "Bootstrap was originally developed by Twitter and is now maintained as an open-source project on GitHub.",
                    Topic = "Bootstrap",
                    Category = "History"
                },

                // JavaScript FAQs
                new FAQmodel
                {
                    Question = "What is JavaScript?",
                    Answer = "JavaScript is a high-level, interpreted programming language primarily used for building dynamic and interactive web pages.",
                    Topic = "JavaScript",
                    Category = "General"
                },
                new FAQmodel
                {
                    Question = "How to declare a variable in JavaScript?",
                    Answer = "You can declare a variable in JavaScript using the 'var', 'let', or 'const' keywords, like 'var myVar = 10;'",
                    Topic = "JavaScript",
                    Category = "General"
                },
                new FAQmodel
                {
                    Question = "What are the key features of JavaScript?",
                    Answer = "JavaScript features include being lightweight, versatile, and capable of asynchronous programming. It is mainly used for client-side web development.",
                    Topic = "JavaScript",
                    Category = "History"
                },
                new FAQmodel
                {
                    Question = "Who created JavaScript?",
                    Answer = "JavaScript was created by Brendan Eich while he was working at Netscape Communications Corporation.",
                    Topic = "JavaScript",
                    Category = "History"
                },
            };
        }
    }
}
