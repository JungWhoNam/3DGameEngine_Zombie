using UnityEngine;

public class ZombieCube : MonoBehaviour, IDamageable
{
    public void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal)
    {
        Debug.Log("??!");
    }

    private void OnTriggerEnter(Collider other)
    {
        LivingEntity livingEntity = other.GetComponent<LivingEntity>();

        if (livingEntity != null)
        {
            livingEntity.OnDamage(10, Vector3.zero, Vector3.zero);
        }
    }
}