using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{

    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<Contact> contactsList = new List<Contact>();

    private void Start()
    {
        foreach (Contact contact in contactsList)
        {
            contact.Initialize();
        }
    }
    }
}