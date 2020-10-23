using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Sprite[] characterImages;
    public Image characterScreen;
    public int characterIdOnScreen = 0;

    public void SetImage(int characterNumber)
    {
        characterScreen.sprite = this.characterImages[characterNumber - 1];
    }

    public void GetNextChar()
    {
        if(this.characterIdOnScreen <= this.characterImages.Length - 1)
        {
        characterScreen.sprite = this.characterImages[this.characterIdOnScreen + 1];
        this.characterIdOnScreen = this.characterIdOnScreen + 1;
        }
    }

    public void GetPreviousChar()
    {
        if(this.characterIdOnScreen >= 0)
        {
        characterScreen.sprite = this.characterImages[this.characterIdOnScreen - 1];
        this.characterIdOnScreen = this.characterIdOnScreen - 1;
        }
    }
}
