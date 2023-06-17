using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTrigger : MonoBehaviour
{
    public Animator Hologram;
    public string enterAreaParam = "enterArea";
    public string inAreaParam = "inArea";
    public string leaveAreaParam = "leaveArea";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Hologram.SetBool(enterAreaParam, true);
            Hologram.SetBool(inAreaParam, true);
            Hologram.SetBool(leaveAreaParam, false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Hologram.SetBool(enterAreaParam, false);
            Hologram.SetBool(inAreaParam, false);
            Hologram.SetBool(leaveAreaParam, true);
        }
    }
}
