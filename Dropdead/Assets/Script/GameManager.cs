using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameover;
    public AudioSource audioSource;
    public GameObject htpimg;

    private void Awake()
    {
        if(htpimg != null)
        {
            htpimg.SetActive(false);
        }
        //htpimg.GetComponent<Image>().CrossFadeAlpha(0.1f, 2.0f, false);
    }

    private void Start()
    {
        //htpimg = GameObject.Find("HTP");
    }

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

    public void StartGame(int sceneID)
    {
        Time.timeScale = 1.0f;
        StartCoroutine(HTPpanel(sceneID));
    }

    private IEnumerator HTPpanel(int sceneID)
    {
        htpimg.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(sceneID, LoadSceneMode.Single);
        
    }
}