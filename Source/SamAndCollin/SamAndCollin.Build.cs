// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SamAndCollin : ModuleRules
{
	public SamAndCollin(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SamAndCollin",
			"SamAndCollin/Variant_Strategy",
			"SamAndCollin/Variant_Strategy/UI",
			"SamAndCollin/Variant_TwinStick",
			"SamAndCollin/Variant_TwinStick/AI",
			"SamAndCollin/Variant_TwinStick/Gameplay",
			"SamAndCollin/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
