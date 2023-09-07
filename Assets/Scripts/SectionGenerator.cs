using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> sectionList;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(sectionList[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited the spawn");
    }
}
