---
title: dotnet-msbuild command - .NET Core CLI | Microsoft Docs
description: The dotnet-msbuild command provides access to the MSBuild command line.
keywords: dotnet-msmsbuild, CLI, CLI command, .NET Core
author: blackdwarf
ms.author: mairaw
ms.date: 05/24/2017
ms.topic: article
ms.prod: .net-core
ms.technology: dotnet-cli
ms.devlang: dotnet
ms.assetid: ffdc40ba-ef33-463e-aa35-b0af1fe615a2
---

# dotnet-msbuild

## Name

`dotnet-msbuild` - Builds a project and all of its dependencies.

## Synopsis

`dotnet msbuild <msbuild_arguments> [-h]`

## Description

The `dotnet msbuild` command allows access to a fully functional MSBuild.

The command has the exact same capabilities as existing MSBuild command-line client. The options are all the same. Use the [MSBuild Command-Line Reference](/visualstudio/msbuild/msbuild-command-line-reference) to obtain information on the available options. 

## Examples

Build a project and its dependencies:

`dotnet msbuild`

Build a project and its dependencies using Release configuration:

`dotnet msbuild /p:Configuration=Release`

Run the publish target and publish for the `osx.10.11-x64` RID:

`dotnet msbuild /t:Publish /p:RuntimeIdentifiers=osx.10.11-x64`

See the whole project with all targets included by the SDK:

`dotnet msbuild /pp`