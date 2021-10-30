// GENERATED AUTOMATICALLY FROM 'Assets/Input/MainInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInput"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""e614a09b-6758-402f-bd78-c40fa8a1ceb0"",
            ""actions"": [
                {
                    ""name"": ""Mouse Wheel"",
                    ""type"": ""Value"",
                    ""id"": ""dbf9ef69-82ac-4e1a-9783-8af52ba6c193"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseClickLeft"",
                    ""type"": ""Value"",
                    ""id"": ""bb11a7da-0fa5-44ca-875c-8704562fe242"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseClickRight"",
                    ""type"": ""Button"",
                    ""id"": ""9465db8e-b9a3-49f7-87d3-1b06734d91b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Position"",
                    ""type"": ""Value"",
                    ""id"": ""3e776e34-581b-46ac-85ab-a051a94f54c3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Delta"",
                    ""type"": ""Value"",
                    ""id"": ""18ea33e2-50c2-4057-92c1-cf185cde631f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eafee452-0dca-4b8f-935b-0273978c1b6c"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Wheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe2957ef-a0eb-4d66-9d40-f25210c99d8f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClickLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ccc3e253-329d-4b51-8bcd-4ce3baee0157"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28e91532-25e7-4269-bfde-650156fae5b4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87a2e7cc-a3bb-4f44-9baf-a2f67fc83246"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClickRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_MouseWheel = m_Main.FindAction("Mouse Wheel", throwIfNotFound: true);
        m_Main_MouseClickLeft = m_Main.FindAction("MouseClickLeft", throwIfNotFound: true);
        m_Main_MouseClickRight = m_Main.FindAction("MouseClickRight", throwIfNotFound: true);
        m_Main_MousePosition = m_Main.FindAction("Mouse Position", throwIfNotFound: true);
        m_Main_MouseDelta = m_Main.FindAction("Mouse Delta", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_MouseWheel;
    private readonly InputAction m_Main_MouseClickLeft;
    private readonly InputAction m_Main_MouseClickRight;
    private readonly InputAction m_Main_MousePosition;
    private readonly InputAction m_Main_MouseDelta;
    public struct MainActions
    {
        private @MainInput m_Wrapper;
        public MainActions(@MainInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseWheel => m_Wrapper.m_Main_MouseWheel;
        public InputAction @MouseClickLeft => m_Wrapper.m_Main_MouseClickLeft;
        public InputAction @MouseClickRight => m_Wrapper.m_Main_MouseClickRight;
        public InputAction @MousePosition => m_Wrapper.m_Main_MousePosition;
        public InputAction @MouseDelta => m_Wrapper.m_Main_MouseDelta;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @MouseWheel.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseWheel;
                @MouseWheel.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseWheel;
                @MouseWheel.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseWheel;
                @MouseClickLeft.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseClickLeft;
                @MouseClickLeft.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseClickLeft;
                @MouseClickLeft.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseClickLeft;
                @MouseClickRight.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseClickRight;
                @MouseClickRight.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseClickRight;
                @MouseClickRight.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseClickRight;
                @MousePosition.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
                @MouseDelta.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseDelta;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseWheel.started += instance.OnMouseWheel;
                @MouseWheel.performed += instance.OnMouseWheel;
                @MouseWheel.canceled += instance.OnMouseWheel;
                @MouseClickLeft.started += instance.OnMouseClickLeft;
                @MouseClickLeft.performed += instance.OnMouseClickLeft;
                @MouseClickLeft.canceled += instance.OnMouseClickLeft;
                @MouseClickRight.started += instance.OnMouseClickRight;
                @MouseClickRight.performed += instance.OnMouseClickRight;
                @MouseClickRight.canceled += instance.OnMouseClickRight;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnMouseWheel(InputAction.CallbackContext context);
        void OnMouseClickLeft(InputAction.CallbackContext context);
        void OnMouseClickRight(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
    }
}
