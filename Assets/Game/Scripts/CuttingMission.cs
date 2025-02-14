using UnityEngine;

public class CuttingMission : IMission
{
    public string MissionName => "CuttingMission";

    public void Execute(AiController controller)
    {
        Debug.Log($"{controller.gameObject.name} ekmek kesiyor...");
        // Kesme iþlemleri burada yapýlabilir
    }
}