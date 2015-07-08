﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Wakeup : StateMachineBehaviour{
	
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
//		var eyesScript = GameObject.Find ("EyesCanvas").GetComponentInChildren<EyesAnimation> ();
//		eyesScript.OpenEyes ();
		//Player Control zurücksetzen, damit animation an richtiger stelle läuft
		GameObject.FindGameObjectWithTag("Player").transform.localPosition =  new Vector3(0,0,0);
		GameObject.FindGameObjectWithTag ("Player").transform.localRotation = Quaternion.identity;

		//camera rotation zurücksetzen
		Camera.main.transform.localRotation = Quaternion.identity;
		animator.gameObject.GetComponentInChildren<FirstPersonController> ().m_MouseLook.ResetRotation ();



	}


	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
//	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//

//	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
	
}