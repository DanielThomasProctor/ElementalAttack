using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveTest : MonoBehaviour
{
  //  public GameObject camera1;
    //float vertical = Input.GetAxis("Vertical") * 4 * Time.deltaTime;
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Update()
    {
        
    //    camera1.transform.Rotate(new Vector3(vertical * 1000, 0, 0));
    }
}
