using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public enum Character { Undefined, Mario, Peach, Bowser }
    public class Contact : MonoBehaviour
    {
        [SerializeField] private Character chosenCharacter = Character.Undefined;
        [SerializeField] private string contactName;
        [SerializeField] private string prefName;
        [SerializeField] private string pronouns;        
        [SerializeField] private string phone;
        [SerializeField] private string address;
        [SerializeField] private string email;

    public void Initialize()
    {
        switch (chosenCharacter)
        {
            case Character.Undefined:
                Debug.Log("Character Undefined, set enum in the inspector");
                break;
            case Character.Mario:
                Setup("Itsame Mario", "Mario", "He/Him", "0404123456", 
                "1 Toadstool Road, Mushroom Kingdom, 0000", "itsame@superstar.com");
                break;
            case Character.Peach:
                Setup("Peach Toadstool", "Princess Peach", "She/Her", "0404000001", 
                "The Castle, Mushroom Kingdom, 0000", "princesspeach@superstar.com");
                break;
            case Character.Bowser:
                Setup("Bowser Kooper", "Bowser", "He/Him", "0404158726", 
                "Lava Castle, World 8, 6666", "kingkoopa@superstar.com");
                break;
            default:
                Debug.Log("Invalid data");
                break;
        }
    }

    void Setup(string newContactName, string newPrefName, string newPronouns, string newPhone, 
        string newAddress, string newEmail)
    {
        contactName = newContactName;
        prefName = newPrefName;
        pronouns = newPronouns;
        phone = newPhone;
        address = newAddress;
        email = newEmail;
    }

    }
}