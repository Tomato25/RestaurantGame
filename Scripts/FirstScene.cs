using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void startScene()
    {
        SceneManager.LoadScene("SecondScene");
    }

    // Update is called once per frame

}