using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace LoadoutFix
{
    public class BASTARD : MonoBehaviour
    {
        [SerializeField] ShotgunHammer[] ShotgunCUNT3;
        [SerializeField] Shotgun[] shotgun;
        [SerializeField] RocketLauncher[] rocketLaunchers;

        void start()
        {
            ReInitialize();
        }
        public void ReInitialize()
        {
            ShotgunCUNT3 = Resources.FindObjectsOfTypeAll<ShotgunHammer>();
            rocketLaunchers = Resources.FindObjectsOfTypeAll<RocketLauncher>();
            shotgun = Resources.FindObjectsOfTypeAll<Shotgun>();
            Debug.Log("Bazinga");
        }
        public void RemoveShotgun()
        {
            foreach (Shotgun s in shotgun)
            {
                if (s.variation == 1 & s.name.Contains("Clone"))
                {
                    Destroy(s.gameObject);
                    Debug.Log("Destroyed " + s.name);
                    GunControl.Instance.slot2.Remove(s.gameObject);
                }
            }
        }
        public void RemoveHammer()
        {
            foreach (ShotgunHammer h in ShotgunCUNT3)
            {
                if (h.variation == 1 & h.name.Contains("Clone"))
                {
                    Destroy(h.gameObject);
                    Debug.Log("Destroyed " + h.name);
                    GunControl.Instance.slot2.Remove(h.gameObject);
                }
            }
        }
        public void RemoveRocket()
        {
            foreach (RocketLauncher r in rocketLaunchers)
            {
                if (r.name.Contains("Clone"))
                {
                    Destroy(r.gameObject);
                    Debug.Log("Destroyed " + r.name);
                    GunControl.Instance.slot5.Remove(r.gameObject);
                }
            }
        }
    }
}
