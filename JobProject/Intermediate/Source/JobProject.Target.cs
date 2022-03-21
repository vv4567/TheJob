using UnrealBuildTool;

public class JobProjectTarget : TargetRules
{
	public JobProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("JobProject");
	}
}
