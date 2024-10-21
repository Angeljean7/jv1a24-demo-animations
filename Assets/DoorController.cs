using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    /// 

    [SerializeReference] Animator door;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Open door!")
            door.SetBool("IsOpen", true);

        }
    }

    private void /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Close door!")
             door.SetBool("IsOpen", false);

        }
    }
}
