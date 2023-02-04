using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogeManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogeText;

    public Animator animator;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialoge(Dialoge dialoge)
    {
        animator.SetBool("isOpen", true);
        nameText.text = dialoge.name;
        sentences.Clear();
        foreach(string sentence in dialoge.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialoge();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogeText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogeText.text += letter;
            yield return null;
        }
    }
    public void EndDialoge()
    {
        animator.SetBool("isOpen", false);
    }


}
