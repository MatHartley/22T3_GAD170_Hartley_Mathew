using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MathewAndDaniel
{
    public class CubeColour : MonoBehaviour
    {

        private GameObject cube;
        private MeshRenderer cubeRenderer;
        private Color newColour;
        private float xDirection;


        // Update is called once per frame
        void Start()
        {
            cubeRenderer = GetComponent<MeshRenderer>();
            //Debug.Log("checking");
        }

        void Update()
        {
            if (transform.position.x < 0)
            {
                cubeRenderer.material.color = Color.red;
                //Debug.Log("colour should be red if cube is to the left");
            }
            else if (transform.position.x > 0)
            {
                cubeRenderer.material.color = Color.green;
                //Debug.Log("colour should be green if cube is to the right");
            }
        }
    }
}