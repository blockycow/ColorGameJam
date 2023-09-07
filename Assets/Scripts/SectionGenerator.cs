using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SectionGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> sectionList;

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("exit");
        Instantiate(sectionList[0],this.transform.position,quaternion.identity);
    }
}
