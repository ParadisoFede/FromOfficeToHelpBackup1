﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TPFINAL: CERIANI, ZEDDE

public class PoweUpShooting : MonoBehaviour, IgeneralPickUp
{
    public CharacterAnimationInteraction characterShooting;

    public void Actions() 
    {
        characterShooting.speedShooting = true;
        Destroy(this.gameObject);
    }
}
