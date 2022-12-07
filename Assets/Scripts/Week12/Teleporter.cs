using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public class Teleporter : MonoBehaviour
    {
        // This cube will teleport when activated
        // Teleport will move the cube to a random position on the Y axis
        private void Start()
        {
            Activate();
            Debug.Log("no");
        }
        private void Activate()
        {
            transform.position = new Vector3 (2, Random.Range(0.5f, 4f), 0);
            Debug.Log("hello");
        }
    }
}