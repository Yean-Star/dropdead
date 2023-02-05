using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndingDialogue : MonoBehaviour
{
    public Dialoge dialoge;
    int click = 0;
    public TMP_Text text;
    public TMP_Text text2;
    private bool allowClick = true;

    private void Start()
    {
        StartCoroutine(WaittoApp());
        if(click >= 6)
        {
            StartCoroutine(DeadAppear());
        }
        
    }
    private void Update()
    {
        ClicktoNext();
        if (click > 6)
        {
            StartCoroutine(DeadAppear());
        }
    }
    IEnumerator WaittoApp()
    {
        yield return new WaitForSeconds(2);
        FindObjectOfType<DialogeManager>().StartDialoge(dialoge);
    }
    IEnumerator DeadAppear()
    {
        yield return new WaitForSeconds(1.5f);
        text2.gameObject.SetActive(false);
        text.gameObject.SetActive(true);
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
    void ClicktoNext()
    {
       
        
       if (Input.GetMouseButtonDown(0))
       {
            FindObjectOfType<DialogeManager>().DisplayNextSentence();
            click++;
       }
        
        
    }
  
}
