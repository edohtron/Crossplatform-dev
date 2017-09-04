using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRoll : MonoBehaviour {

    float BarrelRollMax = 360;
    float BarrelRollSpeed = 36;
    float CurrentAngle = 0;
    bool m_bBarrelRoll = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horiz = Input.GetAxis("Vertical") * 20.0f * Time.deltaTime;


        if (Input.GetKey(KeyCode.Q))
        {
            m_bBarrelRoll = true;
        }

        if (m_bBarrelRoll)
        {
            CurrentAngle = CurrentAngle + 1;
            transform.Rotate(0, 0, BarrelRollSpeed);
        }



        Debug.Log(CurrentAngle.ToString());
        if (CurrentAngle >= BarrelRollMax / BarrelRollSpeed)
        {
            CurrentAngle = 0;
            m_bBarrelRoll = false;
        }
	}

    //IEnumerator barrelRollLeft()
    //{
    //
    //
    //
    //
    //    yield return null;
    //}
    //
    //IEnumerator barrelRollRight()
    //{
    //
    //
    //
    //
    //    yield return null;
    //}
}
