using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttedPart : MonoBehaviour
{
    [SerializeField] internal string type;
    CuttingTable table;
    public void Cut(CuttingTable table, int delayMultiply)
    {
        this.table = table;
        gameObject.SetActive(true);
        transform.SetParent(table.transform);
        StartCoroutine(Stack(delayMultiply));
    }
    IEnumerator Stack(int delayMultiply)
    {
        yield return new WaitForSeconds(.3f * delayMultiply);
        transform.DORotate(Vector3.zero, .2f);
        transform.DOJump(GetStackPosition(), 1, 1, .2f).OnComplete(() =>
        {
            table.stacks.Add(this);
        });
    }
    Vector3 GetStackPosition()
    {
        CuttedPart lastPart = null;
        if (table.stacks.Count > 0)
            lastPart = table.stacks[table.stacks.Count - 1];
        float lastPartTop = 0;
        if (lastPart)
        {
            MeshRenderer lastRenderer = lastPart.GetComponent<MeshRenderer>();
            lastPartTop = +lastRenderer.bounds.max.y;
        }
        else lastPartTop = table.stackPosition.position.y;
        Debug.Log("lastPartTop"+lastPartTop);
        MeshRenderer currentRenderer = GetComponent<MeshRenderer>();
        float currentPartBottom = currentRenderer.bounds.min.y;
        Debug.Log("currentPartBottom" + currentPartBottom);

        // Yüksekliði ayarla
        float heightDifference = lastPartTop - currentPartBottom;
        Debug.Log("heightDifference" + heightDifference);

        Vector3 pos = table.stackPosition.position;
        pos.y = heightDifference + lastPartTop;

        return pos;
    }
}
