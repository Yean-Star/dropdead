using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollController : MonoBehaviour
{
    public Dialoge dialoge;
    public static bool dollPick = false;
    public void DollInteract()
    {
        FindObjectOfType<DialogeManager>().StartDialoge(dialoge);
        dollPick = true;
    }
}
