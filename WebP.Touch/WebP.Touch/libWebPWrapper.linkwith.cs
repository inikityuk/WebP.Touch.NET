using System;
using ObjCRuntime;

[assembly: LinkWith ("libWebPWrapper.a", LinkTarget.Simulator64 | LinkTarget.Arm64, ForceLoad = true)]
