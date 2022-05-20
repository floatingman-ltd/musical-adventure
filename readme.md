# Testing and Code in the Same Assembly

Other languages have the concept of code and test in the same library.  

Let's do this for c#.

## End Result

We want a _dotnet_ installable template, that we can execute from the command line.

```sh
dotnet new console-in-one
dotnet new classlib-in-one
```

In both cases I expect an opinionated environment.

How opinionated?  

- the nuget packages for _xUnit_, _FluentAssertions_ and _nSubstitute_ to be installed.
- the default code file created to have a section of tests delineated with `#if DEBUG` and `#endif`
- a default **hello-world** test t0 be embedded in the test section
- the *.csproj file will have a conditional section included which containes the test library packages only for debug
  - this may or may not be required ...

## Intermediate Result

The _dotnet_ install script should look like this:

```sh
dotnet new install test-in-one
```

This means that the test-in-on needs to be deployed to _nuget_.

## Sources

- [Tutorial - Create template package](https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-template-package)
- [Custom Templates](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)
- [How to create you own templates for dotnet new](https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/)
