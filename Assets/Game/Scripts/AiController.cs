using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class AiController : MonoBehaviour
{
    [Inject] private AiManager aiManager;
    [SerializeField] internal NavMeshAgent agent;
    private void Awake()
    {
    }
    private void Start() // OnEnable injection i�lemi tamamland�ktan sonra �a�r�l�r
    {
        Getmission();
    }
    public void Getmission()
    {
        IMission mission = aiManager.GetNextGorev();
        if (mission != null)
        {
            Debug.Log($"{gameObject.name} g�revi al�yor: {mission.MissionName}");
            mission.Execute(this);
        }
    }
    public void CoroutineStart(IEnumerator coroutine)
    {
        StartCoroutine(coroutine);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
