using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    private TMP_Text pressKeyText;
    public bool isRange = false;
    public KeyCode interactKey;
    public UnityEvent interaction;

    private void Start()
    {
        pressKeyText.gameObject.SetActive(false);
    }
    void Update()
    {
        InteractObject();
    }

    void InteractObject()
    {
        if (isRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interaction.Invoke();
                pressKeyText.gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isRange = true;
            pressKeyText.gameObject.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isRange = false;
            pressKeyText.gameObject.SetActive(false);
            FindObjectOfType<DialogeManager>().EndDialoge();
        }
    }
}

