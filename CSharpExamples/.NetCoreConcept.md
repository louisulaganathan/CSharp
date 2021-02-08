In 2002, Microsoft released .NET Framework, a development platform for creating Windows apps. Today .NET Framework is at version 4.8 and is still supported by Microsoft.

In 2014, Microsoft began writing a cross-platform, open-source successor to .NET Framework. This new implementation of .NET was named .NET Core until it reached version 3.1.
The next version after .NET Core 3.1 is .NET 5.0, which is currently in preview.
Version number 4 was skipped to avoid confusion between this implementation of .NET and .NET Framework 4.8.
The name "Core" was dropped to make clear that this is now the main implementation of .NET.

This article is about .NET 5, but much of the documentation for .NET 5 still has references to ".NET Core" or ".NET Framework".
In addition, "Core" remains in the names ASP.NET Core and Entity Framework Core.

The documentation also refers to .NET Standard. .NET Standard is an API specification that lets you develop class libraries for multiple implementations of .NET.

For more information, see .NET architectural components.

.NET Core is a cross-platform version of .NET for building websites, services, and console apps.

.NET Core 3.1 is an LTS release with support from Microsoft for the next three years. It's highly recommended that you move your apps to .NET Core 3.1.
The current lifecycle of other major releases is as follows:

Version	                Released	End of life	Version
.NET Framework 4.8  	4/18/19		            .NET Framework 4.8 (recommended)
.NET Framework 4.7.2	4/30/18		            .NET Framework 4.7.2
.NET Framework 4.7.1	10/17/17		        .NET Framework 4.7.1
.NET Framework 4.7	    4/5/17		            .NET Framework 4.8
.NET Framework 4.6.2	8/2/16		            .NET Framework 4.6.2
.NET Framework 4.6.1	11/30/15		        .NET Framework 4.6.1
.NET Framework 4.6	    7/20/15		            .NET Framework 4.7
.NET Framework 4.5.2	5/5/14		            .NET Framework 4.5.2
.NET Framework 4.5.1	10/17/13	1/12/16	    .NET Framework 4.5.1
.NET Framework 4.5	    8/15/12	    1/12/16	    .NET Framework 4.5
.NET Framework 4.0	    4/12/10	    1/12/16	    .NET Framework 4.0
.NET Framework 3.5 SP1	11/18/08	10/10/28	.NET Framework 3.5 SP2

LONG-TERM SUPPORT -3 yrs support
Supported versions
===================
Version	Original Release Date	    Latest Patch Version	Patch Release Date	Support Level	End of Support
.NET Core 3.1	December 3, 2019	3.1.9	                October 13, 2020	LTS	            December 3, 2022
.NET Core 2.1	May 30, 2018	    2.1.23	                October 13, 2020	LTS	            August 21, 2021

Out of Support versions
=======================
Version	        Original Release Date	Latest Patch Version	Patch Release Date	End of Support
.NET Core 3.0	September 23, 2019	    3.0.3	                February 18, 2020	March 3, 2020
.NET Core 2.2	December 4, 2018	    2.2.8	                November 19, 2019	December 23, 2019
.NET Core 2.0	August 14, 2017	        2.0.9	                July 10, 2018	    October 1, 2018
.NET Core 1.1	November 16, 2016	    1.1.13	                May 14, 2019	    June 27 2019
.NET Core 1.0	June 27, 2016	        1.0.16	                May 14, 2019	    June 27 2019

.NET Core 3.0	End of life on March 3, 2020.
.NET Core 2.2	End of life on December 23, 2019.
.NET Core 2.1	End of life on August 21, 2021.

.NET Core 2.1 and .NET Core 3.1 are the current LTS releases made available on August 2018 and December 2019, respectively.
After .NET Core 3.1, the product will be renamed to .NET and LTS releases will be made available every other year in November.
So, the next LTS release will be .NET 6, which will ship in November 2021.
This will help customers plan upgrades more effectively. For policy details, see the .NET Core and .NET 5 support policy page.


Preview releases
=================

Version	    Release Date	    End of Support
.NET 5 RC 2	October 13, 2020	November 10, 2020
.NET 5 RC 1	September 14, 2020	October 13, 2020

CI/CD
======
MSBuild and the .NET CLI can be used with various continuous integration tools and environments, such as:

GitHub Actions
Azure DevOps
CAKE
FAKE

NuGet
======
NuGet is an open-source package manager designed for .NET.
A NuGet package is a .zip file with the .nupkg extension that contains compiled code (DLLs), other files related to that code,
 and a descriptive manifest that includes information like the package's version number.
Developers with code to share create packages and publish them to nuget.org or a private host. D
evelopers who want to use shared code add a package to their project and can then call the API exposed by the package in their project code.

CLR
=====
The .NET CLR is a cross-platform runtime that includes support for Windows, macOS, and Linux.
The CLR handles memory allocation and management.
The CLR is also a virtual machine that not only executes apps but also generates and compiles code using a just-in-time (JIT) compiler.

JIT compiler and IL
=====================
Higher-level .NET languages, such as C#, compile down to a hardware-agnostic instruction set, which is called Intermediate Language (IL).
When an app runs, the JIT compiler translates IL to machine code that the processor understands.
JIT compilation happens on the same machine that the code is going to run on.

Since JIT compilation occurs during execution of the application, the compilation time is part of the run time.

AOT compiler
=============
The default experience for most .NET workloads is the JIT compiler, but .NET offers two forms of ahead-of-time (AOT) compilation:

Some scenarios require 100% AOT compilation. An example is iOS[xamerin.ios SDK].
In other scenarios, most of an app's code is AOT-compiled but some is JIT-compiled. Some code patterns aren't friendly to AOT (like generics).
An example of this form of AOT compilation is the ready-to-run publish option. This form of AOT offers the benefits of AOT without its drawbacks.