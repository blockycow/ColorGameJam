using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorPortal : MonoBehaviour
{
    [SerializeField] private MovementColor previousColor;
    [SerializeField] private MovementColor currentColor;

    [SerializeField] private GameObject portal;

    [SerializeField] private ParticleSystem prevParticle;
    [SerializeField] private ParticleSystem curParticle;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivatePortal(MovementColor prev, MovementColor cur)
    {
        previousColor = prev;
        currentColor = cur;
        
        SetColor(prev, prevParticle);
        SetColor(cur, curParticle);
        
        
    }

    public void DeactivatePortal()
    {
        portal.SetActive(false);
    }

    private void SetMovement(MovementColor movementColor)
    {
        Debug.Log("Portal");
    }

    private void SetColor(MovementColor movementColor, ParticleSystem particles)
    {
        var prtcl = particles.main;
            
        switch (movementColor)
        {
            case MovementColor.Green:
                prtcl.startColor = new ParticleSystem.MinMaxGradient(new Color(0, 1, 0, 0.6f));
                break;
            case MovementColor.Red:
                prtcl.startColor = new ParticleSystem.MinMaxGradient(new Color(1, 0, 0, 0.6f));
                break;
            case MovementColor.Blue:
                prtcl.startColor = new ParticleSystem.MinMaxGradient(new Color(0, 0, 1, 0.6f));
                break;
            case MovementColor.Yellow:
                prtcl.startColor = new ParticleSystem.MinMaxGradient(new Color(1, 1, 0, 0.6f));
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        SetMovement(currentColor);
    }
}
