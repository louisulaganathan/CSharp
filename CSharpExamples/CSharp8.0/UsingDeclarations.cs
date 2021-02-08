using System;
using System.Collections.Generic;

namespace CSharp8._0
{
    public class UsingDeclarations
    {
        //A using declaration is a variable declaration preceded by the using keyword.
        //It tells the compiler that the variable being declared should be disposed at the end of the enclosing scope.
        public UsingDeclarations()
        {
        }

        //C# 8.0 Syntax
        static int WriteLinesToFile(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            // Notice how we declare skippedLines after the using statement.
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file is disposed here
        }

        //C# < 8.0 syntax
        static int WriteLinesToFile1(IEnumerable<string> lines)
        {
            // We must declare the variable outside of the using block
            // so that it is in scope to be returned.
            int skippedLines = 0;
            using (var file = new System.IO.StreamWriter("WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                    else
                    {
                        skippedLines++;
                    }
                }
                return skippedLines;
            } // file is disposed here
        }
    }
}
