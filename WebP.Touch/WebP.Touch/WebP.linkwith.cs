using System;
using ObjCRuntime;

[assembly: LinkWith ("WebP.a", LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
