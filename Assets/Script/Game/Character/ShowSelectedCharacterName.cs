using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSelectedCharacterName : MonoBehaviour
{
    public CharacterManager characterManager;
    public Text characterText;
    void Start()
    {
        
    }

    
    void Update()
    {
        characterText.text = "Character " + (characterManager.characterIdOnScreen + 1).ToString();
    }
}
