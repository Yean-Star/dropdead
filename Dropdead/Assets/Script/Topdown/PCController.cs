using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCController : MonoBehaviour
{
    public Dialoge dialoge;
    public void PCInteract()
    {
        FindObjectOfType<DialogeManager>().StartDialoge(dialoge);
    }
}
