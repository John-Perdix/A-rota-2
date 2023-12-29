using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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

    public void Fim()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void VerNau()
    {
        SceneManager.LoadSceneAsync(5);
    }
}
