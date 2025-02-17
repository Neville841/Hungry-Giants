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

        Debug.Log($"{controller.gameObject.name} ekmek ta��yor...");
        // Kesme i�lemleri burada yap�labilir
    }
}