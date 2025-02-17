using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuttable : MonoBehaviour
{
    [SerializeField] internal string type;
    [SerializeField] List<CuttedPart> parts;
    [SerializeField] CuttingTable table;
    public void Cut()
    {
        for (int i = 0; i < parts.Count; i++)
        {
            parts[i].Cut(table,i);
        }
        Destroy(gameObject);
    }
}