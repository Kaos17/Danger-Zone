using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Effects
{
    public class ParticleSystemMultiplier : MonoBehaviour
    {
		public GameObject ship;
		public GameObject camera;
		public GameObject cam2;
		public GameObject camGhost;
		public bool boom = false;
        // a simple script to scale the size, speed and lifetime of a particle system

        public float multiplier = 1;

		private void Start()
		{
			//camera = GameObject.Find ("Main Camera");
		}

		private void Update()
        {
			if (Input.GetKeyDown (KeyCode.E) || boom) {
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
				camera.transform.parent = null;
				cam2.transform.parent = null;
				camGhost.transform.parent = null;
				Destroy (ship);
				boom = false;
				StartCoroutine (pause());
				Destroy (this);
			}
        }

		IEnumerator pause(){
			yield return new WaitForSeconds (3);
		}
    }
}
