using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    Rigidbody2D _rb;
    private int[] _angle = { 0, 90, 180, 270 };
    int rando;
    int rotate;
    public bool rotateEnable = false;
    // Start is called before the first frame update
    private void Awake()
    {
        rando = Random.Range(1, 10);
    }
    void Start()
    {
        int rand = Random.Range(0, _angle.Length);
        transform.rotation = Quaternion.Euler(0, 0, _angle[rand]);

        Debug.Log(rando);
        if(rando == 2&&rotateEnable)
        {
            //Debug.Log("rotate");
            StartCoroutine(RotateCouterClockWise());
        }
        if (rando == 1&&rotateEnable)
        {
            //Debug.Log("rotate");
            StartCoroutine(RotateClockWise());
        }
    }

    // Update is called once per frame
    void Update()
    {
        //rotate++;
        //switch(rando){
        //    case 0:
        //        transform.rotation = Quaternion.Euler(0, 0, rotate);
        //        break;
        //    case 1:

        //        break;
        //}
    }

    private IEnumerator RotateCouterClockWise()
    {
        while (true)
        {
            //Debug.Log("rotate");
            rotate++;
            transform.rotation = Quaternion.Euler(0, 0, rotate);
            yield return new WaitForSeconds(0.02f);
        }
    }

    private IEnumerator RotateClockWise()
    {
        while (true)
        {
            //Debug.Log("rotate");
            rotate--;
            transform.rotation = Quaternion.Euler(0, 0, rotate);
            yield return new WaitForSeconds(0.02f);
        }
    }
}
