using UnityEngine;

public class DestroyOnDeadZone : MonoBehaviour
{   
    //Destroy on entering the dead zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dead Zone")) Destroy(gameObject);
    }
}
