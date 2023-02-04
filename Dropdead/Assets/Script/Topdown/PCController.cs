using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCController : MonoBehaviour
{
    public Dialoge dialoge;
    public static bool pcOk = false;
    public void PCInteract()
    {
        FindObjectOfType<DialogeManager>().StartDialoge(dialoge);
        pcOk = true;
    }
}
