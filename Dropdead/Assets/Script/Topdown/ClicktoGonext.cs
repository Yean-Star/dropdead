using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClicktoGonext : MonoBehaviour
{
    public void GotoNextScene()
    {
        SceneManager.LoadScene(2);
    }
}
