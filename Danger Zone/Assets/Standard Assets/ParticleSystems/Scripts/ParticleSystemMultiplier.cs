using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Effects
{
    public class ParticleSystemMultiplier : MonoBehaviour
    {
		public GameObject ship;
        // a simple script to scale the size, speed and lifetime of a particle system

        public float multiplier = 1;


		private void Update()
        {
			if (Input.GetKeyDown (KeyCode.E)) {
				var systems = GetComponentsInChildren<ParticleSystem> ();
				foreach (ParticleSystem system in systems) {
					ParticleSystem.MainModule mainModule = system.main;
					mainModule.startSizeMultiplier *= multiplier;
					mainModule.startSpeedMultiplier *= multiplier;
					mainModule.startLifetimeMultiplier *= Mathf.Lerp (multiplier, 1, 0.5f);
					system.Clear ();
					system.Play ();
				}
				transform.parent = null;
				Destroy (ship);
				StartCoroutine (pause());
				Destroy (this);
			}
        }

		IEnumerator pause(){
			yield return new WaitForSeconds (3);
		}
    }
}
