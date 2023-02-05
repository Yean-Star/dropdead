using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClicktoGonext : MonoBehaviour
{
    public void GotoNextScene()
    {
        DollController.dollPick = false;
        ChairController.chairPick = false;
        PCController.pcOk = false;
        SceneManager.LoadScene(2);
    }
}
