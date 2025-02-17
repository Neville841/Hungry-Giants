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
    private void Start() // OnEnable injection iþlemi tamamlandýktan sonra çaðrýlýr
    {
        aiManager.ZenjectTest();
        IMission mission = aiManager.GetNextGorev();
        if (mission != null)
        {
            Debug.Log($"{gameObject.name} görevi alýyor: {mission.MissionName}");
            mission.Execute(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
