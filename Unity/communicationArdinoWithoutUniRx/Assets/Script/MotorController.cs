using System.Collections;
using UnityEngine;

public class MotorController : MonoBehaviour
{
    private const KeyCode KEY_STOP = KeyCode.S;
    private const KeyCode KEY_DETACH = KeyCode.D;
    private const KeyCode KEY_START = KeyCode.Alpha1;
    private const KeyCode KEY_NORMAL = KeyCode.Space;
    private const KeyCode KEY_SHOT = KeyCode.Z;
    public SerialHandler serialHandler;
    void Update()
    {
        if ( Input.GetKeyDown(KEY_STOP) ) {
            serialHandler.Write("0");
			Debug.Log("Stop!");
        }
        if ( Input.GetKeyDown(KEY_DETACH) ) {
            serialHandler.Write("9");
			Debug.Log("Detach!");
        }
		
		if ( Input.GetKeyDown(KEY_NORMAL) ) {
            serialHandler.Write("2");
			Debug.Log("Normal!");
        }
        if (Input.GetKeyUp(KEY_NORMAL)) {
			serialHandler.Write("0");
			Debug.Log("Stop!");
		}
		if ( Input.GetKeyDown(KEY_SHOT) ) {
            serialHandler.Write("3");
			Debug.Log("Shot!");
        }
    }
}
