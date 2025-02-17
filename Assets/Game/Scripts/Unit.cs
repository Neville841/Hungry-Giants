using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Unit : MonoBehaviour
{
    [Inject] internal AiManager aiManager;
    [SerializeField] internal Transform agentPos;

    void Start()
    {
    }

    void Update()
    {

    }
}
