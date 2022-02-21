using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderBoardButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void LeaderBtn()
    {
        SceneManager.LoadScene("Leaderboard");
    }
}