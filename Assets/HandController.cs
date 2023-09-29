using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{

    ActionBasedController controller;

    void Awake()
    {
        controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += OnTriggerPress;
    }

    void OnTriggerPress(InputAction.CallbackContext context)
    {
        XRRayInteractor interactor = GetComponentInChildren<XRRayInteractor>();

        foreach (IXRSelectInteractable inter in interactor.interactablesSelected)
        {
            GameObject probablyGun = inter.transform.gameObject;


            if (probablyGun.TryGetComponent<swordController>(out swordController c))
            {
                c.PullTrigger();
            }
        }


    }

    void Update()
    {

    }
}
