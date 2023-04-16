using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    private Transform _playerTransform;
    [SerializeField] private GameInput gameInput;

    private void Start()
    {
        _playerTransform = transform;
    }

    private void Update()
    {
        var inputVector = gameInput.GetMovementVectorNormalised();
        
        var moveDir = new Vector3(inputVector.x, 0, inputVector.y);
        
        _playerTransform.position += moveDir * (Time.deltaTime * 5);
        transform.forward = Vector3.Slerp(_playerTransform.forward, moveDir, Time.deltaTime * 10);
    }
    
    public bool IsWalking()
    {
        return Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
    }
}