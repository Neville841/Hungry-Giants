using UnityEngine;

public class StackMission : IMission
{
    public string MissionName => "StackMission";

    public void Execute(AiController controller)
    {
        Debug.Log($"{controller.gameObject.name} ekmek taþýyor...");
        // Kesme iþlemleri burada yapýlabilir
    }
}