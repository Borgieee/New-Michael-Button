using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Blue;
    public string Name = "Isaiah See";
    public int Age = 12;
    public string Race = "Blasian";
    public int PhysicalDamage = 1000;
    public int Armor = 500;
    public int MagicDamage = 75;
    public int MagicResistance = 200;
    public float Speed = 50.5f;
    public string Height = "6'9";

    public void Button1press()
    {
        Blue.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResistance: " + MagicResistance + " \nSpeed: " + Speed + " \nHeight: " + Height;
    }
}