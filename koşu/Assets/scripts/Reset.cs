using UnityEngine;

using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    


   
    public void RestartLevel()
    {
        // Burada reset i�lemlerini ger�ekle�tir, �rne�in sahneyi yeniden y�kle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
