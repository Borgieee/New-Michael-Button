using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Mo;
    public string Name = "Ni";
    public int Age = 12;
    public string Race = "Adik";
    public float PhysicalDamage = 0.1f;
    public int Armor = 5;
    public int MagicDamage = 1;
    public int MagicResistance = 1;
    public float Speed = 2.1f;
    public string Height = "4'6";

    public void Button2press()
    {
        Mo.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResistance: " + MagicResistance + " \nSpeed: " + Speed + " \nHeight: " + Height;
    }
}
