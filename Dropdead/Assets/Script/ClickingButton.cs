using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickingButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;
    //[SerializeField] private AudioClip _compressClip, _uncompressClip;
    //[SerializeField] private AudioSource _source;
    [SerializeField] private Image raindrop;
    //Detect current clicks on the GameObject (the one with the script attached)
    void Start()
    {
        if(raindrop != null)
        {
            raindrop.enabled = false;
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        _img.sprite = _pressed;
        if (raindrop != null)
        {
            raindrop.enabled = true;
        }
        Debug.Log(gameObject.name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _img.sprite = _default;
        if (raindrop != null)
        {
            raindrop.enabled = false;
        }
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        _img.sprite = _pressed;
        //_source.PlayOneShot(_compressClip);
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        _img.sprite = _default;
        //_source.PlayOneShot(_uncompressClip);
    }
}
