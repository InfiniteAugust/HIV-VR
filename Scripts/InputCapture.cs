using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputCapture : MonoBehaviour
{
    [Header("Select Action")]
    [SerializeField] InputActionReference rightControllerActionGrip;
    [SerializeField] InputActionReference leftControllerActionGrip;
    [Header("Activate Action")]
    [SerializeField] InputActionReference rightControllerActionTrigger;
    [SerializeField] InputActionReference leftControllerActionTrigger;
    [Header("Primary Button Action")]
    [SerializeField] InputActionReference rightPrimaryButtonAction;
    [SerializeField] InputActionReference leftPrimaryButtonAction;
    [Header("Turn (JoyStick) Action")]
    [SerializeField] InputActionReference rightTurnAction;
    [SerializeField] InputActionReference leftTurnAction;


    public GameObject UIPicker;

    public Animator UI;
    private Quaternion targetRotation;
    private Vector3 Angle;

    public bool I;
    public bool N;
    public bool T;
    public bool E;
    public bool L;

    public GameObject plane;

    private void Awake()
    {
        targetRotation = Quaternion.Euler(0, 0, 0);

        rightControllerActionGrip.action.performed += onRightGripPressed;
        leftControllerActionGrip.action.performed += onLeftGripPressed;

        rightControllerActionTrigger.action.performed += onRighTriggerPressed;
        leftControllerActionTrigger.action.performed += onLeftTriggerPressed;

        rightPrimaryButtonAction.action.performed += onRightControllerPrimaryButtonPressed;
        leftPrimaryButtonAction.action.performed += onLeftControllerPrimaryButtonPressed;

        rightTurnAction.action.performed += onRightJoystickTurn;
        leftTurnAction.action.performed += onLeftJoystickTurn;

        Angle = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        targetRotation = Quaternion.Euler(Angle);
        UIPicker.transform.rotation = Quaternion.Slerp(UIPicker.transform.rotation, targetRotation, Time.deltaTime*10f);
    }

    private void onRighTriggerPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right Trigger Pressed.");
    }
    private void onLeftTriggerPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left Trigger Pressed.");
    }

    private void onRightGripPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right Grip Pressed.");
    }

    private void onLeftGripPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left Grip Pressed.");
    }

    private void onRightControllerPrimaryButtonPressed(InputAction.CallbackContext obj)
    {
        //Debug.Log("Right Primary Pressed (A).");
        //if(SceneManager.GetActiveScene().buildIndex==5)
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
        plane.GetComponent<fadeBlack>().Towhite = false;

    }

    private void onLeftControllerPrimaryButtonPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left Primary Pressed (X).");

        if (UI.GetBool("open"))
        {
            UI.SetBool("open", false);
        }
        else
        {
            UI.SetBool("open", true);
        }


        //if (UIPicker.active)
        //{
        //    UIPicker.SetActive(false);
        //    //UI.speed = 1;
        //}
        //else
        //{
        //    UIPicker.SetActive(true);
        //    //UI.speed = -1;
        //}


    }

    private void onRightControllerSecondaryButtonPressed(InputAction.CallbackContext obj)
    {
        //Debug.Log("Right Secondary Pressed (B).");

    }

    private void onLeftControllerSecondaryButtonPressed(InputAction.CallbackContext obj)
    {
        //Debug.Log("Left Secondary Pressed (Y).");
    }

    private void onRightJoystickTurn(InputAction.CallbackContext obj)
    {
        Debug.Log(obj.ReadValue<Vector2>());
    }
    private void onLeftJoystickTurn(InputAction.CallbackContext obj)
    {
        Debug.Log(obj.ReadValue<Vector2>());


        Vector2 rotate = obj.ReadValue<Vector2>();
        if (rotate.x > 0)
        {
            //UIPicker.transform.Rotate(Vector3.up, 10);
            Angle += new Vector3(0, 30, 0);
        }
        else
        {
            Angle -= new Vector3(0, 30, 0);

        }
    }

    private void onRight2DAxisButtonPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right 2D Axis Pressed (Joystick).");
    }

    private void onLeft2DAxisButtonPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left 2D Axis Pressed (Joystick).");
    }


    private void onRight2DAxisTouchPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right 2D Axis Touched (Joystick).");
    }

    private void onLeft2DAxisTouchPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left 2D Axis Touched (Joystick).");
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("I"))
        {
            I = true;
        }
        if (other.CompareTag("N"))
        {
            N = true;
        }
        if (other.CompareTag("T"))
        {
            T = true;
        }
        if (other.CompareTag("E"))
        {
            E = true;
        }
        if (other.CompareTag("L"))
        {
            L = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("I"))
        {
            I = false;
        }
        if (other.CompareTag("N"))
        {
            N = false;
        }
        if (other.CompareTag("T"))
        {
            T = false;
        }
        if (other.CompareTag("E"))
        {
            E = false;
        }
        if (other.CompareTag("L"))
        {
            L = false;
        }
    }

}
