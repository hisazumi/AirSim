// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BlocksEditorTarget : TargetRules
{
	public BlocksEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.AddRange(new string[] { "Blocks" });
        	DefaultBuildSettings = BuildSettingsVersion.V2;
        	//bUseUnityBuild = false;
	        //bUsePCHFiles = false;
		// fix compile errors
		bOverrideBuildEnvironment = true;
		AdditionalCompilerArguments = "-Wno-unused-but-set-variable -Wno-bitwise-instead-of-logical -Wno-unused-but-set-variable -Wno-deprecated-builtins -Wno-single-bit-bitfield-constant-conversion";
    }
}
