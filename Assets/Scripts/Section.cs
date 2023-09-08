using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> colorTriangles;

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
        var color = Color.black;
        switch (movementColor)
        {
            case MovementColor.Green:
                color = Color.green;
                break;
            case MovementColor.Red:
                color = Color.red;
                break;
            case MovementColor.Blue:
                color = Color.blue;
                break;
            case MovementColor.Yellow:
                color = Color.yellow;
                break;
        }

        foreach (var sprite in colorTriangles)
        {
            sprite.color = color;
        }
    }
}
