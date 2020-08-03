#!/bin/bash
# First argument is the root directory name (0-add)
# Second argument is the namespace (MyMath)
# Third argument is the class name (Operations)

mkdir $1
cd $1

dotnet new sln

mkdir $2

cd $2
dotnet new classlib

mv Class1.cs $2.cs

sed -i '/<\/PropertyGroup>/i <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml<\/DocumentationFile>' $2.csproj

cd ..
dotnet sln add $2/$2.csproj

mkdir $2.Tests
cd $2.Tests

dotnet new nunit
mv *.cs $2.Tests.cs

dotnet add reference ../$2/$2.csproj

cd ..
dotnet sln add $2.Tests/$2.Tests.csproj

sed -i "s/Class1/$3/" $2/$2.cs
