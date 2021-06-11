// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""244cc7f1-b0ff-4230-a3af-92f4b72309a3"",
            ""actions"": [
                {
                    ""name"": ""Disparo"",
                    ""type"": ""Button"",
                    ""id"": ""92e9aba3-0c5a-4f82-aaf0-b458c203019c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movimiento"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f3983f05-5eac-4028-a787-560eaadcad71"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa2ff8e6-e9b6-42b3-9078-b5569d54cbb7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b897e58c-aef1-469a-ada2-26b7458371c4"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3530f3ba-afcf-459a-bee6-cdb3bb5c27d5"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb06c836-b135-4af2-8a83-a881a2a8b0fe"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6309381b-ad78-4a02-bd90-07f67a045e1d"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7fb853c0-0a15-43b8-8112-e0bfb79addbd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1d62f1ad-424a-4dd7-99e5-34957ae4c4b5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1b9a7f8-ab99-4984-a031-36e25ffd6c19"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""61807932-c09b-4e7b-a036-fb7636516e51"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Disparo = m_Player.FindAction("Disparo", throwIfNotFound: true);
        m_Player_Movimiento = m_Player.FindAction("Movimiento", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Disparo;
    private readonly InputAction m_Player_Movimiento;
    public struct PlayerActions
    {
        private @Input m_Wrapper;
        public PlayerActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Disparo => m_Wrapper.m_Player_Disparo;
        public InputAction @Movimiento => m_Wrapper.m_Player_Movimiento;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Disparo.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisparo;
                @Disparo.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisparo;
                @Disparo.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisparo;
                @Movimiento.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovimiento;
                @Movimiento.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovimiento;
                @Movimiento.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovimiento;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Disparo.started += instance.OnDisparo;
                @Disparo.performed += instance.OnDisparo;
                @Disparo.canceled += instance.OnDisparo;
                @Movimiento.started += instance.OnMovimiento;
                @Movimiento.performed += instance.OnMovimiento;
                @Movimiento.canceled += instance.OnMovimiento;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnDisparo(InputAction.CallbackContext context);
        void OnMovimiento(InputAction.CallbackContext context);
    }
}
