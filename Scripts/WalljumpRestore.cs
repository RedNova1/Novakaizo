using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Novakaizo
{
    public class WalljumpRestore : MonoBehaviour
    {
        public void RestoreJumps()
        {
            NewMovement.Instance.currentWallJumps = 0;
        }
    }
}
