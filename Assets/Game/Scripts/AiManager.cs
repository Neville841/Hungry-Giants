using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiManager : MonoBehaviour
{
    private Queue<IMission> missionList = new Queue<IMission>();
    [SerializeField] Transform target;

    private void Awake()
    {
    }
    public void SetNewMission(IMission mission)
    {
        missionList.Enqueue(mission);
    }
    public IMission GetNextGorev()
    {
        if (missionList.Count > 0)
            return missionList.Dequeue();
        return null;
    }
}
