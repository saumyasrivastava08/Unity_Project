﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene(1);
    }
    public void ApplictionQuitter()
    {
        Application.Quit();
    }
}
