using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowselectedCharacterName : MonoBehaviour
{
    public CharacterManager characterManager;
    public Text characterText;
    
    private void Update()
    {
        characterText.text = "Character " + (characterManager.characterIdOnScreen + 1).ToString();
    }
}
