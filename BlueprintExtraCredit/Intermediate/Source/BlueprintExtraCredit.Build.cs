using UnrealBuildTool;

public class BlueprintExtraCredit : ModuleRules
{
	public BlueprintExtraCredit(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
