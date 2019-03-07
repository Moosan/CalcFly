using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSpriteManager : MonoBehaviour {
    public static NumberSpriteManager Singleton;
    public Sprite[] NumSpriteArray;
    private void Awake()
    {
        Singleton = this;
    }
}
