//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Inputs/NormalGuyControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @NormalGuyControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NormalGuyControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NormalGuyControls"",
    ""maps"": [
        {
            ""name"": ""Basic Gameplay"",
            ""id"": ""0ad47f46-8c61-406a-b06c-e463ad217fa3"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""73df9d3c-a16b-4ddb-9db9-2d20969f89b2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""88aaab1e-461b-4134-805c-b500d029ca30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""d6ebf3ee-64d7-4b04-9f6b-d1577c9999cb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f2c9df31-ce0f-4c93-ad77-db875ca01204"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""06e24b2d-ccad-4a0b-adf8-9737c8689e2b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""12156e2d-d941-460e-83e0-7577c98a285d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a21e5b1e-c51b-4273-973a-a7cc35d8e8a2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fd741ea7-09b3-4c5a-b3ad-4fe9436b6ec7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Basic Gameplay
        m_BasicGameplay = asset.FindActionMap("Basic Gameplay", throwIfNotFound: true);
        m_BasicGameplay_Move = m_BasicGameplay.FindAction("Move", throwIfNotFound: true);
        m_BasicGameplay_Jump = m_BasicGameplay.FindAction("Jump", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Basic Gameplay
    private readonly InputActionMap m_BasicGameplay;
    private List<IBasicGameplayActions> m_BasicGameplayActionsCallbackInterfaces = new List<IBasicGameplayActions>();
    private readonly InputAction m_BasicGameplay_Move;
    private readonly InputAction m_BasicGameplay_Jump;
    public struct BasicGameplayActions
    {
        private @NormalGuyControls m_Wrapper;
        public BasicGameplayActions(@NormalGuyControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BasicGameplay_Move;
        public InputAction @Jump => m_Wrapper.m_BasicGameplay_Jump;
        public InputActionMap Get() { return m_Wrapper.m_BasicGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicGameplayActions set) { return set.Get(); }
        public void AddCallbacks(IBasicGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_BasicGameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BasicGameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IBasicGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IBasicGameplayActions instance)
        {
            if (m_Wrapper.m_BasicGameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBasicGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_BasicGameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BasicGameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BasicGameplayActions @BasicGameplay => new BasicGameplayActions(this);
    public interface IBasicGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
