using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class AiController : MonoBehaviour
{
    [Inject] private AiManager aiManager;
    [SerializeField] internal NavMeshAgent agent;
    AiMovement aiMovement;
    private void Awake()
    {
        aiMovement = new AiMovement(this);
    }
    private void Start() // OnEnable injection i�lemi tamamland�ktan sonra �a�r�l�r
    {
        aiManager.ZenjectTest();
        IMission mission = aiManager.GetNextGorev();
        if (mission != null)
        {
            Debug.Log($"{gameObject.name} g�revi al�yor: {mission.MissionName}");
            mission.Execute(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
