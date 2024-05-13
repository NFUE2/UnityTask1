using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class NPC : MonoBehaviour
{
    public GameObject interaction;
    public GameObject Display;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interaction.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interaction.SetActive(false);
        Display.SetActive(false);
    }
}
