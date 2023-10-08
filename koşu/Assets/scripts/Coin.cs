using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    
    public int score;
    public int maxScore;
    public TextMeshProUGUI scoreText;
    private PlayerControlor playerController;

    private float winDelayTimer = 1f; // Yeni sahneye geçiþ için beklenen süre
    public Animator playerAnim;
    public GameObject thisPlayer;

    public Button resetButton;
    private void Awake()
    {
        playerController = GetComponent<PlayerControlor>();
        playerAnim = thisPlayer.GetComponentInChildren<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))

        {
            AddCoin();
            Destroy(other.gameObject);



        }
        else if (other.CompareTag("EndGame"))
        {
            playerController._speed = 0f;

            transform.Rotate(transform.rotation.x, 100, transform.rotation.z, Space.Self);
            if (score >= maxScore)
            {
                playerAnim.SetBool("Win", true);
                StartCoroutine(RestartSceneAfterDelay(10f));

            }
            else
            {
                playerAnim.SetBool("Lose", true);
                StartCoroutine(RestartSceneAfterDelay(10f));
                resetButton.interactable = true;
                resetButton.gameObject.SetActive(true);
            }
            if (score > 10)
            {
                // Kazanma koþulu saðlandýðýnda, yeni sahneye geç
                SceneManager.LoadScene(2);
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void AddCoin()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();


    }

    IEnumerator RestartSceneAfterDelay(float delay)

    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);



    }


}
