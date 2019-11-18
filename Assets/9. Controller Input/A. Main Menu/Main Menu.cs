// GENERATED AUTOMATICALLY FROM 'Assets/9. Controller Input/A. Main Menu/Main Menu.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerSetup : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @ControllerSetup()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Main Menu"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""2776b864-51bd-48f7-88dc-e6b3f87966ea"",
            ""actions"": [
                {
                    ""name"": ""Move Controller"",
                    ""type"": ""Value"",
                    ""id"": ""9c3e7ea2-1bd2-413a-83fe-29d38d5b69bc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ee1a0df-797b-44a0-807b-a6e5037646f4"",
                    ""path"": ""<XInputController>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_MoveController = m_Movement.FindAction("Move Controller", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_MoveController;
    public struct MovementActions
    {
        private @ControllerSetup m_Wrapper;
        public MovementActions(@ControllerSetup wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveController => m_Wrapper.m_Movement_MoveController;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @MoveController.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveController;
                @MoveController.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveController;
                @MoveController.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveController;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveController.started += instance.OnMoveController;
                @MoveController.performed += instance.OnMoveController;
                @MoveController.canceled += instance.OnMoveController;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnMoveController(InputAction.CallbackContext context);
    }
}
