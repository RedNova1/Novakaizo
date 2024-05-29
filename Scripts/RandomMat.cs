using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LoadoutFix
{
    public class RandomMat : MonoBehaviour
    {
        [SerializeField] Material[] materials;
        Renderer renderer;

        void Start ()
        {
            renderer = gameObject.GetComponent<Renderer>();
        }
        public void Randomize()
        {
            renderer.material = materials[UnityEngine.Random.Range(0,materials.Length - 1)];
        }
    }
}
