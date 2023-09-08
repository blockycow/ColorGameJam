using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> colorTriangles;

    public ColorPortal Portal;


    public MovementColor MovementColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColor(MovementColor movementColor )
    {
        MovementColor = movementColor;
        
        var color = Color.black;
        switch (movementColor)
        {
            case MovementColor.Green:
                color = new Color(0, 1, 0, 0.6f);
                break;
            case MovementColor.Red:
                color = new Color(1, 0, 0, 0.6f);
                break;
            case MovementColor.Blue:
                color = new Color(0, 0, 1, 0.6f);
                break;
            case MovementColor.Yellow:
                color = new Color(1, 1, 0, 0.6f);
                break;
        }

        foreach (var sprite in colorTriangles)
        {
            sprite.color = color;
        }
    }

    public void ActivateColorPortal()
    {
        
    }
}
