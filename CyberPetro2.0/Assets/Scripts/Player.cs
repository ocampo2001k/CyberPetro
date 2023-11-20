using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]
public class Player : MonoBehaviour
{
    [System.Serializable] public class MouseInput
    {
        public Vector2 Damping;
        public Vector2 Sensitivity;
    }

    [SerializeField] float speed;
    [SerializeField] MouseInput mouseControl;

    private MoveController m_moveController;
    public MoveController MoveController
    {
        get { 
            if(m_moveController == null)
            {
                m_moveController = GetComponent<MoveController>();
            }
            return m_moveController;
        }
    }
    InputController playerInput;
    void Awake()
    {
        playerInput = GameManager.Instance.InputController;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(GameManager.Instance.InputController.vertical * speed, GameManager.Instance.InputController.horizontal * speed);
        MoveController.Move(direction);

    }
}
