using System;
using ObjCRuntime;

[assembly: LinkWith ("AMapFoundationKit.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true)]
