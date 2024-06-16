using UnityEngine;

namespace Novakaizo
{
    public class NovakaizoFix : MonoBehaviour
    {
        ShotgunHammer[] ShotgunCUNT3;
        Shotgun[] shotgun;
        RocketLauncher[] rocketLaunchers;

        public void ReInitialize()
        {
            ShotgunCUNT3 = Resources.FindObjectsOfTypeAll<ShotgunHammer>();
            rocketLaunchers = Resources.FindObjectsOfTypeAll<RocketLauncher>();
            shotgun = Resources.FindObjectsOfTypeAll<Shotgun>();
            Debug.Log("Bazinga");
        }
        public void RemoveShotgun(int variant)
        {
            ReInitialize();
            foreach (Shotgun s in shotgun)
            {
                if (s.variation == variant & s.name.Contains("Clone"))
                {
                    Destroy(s.gameObject);
                    Debug.Log("Destroyed " + s.name);
                    GunControl.Instance.slot2.Remove(s.gameObject);
                }
            }
        }
        public void RemoveHammer(int variant)
        {
            ReInitialize();
            foreach (ShotgunHammer h in ShotgunCUNT3)
            {
                if (h.variation == variant & h.name.Contains("Clone"))
                {
                    Destroy(h.gameObject);
                    Debug.Log("Destroyed " + h.name);
                    GunControl.Instance.slot2.Remove(h.gameObject);
                }
            }
        }
        public void RemoveRocket(int variant)
        {
            ReInitialize();
            foreach (RocketLauncher r in rocketLaunchers)
            {
                if (r.variation == variant & r.name.Contains("Clone"))
                {
                    Destroy(r.gameObject);
                    Debug.Log("Destroyed " + r.name);
                    GunControl.Instance.slot5.Remove(r.gameObject);
                }
            }
        }
    }

}
