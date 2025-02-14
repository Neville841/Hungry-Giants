using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiManager : MonoBehaviour
{
    private Queue<IMission> gorevListesi = new Queue<IMission>();

    
    private void Awake()
    {
        // Görevleri sýrayla ekliyoruz
        gorevListesi.Enqueue(new CuttingMission());
        gorevListesi.Enqueue(new StackMission());
    }
    public void ZenjectTest()
    {
        Debug.Log("test");
    }

    public IMission GetNextGorev()
    {
        if (gorevListesi.Count > 0)
            return gorevListesi.Dequeue();
        return null;
    }
}
