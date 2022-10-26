using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MathewAndDaniel
{
public class CubeColour : MonoBehaviour
{
 
private GameObject cube;
private Renderer cubeRenderer;
private Color newColour;


    // Update is called once per frame
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        cube.transform == (0,0,0);
    }
    
    void Update()
    {
        if (cube.position.x <0)
        {
            cubeRenderer.material.SetColour(Colour.red);
        }
    }
}
}