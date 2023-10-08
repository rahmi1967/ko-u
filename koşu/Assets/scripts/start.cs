using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    // Bu fonksiyon "Start" butonuna basýldýðýnda çaðrýlýr
    public void StartGame()
    {
        // "Scene2" sahnesine geçiþ yap
        SceneManager.LoadScene(1);
    }
}
