using UnrealBuildTool;

public class BuenasAmigosTarget : TargetRules
{
	public BuenasAmigosTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("BuenasAmigos");
	}
}
