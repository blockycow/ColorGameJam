using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SectionGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> sectionList;
    private bool acceptSpawn;

    [SerializeField] private float waitTime;
    private float timer;

    [SerializeField] private GameObject previousSection;
    [SerializeField] private float sectionDistance = 20f;
    
    private void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > waitTime)
        {
            timer -= waitTime;

            SpawnSection();
        }
    }

    private void SpawnSection()
    {
        previousSection = Instantiate(sectionList[0],previousSection.transform.position + new Vector3(sectionDistance,0,0),quaternion.identity);
    }
}
