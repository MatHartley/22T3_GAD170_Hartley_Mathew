using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public class ColourChanger : MonoBehaviour
    {
        // This cube will change colours when activated
        // Change coloursmeans to change the colour of the cube to a new random colour
        private void Start()
        {
            Activate();
        }
        private void Activate()
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}