using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    private Animator _animator = null;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Door Open!");

        _animator.SetBool("isOpen", true);
    }

    void OnTriggerExit(Collider collider)
    {
        Debug.Log("Door Closed!");

        _animator.SetBool("isOpen", false);
    }
}