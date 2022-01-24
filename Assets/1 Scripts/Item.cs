using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type { Column, Light, Rock, Candle, Jug, Pot, Weapon};
    public Type type;
    public int value;
}
