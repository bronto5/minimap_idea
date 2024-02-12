using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    
    // Start is called before the first frame update
    private void LateUpdate() 
    {
        transform.position = new Vector3(player.position.x,transform.position.y,player.position.z);
       
        transform.rotation = Quaternion.Euler(90,player.rotation.eulerAngles.y,0);

        
        
    }
}
