using UnrealBuildTool;

public class BlueprintExtraCreditTarget : TargetRules
{
	public BlueprintExtraCreditTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("BlueprintExtraCredit");
	}
}
