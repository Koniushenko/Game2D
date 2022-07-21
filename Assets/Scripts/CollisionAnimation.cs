using UnityEngine;
using DG.Tweening;
public class CollisionAnimation : MonoBehaviour
{
    [SerializeField] float animationDuration, elasticity;
    [SerializeField] int vibrato;
    [SerializeField] Vector3 scaleStrength;
    
    //Scaled animation on ball hitting
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            transform.DOPunchScale(scaleStrength, animationDuration, vibrato, elasticity);
        }
    }
}
