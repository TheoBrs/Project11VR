using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class UIController : MonoBehaviour
{
    [SerializeField] private XRRayInteractor xrRayInteractor;
    [SerializeField] private ActionBasedController actionbasedController;
    [SerializeField] private XRDirectInteractor xrDirectInteractor;
    [SerializeField] private InputActionReference UIActionRef;

    private void OnEnable()
    {
        UIActionRef.action.performed += UIModeActivate;
        UIActionRef.action.canceled += UIModeCancel;
    }

    private void UIModeActivate(InputAction.CallbackContext obj)
    {
        xrDirectInteractor.enabled = false;

        xrRayInteractor.enabled = true;
        actionbasedController.enableInputActions = true;
    }

    private void UIModeCancel(InputAction.CallbackContext obj) => Invoke(methodName: "DisableUI", time: 0.05f);

    private void DisableUI()
    {
        xrDirectInteractor.enabled = true;

        xrRayInteractor.enabled = false;
        actionbasedController.enableInputActions = false;
    }

    private void OnDisable()
    {
        UIActionRef.action.performed -= UIModeActivate;
        UIActionRef.action.canceled -= UIModeCancel;
    }
}
