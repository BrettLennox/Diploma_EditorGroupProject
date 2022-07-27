using UnityEngine;

namespace Namespace
{
    public abstract class BaseVar : ScriptableObject
    {
        public enum StatsType
        {
            Player,
            Enemy
        }
        [System.Serializable]
        public struct PlayerStats
        {
            public string Name;
            public float health;
            public int lives;
        }

        public PlayerStats stats;
        
        [System.Serializable]
        public struct enemyStats
        {
            public float enemyHealth;
        }

        public enemyStats EnemyStats;
    }

}
