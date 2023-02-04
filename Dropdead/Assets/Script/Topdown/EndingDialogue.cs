using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingDialogue : MonoBehaviour
{
    public Dialoge dialoge;
    int click = 0;
    public TMP_Text text;
    public TMP_Text text2;

    private void Start()
    {
        StartCoroutine(WaittoApp());
        if(click >= 3)
        {
            StartCoroutine(DeadAppear());
        }
    }
    private void Update()
    {
        ClicktoNext();
        if (click > 3 )
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
