using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 1;
    [SerializeField] SpriteRenderer spriteRenderer;
        
        void Start()
    
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update" + transform.position);

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            spriteRenderer.flipX = false;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            spriteRenderer.flipX = false; 
        }

        transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, (80 * Time.deltaTime) + transform.rotation.eulerAngles.z);
    }
}
