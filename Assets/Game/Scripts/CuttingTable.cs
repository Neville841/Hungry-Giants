using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingTable : Unit
{
    [SerializeField] internal Transform knife;
    [SerializeField] Cuttable selectedVegatable;
    [SerializeField] internal Transform stackPosition;
    [SerializeField] internal List<CuttedPart> stacks;
    void Start()
    {
        aiManager.SetNewMission(new CuttingMission(this));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Cut()
    {
        selectedVegatable.Cut();
    }
}
