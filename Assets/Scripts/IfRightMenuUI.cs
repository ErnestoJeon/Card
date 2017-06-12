using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfRightMenuUI : MonoBehaviour
{
    public GameObject _shopButton;
    public GameObject _cardButton;
    public GameObject _battleButton;

    public void Update()
    {
        if (InputField.
        {input
            Instantiate(_shopButton, this.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(_cardButton, this.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(_battleButton, this.transform.position, transform.rotation);
        }
    }
    public void MenuOpen()
    {
        gameObject.SetActive(true);
    }
    public void MenuClose()
    {
        gameObject.SetActive(false);
    }
}