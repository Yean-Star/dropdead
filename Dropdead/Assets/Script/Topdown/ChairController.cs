using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairController : MonoBehaviour
{
    public Dialoge dialoge;
    public void ChairInteract()
    {
        FindObjectOfType<DialogeManager>().StartDialoge(dialoge);
    }
}
