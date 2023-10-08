using UnityEngine;

using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    


   
    public void RestartLevel()
    {
        // Burada reset iþlemlerini gerçekleþtir, örneðin sahneyi yeniden yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
