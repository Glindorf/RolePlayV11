using System;

namespace RolePlayV11
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _level;
        private int _hitPoints;
        #endregion

        #region Constructor
        public Warrior(string name, int hitPoints)
        {
            _name = name;
            _level = 1;
            _hitPoints = hitPoints;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
        }

        public bool Dead
        {
            get { return _hitPoints <= 0; }
        }
        #endregion

        #region Methods
        public void LevelUp()
        {
            _level = _level + 1;
        }

        public void ReceiveDamage(int damageMinus)
        {
            _hitPoints = _hitPoints - damageMinus;
        }

        public int DealDamage()
        {
            int dmg = new Random().Next(10, 31);
            _hitPoints = _hitPoints - dmg;
            return _hitPoints;
        }

        #endregion

    }
}