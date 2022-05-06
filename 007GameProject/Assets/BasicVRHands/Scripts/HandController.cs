﻿using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
public class HandController : MonoBehaviour {

    private Animator animator;
	private XRIDefaultInputActions inputAction;

    private void Awake()
    {
        inputAction = new XRIDefaultInputActions();
    }

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }

    void Start () {
        animator = GetComponent<Animator>();
	}
	
	void Update () {

       if(inputAction.XRIRightHand.Grip.triggered)
        {
            animator.SetBool("isGrabbing",true);
        }
       // animator.SetBool("isGrabbing", Input.GetKey(KeyCode.F));
	}
}
