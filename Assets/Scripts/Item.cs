//================================================================
// Darmstadt University of Applied Sciences, Expanded Realities
// Course: Augmented Reality - Getting started in AR Foundation (Robin Bittlinger, Sebastian Schuchmann)
// Script by:    Lili Weirich (769701)
// Last changed: 20-06-23
//================================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]

public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;
}
