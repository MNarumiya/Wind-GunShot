using UnityEngine;
using System.Collections;

public class LedController : MonoBehaviour
{
    public SerialHandler serialHandler;
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A) ) {
            serialHandler.Write("0");
			Debug.Log("Light Off!");
        }
        if ( Input.GetKeyDown(KeyCode.S) ) {
            serialHandler.Write("1");
			Debug.Log("Light On!");
        }
    }
}
