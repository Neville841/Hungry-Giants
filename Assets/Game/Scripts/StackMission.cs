using UnityEngine;

public class StackMission : IMission
{
    public string MissionName => "StackMission";

    public void Execute(AiController controller)
    {
        Debug.Log($"{controller.gameObject.name} ekmek ta��yor...");
        // Kesme i�lemleri burada yap�labilir
    }
}