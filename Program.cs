using System;
using System.IO;
using LibGit2Sharp;

namespace LibGitTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            var gitUrl = "https://github.com/LambdaSharp/AlexaEcho.git";
            var folder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Console.WriteLine($"Cloning {gitUrl} to {folder}");
            string clonedRepoPath = Repository.Clone(gitUrl, folder);
        }
    }
}
