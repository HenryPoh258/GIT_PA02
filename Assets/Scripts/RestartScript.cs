using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    private HUD hud;

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
