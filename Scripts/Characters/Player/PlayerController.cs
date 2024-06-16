using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : Character
{
    [field: Header("Player Refs")]
    [field: SerializeField] public Transform camTransform { get; private set; }
    [field: SerializeField] public CinemachineVirtualCamera Camera { get; private set; }
    [field: SerializeField] public AudioListener AudioListener { get; private set; }

    [field: Header("Player Settings")]
    [field: SerializeField] public Vector2 LookSens { get; private set; } = Vector2.one;

    [Header("Player Inputs")]
    protected Vector2 moveInput;
    protected Vector2 lookInput;
    protected bool jumpInput;

    // Actions
    InputAction moveAction;
    InputAction lookAction;
    InputAction jumpAction;

    public override void OnNetworkSpawn()
    {
        DetermineOwnership();
        base.OnNetworkSpawn();
    }
    private void DetermineOwnership()
    {
        if(IsOwner)
        {
            AudioListener.enabled = true;
            Camera.Priority = 100;
            SetPlayerColor(GameManager.Instance.FriendlyColor);
        } else
        {
            AudioListener.enabled = false;
            Camera.Priority = 0;
            SetPlayerColor(GameManager.Instance.EnemyColor);
        }
    }

    private void SetPlayerColor(Color color) => Renderer.material.color = color;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        RegisterActions();
    }

    private void Update()
    {
        if (!IsOwner) return;
        GroundCheck();
        HandleActions();
        HandleInputs();
    }

    private void RegisterActions()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        lookAction = InputSystem.actions.FindAction("Look");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    private void HandleActions()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        lookInput = lookAction.ReadValue<Vector2>();
        jumpInput = jumpAction.IsPressed();
    }

    private void HandleInputs()
    {
        HandleLookInput();
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        //Movement = moveInput.x * transform.right + moveInput.y * transform.forward;
    }

    private void HandleLookInput()
    {
        yRotation += lookInput.x * LookSens.x * GameManager.Instance.MovementData.RotationSpeed;
        xRotation -= lookInput.y * LookSens.y * GameManager.Instance.MovementData.RotationSpeed;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        //RotateCamera(yRotation);
    }

    private void RotateCamera(float lookInputY)
    {
        float camAngle = Vector3.SignedAngle(transform.forward, camTransform.forward, camTransform.right);
        float camRotateAmount = lookInputY * Time.deltaTime;
        float newCamAngle = camAngle - camRotateAmount;
        //if(newCamAngle < )
    }
}