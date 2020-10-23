using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowselectedCharacter : MonoBehaviour
{
    public CharacterManager characterManager;
    public Image character;

    private void Update()
    {
        this.character.sprite = characterManager.characterImages[characterManager.characterIdOnScreen];
    }
}
