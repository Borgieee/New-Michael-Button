using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Mama;
    public string Name = "Chiikawa";
    public int Age = 2;
    public string Race = "Chiikawa";
    public int PhysicalDamage = 1000;
    public int Armor = 1000;
    public int MagicDamage = 1000;
    public int MagicResistance = 1;
    public float Speed = 1000.1f;
    public float Height = 0.2f;

    public void Button1press()
    {
        Mama.text = "Name: " + Name + " \nAge: " + Age + "\nRace: " + Race + " \nPhysicalDamage: " + PhysicalDamage + " \nArmor: " + Armor + " \nMagicDamage: " + MagicDamage + " \nMagicResistance: " + MagicResistance + " \nSpeed: " + Speed + " \nHeight: " + Height;
    }
}