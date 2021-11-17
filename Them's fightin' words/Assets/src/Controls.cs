// GENERATED AUTOMATICALLY FROM 'Assets/src/Controls.inputactions'

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
                    ""interactions"": ""Press""
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
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveDown"",
                    ""type"": ""Button"",
                    ""id"": ""a6286feb-1e29-41f7-b24a-c36d36f9f7b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveRight"",
                    ""type"": ""Button"",
                    ""id"": ""c501dd83-67ff-460d-baf3-7e38093c8918"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e5d48ed3-557b-44ca-9e08-d7ac5cd63c06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""3fe9e567-99f2-49f1-9715-b006c8bf474c"",
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
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94973c18-9963-4953-88b4-a58ff0673ae6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                    ""id"": ""e5d25814-767a-4797-a287-defc25c17e4d"",
                    ""path"": ""<Gamepad>/dpad/up"",
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
                    ""id"": ""ab50dab4-b5b5-49db-ace4-d6915d098741"",
                    ""path"": ""<Gamepad>/dpad/down"",
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
                    ""id"": ""173c951a-4cae-4616-9c1e-294f7dce71be"",
                    ""path"": ""<Gamepad>/dpad/right"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""ccd99c67-10be-40a2-a834-46973dd37e79"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f093c62-b0ad-4fa1-ad80-397418bfe326"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3d948e8-16dc-45c8-90b0-a8bc98dff76a"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
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
                    ""name"": ""Op1"",
                    ""type"": ""Button"",
                    ""id"": ""35702262-dcc5-49d5-8b67-d5e928a2be86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Op2"",
                    ""type"": ""Button"",
                    ""id"": ""b43ab227-7123-4685-8610-2357e1db4dac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Op3"",
                    ""type"": ""Button"",
                    ""id"": ""8aeca37b-2bbc-4984-9d54-09b9746009eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""222179cb-4670-4673-aed9-8df49a9c3f6c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Op1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58e9c49f-da7a-4709-8411-a0e19d7626b2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Op1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce8a0b91-0395-4f09-9601-ac14ac4084de"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Op2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b56d6ef5-f4cf-4167-a1a0-31401670d5b4"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Op2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaccc6c2-3d8c-437d-8738-b5b582730eea"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Op3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed6885ab-cf3d-479b-b4b9-87cc30aea0c4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Op3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""minigame_snake"",
            ""id"": ""343f18c2-84a8-4365-a5ce-c2e261b915b6"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""e8d2764f-f6c9-4a03-9301-daf5cc419af6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""3ed259b4-1e44-406a-ab29-b8cf43a83411"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""1e25c4e3-d4a0-4d0f-a6d1-0f63c99d718b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""14cd53bd-1d2e-4e58-b6f0-02d3e8a6153f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""219c5b74-89bd-4471-a3c6-876b90cf5863"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77af0411-6534-4bbf-a6a0-b2f607cb7bba"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c2d65f9-f579-476b-9f00-3a2287e52bfc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bccc577-2767-422b-b2ef-b53d3390a939"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6342a4bb-0a16-4f65-8749-3100ad9ef6d6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e8a5720-6edd-4dbe-b956-a3a26f16b5e6"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7a8eb96-18cc-4920-bcaa-1e3f56463a51"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17177f66-db96-46ed-bdcb-743b8e580dcf"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
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
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_moveUp = m_Player.FindAction("moveUp", throwIfNotFound: true);
        m_Player_moveDown = m_Player.FindAction("moveDown", throwIfNotFound: true);
        m_Player_moveRight = m_Player.FindAction("moveRight", throwIfNotFound: true);
        m_Player_moveLeft = m_Player.FindAction("moveLeft", throwIfNotFound: true);
        m_Player_Inventory = m_Player.FindAction("Inventory", throwIfNotFound: true);
        // Conversation
        m_Conversation = asset.FindActionMap("Conversation", throwIfNotFound: true);
        m_Conversation_Op1 = m_Conversation.FindAction("Op1", throwIfNotFound: true);
        m_Conversation_Op2 = m_Conversation.FindAction("Op2", throwIfNotFound: true);
        m_Conversation_Op3 = m_Conversation.FindAction("Op3", throwIfNotFound: true);
        // minigame_snake
        m_minigame_snake = asset.FindActionMap("minigame_snake", throwIfNotFound: true);
        m_minigame_snake_Up = m_minigame_snake.FindAction("Up", throwIfNotFound: true);
        m_minigame_snake_Down = m_minigame_snake.FindAction("Down", throwIfNotFound: true);
        m_minigame_snake_Left = m_minigame_snake.FindAction("Left", throwIfNotFound: true);
        m_minigame_snake_Right = m_minigame_snake.FindAction("Right", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_moveUp;
    private readonly InputAction m_Player_moveDown;
    private readonly InputAction m_Player_moveRight;
    private readonly InputAction m_Player_moveLeft;
    private readonly InputAction m_Player_Inventory;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @moveUp => m_Wrapper.m_Player_moveUp;
        public InputAction @moveDown => m_Wrapper.m_Player_moveDown;
        public InputAction @moveRight => m_Wrapper.m_Player_moveRight;
        public InputAction @moveLeft => m_Wrapper.m_Player_moveLeft;
        public InputAction @Inventory => m_Wrapper.m_Player_Inventory;
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
                @Inventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
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
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Conversation
    private readonly InputActionMap m_Conversation;
    private IConversationActions m_ConversationActionsCallbackInterface;
    private readonly InputAction m_Conversation_Op1;
    private readonly InputAction m_Conversation_Op2;
    private readonly InputAction m_Conversation_Op3;
    public struct ConversationActions
    {
        private @Controls m_Wrapper;
        public ConversationActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Op1 => m_Wrapper.m_Conversation_Op1;
        public InputAction @Op2 => m_Wrapper.m_Conversation_Op2;
        public InputAction @Op3 => m_Wrapper.m_Conversation_Op3;
        public InputActionMap Get() { return m_Wrapper.m_Conversation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ConversationActions set) { return set.Get(); }
        public void SetCallbacks(IConversationActions instance)
        {
            if (m_Wrapper.m_ConversationActionsCallbackInterface != null)
            {
                @Op1.started -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp1;
                @Op1.performed -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp1;
                @Op1.canceled -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp1;
                @Op2.started -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp2;
                @Op2.performed -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp2;
                @Op2.canceled -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp2;
                @Op3.started -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp3;
                @Op3.performed -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp3;
                @Op3.canceled -= m_Wrapper.m_ConversationActionsCallbackInterface.OnOp3;
            }
            m_Wrapper.m_ConversationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Op1.started += instance.OnOp1;
                @Op1.performed += instance.OnOp1;
                @Op1.canceled += instance.OnOp1;
                @Op2.started += instance.OnOp2;
                @Op2.performed += instance.OnOp2;
                @Op2.canceled += instance.OnOp2;
                @Op3.started += instance.OnOp3;
                @Op3.performed += instance.OnOp3;
                @Op3.canceled += instance.OnOp3;
            }
        }
    }
    public ConversationActions @Conversation => new ConversationActions(this);

    // minigame_snake
    private readonly InputActionMap m_minigame_snake;
    private IMinigame_snakeActions m_Minigame_snakeActionsCallbackInterface;
    private readonly InputAction m_minigame_snake_Up;
    private readonly InputAction m_minigame_snake_Down;
    private readonly InputAction m_minigame_snake_Left;
    private readonly InputAction m_minigame_snake_Right;
    public struct Minigame_snakeActions
    {
        private @Controls m_Wrapper;
        public Minigame_snakeActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_minigame_snake_Up;
        public InputAction @Down => m_Wrapper.m_minigame_snake_Down;
        public InputAction @Left => m_Wrapper.m_minigame_snake_Left;
        public InputAction @Right => m_Wrapper.m_minigame_snake_Right;
        public InputActionMap Get() { return m_Wrapper.m_minigame_snake; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Minigame_snakeActions set) { return set.Get(); }
        public void SetCallbacks(IMinigame_snakeActions instance)
        {
            if (m_Wrapper.m_Minigame_snakeActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_Minigame_snakeActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_Minigame_snakeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public Minigame_snakeActions @minigame_snake => new Minigame_snakeActions(this);
    public interface IPlayerActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
    }
    public interface IConversationActions
    {
        void OnOp1(InputAction.CallbackContext context);
        void OnOp2(InputAction.CallbackContext context);
        void OnOp3(InputAction.CallbackContext context);
    }
    public interface IMinigame_snakeActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
