// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LetMeBe : ModuleRules
{
	public LetMeBe(ReadOnlyTargetRules Target) : base(Target)
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
			"LetMeBe",
			"LetMeBe/Variant_Strategy",
			"LetMeBe/Variant_Strategy/UI",
			"LetMeBe/Variant_TwinStick",
			"LetMeBe/Variant_TwinStick/AI",
			"LetMeBe/Variant_TwinStick/Gameplay",
			"LetMeBe/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
