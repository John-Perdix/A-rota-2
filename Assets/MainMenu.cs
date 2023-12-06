using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void LigarAR()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Puzzle()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
