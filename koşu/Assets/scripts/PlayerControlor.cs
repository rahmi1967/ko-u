using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerControlor : MonoBehaviour
{
    public float _speed;
    private float touchX;
    private float newX;
    public float xSpeed;
    public float limitX;

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer() 
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase==TouchPhase.Moved ) 
        {
            touchX = Input.GetTouch(0).deltaPosition.x / Screen.width;

        }

        else if (Input.GetMouseButton(0))
        {
            touchX = Input.GetAxis("Mouse X");
        }
        else
        {
            touchX=0;
        }

        newX = transform.position.x + xSpeed * touchX * Time.deltaTime;
        newX = Mathf.Clamp(newX , -limitX,limitX);

        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + _speed * Time.deltaTime);
        transform.position = newPosition;


    }
}
