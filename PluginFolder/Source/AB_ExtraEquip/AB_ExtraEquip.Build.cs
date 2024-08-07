using UnrealBuildTool;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Text;
using EpicGames.Core;

public class AB_ExtraEquip : ModuleRules
{
	public AB_ExtraEquip(ReadOnlyTargetRules Target) : base(Target) {
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new[] {
			"Core", "CoreUObject",
			"Engine",
			"DeveloperSettings",
			"PhysicsCore",
			"InputCore",
			"OnlineSubsystem", "OnlineSubsystemNull", "OnlineSubsystemUtils",
			"SignificanceManager",
			"GeometryCollectionEngine",
			"ChaosVehiclesCore", "ChaosVehicles", "ChaosSolverEngine",
			"AnimGraphRuntime",
			"AkAudio",
			"AssetRegistry",
			"NavigationSystem",
			"ReplicationGraph",
			"AIModule",
			"GameplayTasks",
			"SlateCore", "Slate", "UMG",
			"RenderCore",
			"CinematicCamera",
			"Foliage",
			"Niagara",
			"EnhancedInput",
			"GameplayCameras",
			"TemplateSequence",
			"NetCore",
			"GameplayTags",
		});

		// FactoryGame plugins
		PublicDependencyModuleNames.AddRange(new[] {
			"AbstractInstance",
			"SignificanceISPC"
		});

		// Header stubs
		PublicDependencyModuleNames.AddRange(new[] {
			"DummyHeaders",
		});


		if (Target.Type == TargetRules.TargetType.Editor) {
			PublicDependencyModuleNames.AddRange(new string[] {"OnlineBlueprintSupport", "AnimGraph"});
		}

		PublicDependencyModuleNames.AddRange(new string[] {"FactoryGame", "SML"});
	}
}