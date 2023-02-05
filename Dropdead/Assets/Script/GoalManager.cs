using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    [SerializeField]
    private DollController dollController;
    [SerializeField]
    private ChairController chairController;
    [SerializeField]
    private PCController pCController;

    public Button button;
    private void Start()
    {
        button.gameObject.SetActive(false);
    }

    private void Update()
    {
        goal();
    }
    void goal()
    {
        if (ChairController.chairPick == true && PCController.pcOk == true 
            && DollController.dollPick == true)
        {
            button.gameObject.SetActive(true);
        }
        else
        {
            button.gameObject.SetActive(false);
        }
        
    }
}
