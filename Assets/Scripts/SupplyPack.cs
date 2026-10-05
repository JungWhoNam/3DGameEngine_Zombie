using UnityEngine;

// 체력과 탄약을 함께 보충하는 아이템
public class SupplyPack : MonoBehaviour, IItem
{
    public float health = 30f; // 체력 회복량
    public int ammo = 20;      // 탄약 보충량

    public void Use(GameObject target)
    {
        // 체력 회복
        LivingEntity life = target.GetComponent<LivingEntity>();

        if (life != null)
        {
            life.RestoreHealth(health);
        }

        // 예비 탄약 보충
        PlayerShooter playerShooter = target.GetComponent<PlayerShooter>();

        if (playerShooter != null && playerShooter.gun != null)
        {
            playerShooter.gun.ammoRemain += ammo;
        }

        // 사용한 아이템 제거
        Destroy(gameObject);
    }
}