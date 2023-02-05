using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameover;
    public AudioSource audioSource;
    
    public void Gameover()
    {
        Time.timeScale = 0;
        audioSource.mute = true;
        gameover.SetActive(true);
    }
    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID,LoadSceneMode.Single);
        Time.timeScale = 1.0f;
    }
    public void ClicktoTop()
    {
        SceneManager.LoadScene("Mainmenu", LoadSceneMode.Single);
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}