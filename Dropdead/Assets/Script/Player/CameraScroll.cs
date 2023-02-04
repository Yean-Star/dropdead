using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    Vector3 camMotion;
    [SerializeField]
    private float camSpeed;

    [SerializeField]
    private float _reframeSpeed = 2f;

    // Start is called before the first frame update

    private bool _repositioning;
    private Vector3 _reframeEndPos;
    private float _reframeTimer;

    void Start()
    {
        camMotion = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        NormalScroll();
        Reframe();
    }

    private void NormalScroll()
    {
        if (_repositioning) return;

        camMotion.y -= camSpeed * Time.deltaTime;
        camMotion.z = -10.0f;
        this.transform.position = camMotion;
    }

    public void TryReframePlayer()
    {
        if (_repositioning) return;

        _repositioning = true;
        _reframeEndPos = transform.position;
        _reframeEndPos.y = player.transform.position.y;
        _reframeTimer = 0f;
    }
  
    private void Reframe()
    {
        if (!_repositioning) return;

        _reframeTimer += Time.deltaTime * _reframeSpeed;
        if (_reframeTimer >= 1f)
        {
            _reframeTimer = 1f;
            _repositioning = false;
        }

        camMotion = Vector3.Slerp(camMotion, _reframeEndPos, _reframeTimer);
        this.transform.position = camMotion;
    }
}
