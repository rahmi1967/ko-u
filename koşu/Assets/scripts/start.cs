using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    // Bu fonksiyon "Start" butonuna bas�ld���nda �a�r�l�r
    public void StartGame()
    {
        // "Scene2" sahnesine ge�i� yap
        SceneManager.LoadScene(1);
    }
}
