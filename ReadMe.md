# LibGit Linux Error

The following error occurs when the code is run on Amazon Linux 2.

```
$ dotnet run
```

```
Cloning https://github.com/LambdaSharp/AlexaEcho.git to /tmp/lrg211aq.x5c
Unhandled exception. System.TypeInitializationException: The type initializer for 'LibGit2Sharp.Core.NativeMethods' threw an exception.
 ---> System.DllNotFoundException: Unable to load shared library 'git2-106a5f2' or one of its dependencies. In order to help diagnose loading problems, consider setting the LD_DEBUG environment variable: libgit2-106a5f2: cannot open shared object file: No such file or directory
   at LibGit2Sharp.Core.NativeMethods.git_libgit2_init()
   at LibGit2Sharp.Core.NativeMethods.InitializeNativeLibrary()
   at LibGit2Sharp.Core.NativeMethods..cctor()
   --- End of inner exception stack trace ---
   at LibGit2Sharp.Core.NativeMethods.git_clone(git_repository*& repo, String origin_url, FilePath workdir_path, GitCloneOptions& opts)
   at LibGit2Sharp.Core.Proxy.git_clone(String url, String workdir, GitCloneOptions& opts)
   at LibGit2Sharp.Repository.Clone(String sourceUrl, String workdirPath, CloneOptions options)
   at LibGit2Sharp.Repository.Clone(String sourceUrl, String workdirPath)
   at LibGitTrouble.Program.Main(String[] args) in /mnt/c/LambdaSharp/LibGitTrouble/Program.cs:line 14
```