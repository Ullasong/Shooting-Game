using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ºÎµúÈù »ó´ë¸¦ ÆÄ±«ÇÏ°í½Í´Ù.
public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // other¸¦ ÆÄ±«ÇÏ°í½Í´Ù.
        Destroy(other.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
