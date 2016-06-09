﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerTimeController : MonoBehaviour {
    public TimeMaster spells; 

	// Use this for initialization
	void Start () {
        spells = new TimeMaster( new FreezeTimeSkill(), new Skill(), new Skill(), new Skill() );
	}
	
	// Update is called once per frame
	void Update () {

	    if ( Input.GetKeyDown( KeyCode.Alpha1 ) ) {
            spells.Freeze.Activate();
	    }
        if ( Input.GetKeyDown( KeyCode.Alpha2 ) ) {
            spells.Haste.Activate();
        }
        if ( Input.GetKeyDown( KeyCode.Alpha3 ) ) {
            spells.Slow.Activate();
        }
        if ( Input.GetKeyDown( KeyCode.Alpha4 ) ) {
            spells.Rewind.Start();
        }
    }
}
