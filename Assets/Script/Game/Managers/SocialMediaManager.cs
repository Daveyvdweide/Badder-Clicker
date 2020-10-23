using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocialMediaManager : MonoBehaviour
{
    public void OpenInstagram()
    {
        Application.OpenURL ("instagram://user?username=badderandfriends");
    }
}
