using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayNickname : MonoBehaviour
{
    public string nickName;
    public void setNickname()
    {
        nickName = PlayerPrefs.GetString("nickname");
    }
}
