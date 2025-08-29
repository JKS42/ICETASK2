// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ICETASK : ModuleRules
{
	public ICETASK(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ICETASK",
			"ICETASK/Variant_Platforming",
			"ICETASK/Variant_Platforming/Animation",
			"ICETASK/Variant_Combat",
			"ICETASK/Variant_Combat/AI",
			"ICETASK/Variant_Combat/Animation",
			"ICETASK/Variant_Combat/Gameplay",
			"ICETASK/Variant_Combat/Interfaces",
			"ICETASK/Variant_Combat/UI",
			"ICETASK/Variant_SideScrolling",
			"ICETASK/Variant_SideScrolling/AI",
			"ICETASK/Variant_SideScrolling/Gameplay",
			"ICETASK/Variant_SideScrolling/Interfaces",
			"ICETASK/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
