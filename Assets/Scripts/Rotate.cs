using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using this for our challenges demo
public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
 
    private void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }
}
