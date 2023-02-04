using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollController : MonoBehaviour
{
    public Dialoge dialoge;
    public void DollInteract()
    {
        FindObjectOfType<DialogeManager>().StartDialoge(dialoge);
    }
}
