using System.Collections;
using UnityEngine;
using DG.Tweening;
public class CuttingMission : IMission
{
    public string MissionName => "CuttingMission";

    public AiController aiController { get; set; }

    Unit unit;
    public CuttingMission(Unit unit)
    {
        this.unit = unit;
    }
    public void Execute(AiController controller)
    {
        aiController = controller;

        aiController.agent.SetDestination(unit.agentPos.position);
        aiController.CoroutineStart(Movement());
        //Coroutine burda çalýþacak
        Debug.Log($"{controller.gameObject.name} ekmek kesiyor...");
        // Kesme iþlemleri burada yapýlabilir
    }
    IEnumerator Movement()
    {
        float distance = 0;
        distance = Vector3.Distance(aiController.transform.position, unit.agentPos.position);
        while (distance > .5f)
        {
            distance = Vector3.Distance(aiController.transform.position, unit.agentPos.position);
            yield return null;
        }
        aiController.transform.DORotate(unit.agentPos.transform.rotation.eulerAngles, .5f);

        Debug.Log($"{aiController.gameObject.name} hedefe ulaþtý.");
        yield return new WaitForSeconds(1f);
        MissionComplete();
    }
    void MissionComplete()
    {
        if (unit is CuttingTable cuttingTable)
        {
            cuttingTable.Cut();
        }
        aiController.Getmission();
    }
}