using System;
using System.IO;
using LibGit2Sharp;

namespace LibGitTrouble {

    public class Program {

        //--- Class Methods ---
        public static void Main(string[] args)
            => Console.WriteLine($"Current directory is a git folder: {Repository.IsValid(Directory.GetCurrentDirectory())}");
    }
}
