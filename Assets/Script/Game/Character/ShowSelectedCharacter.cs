using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSelectedCharacter : MonoBehaviour
{
    public CharacterManager characterManager;
    public Image character;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.character.sprite = characterManager.characterImages[characterManager.characterIdOnScreen];
    }
}
