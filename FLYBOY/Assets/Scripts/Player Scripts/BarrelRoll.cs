using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRoll : MonoBehaviour {

    float BarrelRollMax = 360;
    float BarrelRollSpeed = 24;
    float CurrentAngle = 0;
    bool m_bBarrelRoll = false;
    bool rollLeft = false;
    bool rollRight = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            m_bBarrelRoll = true;
            rollLeft = true;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            m_bBarrelRoll = true;
            rollRight = true;
        }

        if (m_bBarrelRoll && rollLeft)
        {
            CurrentAngle = CurrentAngle + 1;
            transform.Rotate(0, 0, BarrelRollSpeed);
        }
        else if(m_bBarrelRoll && rollRight)
        {
            CurrentAngle = CurrentAngle + 1;
            transform.Rotate(0, 0, -BarrelRollSpeed);
        }

        if (CurrentAngle >= BarrelRollMax / BarrelRollSpeed)
        {
            CurrentAngle = 0;
            m_bBarrelRoll = false;
            rollLeft = false;
            rollRight = false;
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
