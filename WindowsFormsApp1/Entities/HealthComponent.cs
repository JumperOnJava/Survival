using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survival.Entities
{
    public class HealthComponent : Entity
    {

        private DamageableEntity damageableParent;
        private HealthComponent(Entity parent, DamageableEntity damagebleEntity, int health) : base(parent)
        {
            this.damageableParent = damagebleEntity;
            this.health = health;
        }
        public static HealthComponent createComponent<T>(T entity, int health) where T : Entity, DamageableEntity
        {
            return new HealthComponent(entity,entity,health);
        }

        public int health { get; set; }
        public float hurtTimer = 0;

        public virtual void Hurt(Entity attacker)
        {
            if (attacker == this.parent)
                return;

            hurtTimer = 4 / 6f;
            health -= 1;
            damageableParent.OnDamage(health);
        }
        protected override void Update()
        {
            if (hurtTimer > 0)
                this.hurtTimer -= FormMain.deltaTime;
        }
    }
    public interface DamageableEntity
    {
        void OnDamage(int currentHealth);
    }
}
