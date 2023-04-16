using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions _playerInputActions;
    private void Awake()
    {
         _playerInputActions = new PlayerInputActions();
        _playerInputActions.Player.Enable();
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public Vector2 GetMovementVectorNormalised()
    {
        var inputVector = _playerInputActions.Player.Move.ReadValue<Vector2>();
        
        
        // if (Input.GetKey(KeyCode.W)) inputVector.y += 1;
        // if (Input.GetKey(KeyCode.S)) inputVector.y -= 1;
        // if (Input.GetKey(KeyCode.A)) inputVector.x -= 1;
        // if (Input.GetKey(KeyCode.D)) inputVector.x += 1;

        inputVector = inputVector.normalized;
        return inputVector;
    }
}
