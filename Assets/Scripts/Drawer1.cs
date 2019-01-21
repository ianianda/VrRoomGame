using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer1 : MonoBehaviour
{

    private Animator _animator = null;
    private bool drawer1Open;

    void Start()
    {
        _animator = GetComponent<Animator>();
        drawer1Open = false;
    }

    void OnMouseDown()
    {
        if (drawer1Open == true)
        {
            Debug.Log("Drawer 1 Open!");

            _animator.SetBool("DrawerIsOpen", true);
            drawer1Open = false;
        }
        else
        {
            Debug.Log("Drawer 1 Closed!");

            _animator.SetBool("DrawerIsOpen", false);
            drawer1Open = true;
        }
    }
}