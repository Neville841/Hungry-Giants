using UnityEngine;

public class StackMission : IMission
{
    public string MissionName => "StackMission";

    public AiController aiController { get; set; }
    Unit unit;
    public StackMission(Unit unit)
    {
        this.unit = unit;
    }
    public void Execute(AiController controller)
    {
        aiController = controller;

        Debug.Log($"{controller.gameObject.name} ekmek taþýyor...");
        // Kesme iþlemleri burada yapýlabilir
    }
}