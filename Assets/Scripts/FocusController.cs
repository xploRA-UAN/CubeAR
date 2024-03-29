﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

/*
 * Script to Camera Focus Control.
 */

public class FocusController : MonoBehaviour {

    #region PRIVATE_METHODS

    // Use this for initialization
    void Start () {
		var vuforia = VuforiaARController.Instance;    
		vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);    
		vuforia.RegisterOnPauseCallback(OnPaused);
	}

	private void OnVuforiaStarted() {    
		CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}

	
	private void OnPaused(bool paused) {    
  		if (!paused){ // resumed
       	// Set again autofocus mode when app is resumed
       		CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);    
  		}
 	}

    #endregion //PRIVATE_METHODS
}
