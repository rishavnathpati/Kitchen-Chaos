using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public Vector2 GetMovementVectorNormalised()
    {
        var inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W)) inputVector.y += 1;
        if (Input.GetKey(KeyCode.S)) inputVector.y -= 1;
        if (Input.GetKey(KeyCode.A)) inputVector.x -= 1;
        if (Input.GetKey(KeyCode.D)) inputVector.x += 1;

        inputVector = inputVector.normalized;
        return inputVector;
    }
}
