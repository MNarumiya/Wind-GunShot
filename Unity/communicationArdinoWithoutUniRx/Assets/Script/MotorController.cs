using System.Collections;
using UnityEngine;

public class MotorController : MonoBehaviour
{
    public SerialHandler serialHandler;
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A) ) {
            serialHandler.Write("0");
			Debug.Log("Stop!");
        }
        if ( Input.GetKeyDown(KeyCode.Delete) ) {
            serialHandler.Write("9");
			Debug.Log("Detach!");
        }
		if ( Input.GetKeyDown(KeyCode.S) ) {
            serialHandler.Write("1");
			Debug.Log("Start!");
        }
		if ( Input.GetKeyDown(KeyCode.F) ) {
            serialHandler.Write("2");
			Debug.Log("Normal!");
        }
		if ( Input.GetKeyDown(KeyCode.J) ) {
            serialHandler.Write("3");
			Debug.Log("Shot!");
        }
    }
}
