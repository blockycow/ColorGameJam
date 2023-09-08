using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class SectionGenerator : MonoBehaviour
{
    //list of possible sections to spawn
    [SerializeField] private List<Section> sectionList;

    [SerializeField] private float waitTime;
    private float timer;

    [SerializeField] private Section previousSection;
    [SerializeField] private Section currentSection;
    [SerializeField] private float sectionDistance = 20f;
    
    private void Update()
    {
        timer += Time.deltaTime;
    }

    private void SpawnSection()
    {
        int randomSection = Random.Range(0, sectionList.Count);
        previousSection = currentSection;
        currentSection = Instantiate(sectionList[randomSection].gameObject,
            this.transform.position/*+ new Vector3(sectionList[randomSection].gameObject.GetComponent<BoxCollider2D>().size.x/2,0,0)*/,
            quaternion.identity).GetComponent<Section>();
        
        SetSection();
    }

    private void SetSection()
    {
        currentSection.SetColor((MovementColor)Random.Range(0,3));

        if (currentSection.MovementColor == previousSection.MovementColor)
        {
            currentSection.Portal.DeactivatePortal();
        }
        else
        {
            currentSection.Portal.ActivatePortal(previousSection.MovementColor, currentSection.MovementColor);
        }
        
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (timer > waitTime)
        {
            timer = 0;

            SpawnSection();
        }
    }
}
