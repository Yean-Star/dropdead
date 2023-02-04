using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairController : MonoBehaviour
{
    public Dialoge dialoge;
    public static bool chairPick = false;
    public void ChairInteract()
    {
        FindObjectOfType<DialogeManager>().StartDialoge(dialoge);
        chairPick = true;
    }
}
