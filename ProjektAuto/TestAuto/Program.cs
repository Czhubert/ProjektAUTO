﻿using System;
using Octokit.Caching;
using Octokit.Internal;









var gitHubClient = new GitHubClient(new ProductHeaderValue("ProjektTestowy"));

var sb = new StringBuilder("---");
sb.AppendLine();
sb.AppendLine($"date: \"2024-02-01\"");
sb.AppendLine($"title: \"Nowy test\"");
sb.AppendLine("tags: [csharp, azure, dotnet, java]");
sb.AppendLine("---");
sb.AppendLine();

sb.AppendLine("# The heading for my first post");
sb.AppendLine();

var (owner, repoName, filePath, branch) = ("Czechhubert", "daveabrock.github.io", 
        "_posts/2021-05-02-my-new-post.markdown", "main");

await gitHubClient.Repository.Content.CreateFile(
     owner, repoName, filePath,
     new CreateFileRequest($"First commit for {filePath}", sb.ToString(), branch)); 