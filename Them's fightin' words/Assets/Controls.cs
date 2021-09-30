// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""161e1399-939d-4aed-af6e-9c449b959f03"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""373ea5ca-8ab0-437d-a87f-b10d5bdaa218"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""a4efae19-9eee-4a5b-ac47-63b965918eb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""e6b580b2-8c99-4fe6-87f9-a31acea986e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveUp"",
                    ""type"": ""Button"",
                    ""id"": ""6fdc7beb-eecd-41d2-bb88-be13e61e6340"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""moveDown"",
                    ""type"": ""Button"",
                    ""id"": ""a6286feb-1e29-41f7-b24a-c36d36f9f7b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""moveRight"",
                    ""type"": ""Button"",
                    ""id"": ""c501dd83-67ff-460d-baf3-7e38093c8918"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""moveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e5d48ed3-557b-44ca-9e08-d7ac5cd63c06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2efe4fbd-f7d5-4b9b-9b30-4f4bfa6a768a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8300e84f-33b3-4cd2-b70b-51f86c8447ba"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f28bd04f-e8a2-49c1-a530-a58482404aa9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0e04f885-8645-4faa-a059-d06848907808"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f5cc3583-cbe0-4ed9-a008-787804e9c6ba"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a9274d7a-9ed2-41a2-9736-c83d099cd0e5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a4c6f1dc-ad75-4aff-b254-7de2943210b1"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f808740-5aee-467f-844a-af958b45ab92"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23941917-ca14-46a3-aead-60d0aa025628"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f96ad06b-e9c4-4f7d-b0ca-f426f701d3d0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f753ec2b-5288-4b3f-899d-6888630baaf2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Conversation"",
            ""id"": ""0e1df50c-ecfc-4f9f-81fe-4aa0fc3a2d38"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""09226359-2c7e-4f77-9f4c-073bcc45e2b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20146196-51c9-4a05-8f71-25f43c7f2d02"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_moveUp = m_Player.FindAction("moveUp", throwIfNotFound: true);
        m_Player_moveDown = m_Player.FindAction("moveDown", throwIfNotFound: true);
        m_Player_moveRight = m_Player.FindAction("moveRight", throwIfNotFound: true);
        m_Player_moveLeft = m_Player.FindAction("moveLeft", throwIfNotFound: true);
        // Conversation
        m_Conversation = asset.FindActionMap("Conversation", throwIfNotFound: true);
        m_Conversation_Newaction = m_Conversation.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_moveUp;
    private readonly InputAction m_Player_moveDown;
    private readonly InputAction m_Player_moveRight;
    private readonly InputAction m_Player_moveLeft;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @moveUp => m_Wrapper.m_Player_moveUp;
        public InputAction @moveDown => m_Wrapper.m_Player_moveDown;
        public InputAction @moveRight => m_Wrapper.m_Player_moveRight;
        public InputAction @moveLeft => m_Wrapper.m_Player_moveLeft;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @moveUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUp;
                @moveUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUp;
                @moveUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUp;
                @moveDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveDown;
                @moveDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveDown;
                @moveDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveDown;
                @moveRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
                @moveRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
                @moveRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveRight;
                @moveLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
                @moveLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
                @moveLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveLeft;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @moveUp.started += instance.OnMoveUp;
                @moveUp.performed += instance.OnMoveUp;
                @moveUp.canceled += instance.OnMoveUp;
                @moveDown.started += instance.OnMoveDown;
                @moveDown.performed += instance.OnMoveDown;
                @moveDown.canceled += instance.OnMoveDown;
                @moveRight.started += instance.OnMoveRight;
                @moveRight.performed += instance.OnMoveRight;
                @moveRight.canceled += instance.OnMoveRight;
                @moveLeft.started += instance.OnMoveLeft;
                @moveLeft.performed += instance.OnMoveLeft;
                @moveLeft.canceled += instance.OnMoveLeft;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Conversation
    private readonly InputActionMap m_Conversation;
    private IConversationActions m_ConversationActionsCallbackInterface;
    private readonly InputAction m_Conversation_Newaction;
    public struct ConversationActions
    {
        private @Controls m_Wrapper;
        public ConversationActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Conversation_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Conversation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ConversationActions set) { return set.Get(); }
        public void SetCallbacks(IConversationActions instance)
        {
            if (m_Wrapper.m_ConversationActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_ConversationActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_ConversationActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_ConversationActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_ConversationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public ConversationActions @Conversation => new ConversationActions(this);
    public interface IPlayerActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
    }
    public interface IConversationActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
