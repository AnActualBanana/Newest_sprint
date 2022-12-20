using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("Hack_Sprint");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}