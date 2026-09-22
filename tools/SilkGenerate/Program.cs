// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Silk.NET.BuildTools ships as a library on NuGet (lib/net6.0, no tool manifest), so this thin
// host exists purely to give its entry point an executable to live in. It is a straight
// delegation: all arguments are passed through to BuildTools verbatim.
//
//   dotnet run --project tools/SilkGenerate -- generator.json
//   dotnet run --project tools/SilkGenerate -- generator.json --profile=EGL
//
// Run it from the repository root; paths in generator.json are relative to the working directory.
public static class SilkGenerate
{
    public static int Main(string[] args) => Silk.NET.BuildTools.Program.Main(args);
}
